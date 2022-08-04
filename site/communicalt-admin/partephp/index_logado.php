<?php
require_once "config.php";
require_once "Log.php";
require_once "Log.php";
require_once "Alunos.php";
require_once "Habilidades.php";
require_once "feed.php";
$log = new LogIn();

?>
<html>
<head>
<meta charset="UTF-8">
</head>

<body>
 
 
<?php if ( isset($_SESSION['msg']) ) { echo $_SESSION['msg'];  unset($_SESSION['msg']); } ?>
<?php echo $log; ?>


<a href="cadastro_habilidades.php"><input type="button" value=" Cadastrar Habilidades " ></a> 
<a href="cadastro_aluno.php"><input type="button" value=" Cadastrar aluno " ></a> 
<a href="index_habilidades.php"><input type="button" value="  Habilidades " ></a> 
<a href="index_alunos.php"><input type="button" value="  alunos " ></a> 
<a href="menu_relatorios.php"><input type="button" value=" Ir para relatorios"></a>

<hr>

<form method="post" action="feedback.php">

<label> Nome: <input type="text" name="profissional" id="profissional" required> <br>
<label> Instituição: <input type="text" name="instituicao" id="instituicao"required> <br>



Comente o que você achou do nosso serviço: <br>
<textarea style="resize: none" class="form-control" name="mensagem" rows="5" id="mensagem"required></textarea>

<a href="feedback.php"><input type="submit" value="Enviar" id="enviar" name="enviar">

</form>

</body>


</html>


 