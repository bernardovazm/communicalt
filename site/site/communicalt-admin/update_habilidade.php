<?php
require_once "config.php";
require_once "Habilidades.php";
$hab = new Habilidades($_GET['id']);
if ( isset($_POST['habilidades']) ){
    $hab->set($_POST['habilidades']);
    $hab->update();
}
?>
<!DOCTYPE html>
<html lang="pt">
<head>
    <title>TPA</title>
    <meta charset="utf-8">
</head>
<body>
<div class="container">

    <h1>Alterar habilidades do aluno</h1>

    <form action="" method="post">

        <div class="form-group">
            <label for="metacognitivas">Habilidades cognitivas/metacognitivas:</label>
            <input id= "metacognitivas" class="form-control"  type="text" name="habilidades[cognitivas]" value="<?php echo $hab->getCognitivas(); ?>"><br>
        </div>
        <div class="form-group">
            <label for="motoras">Habilidades motoras/psicomotoras:</label>
            <input id="motoras" class="form-control"  type="text" name="habilidades[motoras]" value="<?php echo $hab->getMotoras(); ?>">
        </div>
        <div class="form-group">
            <label for="interpessoais">Habilidades interpessoais/afetivas:</label>
            <input id="interpessoais" class="form-control" type="text" name="habilidades[interpessoais]" value="<?php echo $hab->getInterpessoais(); ?>">
        </div>
        <div class="form-group">
            <label for="comunicacionais">Habilidades comunicacionais</label>
            <input id="comunicacionais" class="form-control"  type="text" name="habilidades[comunicacionais]" value="<?php echo $hab->getComunicacionais(); ?>">
        </div>
        <div class="form-group">
            <label for="alfabetizacao">Alfabetizacao/letramento:</label>
            <input id="alfabetizacao" class="form-control"  type="text" name="habilidades[alfabetizacao]" value="<?php echo $hab->getAlfabetizacao(); ?>">
        </div>
		<div class="form-group">
            <label for="raciociniologico">Raciociniologico/matematico:</label>
            <input id="raciociniologico" class="form-control"  type="text" name="habilidades[raciociniologico]" value="<?php echo $hab->getRaciociniologico(); ?>">
        </div>
		<div class="form-group">
            <label for="data_atendimento">Data do atendimento:</label>
            <input id="data_atendimento" class="form-control" placeholder="(Ano / mês / dia)" pattern="[0-9]{4}+/[0-9]{2}+/[0-9]{2}" type="text" name="habilidades[data_atendimento]" value="<?php echo $hab->getData_atendimento(); ?>">
        </div>
		<div class="form-group">
            <label for="observacoes">Observações:</label>
            <input id="observacoes" class="form-control"  type="text" name="habilidades[observacoes]" value="<?php echo $hab->getObservacoes(); ?>">
        </div>
		<div class="form-group">
            <label for="aluno">ID do aluno:</label>
            <input id="aluno" class="form-control"  type="text" name="habilidades[aluno]" value="<?php echo $hab->getAluno(); ?>">
        </div>
        

        <a href="./" class="btn btn-default">Voltar</a>
        <button type="submit" class="btn btn-success">Cadastrar</button>

    </form>

</div>
</body>
</html>

