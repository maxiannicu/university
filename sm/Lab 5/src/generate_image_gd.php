<?php
    require('prepare_properties.php');

    $image = imagecreatetruecolor($width,$height);
    imagefill($image,0,0,$backgroundColor);

    $box = imageftbbox($textSize,0,$fontFile,$text);
    $textWidth = abs($box[4] - $box[0]);
    $textHeight = abs($box[5] - $box[1]);

    imagefttext($image,$textSize,0,($width - $textWidth)/2,($height+$textHeight)/2,$textColor,$fontFile,$text);
    imageellipse($image,$width/2,$height/2,$ellipseWidth,$ellipseHeight,$ellipseColor);

    // send image to the browser    
    header("Content-Type: image/png");
    imagepng($image);
    imagedestroy($image);
?>