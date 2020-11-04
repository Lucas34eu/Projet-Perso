<?php

class ControleurConnexion {
    public function seConnecter(){
        require Chemins::VUES_ADMIN.'v_connexion.inc.php';
    }
    
    
    public function verifier(){
        GestionBoutique::seConnecter();
        if (GestionBoutique::isAdminOK($_POST['login'], $_POST['passe'])==true)
        {
            $_SESSION['login_admin'] = $_POST['login'];
            if (isset($_POST['connexion_auto'])){
                setcookie('login_admin', $_POST['login'], time() +7*24*3600, null,null,false,true);
                
            }
            require Chemins::VUES_ADMIN.'v_index_admin.inc.php';
        }
        else{
            require Chemins::VUES_ADMIN.'v_acces_interdit.inc.php';
        }
    }
    public function afficher(){
        if (isset($_SESSION['login_admin'])){
            require Chemins::VUES_ADMIN.'v_index_admin.inc.php';
        }
        else{
            require Chemins::VUES_ADMIN.'v_connexion.inc.php';
        }
    }
    
    public function gestionProduit(){
        
    }
    
    public function gestionCategorie(){
        
        
    }
    
    public function seDeconnecter(){
        $_SESSION=array();
        session_destroy();
        setcookie('login_admin', '');
        header("Location:index.php");
    }
}