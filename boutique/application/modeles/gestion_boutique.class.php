<?php

// Inclusion de la classe MysqlConfig
// à partir de l'emplacement actuel (dossier "modeles")
require_once 'configs/mysql_config.class.php';
require 'modele_pdo.class.php';

/**
 * Classe utilitaire de gestion de la Base de Données
 *
 * @author OALBERT
 */
class GestionBoutique extends modele_pdo {

// 
// 
// <editor-fold defaultstate="collapsed" desc="Méthodes statiques">
    
    

    
    
    

    //<editor-fold defaultstate="collapsed" desc="getLesCatégories">
    /**
     * Retourne la liste des Catégories
     * @return type Tableau d'objets
     */
    public static function getLesCategories() {
        return self::getLesTuplesByTable("Categorie");
    }
    // </editor-fold>

    
    //<editor-fold defaultstate="collapsed" desc="getLesProduits">
    /**
     * Retourne la liste des Produits
     * @return type Tableau d'objets
     */
    public static function getLesProduits() {
        return self::getLesTuplesByTable("Produit");
    }
    // </editor-fold>
    

    //<editor-fold defaultstate="collapsed" desc="getLesProduitsbyCategorie">
    /**
     * Retourne la liste des produits d'une catégorie donnée
     * @param type $libelleCategorie Libellé de la catégorie
     * @return type
     */
    public static function getLesProduitsByCategorie($libelleCategorie) {
        self::seConnecter();

        self::$requete = "SELECT P.id,nom,description,prix,image,C.libelle FROM Produit P,Categorie C where P.idCategorie = C.id AND libelle = :libCateg";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->bindValue('libCateg', $libelleCategorie);
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetchAll();

        self::$pdoStResults->closeCursor();

        return self::$resultat;
    }
    // </editor-fold>

    
    //<editor-fold defaultstate="collapsed" desc="getLesProduitsAvecLibCategorie">
    /**
     * Retourne la liste des produits et leur catégorie d'une catégorie donnée
     * @param type $libelleCategorie Libellé de la catégorie
     * @return type
     */
    public static function getLesProduitsAvecLibCategorie() {
        self::seConnecter();

        self::$requete = "SELECT P.id,nom,description,prix,image,C.libelle  FROM Produit P,Categorie C where P.idCategorie = C.id;";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetchAll();

        self::$pdoStResults->closeCursor();

        return self::$resultat;
    }
    
    // </editor-fold>
    
    
    //<editor-fold defaultstate="collapsed" desc="getProduitById">
    
    /**
     * Retourne LE produit dont l'id est passé en paramètre
     * @param type $idProduit id du produit
     * @return type
     */
    public static function getProduitById($idProduit) {
        return self::getLeTupleTableById("Produit", $idProduit);
    }
    
    public static function getProduitAndCategById($idProduit) {
        self::seConnecter();

        self::$requete = "SELECT P.id,nom,description,prix,image,C.libelle  FROM Produit P,Categorie C where P.idCategorie = C.id and P.id = $idProduit;";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch();

        self::$pdoStResults->closeCursor();

        return self::$resultat;
        
    
    }
    // </editor-fold>

    
    //<editor-fold defaultstate="collapsed" desc="getNbProduits">
    /**
     * Retourne le nombre de produits
     * @return type
     */
    public static function getNbProduits() {
        self::seConnecter();

        //self::$requete = "SELECT Count(*) FROM Produit";
        self::$requete = "SELECT Count(*) AS nbProduits FROM Produit";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch();

        self::$pdoStResults->closeCursor();

        //return self::$resultat;
        return self::$resultat->nbProduits;
    }
    // </editor-fold>
    

    //<editor-fold defaultstate="collapsed" desc="ajouterCategorie">
   
    /**
     * Ajoute une ligne dans la table Catégorie     
     * @param type $libelleCateg Libellé de la Catégorie
     */
    public static function ajouterCategorie($libelleCateg) {

        self::seConnecter();

        self::$requete = "insert into Categorie(libelle) values(:libelle)";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->bindValue('libelle', $libelleCateg);
        self::$pdoStResults->execute();
      
    }
    
    // </editor-fold>
    
