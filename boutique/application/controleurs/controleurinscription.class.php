<?php


class controleurinscription {
    
    public function afficher() {
         
        
        require Chemins::VUES . 'v_inscription.inc.php';    
    }
    
    public function inscription() {
        
        //var_dump(GestionBoutique::getLeMaxClient());
        GestionBoutique::ajouterClient(GestionBoutique::getLeMaxClient(),$_POST['pseudo'], $_POST['pass1'], $_POST['mail'], $_POST['nom'], $_POST['prenom'], $_POST['cp'], $_POST['ville'])   ;
        require Chemins::VUES . 'v_connexionClient.inc.php'; 
    }
    
   public function chercherPseudo () {
       echo GestionBoutique::getNBClientByPseudo($_POST['pseudo']);
   }
           
    
    
}
