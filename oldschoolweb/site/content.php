<?php
    function CreateHtml($dir, $elements)
    {
        $html = "";
        for($i = 0; $i < count($elements); $i++){
            $html .='<div class="4u 12u$(mobile)">
                <article class="item">
                    <img src="' . $dir[1] . $elements[$i] . '" alt="' . GetTitle($elements[$i]) . 
                        '" onclick="GetPage(\'' . $dir[0] . GetPage($elements[$i]) . ', GetPage\')" class="image fit" />
                    <header>
                        <h3>' . GetTitle($elements[$i]) . '</h3>
                    </header>
                </article> 
                </div>';
        }
        return $html;
    }

    function GetContentPage($page)
    {
        include '../core/arrays.php';
        include '../core/string.php';
        if(file_exists(GetFullPath($page)))
        {
            include GetFullPath($page);
            $config = GetConfigPage($page);
            return GetPageResponse($config[1], $config[2]);
        }
        else
        {
            return PageNotFound();
        }
    }

    function PageNotFound()
    {
        include "pagenotfound.php";
        return GetPageResponse();
    }

    function SendMailPage($name, $mail, $message)
    {
        require '../core/mail.php';
        $mailMessage = SendMail($name, $mail, $message);
        $response = '<div class="sentmail">
                        <span class="icon fa-envelope"></span>
                        <p>' . $mailMessage . '</p>
                    </div>';
        return $response;
    }
?>