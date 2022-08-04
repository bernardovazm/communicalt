<?php
require_once "../config.php";
require_once "../relatorios.php";

$relatorio = new Relatorio();

?>
<html>
<head>
<meta charset="UTF-8">
</head>

<body>


 
 <a href="../index_logado.php"><input type="button" value=" Voltar " ></a>
 
<?php if ( isset($_SESSION['msg']) ) { echo $_SESSION['msg'];  unset($_SESSION['msg']); } ?>
<?php echo $relatorio->listar_habilidadesalunos(); ?>


 

<hr>



</body>


</html>