<?php 
    require_once "config.php";

class LogIn{

    private $id;
    private $nome;
    private $email;
    private $senha;
    private $telefone;
    private $login;
	private $serial;

    public function __construct($id=NULL){
        $this->id = $id;
        if ( $id ){
            $con = new PDO(SERVIDOR, USUARIO, SENHA);
            $sql = $con->prepare("SELECT * FROM profissional WHERE id=?");
            $sql->execute(array($this->id));
            $r = $sql->fetchObject();
            if ( $r ){
                $this->nome = $r->nome;
                $this->email = $r->email;
                $this->senha = $r->senha;
                $this->telefone = $r->telefone;
                $this->login = $r->login;  
				$this->serial = $r->serial; 
            }
        }
    }

    public function getNome(){ return $this->nome; }
    public function getEmail(){ return $this->email; }
    public function getSenha(){ return $this->senha; }
    public function getTelefone(){ return $this->telefone; }
    public function getLogin(){ return $this->login; }
    public function getSerial(){ return $this->serial; }
    

    public function set($user){
        $this->nome = $user['nome'];
        $this->email = $user['email'];
        $this->senha = $user['senha'];
        $this->telefone = $user['telefone'];
        $this->login = $user['login'];
		$this->serial = $user['serial'];
    }
	
	public function view(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("SELECT * FROM profissional WHERE id=?");
        $sql->execute(array($this->id));
        $r = $sql->fetchObject();

        if ( $r ){
            $this->nome = $r->nome;
            $this->email = $r->email;
            $this->senha = $r->senha;
            $this->telefone = $r->telefone;
            $this->login = $r->login;
			$this->serial = $r->serial;
        }
        echo "<table class='table'>";
        echo "<tr><td class='col-md-2'>ID</td><td class='col-md-10'>$this->id</td></tr>";
        echo "<tr><td>Nome: </td><td>$this->nome</td></tr>";
        echo "<tr><td>Email: </td><td>$this->email</td></tr>";
        echo "<tr><td>Senha</td><td>$this->senha</td></tr>";
        echo "<tr><td>Telefone: </td><td>$this->telefone</td></tr>";
        echo "<tr><td>Login: </td><td>$this->login</td></tr>";  
        echo "<tr><td>Serial: </td><td>$this->serial</td></tr>";		
        echo "</table>";
		
    }
	
    public function add(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
		$sql = $con->prepare("SELECT count(*) as num FROM profissional WHERE login = ?");
        $sql->execute(array($this->login));
		$quiz = $sql->fetchObject();
		
		if($quiz->num == 0)
		{
			
        $sql = $con->prepare("INSERT INTO profissional (id, nome, email, senha, telefone, login, serial) VALUES (NULl, ?, ?, ?, ?, ?, ?)");
        $sql->execute(array($this->nome, $this->email, $this->senha, $this->telefone, $this->login, $this->serial ));

		echo $sql->errorInfo()[2];
		
        if ( $sql->errorCode()=='00000' ){
            $_SESSION['msg']="<div class='alert alert-success'>Registro inserido</div>";
            header("Location: ./index_logado.php");
        }else{
            $_SESSION['msg']="<div class='alert alert-danger'><b>ERRO</b> ".$sql->errorCode()[2]."</div>";
        }
		}else{
		 echo"<script language='javascript' type='text/javascript'>alert('Usuario já existe');window.location.href='./cadastro.html'</script>";
        }
      }   		 

	public function update(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        if ( isset($_POST['profissional'])){
           
            $this->email = $_POST['profissional']['email'];
            $this->senha = $_POST['profissional']['senha'];
            $this->telefone = $_POST['profissional']['telefone'];
           
			

            $sql = $con->prepare("UPDATE profissional SET email=?, senha=?, telefone=? WHERE id=?");
            $sql->execute(array($this->email, $this->senha, $this->telefone, $this->id));

            echo $sql->errorInfo()[2];

            if ( $sql->errorCode()=='00000' ){
                $_SESSION['msg']="<div class='alert alert-success'>Registro alterado</div>";
                header("Location: ./index_logado.php");
            }else{
                $_SESSION['msg']="<div class='alert alert-danger'><b>ERRO</b> ".$sql->errorInfo()[2]."</div>";
            }

        }

         
    }

    public function delete(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("DELETE FROM profissional WHERE id=?");
        $sql->execute(array($this->id ));
        if ( $sql->errorCode()=='00000' ){
            $_SESSION['msg']="<div class='alert alert-success'>Registro excluído</div>";
        }else{
            $_SESSION['msg']="<div class='alert alert-danger'><b>ERRO</b> ".$sql->errorCode()[2]."</div>";
        }
        header("Location: ./index_logado.php");
    }

    public function __toString(){
		$this->login = $_SESSION['login'];
		$this->senha = $_SESSION['senha'];
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("SELECT * FROM profissional WHERE login = ? AND senha = ?");		
        $sql->execute(array($this->login, $this->senha));
        $quiz = $sql->fetchAll(PDO::FETCH_CLASS);

        $html='';
        $html.= "";
        if ($quiz){
            $html.= "<table class='table table-bordered'>";
            $html.= "<tr><td style='display:none;'>ID</td><td>Nome</td><td>Informações</td><td>AÇÕES</td></tr>";
            foreach($quiz as $r){
				$_SESSION['profissional'] = $r->id;
                $html.= "<tr><td style='display:none;'>$r->id</td><td>$r->nome</td><td>Email: $r->email<br>Telefone: $r->telefone<br>Login: $r->login</td><td>";
                $html.= "<a href='ver_login.php?id=$r->id' class='btn btn-info'>Ver</a> ";
                $html.= "<a href='alterar.php?id=$r->id' class='btn btn-primary'>Alterar</a> ";               
                $html.= "</td></tr>";
            }
            $html.= "</table>";
        } else {
            $html.= 'Erro ao tentar exibir';
        }

        return $html;
    }
	
	public function VerificarLogin(){
		$this->login = $_POST['login'];
		$this->senha = $_POST['senha'];
		$con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("SELECT count(*) as num FROM profissional WHERE login = ? AND senha = ?");		
        $sql->execute(array($this->login, $this->senha));
		$quiz = $sql->fetchObject();
		
		
		if($quiz->num == 0){
        $teste = 0;
        }else{
			$teste = 1;
			
			$_SESSION['login'] = $_POST['login'];
		    $_SESSION['senha'] = $_POST['senha'];
		}
		
		
		
		return $teste;
		
		
	}
	
	public function VerLogin(){
		$con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("SELECT * FROM profissional WHERE login = ? AND senha = ?");		
        $sql->execute(array($this->login, $this->senha));
        $r = $sql->fetchObject();

        if ( $r ){
			$_SESSION['profissional'] = $r->id;
			
            $this->nome = $r->nome;
            $this->email = $r->email;
            $this->senha = $r->senha;
            $this->telefone = $r->telefone;
            $this->login = $r->login;
			$this->serial = $r->serial;
        }

        echo "<table class='table'>";
        echo "<tr><td>Nome: </td><td>$this->nome</td></tr>";
        echo "<tr><td>Email: </td><td>$this->email</td></tr>";
        echo "<tr><td>Senha</td><td>$this->senha</td></tr>";
        echo "<tr><td>Telefone: </td><td>$this->telefone</td></tr>";
        echo "<tr><td>Login: </td><td>$this->login</td></tr>";  
        echo "<tr><td>Serial: </td><td>$this->serial</td></tr>";		
        echo "</table>";
	}
    
	
	
}