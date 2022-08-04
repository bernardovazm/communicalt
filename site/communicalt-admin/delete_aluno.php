<?php
require_once "config.php";
require_once "Alunos.php";
$aln = new Alunos($_GET['id']);
$aln->delete();
?>