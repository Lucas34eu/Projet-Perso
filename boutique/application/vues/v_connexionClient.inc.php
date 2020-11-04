<section>
<div class="titre">

</div>
<form method="post" action="index.php?controleur=connexionclient&action=verifier">
<fieldset>
<legend>Connexion</legend>
<label for="login">Pseudo :</label> <input type="text" name="login" id="login" /> <br/>
<label for="passe">Mot De Passe :</label><input type="password" name="passe" id="passe" />
<br/>

<input type="submit" value="Connexion" id="connexion"/>



<input type="checkbox" name="connexion_auto" id="connexion_auto" />

<label for="connexion_auto" class="enligne"> Connexion automatique </label><br/>

<input type="button" value="Nouveau Membre ?" id="nouveauClient" onclick="location.href='index.php?controleur=inscription&action=afficher'" />
</fieldset>
</form>
</section>

