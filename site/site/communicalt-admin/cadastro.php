<?php 
 require_once "config.php";
 require_once "Log.php";
if( isset( $_POST['profissional'])){
    $log = new LogIn();
    $log->set($_POST['profissional']);
    $log->add();   
}
?>

<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <meta name="description" content="Software de comunicação alternativa para crianças com deficiência.">
  <meta name="author" content="">
  
  <title>CommunicAlt - Cadastro de usuários</title>
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
<body id="page-top">
    <!-- Start: Modal pro cadastro Form
        ================================== -->
        <div id="cadastro-form" class="text-center" role="dialog">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <form id="contact-form-2" method="POST" class="d-espacito single-form" action="">

                        <div class="col-xs-12 text-center">
                            <h4 class="title">Cadastre-se</h4>
                        </div>
						<hr>
						<br>
						<p> Preencha todos os campos abaixo: </p>
                        <div class="col-xs-12">
                            <!-- Name -->
                            <input name="profissional[nome]" id="nome" class="contact-name form-control" type="text" placeholder="Nome" required="">
                        </div>
						<br>
                        <div class="col-xs-12">
                            <!-- Email -->
                            <input name="profissional[email]" id="email" class="contact-email form-control" type="text" placeholder="Email" required="">
                        </div>
						<br>
                        <div class="col-xs-12">
                            <!-- a -->
                            <input name="profissional[senha]" id="senha" class="contact-email form-control" type="password" placeholder="Senha" required="">
                        </div>
						<br>
						<div class="col-xs-12">
                            <!-- s -->
                            <input name="profissional[login]" id="login" class="contact-email form-control" type="text" placeholder="Login" required="">
                        </div>
						<br>
						<div class="col-xs-12">
                            <!-- d -->
                            <input name="profissional[telefone]" id="telefone" class="contact-email form-control" type="number" placeholder="Telefone" required="">
                        </div>
						<br>
						<div class="col-xs-12">
                            <!-- r -->
                            <input name="profissional[serial]" id="serial" class="contact-email form-control" type="number" placeholder="Serial" required="">
                        </div>
						<br>
						
                        <!-- Subject Button -->
                        <div class="btn-form text-center col-xs-4">
                            <input class="btn btn-primary" type="submit" value="Cadastrar" id="profissional[cadastrar]" name="cadastrar">
                        </div>
						<br>
						<div class="btn-form text-center col-xs-4">
                            <input class="btn btn-warning" type="reset" value="Limpar">
                        </div>
						<br>
						<div class="btn-form text-center col-xs-4">
                            <input class="btn btn-danger" type="button" onclick="history.back();" value="Voltar">
                        </div>
                    </form>

                </div><!-- End: .modal-content -->
            </div><!-- End: .modal-dialog -->
        </div><!-- End: .modal -->
</body>
</html>