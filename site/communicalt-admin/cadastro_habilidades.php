<?php 
 require_once "config.php";
 require_once "Habilidades.php";
 $hab = new Habilidades();
if( isset( $_POST['habilidades'])){   
    $hab->set($_POST['habilidades']);
    $hab->add();   
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
<form method="POST" action="">
<br>
<div class="col-xs-12 text-center">
 <h4 class="title">Insira uma nova habilidade:</h4>
 <br>
</div>

<label>Habilidades	cognitivas/metacognitivas:</label><br><textarea style="resize: none" class="form-control" rows="5" name="habilidades[cognitivas]" id="cognitivas" required></textarea><br>
<label>Habilidades motoras/psicomotoras:</label><br><textarea style="resize: none" class="form-control" rows="5" name="habilidades[motoras]" id="motoras"required></textarea><br>
<label>Habilidades interpessoais/afetivas:</label><br><textarea style="resize: none" class="form-control" rows="5" name="habilidades[interpessoais]" id="interpessoais"required></textarea><br>
<label>Habilidades comunicacionais:</label><br><textarea style="resize: none" class="form-control" rows="5" name="habilidades[comunicacionais]" id="comunicacionais"required></textarea><br>
<label>Alfabetizacao/letramento:</label><br><textarea style="resize: none" class="form-control" rows="5" name="habilidades[alfabetizacao]" id="alfabetizacao"required></textarea><br>
<label>Raciociniologico/matematico:</label><br><textarea style="resize: none" class="form-control" rows="5" name="habilidades[raciociniologico]" id="raciociniologico"required></textarea><br>
<label>Data do atendimento:</label><input class="contact-name form-control" placeholder="(Ano / mês / dia)" pattern="[0-9]{4}+/[0-9]{2}+/[0-9]{2}" type="DATE" name="habilidades[data_atendimento]" id="data_atendimento"required><br>
<label>Observações:</label><br><textarea style="resize: none" class="form-control" rows="5" name="habilidades[observacoes]" id="observacoes"required></textarea><br>
<label>ID do aluno</label><select class="contact-name form-control" type="text" name="habilidades[aluno]" id="aluno"required>

<?php
echo $hab->ListarAlunos(); 
?>
</select>
<br>
<a href="cadastro.php"><input class="btn btn-primary" type="submit" value="Cadastrar" id="cadastrar" name="cadastrar"></a>

</form>

<div class="btn-form text-center col-xs-4">
    <input class="btn btn-danger"  onclick="history.back();" value="Voltar">
</div>
<br>
</body>
</html>
