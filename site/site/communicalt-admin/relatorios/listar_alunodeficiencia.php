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
 
Digite uma deficiencia: <input type="text" name="deficiencia" >

<button type="submit" >Pesquisar </button>

</form>
 

<hr>


<?php echo $relatorio->listar_alunodeficiencia() ?>


</body>


</html>