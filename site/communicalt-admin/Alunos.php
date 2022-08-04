<?php

 require_once "config.php";

 
class Alunos{

    private $id;
	private $nome;
    private $deficiencia;
    private $afinidade;
    private $adicional;

    public function __construct($id=NULL){
        $this->id = $id;
        if ( $id ){
            $con = new PDO(SERVIDOR, USUARIO, SENHA);
            $sql = $con->prepare("SELECT * FROM aluno WHERE id=?");
            $sql->execute(array($this->id));
            $r = $sql->fetchObject();
            if ( $r ){
                $this->nome = $r->nome;
                $this->deficiencia = $r->deficiencia;
                $this->afinidade = $r->afinidade;
                $this->adicional = $r->adicional;
            }
        }
    }

    public function getNome(){ return $this->nome; }
    public function getDeficiencia(){ return $this->deficiencia; }
    public function getAfinidade(){ return $this->afinidade; }
    public function getAdicional(){ return $this->adicional; }


    public function set($u){
        $this->nome = $u['nome'];
        $this->deficiencia = $u['deficiencia'];
        $this->afinidade = $u['afinidade'];
        $this->adicional = $u['adicional'];
    }

    public function view(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("SELECT * FROM aluno WHERE id=?");
        $sql->execute(array($this->id));
        $r = $sql->fetchObject();

        if ( $r ){
            $this->nome = $r->nome;
            $this->deficiencia = $r->deficiencia;
            $this->afinidade = $r->afinidade;
            $this->adicional = $r->adicional;
        }
        echo "<table class='table'>";
        echo "<tr><td class='col-md-2'>ID</td><td class='col-md-10'>$this->id</td></tr>";
        echo "<tr><td>nome</td><td>$this->nome</td></tr>";
        echo "<tr><td>deficiencia</td><td>$this->deficiencia</td></tr>";
        echo "<tr><td>afinidade</td><td>$this->afinidade</td></tr>";
        echo "<tr><td>adicional</td><td>$this->adicional</td></tr>";
        echo "</table>";
    }

    public function add(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("INSERT INTO aluno (id, nome, deficiencia, afinidade, adicional, profissional_id) VALUES (NULL, ?, ?, ?, ?, ?)");
        $sql->execute(array($this->nome, $this->deficiencia, $this->afinidade, $this->adicional, $_SESSION['profissional'] ));

        if ( $sql->errorCode()=='00000' ){
            $_SESSION['msg']="<div class='alert alert-success'>Registro inserido</div>";
            header("Location: ./");
        }else{
            $_SESSION['msg']="<div class='alert alert-danger'><b>ERRO</b> ".$sql->errorCode()[2]."</div>";
        }
		
    }

    public function update(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        if ( isset($_POST['aluno'])){
            $this->nome = $_POST['aluno']['nome'];
            $this->deficiencia = $_POST['aluno']['deficiencia'];
            $this->afinidade = $_POST['aluno']['afinidade'];
            $this->adicional= $_POST['aluno']['adicional'];

            $sql = $con->prepare("UPDATE aluno SET nome=?, deficiencia=?, afinidade=?, adicional=? WHERE id=?");
            $sql->execute(array($this->nome, $this->deficiencia, $this->afinidade, $this->adicional, $this->id ));

            echo $sql->errorInfo()[2];

            if ( $sql->errorCode()=='00000' ){
                $_SESSION['msg']="<div class='alert alert-success'>Registro alterado</div>";
                header("Location: ./index_logado.php");
            }else{
                $_SESSION['msg']="<div class='alert alert-danger'><b>ERRO</b> ".$sql->errorCode()[2]."</div>";
            }

        }


    }

    public function delete(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("DELETE FROM habilidades WHERE FK_aluno_id=?");
		$sql->execute(array($this->id ));
        $sql = $con->prepare("DELETE FROM aluno WHERE id=?");
        $sql->execute(array($this->id ));
        if ( $sql->errorCode()=='00000' ){
            $_SESSION['msg']="<div class='alert alert-success'>Registro excluído</div>";
        }else{
            $_SESSION['msg']="<div class='alert alert-danger'><b>ERRO</b> ".$sql->errorInfo()[2]."</div>";
        }
        header("Location: ./index_logado.php");
    }

   public function __toString(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("SELECT * FROM aluno where profissional_id=?");
        $sql->execute(array($_SESSION['profissional']));
        $quiz = $sql->fetchAll(PDO::FETCH_CLASS);

        $html='';
        $html.= "<div class='pull-right'><a href='cadastro_aluno.php' class='btn btn-success'><span class='glyphicon glyphicon-plus'></span> Incluir</a></div><br><br>";
        if ($quiz){
            $html.= "<table class='table table-bordered'>";
			$html.= "<tr><td style='display:none;'>ID</td><td>Nome</td><td>Informações</td><td>AÇÕES</td></tr>";
            foreach($quiz as $r){
                $html.= "<tr><td style='display:none;'>$r->id</td><td>$r->nome</td><td>DEFICIENCIA: $r->deficiencia<br>AFINIDADES: $r->afinidade<br> ADICIONAL: $r->adicional</td><td>";
                $html.= "<a href='ver_alunos.php?id=$r->id' class='btn btn-info'>Ver</a> ";
                $html.= "<a href='update_aluno.php?id=$r->id' class='btn btn-primary'>Alterar</a> ";
				$html.= "<a href='delete_aluno.php?id=$r->id' class='btn btn-primary'>excluir</a> ";
                $html.= "</td></tr>";
            }
            $html.= "</table>";
        } else {
            $html.= 'Nenhum registro encontrado';
        }

        return $html;
	}
	
}


