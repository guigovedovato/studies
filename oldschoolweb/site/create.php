<?php
    require 'core/string.php';
    require 'core/config.php';
    require 'content.php';
    require 'core/arrays.php';
    require 'site/portfolio/portfolio.php';
    require 'site/team/team.php';

    function GetContent($content)
    {
        if($content == "portfolio")
        {
            echo GetPortfolio();
        }
        else
        {
            echo GetTeam();
        }
    }
?>