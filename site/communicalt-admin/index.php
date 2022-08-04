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
<html lang="en" >

<head>
  <meta charset="UTF-8">
  <title>Central Administrativa - Communicalt</title>
  <meta content="width=device-width, initial-scale=1.0" name="viewport">
  <link href='https://fonts.googleapis.com/css?family=Titillium+Web:400,300,600' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">
  <!-- ico -->
  <link href="data:image/x-icon;base64,AAABAAEAEBAAAAEAIABoBAAAFgAAACgAAAAQAAAAIAAAAAEAIAAAAAAAAAQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAOOTAFPmlQCo5pUAqOaVAKjmlQCo5ZQAp9+KABgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAD0ngDk750AYPKdAGDynQBg8p0AYPKcAF/riQANAAAAAAAAAAAAAAADHR0ffBQUFA0AAAAAAAAAAAAAAAAAAAAA9Z8AygAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAGKCYqgDk5PPwjFyMWAAAAAAAAAAAAAAAAAAAAAPWfAMoAAAAAAAAAAB0dIFc3NzmQNzc5kDc3OZA3NzmQNTU4sra1t/9ubXD/MzM3mh8fIlMAAAAAAAAAAAAAAAD1nwDKAAAAAAAAAAAhISOZ7e3t//Hx8f/x8fH/8fHx//Ly8v/+/v7/9fT1/+Xl5f8iIiSVAAAAAAAAAAAAAAAA9qABygAAAAAAAAAAIyElmfv7+//////////////////////////////////z8/P/JCImlQAAAAAAAAAAAAAAAPehA8oAAAAAAAAAACMjJpn7+/v/////////////////////////////////8/Pz/yQkJ5UAAAAAAAAAAOaWAD33oQPKAAAAAAAAAAAlIyiZ+/v7//////////////////////////////////Pz8/8mJCmVAAAAAAAAAAD0nwPb+aMEygAAAAAAAAAAJiUomfv7+//////////////////////////////////z8/P/JyYplQAAAAAAAAAA9qED2/qkBcoAAAAAAAAAACYmKpnx8fH/9fX1//X19f/19fX/9fX1//X19f/19fX/6enp/ycnK5UAAAAAAAAAAPaiBdv6pQXKAAAAAAAAAAAlJShZKScrlSknK5UpJyuVKScrlSknK5UpJyuVKScrlSknK5UmJilXAAAAAAAAAAD3ogXb+6YFy9uSAA7bkgAO25IADtuSAA7bkgAO25IADtuSAA7bkgAO25IADtuSAA7bkgAO25IADtuSAA7bkgAO96MG3PymBu/8pwjt/KcI7fynCO38pwjt/KcI7fynCO38pwjt/KcI7fynCO38pwjt/KcI7fynCO38pwjt/KcI7f6nB/j7ogQ/+qUFMPqlBTD6pQUw9aEFMfqlBTD6pQUw+qUFMPWhBTH6pQUw+qUFMPqlBTD1oQUx+qUFMPqlBTD0nwUw//8AAP//AACD/wAAf/8AAH+fAABwDwAAYAcAAGAHAABgBwAAYAYAAGAGAABgBgAAcA4AAH/+AAAAAAAA//8AAA==" rel="icon" type="image/x-icon" />

  <!-- Google Fonts -->

  <!-- Bootstrap CSS File --
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

	<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
	<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
-->
  
      <link rel="stylesheet" href="css/style.css">
</head>

<body onload="createCaptcha()">

<h1 class="blacktext"> COMMUNICALT <strong>ADMINISTRADOR </strong></h1> 

  <div class="form">
      
      <ul class="tab-group">
        <li class="tab active"><a href="#signup">Cadastrar</a></li>
        <li class="tab"><a href="logintab.html">Logar</a></li>
      </ul>
      
      <div class="tab-content">
        <div id="signup">   
          <h1>Realize seu cadastro abaixo:</h1>
          <p>Por favor preencha todos os campos</p>
          <form method="POST" action="" onsubmit="validateCaptcha()">
            <div class="field-wrap">
			<p>Seu nome completo:</p>
              <label>
              </label>
              <input type="text" required name="profissional[nome]" id="nome" autocomplete="off"/>
            </div>

          <div class="field-wrap">
		  <p>Endereço de email:</p>
            <label>
            </label>
           <input type="email" required  name="profissional[email]" id="email" autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
		  <p>Senha:</p>
            <label>
            </label>
            <input name="profissional[senha]" id="senha" type="password" required autocomplete="off"/>
          </div>
		  
		  <div class="field-wrap">
		  <p>Login:</p>
            <label>
            </label>
            <input name="profissional[login]" id="login" type="text" required />
          </div>
		  
		  <div class="field-wrap">
		  <p>Celular:</p>
            <label>
            </label>
            <input name="profissional[telefone]" id="telefone" type="number" required autocomplete="off"/>
          </div>
		  
		  <div class="field-wrap">
		  <p>Serial:</p>
            <label>
            </label>
            <input name="profissional[serial]" id="serial" type="text" required />
          </div>
		  <p>Por favor, conclua a verificação anti robô a seguir...</p>
			<div class="field-wrap">
				<div id="captcha">
				</div>
			<label>
			</label>
				<input type="text" id="cpatchaTextBox" required />
			</div>
			
				<button type="submit"  id="entrar" name="entrar" class="button button-block">Enviar</button>
			  </form>

        </div>
      </div><!-- tab-content -->
      
</div> <!-- /form -->
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

  
    <script  src="js/index.js"></script>




</body>

</html>
