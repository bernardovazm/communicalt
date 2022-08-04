<?php
require_once "config.php";
require_once "Alunos.php";
require_once "Habilidades.php";
$aln = new Alunos($_GET['id']);

?>

<html>
<head>
<meta charset="UTF-8">
</head>
<body>
<h1>Informações do perfil do aluno</h1>
<?php  
		
$aln->View(); 
		
?>
<a href="./" class="btn btn-default">Voltar</a>
</body>
</html>



