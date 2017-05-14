<?php
    $text = $_GET["text"] ?: "Enter your text here";
    $textSize = intval($_GET["textSize"] ?: 17);
    $width = intval($_GET["width"] ?: 400);
    $height = intval($_GET["height"] ?: 400);
    $ellipseWidth = intval($_GET["ellipseWidth"] ?: 200);
    $ellipseHeight = intval($_GET["ellipseHeight"] ?: 200);
    $backgroundColor =$_GET["backgroundColor"] ? hexdec($_GET["backgroundColor"]) : 0xFFFFFF;
    $textColor = $_GET["textColor"] ? hexdec($_GET["textColor"]) : 0x000000;
    $ellipseColor = $_GET["ellipseColor"] ? hexdec($_GET["ellipseColor"]) : 0xFF0000;
    $fontFile = "./Lazy_Dog_free.ttf";
?>
