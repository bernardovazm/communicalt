<?php
require_once "config.php";
require_once "Alunos.php";
$aln = new Alunos($_GET['id']);
if ( isset($_POST['aluno']) ){
    $aln->set($_POST['aluno']);
    $aln->update();
}
?>
<!DOCTYPE html>
<html lang="pt">
<head>
    <title>Alterar dados do aluno</title>
    <meta charset="utf-8">
</head>
<body>
<div class="container">

    <h1>Alterar Registro</h1>

    <form action="" method="post">

        <div class="form-group">
            <label for="nome">Nome:</label>
            <input id= "nome" class="form-control"  type="text" name="aluno[nome]" value="<?php echo $aln->getNome(); ?>"><br>
        </div>
        <div class="form-group">
            <label for="deficiencia">Deficiência: </label>
            <input id="deficiencia" class="form-control"  type="text" name="aluno[deficiencia]" value="<?php echo $aln->getDeficiencia(); ?>">
        </div>
        <div class="form-group">
            <label for="afinidade">Afinidade:</label>
            <input id="afinidade" class="form-control" type="text" name="aluno[afinidade]" value="<?php echo $aln->getAfinidade(); ?>">
        </div>
        <div class="form-group">
            <label for="adicional">Adicional:</label>
            <input id="adicional" class="form-control"  type="text" name="aluno[adicional]" value="<?php echo $aln->getAdicional(); ?>">
        </div>
 
        <a href="./" class="btn btn-default">Voltar</a>
        <button type="submit" class="btn btn-success">Cadastrar</button>

    </form>

</div>
</body>
</html>

