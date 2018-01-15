<?php
    function GetPageResponse($imageDir, $pageName)
    {
        $imagePath = CreateCategoryPath($imageDir, $pageName);
        $elements = GetImages(GetFullPath($imagePath));
        
        $html = '<div class="container">
                <header>
                    <h2>' . Upper($pageName) . '</h2>
                </header>
                <p>Tattoos are nothing short of a style statement today, 
                which reflects the attitude and fashion sense of the bearer. 
                This is the reason why discerning tattoo lovers are so choosy 
                about the designs and look for something different from the 
                common and traditional designs. One of such cool design options 
                is geometry tattoo designs, which carry a unique stylized look 
                and also have a deep symbolic significance, which have together, 
                taken these designs to the heights of popularity. Geometry is a 
                science of perfection and symmetry, in which there is an amazing 
                balance and harmony between elements and this is what is essentially 
                depicted by geometry tattoos too.</p>
                <div class="row">';
        for($i = 0; $i < count($elements); $i++)
        {
            $html .= '<div class="4u 12u$(mobile)">
                        <article class="item">
                            <div id="loader'.$i.'" class="loader"></div>
                            <img src="'.$imagePath.$elements[$i].'" alt="'.GetTitle($elements[$i]).'" class="image fits" id="'.$i.'" />
                        </article>
                    </div>';
        }            
        $html .= '</div>
            </div>';

        $html .= '<script>
                    var image = $(".fits");
                    image.on("load", function() {
                        $("#loader"+$(this).attr("id")).hide();
                    });
                </script>';

        echo $html;
    }
?>