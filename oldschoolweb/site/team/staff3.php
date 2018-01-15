<?php
    function GetPageResponse($imageDir, $pageName)
    {
        $imagePath = CreateCategoryPath($imageDir, $pageName);
        $elements = GetImages(GetFullPath($imagePath));
        
        $html = '<div class="avatar">
                    <img src="' . GetImage($imageDir, $pageName) . '" alt="' . $pageName . '" class="img" />
                <div>
                <div class="container">
                <h3>' . Upper($pageName) . '</h3>
                <p>Aenean sit amet metus a quam ullamcorper ultrices vel in erat. 
                Mauris porta risus in sem varius hendrerit eu eget ex. Phasellus commodo quam turpis, 
                eu sodales justo tincidunt non. Nunc molestie facilisis ex sit amet scelerisque. 
                Nullam luctus vitae tellus ut molestie. Nam viverra, enim eget scelerisque feugiat, 
                elit diam dictum augue, vel eleifend lorem erat id elit. Nam tellus velit, 
                varius eu sodales quis, condimentum in est. Nunc eleifend leo lacinia quam maximus, 
                maximus elementum nulla scelerisque. Aenean et consectetur arcu. Nam mollis lectus 
                at commodo dictum. Curabitur et molestie lorem. Aenean feugiat fermentum nisi 
                tincidunt volutpat. Nulla sagittis sed magna sit amet mollis. Ut ut accumsan nulla. 
                Pellentesque eu ultrices nisi.</p>
                <h3>Some works</h3>
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