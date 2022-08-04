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
Pesquisar atendimentos entre: <input type="date" name="inicio" id="inicio"> e <input type="date" name="fim" id="fim">

<button type="submit" >Pesquisar </button>

</form>

<?php echo $relatorio->listar_habilidadedata(); ?>

 

<hr>



</body>


</html>