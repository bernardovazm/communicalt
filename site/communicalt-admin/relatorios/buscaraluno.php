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
 


<form action="" method="post">
 
Digite um ID: <input type="text" name="id" >

<button type="submit" >Pesquisar </button>

</form>
 

<hr>


<?php echo $relatorio->buscar_idaluno() ?>


</body>


</html>