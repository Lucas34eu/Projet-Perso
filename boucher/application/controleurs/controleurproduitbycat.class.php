<?php

class ControleurProduitbyCat {

    public function __construct() {
        // si on séparait les modèles, le constructeur donnerait son chemin
        // require_once Chemins::MODELES.'gestion_categories.class.php';    
    }

    public function afficher() {
        VariablesGlobales::$libelleCategorie=$_REQUEST['categorie'];
        VariablesGlobales::$lesProduits = GestionBoutique::getLesProduitsByCategorie($_REQUEST['categorie']);
        require Chemins::VUES . 'v_produits.inc.php';    
    }

}