    //<editor-fold defaultstate="collapsed" desc="ajouterProduit">
    /**
     * ajoute un produit 
     * @return type
     */
    public static function ajouterProduit($id,$nom,$description,$prix,$image,$categorie) {

        
        
        self::seConnecter();
        
        self::$requete = "insert into Produit values(:id,:nom,:description,:prix,:image,:idCategorie)";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->bindValue('id', (int)$id);
        self::$pdoStResults->bindValue('nom', $nom);
        self::$pdoStResults->bindValue('description', $description);
        self::$pdoStResults->bindValue('prix', (int)$prix);
        self::$pdoStResults->bindValue('image', $image);
        self::$pdoStResults->bindValue('idCategorie',(int)$categorie);
        
        
        self::$pdoStResults->execute();
      
    }
    
    // </editor-fold>
    
    
    //<editor-fold defaultstate="collapsed" desc="ajouterClient">
    /**
     * Retourne la liste des produits d'une catégorie donnée
     * @param type $libelleCategorie Libellé de la catégorie
     * @return type
     */
    
    public static function ajouterClient($id ,$login,$passe,$mail,$nom,$prenom,$codePostal,$ville) {
        
        self::seConnecter();
        self::$passeSHA1 = sha1($passe); 
        self::$requete = "insert into Client Values (:id,:login,:passe,:mail,:nom,:prenom,:codePostal,:ville)";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->bindValue('id', $id);
        self::$pdoStResults->bindValue('login', $login);
        self::$pdoStResults->bindValue('passe', self::$passeSHA1);
        self::$pdoStResults->bindValue('mail', $mail);
        self::$pdoStResults->bindValue('nom', $nom);
        self::$pdoStResults->bindValue('prenom', $prenom);
        self::$pdoStResults->bindValue('codePostal', $codePostal);
        self::$pdoStResults->bindValue('ville', $ville);
        self::$pdoStResults->execute();
      
    }
    
    // </editor-fold>
    
    
public static function getIDCateg($nomCateg) 
        
        {
    
    self::seConnecter();
    
    self::$requete = "select id from categorie where libelle=:nomCateg";
    self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
    self::$pdoStResults->bindValue('nomCateg', $nomCateg);
    self::$pdoStResults->closeCursor();
    self::$pdoStResults->execute();
    self::$resultat = self::$pdoStResults->fetch();
    return intval(self::$resultat->id);
    
}

    
    
    
    
     //<editor-fold defaultstate="collapsed" desc="getLeMax">
    /**
     * Retourne le max id de produit
     
     */
    public static function getLeMaxProduit() {
        self::seConnecter();

        self::$requete = "select max(id) as nb from produit";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch();

        self::$pdoStResults->closeCursor();

        return self::$resultat->nb;
    }
    
    
    public static function getNBClientByPseudo($pseudo) {
        self::seConnecter();

        self::$requete = "select count(*) as nbResultats from client where login like '".$pseudo."'";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch();

        self::$pdoStResults->closeCursor();

        return self::$resultat->nbResultats;
    }
    
    
    
    // </editor-fold>
    
    
     //<editor-fold defaultstate="collapsed" desc="getLeMaxClient">
    /**
     * Retourne le tuple d'une tables donnée et d'un id
     
     */
    public static function getLeMaxClient() {
        self::seConnecter();

        self::$requete = "select (max(idProfil)+1) as nb from Client";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch();
        self::$pdoStResults->closeCursor();
        return self::$resultat->nb;
    }
    // </editor-fold>
    
    
     //<editor-fold defaultstate="collapsed" desc="isAdminOK">
    /**
     * Retourne le tuple d'une tables donnée et d'un id
     
     */
   public static function isAdminOK ($login , $passe) {
        self::seConnecter();
        
        self::$passeSHA1 = sha1($passe); 
        self::$requete ="SELECT * FROM Client where login=:login and password=:passe and isAdmin=1";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->bindValue('login', $login);
        self::$pdoStResults->bindValue('passe', self::$passeSHA1);
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch();
        self::$pdoStResults->closeCursor();
        
        if (self::$resultat!=null)
            return TRUE;
        else
            return FALSE;

    }
    
    // </editor-fold>
 
    
     //<editor-fold defaultstate="collapsed" desc="ClientVerif">
    /**
     * Retourne le tuple d'une tables donnée et d'un id
     
     */
    public static function ClientVerif ($login , $passe) {
        self::seConnecter();
        
        self::$passeSHA1 = sha1($passe);        
        self::$requete ="SELECT * FROM Client where login=:login and password=:passe";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->bindValue('login', $login);
        self::$pdoStResults->bindValue('passe',  self::$passeSHA1);
        
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch();
        self::$pdoStResults->closeCursor();
       
        if (self::$resultat!=null)
            return TRUE;
        else
            return FALSE; 

    }
    // </editor-fold>
    
    
     //<editor-fold defaultstate="collapsed" desc="getProduits">
    
