<section>
    <?php VariablesGlobales::$nbProduits= GestionBoutique::getLeMaxProduit(); ?>
    <div class="titre">Ajouter un Produit</div>
    <form method="POST" action="index.php?controleur=produits&action=ajout">
    <fieldset>
      <legend> Entrez les informations suivantes </legend>
      <label for="ID">ID du produit :</label> <input type="text" name="ID" id="ID" value="<?php echo VariablesGlobales::$nbProduits+1 ;  ?>" /><span> </span><br />
      <label for="Nom"> Nom du produit : </label><input type="text" name="Nom" id="Nom" /><span> </span><br />
      <label for="Description"> Description :</label><input type='text' name='Description' id='Description' /><span> </span><br />
      <label for="Prix"> Prix du produit :</label><input type='text' name='Prix' id='Prix' /><span> </span><br />
      <label for="Nom_image"> Nom de l'image :</label><input type='text' name='Nom_image' id='Nom_image' /><span> </span><br />
      
      
      <label for="Categorie"> Categorie  :</label> <select name="Categorie" id="Categorie">
          
      <?php 
      
      foreach (GestionBoutique::getLesCategories() as $uneCategorie)
      { ?>
        <option value="<?php echo $uneCategorie->id;?>"> <?php echo $uneCategorie->libelle;?> </option>
      <?php 
      }
      ?>
              
 
    
      </select><br>
      
      <input type='submit' name='creer' id='creer' value='Créer le Produit'/> <!--onclick="location.href='index.php?controleur=ajout_produit&action=creer'" />-->
    </fieldset>
    </form>
    
</section>

