<?php
    require '../site/content.php';
    if(isset($_POST['callfunction']) && !empty($_POST['callfunction'])) {
        switch($_POST['callfunction']) {
            case "GetPage" : 
                echo GetContentPage($_POST['content']);
                break;
            case "SendMail" :
                echo SendMailPage($_POST['name'], $_POST['email'], $_POST['message']);
                break;
            default:
                echo PageNotFound();
                break;
        }
    }
?>