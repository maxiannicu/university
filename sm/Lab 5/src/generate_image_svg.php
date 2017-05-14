<?php
    require('prepare_properties.php');

    function getHTMLHEXColor(int $color){
        $hex = dechex($color);
        return "#".str_pad($hex, 6, "0", STR_PAD_LEFT);
    }

    echo '<svg width="'.$width.'" height="'.$height.'" style="background:'.getHTMLHEXColor($backgroundColor).'">
                    <ellipse cx="'.($width/2).'" cy="'.($height/2).'" rx="'.($ellipseWidth/2).'" ry="'.($ellipseHeight/2).'" style="fill:none;stroke:'.getHTMLHEXColor($ellipseColor).'" />
                    <text text-anchor="middle" font-size="'.$textSize.'" x="'.($width/2).'" y="'.($height/2).'" fill="'.getHTMLHEXColor($textColor).'">'.$text.'</text>
                </svg>';
?>
<style>
    @font-face {
        font-family: font;
        src: url(<?php echo $fontFile; ?>);
    }
    svg{
        font-family: font, fallBackFonts, sans-serif;
    }
</style