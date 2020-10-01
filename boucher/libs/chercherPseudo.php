<?php 

//require '../configs/mysql_config.class.php';
//require dirname(__DIR__) . '/application/modeles/gestion_boutique.class.php';


echo GestionBoutique::getNBClientByPseudo($_POST['pseudo']);
?>