<?php
    function Replace($search, $replace, $subject)
    {
        return str_replace($search, $replace, $subject);
    }

    function GetTitle($str)
    {
        return Upper(Replace(array("-",".jpg"), " ", $str));
    }
    
    function Upper($str)
    {
        return ucwords($str);
    }

    function GetPage($str)
    {
        return Replace(".jpg", "", $str) . ".php";
    }

    function GetFullPath($path)
    {
        return "../" . $path;
    }

    function GetConfigPage($str)
    {
        $str = Replace(".php", "", $str);
        $config = explode("/", $str);

        return $config;
    }

    function CreateCategoryPath($imageDir, $pageName)
    {
        return "images/" . $imageDir . "/" . $pageName . "/";
    }

    function GetImage($imageDir, $pageName)
    {
        return "images/" . $imageDir . "/" . $pageName . ".jpg";
    }
?>