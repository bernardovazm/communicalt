<?php 
require_once "config.php";
require_once "Log.php";
require_once "Alunos.php";
require_once "Habilidades.php";

 $log = new LogIn($_POST['login'], $_POST['senha']);
 $t = $log->VerificarLogin();   
if( $t == 1 ) {
	header("Location: index_logado.php");
}
else if($t == 0){
	header("Location: ./login.html");
}else{
	echo "Error";
}

?>
 
  


