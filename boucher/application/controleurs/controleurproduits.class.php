<?php

class ControleurProduits {

    public function __construct() {
        // si on séparait les modèles, le constructeur donnerait son chemin
        // require_once Chemins::MODELES.'gestion_categories.class.php';    
    }

    public function afficher() {
        
        VariablesGlobales::$lesProduits = GestionBoutique::getLesProduitsAvecLibCategorie();
        //var_dump(VariablesGlobales::$lesProduits);
        VariablesGlobales::$nbProduits=GestionBoutique::getNbProduits();
        require Chemins::VUES . 'v_produits.inc.php';    
    }
    
    
    
    public function afficherCreation() {
        
        
        require Chemins::VUES_ADMIN . 'v_ajout-produit.inc.php';
        
        
     
    }
    
    public function Ajout() {
        
        
        GestionBoutique::ajouterProduit($_POST['ID'], $_POST['Nom'], $_POST['Description'], $_POST['Prix'], $_POST['Nom_image'], $_POST['Categorie']);
        
        
        
        
     
    }
    

}

?>