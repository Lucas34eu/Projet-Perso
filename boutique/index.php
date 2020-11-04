<?php

//indentation auto du code sous Netbeans : ALT+MAJ+F

session_start(); 

ob_start(); // A PLACER pour éviter erreur de création cookies


require_once("configs/chemins.class.php");
require_once(Chemins::MODELES . "gestion_boutique.class.php");
require_once(Chemins::LIBS . "Panier.class.php");
Panier::initialiser();
//Panier::vider();
require_once(Chemins::CONFIGS . "mysql_config.class.php");
require_once(Chemins::CONFIGS . "variables_globales.class.php");
//require_once(Chemins::LIBS . "Panier.class.php");
//
//require_once(Chemins::MODELES . "ModelePDO.class.php");
//require_once(Chemins::MODELES . "ModeleZikBoutik.class.php");

//Rmq : si les modèles étaient "découpés", ils seraient inclus dans chaque controleur associé et non dans le controleur principal
//ModeleZikBoutik::seConnecter();

require_once(Chemins::VUES_PERMANENTES . "v_entete.inc.php");

//Affichage des catégories (menu de gauche)
require_once(Chemins::CONTROLEURS . "controleurcategories.class.php");


$controleurCategorie = new ControleurCategories();
$controleurCategorie->afficher();

if (!isset($_REQUEST['controleur'])) {
    require_once(Chemins::VUES . "v_accueil.inc.php");
//    Panier::initialiser();
} else {
    $action = $_REQUEST['action'];

    $classeControleur = 'controleur' . $_REQUEST['controleur']; //ex : ControleurProduits
    $fichierControleur = $classeControleur . ".class.php"; //ex : ControleurProduits.class.php
    require_once(Chemins::CONTROLEURS . $fichierControleur);

    $objetControleur = new $classeControleur(); //ex : $objetControleur = new ControleurProduits();
    $objetControleur->$action(); //ex : $objetControleur->afficher();
    //version avec classe statique
    // $classeStatiqueControleur = 'Controleur' . $_REQUEST['controleur'];
    // $classeStatiqueControleur::$action();
}

//VariablesGlobales::$nbArticles = Panier::nbProduits();

require_once(Chemins::VUES_PERMANENTES . "v_resume_panier.inc.php");

require_once(Chemins::VUES_PERMANENTES . "v_pied.inc.php");
?>