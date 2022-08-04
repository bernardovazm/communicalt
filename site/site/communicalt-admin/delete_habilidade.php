<?php
require_once "config.php";
require_once "Habilidades.php";
$hab = new Habilidades($_GET['id']);
$hab->delete();
?>