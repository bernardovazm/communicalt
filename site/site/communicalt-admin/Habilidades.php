<?php 

 require_once "config.php";
 
class Habilidades{
    
	private $id;
    private $cognitivas;
    private $motoras;
    private $interpessoais;
    private $comunicacionais;
    private $alfabetizacao;
    private $raciociniologico;
    private $data_atendimento;
	private $observacoes;
	private $aluno;

    public function __construct($id=NULL){
        $this->id = $id;
        if ( $id ){
            $con = new PDO(SERVIDOR, USUARIO, SENHA);
            $sql = $con->prepare("SELECT * FROM habilidades WHERE id=?");
            $sql->execute(array($this->id));
            $r = $sql->fetchObject();
            if ( $r ){
            $this->cognitivas = $r->cognitivas_metacognitivas;
            $this->motoras = $r->motoras_psicomotoras;
            $this->interpessoais = $r->interpessoais_afetivas;
            $this->comunicacionais = $r->comunicacionais;
            $this->alfabetizacao = $r->alfabetizacao_letramento;
            $this->raciociniologico = $r->raciociniologico_matematico;
			$this->data_atendimento = $r->data_atendimento;
			$this->observacoes = $r->observacoes;
			$this->aluno = $r->FK_aluno_id;
            }
        }
    }

    public function getCognitivas(){ return $this->cognitivas; }
    public function getMotoras(){ return $this->motoras; }
    public function getInterpessoais(){ return $this->interpessoais; }
    public function getComunicacionais(){ return $this->comunicacionais; }
    public function getAlfabetizacao(){ return $this->alfabetizacao; }
    public function getRaciociniologico(){ return $this->raciociniologico; }
	public function getData_atendimento(){ return $this->data_atendimento; }
	public function getObservacoes(){ return $this->observacoes; }
	public function getAluno(){ return $this->aluno; }

    public function set($user){
        $this->cognitivas = $user['cognitivas'];
        $this->motoras = $user['motoras'];
        $this->interpessoais = $user['interpessoais'];
        $this->comunicacionais = $user['comunicacionais'];
        $this->alfabetizacao = $user['alfabetizacao'];
		$this->raciociniologico = $user['raciociniologico'];
		$this->data_atendimento = $user['data_atendimento'];
		$this->observacoes = $user['observacoes'];
		$this->aluno = $user['aluno'];
   }
		
    public function view(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("SELECT * FROM habilidades WHERE id=?");
        $sql->execute(array($this->id));
        $r = $sql->fetchObject();

        if ( $r ){
            $this->cognitivas = $r->cognitivas_metacognitivas;
            $this->motoras = $r->motoras_psicomotoras;
            $this->interpessoais = $r->interpessoais_afetivas;
            $this->comunicacionais = $r->comunicacionais;
            $this->alfabetizacao = $r->alfabetizacao_letramento;
            $this->raciociniologico = $r->raciociniologico_matematico;
			$this->data_atendimento = $r->data_atendimento;
			$this->observacoes = $r->observacoes;
			$this->aluno = $r->FK_aluno_id;
        }
		
      
        echo "<table class='table'>";
        echo "<tr><td class='col-md-2'>ID</td><td class='col-md-10'>$this->id</td></tr>";
        echo "<tr><td>Cognitivas: </td><td>$this->cognitivas</td></tr>";
        echo "<tr><td>Motoras: </td><td>$this->motoras</td></tr>";
		echo "<tr><td>Interpessoais: </td><td>$this->interpessoais</td></tr>";
        echo "<tr><td>Comunicacionais</td><td>$this->comunicacionais</td></tr>";
        echo "<tr><td>Alfabetizacao: </td><td>$this->alfabetizacao</td></tr>";
        echo "<tr><td>Raciociniologico: </td><td>$this->raciociniologico</td></tr>";
        echo "<tr><td>Data_atendimento: </td><td>$this->data_atendimento</td></tr>";			
        echo "<tr><td>Observacoes: </td><td>$this->observacoes</td></tr>";	
        echo "<tr><td>Aluno: </td><td>$this->aluno</td></tr>";		
        echo "</table>";
    }

    public function add(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);	           			
        $sql = $con->prepare("INSERT INTO habilidades (id, cognitivas_metacognitivas, motoras_psicomotoras, interpessoais_afetivas, comunicacionais, alfabetizacao_letramento, raciociniologico_matematico, data_atendimento, observacoes, FK_aluno_id)  VALUES (NULL, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
        $sql->execute(array($this->cognitivas, $this->motoras, $this->interpessoais, $this->comunicacionais, $this->alfabetizacao, $this->raciociniologico, $this->data_atendimento, $this->observacoes, $this->aluno ));
   
        if ( $sql->errorCode()=='00000' ){
            $_SESSION['msg']="<div class='alert alert-success'>Registro inserido</div>";
            header("Location: ./index_logado.php");
        }else{
            $_SESSION['msg']="<div class='alert alert-danger'><b>ERRO</b> ".$sql->errorInfo()[2]."</div>";
        }	
    }
	
