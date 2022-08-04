
<?php

 require_once "config.php";
 

 
class Relatorio{
	


    private $id;
	private $cognitivas;
    private $motoras;
    private $interpessoais;
    private $comunicacionais;
	private $alfabetizacao;
	private $raciocinio;
	private $data_atendimento;
	private $observacoes;
	private $aluno;
	
	private $profissional;
	private $instituicao;
	private $mensagem;
	

   

     public function listar_habilidadedata(){
		  
		  
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
		if( isset($_POST['inicio']) && isset($_POST['fim'])){
			$dataI = $_POST['inicio'];
            $dataF = $_POST['fim'];
		$dataI = str_replace('/', '-', $dataI);
        $inicio = date('Y-m-d', strtotime($dataI));
		
		$dataF = str_replace('/', '-', $dataF);
        $fim = date('Y-m-d', strtotime($dataF));
		
		}
		else{
			$inicio = '0001-01-01';
			$fim = '9999-12-31';
		}
		
        $sql = $con->prepare("select h.id as 'id',
                                    h.cognitivas_metacognitivas as 'cognitivas_metacognitivas',
                                    h.motoras_psicomotoras as 'motoras_psicomotoras',
                                    h.interpessoais_afetivas as 'interpessoais_afetivas',
                                    h.comunicacionais as 'comunicacionais',
                                    h.alfabetizacao_letramento as 'alfabetizacao_letramento',
									h.raciociniologico_matematico as 'raciociniologico_matematico',
									h.data_atendimento as 'data_atendimento',
									h.observacoes as 'observacoes',
									a.nome as 'Aluno'
                            from    habilidades h,
                                    aluno a
                            where   h.FK_aluno_id = a.id and
                                    h.data_atendimento between ? and ?
                            order by h.id;");
        $sql->execute(array($inicio, $fim));
        $quiz = $sql->fetchAll(PDO::FETCH_CLASS);

        $html='';
        if ($quiz){
            $html.= "<table class='table table-bordered'>";
		    $html.= "<tr><td>ID</td><td>Aluno</td><td>Data Atendimento</td><td>Cognitivas e Metacognitivas</td><td>Motoras e psicomotoras</td><td>Interpessoais e afetivas</td><td>Comunicacionais</td><td>Alfabetização e letramento</td><td>Raciocinio logico e matematico</td><td>Observações</td></tr>";
            foreach($quiz as $r){     
                $html.= "<tr><td>$r->id</td><td>$r->Aluno</td><td>$r->data_atendimento</td><td>$r->cognitivas_metacognitivas</td><td> $r->motoras_psicomotoras</td><td>$r->interpessoais_afetivas</td><td>$r->comunicacionais</td><td>$r->alfabetizacao_letramento</td><td>$r->raciociniologico_matematico</td><td> $r->observacoes</td><td>";
                $html.= "</td></tr>";
            }
            $html.= "</table>";
        } else {
            $html.= 'Nenhum registro encontrado';
        }

        return $html;
    }

    public function listar_alunodeficiencia(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
		if( isset($_POST['deficiencia'])){
			$deficiencia=$_POST['deficiencia'];
			$sql = $con->prepare("select a.nome, a.deficiencia, a.afinidade, a.adicional, p.login from aluno a, profissional p where p.id = a.profissional_id and deficiencia = ?;");
        $sql->execute(array($deficiencia));
		}
		else{
			$sql = $con->prepare("select a.nome, a.deficiencia, a.afinidade, a.adicional, p.login from aluno a, profissional p where p.id = a.profissional_id ;");
            $sql->execute();
		}
        
        $quiz = $sql->fetchAll(PDO::FETCH_CLASS);

        $html='';
        if ($quiz){
            $html.= "<table class='table table-bordered'>";
			$html.= "<tr><td>Nome</td><td>Informações</td></tr>";
            foreach($quiz as $r){
                $html.= "<tr><td>$r->nome</td><td>$r->deficiencia<br>$r->afinidade<br>$r->adicional</td><td>";

                $html.= "</td></tr>";
            }
            $html.= "</table>";
        } else {
            $html.= 'Nenhum registro encontrado';
        }

        return $html;
	}
	
	public function listar_feedback(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("select f.id as 'ID',
                                    f.profissional as 'Profissional',
                                    f.instituicao as 'Instituição',
                                    f.mensagem as 'Mensagem'                                  
                            from    feedback f                         
                            order by f.id; ");
        $sql->execute();
        $quiz = $sql->fetchAll(PDO::FETCH_CLASS);

        $html='';
        if ($quiz){
            $html.= "<table class='table table-bordered'>";
			$html.= "<tr><td style='display:none;'>ID</td><td>Profissional</td><td>Mensagem</td></tr>";
            foreach($quiz as $r){
                $html.= "<tr><td style='display:none;'>$r->ID</td><td>$r->Profissional</td><td>$r->Mensagem<br></td><td>";

                $html.= "</td></tr>";
            }
            $html.= "</table>";
        } else {
            $html.= 'Nenhum registro encontrado';
        }

        return $html;
	
    }
	
	public function listar_alunosprofissionais(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
		if( isset($_POST['profissional'])){
			$profissional=$_POST['profissional'];
        $sql = $con->prepare("select a.nome as 'aluno', a.deficiencia, a.afinidade, a.adicional, p.nome, p.login from aluno a, profissional p where a.profissional_id = p.id and p.nome = ?;");
        $sql->execute(array($profissional));
		}
		else{
			$sql = $con->prepare("select a.nome as 'aluno', a.deficiencia, a.afinidade, a.adicional, p.nome, p.login from aluno a, profissional p where a.profissional_id = p.id;");
        $sql->execute();
		}
        $quiz = $sql->fetchAll(PDO::FETCH_CLASS);

        $html='';
        if ($quiz){
            $html.= "<table class='table table-bordered'>";
			$html.= "<tr><td>Profissional </td><td> Aluno</td><td>Deficiencia </td><td> Afinidade</td><td> Adicional</td><td> Login profissional</td></tr>";
            foreach($quiz as $r){
                $html.= "<tr><td>$r->nome</td><td>$r->aluno</td><td>$r->deficiencia</td><td>$r->afinidade</td><td>$r->adicional</td><td>$r->login</td><td>";

                $html.= "</td></tr>";
            }
            $html.= "</table>";
        } else {
            $html.= 'Nenhum registro encontrado';
        }

        return $html;
	
    }
	
	public function listar_profissionaisalunos(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
		if( isset($_POST['aluno'])){
			$aluno=$_POST['aluno'];
        $sql = $con->prepare("select a.nome as 'aluno', p.nome as 'profissional', p.email, p.telefone, p.login from aluno a, profissional p where a.profissional_id = p.id and a.nome= ? ;");
        $sql->execute(array($aluno));
		}
		else{
			$sql = $con->prepare("select a.nome as 'aluno', p.nome as 'profissional', p.email, p.telefone, p.login from aluno a, profissional p where a.profissional_id = p.id;");
        $sql->execute();
		}
        $quiz = $sql->fetchAll(PDO::FETCH_CLASS);

        $html='';
        if ($quiz){
            $html.= "<table class='table table-bordered'>";
			$html.= "<tr><td>Aluno </td><td> Profissional</td><td>E-mail </td><td> Telefone</td><td> Login Profissional </td></tr>";
            foreach($quiz as $r){
                $html.= "<tr><td>$r->aluno</td><td>$r->profissional</td><td>$r->email</td><td>$r->telefone</td><td>$r->login</td><td>";

                $html.= "</td></tr>";
            }
            $html.= "</table>";
        } else {
            $html.= 'Nenhum registro encontrado';
        }

        return $html;
	
    }
	
	public function listar_habilidadesalunos(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("select DISTINCT a.nome, (SELECT COUNT(*) FROM habilidades h WHERE h.FK_aluno_id=a.id) as habilidades FROM aluno a, habilidades h WHERE a.id=h.FK_aluno_id;");
        $sql->execute();
        $quiz = $sql->fetchAll(PDO::FETCH_CLASS);

        $html='';
        if ($quiz){
            $html.= "<table class='table table-bordered'>";
			$html.= "<tr><td>Nome</td><td>Habilidades</td></tr>";
            foreach($quiz as $r){
                $html.= "<tr><td>$r->nome</td><td>$r->habilidades<br></td><td>";

                $html.= "</td></tr>";
            }
            $html.= "</table>";
        } else {
            $html.= 'Nenhum registro encontrado';
        }

        return $html;
	
    }
	
	public function contar_alunosprofissionais(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
        $sql = $con->prepare("select DISTINCT p.nome, (SELECT COUNT(*) FROM aluno a WHERE a.profissional_id=p.id) as alunos FROM aluno a, profissional p WHERE p.id=a.profissional_id;");
        $sql->execute();
        $quiz = $sql->fetchAll(PDO::FETCH_CLASS);

        $html='';
        if ($quiz){
            $html.= "<table class='table table-bordered'>";
			$html.= "<tr><td>Profissional</td><td>Alunos</td></tr>";
            foreach($quiz as $r){
                $html.= "<tr><td>$r->nome</td><td>$r->alunos<br></td><td>";

                $html.= "</td></tr>";
            }
            $html.= "</table>";
        } else {
            $html.= 'Nenhum registro encontrado';
        }

        return $html;
	
    }
	
	public function buscar_idaluno(){
        $con = new PDO(SERVIDOR, USUARIO, SENHA);
		if( isset($_POST['id'])){
			$id=$_POST['id'];
        $sql = $con->prepare("select DISTINCT a.id, a.nome as 'Aluno', a.deficiencia, a.afinidade, a.adicional, a.profissional_id, p.nome as 'profissional' from aluno a, profissional p where a.profissional_id=p.id and a.id= ?");
        $sql->execute(array($id));
		}
		else{
			$sql = $con->prepare("select DISTINCT a.id, a.nome as 'Aluno', a.deficiencia, a.afinidade, a.adicional, a.profissional_id, p.nome as 'profissional' from aluno a, profissional p where a.profissional_id=p.id;");
        $sql->execute();
		}
        $quiz = $sql->fetchAll(PDO::FETCH_CLASS);

        $html='';
        if ($quiz){
            $html.= "<table class='table table-bordered'>";
			$html.= "<tr><td>ID </td><td> Aluno</td><td>Deficiencia </td><td> Afinidade</td><td> Adicional </td><td> profissional_id </td><td> Profissional </td></tr>";
            foreach($quiz as $r){
                $html.= "<tr><td>$r->id</td><td>$r->Aluno</td><td>$r->deficiencia</td><td>$r->afinidade</td><td>$r->adicional</td><td>$r->profissional_id</td><td>$r->profissional</td><td>";

                $html.= "</td></tr>";
            }
            $html.= "</table>";
        } else {
            $html.= 'Nenhum registro encontrado';
        }

        return $html;
	
    }
	
}


                
