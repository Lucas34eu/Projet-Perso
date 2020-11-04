<!-- CORPS de la page-->
<section>

    <?php
    //var_dump(VariablesGlobales::$lesProduits);
    foreach (VariablesGlobales::$lesProduits as $unProduit) {
        VariablesGlobales::$libelleCategorie = $unProduit->libelle;
        $idProduit= $unProduit->id;
        
        
    ?>
        <article>
            
            <img src="<?php echo Chemins::IMAGES_PRODUITS.VariablesGlobales::$libelleCategorie."/".$unProduit->image;?>" alt="photo" />
            <aside>
                <h1><?php echo $unProduit->nom;?></h1>
                <h3><?php echo $unProduit->description;?></h3>
                <h1><?php echo $unProduit->libelle;?></h1>
                <h3><?php echo $unProduit->prix;?></h3>
                <h3><?php echo $unProduit->id;?></h3>
                <a href="index.php?controleur=panier&action=ajouter&id=<?php echo $unProduit->id;?>&categorie=<?php echo VariablesGlobales::$libelleCategorie;?>">
                    <img src="public/images/ajouter_panier.png" title="Ajouter au panier"/> </a>
            </aside>

        </article>

    <?php
      }
    ?>
</section>