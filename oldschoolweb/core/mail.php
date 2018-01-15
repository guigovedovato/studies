<?php
    require 'config.php';
    include 'smtp.php';

    function SendMail($name, $mail, $message)
    {
        // use wordwrap() if lines are longer than 70 characters
        $msg = wordwrap($message,70);

        $from = $mail;

        $subject = "Email sent by " . $name;

        // Always set content-type when sending HTML email
        $headers = "MIME-Version: 1.0" . "\r\n";
        $headers .= "Content-type:text/html;charset=UTF-8" . "\r\n";
        $headers .= 'From: ' . $from . "\r\n";

        // send email
        if(@mail($to, $subject, $msg, $headers))
        {
            return "Message sent!";
        }
        else
        {
            return "Your message couldn't sent!";
        }
    }
?>