<?php
    function GetPageResponse()
    {
        $html = '
                <div class="notfound">
                    <div class="container">
                        <header>
                            <h2>Page not found!</h2>
                        </header>
                        <p>The requested page could not be found.</p>
                        <div class="12u$">
                            <div id="back" class="button">Back</div>
                        </div>
                    </div>
                    <img src="images/page-not-found.jpg" alt="Page not found" class="imgnotfound" />
                </div>
                <script>
                $("#back").click(function() {
                    $("#close").click();
                });
                </script>
                ';
        echo $html;
    }
?>