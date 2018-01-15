<?php
    function GetTeam()
    {
        global $teamImageDir;
        global $teamSiteDir;
        return CreateHtml(array($teamSiteDir,$teamImageDir), GetImages($teamImageDir));
    }
?>