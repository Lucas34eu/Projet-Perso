<?php

class ControleurPanier {

    public function afficherPanier() {
        //var_dump(Panier::getProduits());
        if (Panier::isVide()) {
            require Chemins::VUES . 'v_message.inc.php';
        } else
            require Chemins::VUES . 'v_contenu_panier.inc.php';
    }

    public function ajouter(){
        
        $idProduit = $_REQUEST['id'];
        $leProduit = GestionBoutique::getProduitById($idProduit);        
        Panier::ajouterProduit($idProduit, 1);
        require Chemins::VUES . 'v_contenu_panier.inc.php';
        
    }

    public function vider_Panier() {
        Panier::vider();
        VariablesGlobales::$message = "le panier est vide";
        include (Chemin::VUES . "v_message.php");
    }

    public function afficherProduit_du_panier() {
        Panier::getProduits();
    }

    public function Retirer_Produit() {
        $idProduit = $_REQUEST['id'];
        Panier::retirerProduit($idProduit);
        $this->afficherProduit_du_panier();
        require Chemins::VUES . 'v_contenu_panier.inc.php';
    }

}