     /**
     * Retourne le tuple d'une tables donnée et d'un id
     */
    
    public static function getProduits() {
        self::seConnecter();
        
               
        self::$requete ="SELECT * FROM Client where login=:login and password=:passe";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->bindValue('login', $login);
        self::$pdoStResults->bindValue('passe',  self::$passeSHA1);
        
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch();
        self::$pdoStResults->closeCursor();
       // </editor-fold>
        if (self::$resultat!=null)
            return TRUE;
        else
            return FALSE; 
        // </editor-fold>
}

public static function getTotalPanier() {
        self::seConnecter();

//        self::$requete = "select (max(idProfil)+1) as nb from Client";
//        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
//        self::$pdoStResults->execute();
//        self::$resultat = self::$pdoStResults->fetch();
//        self::$pdoStResults->closeCursor();
//        return self::$resultat->nb;
    }

//public static function initialiser() {
//        if (!isset($_SESSION['produits'])) {
//            $_SESSION['produits'] = array();            
//        }
//    }
//    
//    public static function vider() {
//        $_SESSION['produits'] = array();
//    }
//
//    public static function detruire() {
//        unset($_SESSION['produits']);
//    }
//    
//    public static function ajouterProduitPanier($idProduit,$qte) {
//          $_SESSION['produits'][$idProduit] = $qte;        
//    }
//
//     public static function modifierQteProduit($idProduit,$qte) {
//       if (array_key_exists($idProduit, self::getProduits()))
//                $_SESSION['produits'][$idProduit] = $qte;
//    }
//        
//    public static function retirerProduit($idProduit) {
//        if (array_key_exists($idProduit, self::getProduits()))
//             unset ($_SESSION['produits'][$idProduit]);
//    }    
//    
//    public static function getProduitsPanier() {
//        return $_SESSION['produits'];
//    }
//    
//    public static function getNbProduitsPanier() {
//        return isset($_SESSION['produits'])?count($_SESSION['produits']):0;
//    }
//    public static function getQteByProduit($idProduit) {
//        $nb = 0;
//        if (array_key_exists($idProduit, self::getProduits()))
//                $nb=$_SESSION['produits'][$idProduit];
//        
//        return $nb;
//    }
//    
//    public static function isVide() {
//        return (self::getNbProduits() == 0);
//    }
//
//    public static function contains($idProduit) {
//        return (array_key_exists($idProduit, self::getProduits()));
//    }



    }
?>

<?php

header('Content-Type: text/html; charset=UTF-8');

//var_dump(GestionBoutique::getProduitById(7));
// Tests des services (méthodes) de la classe GestionBoutique
//-----------------------------------------------------------


//var_dump(GestionBoutique::getNbProduits());
//$nbProduits = GestionBoutique::getNbProduits();
//echo "Il y a $nbProduits produit(s) dans la boutique...";

//$leProduit = GestionBoutique::getProduitById(1);
//var_dump($leProduit);

//-----------------------------------------------------------
//EXERCICE 1
//-----------------------------------------------------------
//echo "Produit retourné : <br/>";
//echo "--------------------<br/>";
//echo " id : $leProduit->id <br/>";
//echo " nom : $leProduit->nom <br/>";
//echo " description : $leProduit->description <br/>";
//echo " prix : $leProduit->prix <br/>";
//echo " Fichier de l'image : $leProduit->image";
//------------------------------------------------------------
//$lesCategories = GestionBoutique::getLesCategories();
//var_dump($lesCategories);

//echo $lesCategories[2]->libelle;

//echo "Le libellé de la 2ème catégorie est : " . $lesCategories[2]->libelle. "</br>";

//------------------------------------------------------------------------------
//EXERCICE 2
//------------------------------------------------------------------------------
//echo "Il y a ".  count($lesCategories). " catégories dans la base : </br>";
//echo "-------------------------------------</br>";
//foreach ($lesCategories as $uneCategorie)
//{    
//    echo "$uneCategorie->libelle (catégorie $uneCategorie->id) </br>";
//}
//------------------------------------------------------------------------------
//var_dump(GestionBoutique::isAdminOK("grandChef" , "passeGrandChef"));
//var_dump(GestionBoutique::isAdminOK("petitChef" , "passePetitChef"));

?>