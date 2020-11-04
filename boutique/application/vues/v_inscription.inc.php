<section>

    
        <div class="titre">Nouveau compte CLIENT</div>
        <form method="POST" action="index.php?controleur=inscription&action=inscription">
            <fieldset>
                <legend> Identification : </legend>
                <label for="pseudo">Pseudo choisi :</label> <input type='text' name='pseudo' id='pseudo' /><span> </span><br />
                <label for="pass1"> Mot de passe :</label><input type='password' name='pass1' id='pass1' /><span> </span><br />
                <label for="pass2"> Resaisir le passe :</label><input type='password' name='pass2' id='pass2' /><span> </span><br />
            </fieldset>
            <fieldset>
                <legend> Coordonnées : </legend>
                <label for="mail">Adresse mail :</label> <input type='text' name='mail' id='mail' /><span> </span><br />
                <label for="nom">Nom :</label><input type='text' name='nom' id='nom' /><span> </span><br />
                <label for="prenom">Prénom :</label><input type='text' name='prenom' id='prenom' /><span> </span><br />
                <label for="cp">Code Postal :</label><input type='text' name='cp' id='cp' /><span> </span><br />
                <label for="ville">Ville :</label><input type='text' name='ville' id='ville' /> <span> </span>
            </fieldset>
            <fieldset class="sansBordure">
                <span> Acceptez-vous de recevoir notre newsletter ? </span>
                <label for="oui" class="enligne">oui</label> <input type="radio" name="newsletter" value="oui" id="oui" checked="checked" />
                <label for="non" class="enligne">non</label> <input type="radio" name="newsletter" value="non" id="non" />
                <br />
                <input name='conditions' id='conditions' type='checkbox' /><label for="conditions" class="enligne"> J'accepte les <a href='#'>conditions générales</a></label> <span id='erreurConditions'> </span>
                <br />
                <input type='submit' name='valider' id='valider' value='VALIDER' onclick="location.href = 'index.php?controleur=inscription&action=inscription'" />
            </fieldset>
        </form>
    

</section>