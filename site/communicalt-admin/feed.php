<?php 
    require_once "config.php";

class Feed{

    private $id;
    private $profissional;
    private $instituicao;
    private $mensagem;
    
    public function set($user){
        $this->profissional = $user['profissional'];
        $this->instituicao = $user['instituicao'];
        $this->mensagem = $user['mensagem'];
    }
	
    public function add(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);	           			
        $sql = $con->prepare("INSERT INTO feedback (id, profissional, instituicao, mensagem)  VALUES (NULL, ?, ?, ?)");
        $sql->execute(array($_POST['profissional'], $_POST['instituicao'], $_POST['mensagem']));
   
        if ( $sql->errorCode()=='00000' ){
            $_SESSION['msg']="<div class='alert alert-success'>Registro inserido</div>";
            header("Location: ./index_logado.php");
        }else{
            $_SESSION['msg']="<div class='alert alert-danger'><b>ERRO</b> ".$sql->errorInfo()[2]."</div>";
        }	
      }   		  	
}