<!-- CORPS de la page-->
<section>
    <h2> Votre panier </h2>
    
    <?php
    //var_dump(Panier::getProduits());
    //var_dump(VariablesGlobales::$libelleCategorie);
    foreach (Panier::getProduits() as $unIdProduit=>$uneQte) {
        $unProduit = GestionBoutique::getProduitAndCategById($unIdProduit);
        //var_dump($unProduit);
        //$idProduit= $unProduit->id;
        
        
    ?>
        <article>
            
            <img src="<?php echo Chemins::IMAGES_PRODUITS.$unProduit->libelle."/".$unProduit->image;?>" alt="photo" />
            <aside>
                <h1><?php echo $unProduit->nom;?></h1>
                
                <h1><?php echo $unProduit->libelle;?></h1>
                <h3><?php echo $unProduit->prix;?></h3>
                
                
                
            </aside>
                <a href="index.php?controleur=panier&action=Retirer_Produit&id=<?php echo $unProduit->id;?>">
                    <img id="delete" src="public/images/pasOK.png" title="Ajouter au panier" > </a>
        </article>

    <?php
      }
    ?>
</section>