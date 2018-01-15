<?php
    function GetPortfolio()
    {
        global $portfolioImageDir;
        global $portfolioSiteDir;
        return CreateHtml(array($portfolioSiteDir,$portfolioImageDir), GetImages($portfolioImageDir));
    }
?>