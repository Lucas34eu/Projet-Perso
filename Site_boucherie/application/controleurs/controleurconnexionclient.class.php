<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of controleurconnexionclient
 *
 * @author lucas.mancini
 */
class controleurconnexionclient {
    
    public function sInscrire(){
        require Chemins::VUES_ADMIN.'v_inscription.inc.php';
    }
    
    public function seConnecter(){
        require Chemins::VUES_ADMIN.'v_connexion.inc.php';
    }
    
    
    public function afficher(){
        if (isset($_SESSION['login'])){
            require Chemins::VUES.'v_accueil_client.inc.php';
        }
        else{
            require Chemins::VUES.'v_connexionClient.inc.php';
        }
    }
    
    
    public function verifier(){
        GestionBoutique::seConnecter();
                
        if (GestionBoutique::ClientVerif($_POST['login'], $_POST['passe'])==true)
        {
            $_SESSION['login'] = $_POST['login'];
            
            if (isset($_POST['connexion_auto'])){
                setcookie('login', $_POST['login'], time() +7*24*3600, null,null,false,true);
                
            }
            require Chemins::VUES.'v_accueil_client.inc.php';
        }
        else{
            require Chemins::VUES.'v_connexionClient.inc.php';
        }
    }
    
    
    public function seDeconnecter(){
        $_SESSION=array();
        session_destroy();
        setcookie('login_client', '');
        header("Location:index.php");
    }
}