    public function update(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        if ( isset($_POST['habilidades'])){
            $this->cognitivas = $_POST['habilidades']['cognitivas'];
            $this->motoras = $_POST['habilidades']['motoras'];
			$this->interpessoais = $_POST['habilidades']['interpessoais'];
            $this->comunicacionais = $_POST['habilidades']['comunicacionais'];
            $this->alfabetizacao = $_POST['habilidades']['alfabetizacao'];
            $this->raciociniologico = $_POST['habilidades']['raciociniologico'];
            $this->data_atendimento = $_POST['habilidades']['data_atendimento'];
			$this->observacoes = $_POST['habilidades']['observacoes'];
			$this->aluno = $_POST['habilidades']['aluno'];

            $sql = $con->prepare("UPDATE habilidades SET cognitivas_metacognitivas=?, motoras_psicomotoras=?, interpessoais_afetivas=?, comunicacionais=?, alfabetizacao_letramento=?, raciociniologico_matematico=?, data_atendimento=?, observacoes=?, FK_aluno_id=? WHERE id=?");
            $sql->execute(array($this->cognitivas, $this->motoras, $this->interpessoais, $this->comunicacionais, $this->alfabetizacao, $this->raciociniologico, $this->data_atendimento, $this->observacoes, $this->aluno, $this->id));
			
			
            echo $sql->errorInfo()[2];

            if ( $sql->errorCode()=='00000' ){
                $_SESSION['msg']="<div class='alert alert-success'>Registro alterado</div>";
                header("Location: ./");
            }else{
                $_SESSION['msg']="<div class='alert alert-danger'><b>ERRO</b> ".$sql->errorCode()[2]."</div>";
            }

        }
    }

    public function delete(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("DELETE FROM habilidades WHERE id=?");
        $sql->execute(array($this->id ));
        if ( $sql->errorCode()=='00000' ){
            $_SESSION['msg']="<div class='alert alert-success'>Registro excluído</div>";
        }else{
            $_SESSION['msg']="<div class='alert alert-danger'><b>ERRO</b> ".$sql->errorCode()[2]."</div>";
        }
        header("Location: ./");
    }

   public function __toString(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("SELECT * FROM habilidades");
        $sql->execute();
        $quiz = $sql->fetchAll(PDO::FETCH_CLASS);

        $html='';
        $html.= "<div class='pull-right'><a href='cadastro_habilidades.php' class='btn btn-success'><span class='glyphicon glyphicon-plus'></span> Incluir</a></div><br><br>";
        if ($quiz){
            $html.= "<table class='table table-bordered'>";
		    $html.= "<tr><td>ID</td><td>Aluno</td><td>COGNITIVAS/METACOGNITIVAS</td><td>MOTORAS/PSICOMOTORAS</td><td>INTERPESSOAIS/AFETIVAS</td><td>COMUNICACIONAIS</td><td>ALFABETIZACAO/LETRAMENTO</td><td>RACIOCINIOLOGICO/MATEMATICO</td><td>DATA ATENDIMENTO</td><td>OBSERVAÇÕES</td><td>AÇÕES</td></tr>";
            foreach($quiz as $r){     
                $html.= "<tr><td>$r->id</td><td>$r->FK_aluno_id</td><td>$r->cognitivas_metacognitivas</td><td>$r->motoras_psicomotoras</td><td> $r->interpessoais_afetivas</td><td> $r->comunicacionais</td><td> $r->alfabetizacao_letramento</td><td> $r->raciociniologico_matematico</td><td> $r->data_atendimento</td><td> $r->observacoes</td><td>";
                $html.= "<a href='ver_habilidades.php?id=$r->id' class='btn btn-info'>Ver</a> ";
                $html.= "<a href='update_habilidade.php?id=$r->id' class='btn btn-primary'>Alterar</a> ";
				$html.= "<a href='delete_habilidade.php?id=$r->id' class='btn btn-primary'>excluir</a> ";
                $html.= "</td></tr>";
            }
            $html.= "</table>";
        } else {
            $html.= 'Nenhum registro encontrado';
        }

        return $html;
	}
	
	
    public function VerHabilidades(){
		$con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("SELECT * FROM habilidades WHERE id=?");		
        $sql->execute(array($this->id));
        $r = $sql->fetchObject();
		
		if ( $r ){
		    $this->cognitivas = $r->cognitivas;
            $this->motoras = $r->motoras;
            $this->interpessoais = $r->interpessoais;
            $this->comunicacionais = $r->comunicacionais;
            $this->alfabetizacao = $r->alfabetizacao;
            $this->raciociniologico = $r->raciociniologico;
			$this->data_atendimento = $r->data_atendimento;
			$this->observacoes = $r->observacoes;
			$this->aluno = $r->aluno;
		}	
		
        echo "<table class='table'>";
        echo "<tr><td class='col-md-2'>ID: </td><td class='col-md-10'>$this->id</td></tr>";
        echo "<tr><td>Habilidades cognitivas: </td><td>$this->cognitivas</td></tr>";
        echo "<tr><td>Habilidades motoras:</td><td>$this->motoras</td></tr>";
		echo "<tr><td>Habilidades interpessoais: </td><td>$this->interpessoais</td></tr>";
        echo "<tr><td>Habilidades comunicacionais: </td><td>$this->comunicacionais</td></tr>";
        echo "<tr><td>Alfabetizacao: </td><td>$this->alfabetizacao</td></tr>";
        echo "<tr><td>Raciociniologico: </td><td>$this->raciociniologico</td></tr>";
        echo "<tr><td>Data atendimento:  </td><td>$this->data_atendimento</td></tr>";			
        echo "<tr><td>Observacoes: </td><td>$this->observacoes</td></tr>";	
        echo "<tr><td>Aluno: </td><td>$this->aluno</td></tr>";		
        echo "</table>";
	}
	
public function ListarAlunos(){
		
        
		$con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("SELECT * FROM aluno where profissional_id=?");
        $sql->execute(array($_SESSION['profissional']));
        $quiz = $sql->fetchAll(PDO::FETCH_CLASS);
        
        if ($quiz){
					
            foreach($quiz as $r){
                $html.=" <option value='$r->id' name='habilidades[aluno]'>$r->nome</option>";                     
            }       
		} else {
            $html.= 'Nenhum registro encontrado';
        }
		
        return $html;
}
		
}


