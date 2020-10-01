<?php


class modele_pdo {
    
    // <editor-fold defaultstate="collapsed" desc="Champs statiques">

    /**
     * Objet de la classe PDO
     * @var PDO
     */
    protected static $pdoCnxBase = null;

    protected static $passeSHA1;
    /**
     * Objet de la classe PDOStatement
     * @var PDOStatement
     */
    protected static $pdoStResults = null;
    protected static $requete = ""; //texte de la requête
    protected static $resultat = null; //résultat de la requête

// </editor-fold>
    
    // <editor-fold defaultstate="collapsed" desc="Méthodes statiques">
    
    //<editor-fold defaultstate="collapsed" desc="seConnecter">
    /**
     * Permet de se connecter à la base de données
     */
    
    public static function seConnecter() {

        if (!isset(self::$pdoCnxBase)) { //S'il n'y a pas encore eu de connexion
            try {
                self::$pdoCnxBase = new PDO('mysql:host=' . MysqlConfig::SERVEUR . ';dbname=' . MysqlConfig::BASE, MysqlConfig::UTILISATEUR, MysqlConfig::MOT_DE_PASSE);
                self::$pdoCnxBase->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION); //méthode de la classe PDO
                self::$pdoCnxBase->setAttribute(PDO::ATTR_DEFAULT_FETCH_MODE, PDO::FETCH_OBJ); //méthode de la classe PDO
                self::$pdoCnxBase->query("SET CHARACTER SET utf8"); //méthode de la classe PDO
            } catch (Exception $e) {
                // l’objet pdoCnxBase a généré automatiquement un objet de type Exception
                echo 'Erreur : ' . $e->getMessage() . '<br />'; // méthode de la classe Exception
                echo 'Code : ' . $e->getCode(); // méthode de la classe Exception
            }
        }
    }
    // </editor-fold>

    //<editor-fold defaultstate="collapsed" desc="seDeconnecter">
    /**
     * Permet de se déconnecter à la base de données
     */
    public static function seDeconnecter() {
        self::$pdoCnxBase = null;
        //si on n'appelle pas la méthode, la déconnexion a lieu en fin de script
    }
    // </editor-fold>
    
    //<editor-fold defaultstate="collapsed" desc="getLesTuplesByTable">
    /**
     * Retourne la liste des tuples d'une tables donnée
     
     */
    
    
    protected static function getLesTuplesByTable($table) {
        self::seConnecter();

        self::$requete = "select * from $table";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetchAll();

        self::$pdoStResults->closeCursor();

        return self::$resultat;
    }
    
    // </editor-fold>
    
    //<editor-fold defaultstate="collapsed" desc="getLeTupleTableById">
    /**
     * Retourne le tuple d'une tables donnée et d'un id
     
     */
    protected static function getLeTupleTableById($table,$id) {
        self::seConnecter();

        self::$requete = "select * from $table where id=:idTable";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->bindValue('idTable', $id);
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch();

        self::$pdoStResults->closeCursor();

        return self::$resultat;
    }
    // </editor-fold>
    
    // </editor-fold>
    
}
