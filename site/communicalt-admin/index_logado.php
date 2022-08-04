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
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <meta name="description" content="Software de comunicação alternativa para crianças com deficiência.">
  <meta name="author" content="">
  
  <title>CommunicAlt - Central Administrativa</title>
  <!-- Bootstrap core CSS -->
  <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
  
  <link href="vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
  <link href="https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800" rel="stylesheet" type="text/css">
  <link href="https://fonts.googleapis.com/css?family=Merriweather:400,300,300italic,400italic,700,700italic,900,900italic" rel="stylesheet" type="text/css">
  <!-- Plugin CSS -->
  <link href="vendor/magnific-popup/magnific-popup.css" rel="stylesheet">
  <!-- Custom styles for this template -->
  <link href="css/creative.min.css" rel="stylesheet">
  <!-- Extra style (edit or add something here!) -->
  <link href="css/extra_style.css" rel="stylesheet">
  <!-- Bootstrap 4 test (remover qqr coisa) --
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
	<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
	<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
  <!-- -->
  <link rel="icon" href="img/favicon.ico">
  
</head>

<body class="container">
<br>
		<h1 class="text-center">Central Administrativa - Gerenciamento</h1>
		<hr>
<br>
<?php if ( isset($_SESSION['msg']) ) { echo $_SESSION['msg'];  unset($_SESSION['msg']); } ?>
<?php echo $log; ?>

<div class="text-center">
<a href="cadastro_habilidades.php"><input class="btn btn-primary" type="button" value=" Cadastrar Habilidades " ></a> 
<a href="cadastro_aluno.php"><input class="btn btn-primary" type="button" value=" Cadastrar aluno " ></a> 
<a href="index_habilidades.php"><input class="btn btn-primary" type="button" value="  Habilidades " ></a> 
<a href="index_alunos.php"><input class="btn btn-primary" type="button" value="  alunos " ></a> 
<a href="menu_relatorios.php"><input class="btn btn-primary" type="button" value=" Ir para relatorios"></a>
</div>

<br>


<!-- Start: FEEDBACK -->
<br>
	<form id="contact-form-2" method="POST" class="d-espacito single-form" action="feedback.php">
	
                        <h4 class="title">Deixe sua dica ou sugestão abaixo:</h4>
						<br>
                        <div class="col-xs-12">
                            <!-- Name -->
                            <input name="profissional" id="profissional" class="contact-name form-control" type="text" placeholder="Nome" required="">
                        </div>
						<br>
                        <div class="col-xs-12">
                            <!-- Email -->
                            <input name="instituicao" id="instituicao" class="contact-name form-control" type="text" placeholder="Instituição" required="">
                        </div>
						<br>
                        <div class="col-xs-12">
                            <textarea id="mensagem" class="contact-message form-control" rows="6" placeholder="Mensagem" required=""></textarea>  
                        </div>
						<br>
                        
                        <!-- Subject Button -->
                        <div class="btn-form text-center col-xs-12">
                            <a href="feedback.php"><input class="btn btn-primary" type="submit" value="Enviar sugestão" id="enviar" name="enviar"></a>
                        </div>
	</form>
        <!-- End: Contact Form
        ================================== -->

<div class="btn-form text-center col-xs-4">
    <a href="./" class="btn btn-danger">Voltar</a>
</div>
<br>

</body>


</html>


 