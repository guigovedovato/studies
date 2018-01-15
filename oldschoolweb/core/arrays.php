<?php
    function GetArray($elementsDir)
    {
        $elements = array();
        foreach($elementsDir as $key => $value)
        {
            if(strpos($value, '.jpg') == false)
            {
                continue;
            }
            array_push($elements, $value);
        }
        return $elements;
    }

    function GetImages($path)
    {
        return GetArray(scandir($path));
    }
?>