<section>
<div class="titre">
Administration du site (Accès réservé)
</div>
<form method="post" action="index.php?controleur=connexion&action=verifier">
<fieldset>
<legend>Identification</legend>
<label for="login">Votre login :</label> <input type="text" name="login" id="login" /> <br/>
<label for="passe">Votre mot de passe :</label><input type="password" name="passe" id="passe" />
<br/>

<input type="submit" value="Connexion" id="connexion"/>



<input type="checkbox" name="connexion_auto" id="connexion_auto" />

<label for="connexion_auto" class="enligne"> Connexion automatique </label><br/>


</fieldset>
</form>
</section>

