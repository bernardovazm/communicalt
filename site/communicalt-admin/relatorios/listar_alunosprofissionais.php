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
 
Digite um Nome de um profissional: <input type="text" name="profissional">

<button type="submit" >Pesquisar </button>

</form>

<?php echo $relatorio->listar_alunosprofissionais(); ?>
 

<hr>



</body>


</html>