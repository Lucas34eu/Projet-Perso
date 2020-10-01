

<nav id="menu_gauche">
    <h1> Trier les plats par catégories </h1>
    <ul>
        <?php
        $lesCategories = GestionBoutique::getLesCategories();
        foreach (VariablesGlobales::$lesCategories as $uneCategorie)
        {
          ?>
           <li>
               <a href="index.php?controleur=produitbycat&categorie=<?php echo $uneCategorie->libelle;?>&action=afficher"><?php echo $uneCategorie->libelle;?></a>
           </li>
        <?php
        }
        ?>        
    </ul>
</nav>