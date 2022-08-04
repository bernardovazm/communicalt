<?php 
 require_once "config.php";
 require_once "Alunos.php";
if( isset( $_POST['aluno'])){
    $aln = new Alunos();
    $aln->set($_POST['aluno']);
    $aln->add();   
	
}
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
<body class="container text-center">
<div class="col-xs-12 text-center">
 <br>
 <h4 class="title">Cadastre um novo aluno:</h4>
 <br>
</div>
<form method="POST" action="">
<label>Nome:</label><input class="contact-name form-control" type="text" name="aluno[nome]" id="nome"><br>
<label>Deficiência:</label><input class="contact-name form-control" type="text" name="aluno[deficiencia]" id="deficiencia"><br>
<label>Afinidade:</label><input class="contact-name form-control" type="text" name="aluno[afinidade]" id="afinidade"><br>
<label>Adicional:</label><input class="contact-name form-control" class="contact-name form-control" type="text" name="aluno[adicional]" id="adicional"><br>
<div class="btn-form text-center col-xs-2">
<input type="submit" class="btn btn-primary" value="Cadastrar" id="cadastrar" name="cadastrar">
</div>
</form>
<div class="btn-form text-center col-xs-2">
    <input class="btn btn-danger"  onclick="history.back();" value="Voltar">
</div>
<br>
</body>
</html>
