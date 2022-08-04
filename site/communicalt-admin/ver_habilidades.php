<?php
require_once "config.php";
require_once "Alunos.php";
require_once "Habilidades.php";
$hab = new Habilidades($_GET['id']);

?>

<html>
<head>
<meta charset="UTF-8">
</head>
<body>

<h1>Informações do perfil</h1>

<?php  
	
	
    $hab->view(); 	
	
?>

<a href="./" class="btn btn-default">Voltar</a>

</body>
</html>



