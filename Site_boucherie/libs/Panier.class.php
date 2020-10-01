<?php

class Panier{

    public static function initialiser() {
        if (!isset($_SESSION['produits'])) {
            $_SESSION['produits'] = array();            
        }
    }
    
    public static function vider() {
        $_SESSION['produits'] = array();
    }

    public static function detruire() {
        unset($_SESSION['produits']);
    }
    
    
    
    
    
    
    public static function ajouterProduit($idProduit,$qte) {
          if (Panier::contains($idProduit))
              $_SESSION['produits'][$idProduit] += $qte;  
          else
              $_SESSION['produits'][$idProduit] = $qte;
    }
    
    

     public static function modifierQteProduit($idProduit,$qte) {
       if (array_key_exists($idProduit, self::getProduits()))
                $_SESSION['produits'][$idProduit] = $qte;
    }
        
    public static function retirerProduit($idProduit) {
        if (array_key_exists($idProduit, self::getProduits()))
             unset ($_SESSION['produits'][$idProduit]);
    }    
    
    
    
    
    
    
    
    
    public static function getProduits() {
        return $_SESSION['produits'];
    }
    
    public static function getNbProduits() {
        $nb = 0;
        if (isset($_SESSION['produits'])) {
            $nb = array_sum($_SESSION['produits']);
        }
        return $nb;
        
    }
    
    
    public static function getQteByProduit($idProduit) {
        $nb = 0;
        if (array_key_exists($idProduit, self::getProduits()))
                $nb=$_SESSION['produits'][$idProduit];
        
        return $nb;
    }
    
    public static function isVide() {
        return (self::getNbProduits() == 0);
    }

    public static function contains($idProduit) {
        return (array_key_exists($idProduit, self::getProduits()));
    }
   
}
?>
