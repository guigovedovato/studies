$("#content").hide();

//var KEYCODE_ENTER = 13;
var KEYCODE_ESC = 27;
$(document).keyup(function(e) {
  //if (e.keyCode == KEYCODE_ENTER) $('.save').click();
  if (e.keyCode == KEYCODE_ESC) $('#close').click();
});

function GetPage(str) {
  Show();
  var content = str.split(',')[0].trim();
  var callfunction = str.split(',')[1].trim();
    $.post("core/pagehandler.php", {content: content, callfunction: callfunction})
        .done(function( data ) {
          ShowContent(data);
        });
};

function Show() {
  $("#content").show();
  $("#loader").show();
}

function ShowContent(data) {
  $("body").css("overflow", "hidden");
  $("#pagecontent").html(data);
  $("#loader").hide();
}

$("#close").click(function () {
    $("#content").hide();
    $("#pagecontent").html("");
    $("body").css("overflow", "auto");
});

$('#mail-form').on("submit", function(e) {
    e.preventDefault(); 
    SendMail();
});

function isValidEmailAddress(emailAddress) {
    var pattern = new RegExp(/^[+a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/i);
    return pattern.test(emailAddress);
};

function ValidateForm() {
    var validate = false;

    if($('input[name=name]').val() == "") {
      validate = true;
      $("#namevalidate").html("*Name is required!");
      $('input[name=name]').addClass("validation");
    } 
    if($('input[name=email]').val() == "") {
      validate = true;
      $("#emailvalidate").html("*Email is required!");
      $('input[name=email]').addClass("validation");
    } else {
      if(!isValidEmailAddress($('input[name=email]').val())) {
          validate = true;
          $("#emailvalidate").html("*Email invalid!");
          $('input[name=email]').addClass("validation");
      }
    }
    if($('textarea[name=message]').val() == "") {
      validate = true;
      $("#messagevalidate").html("*Message is required!");
      $('textarea[name=message]').addClass("validation");
    }

    return validate;
};

function ClearValidation() {
    $("#namevalidate").html("");
    $('input[name=name]').removeClass("validation");
    $("#emailvalidate").html("");
    $('input[name=email]').removeClass("validation");
    $("#messagevalidate").html("");
    $('textarea[name=message]').removeClass("validation");
}

function SendMail() {
    ClearValidation();
    if(!ValidateForm()) {
      Show();
      $.post("core/pagehandler.php", 
          {
            name: $('input[name=name]').val(), 
            email: $('input[name=email]').val(), 
            message: $('textarea[name=message]').val(), 
            callfunction: "SendMail"
          })
          .done(function( data ) {
            ShowContent(data);
          });
    }
};