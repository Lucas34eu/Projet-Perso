<!DOCTYPE html>
<!-- TITRE ET MENUS -->
<html lang="fr">
    <head>        
        <title>La Ferme - Vias </title>
        <meta http-equiv="Content-Language" content="fr">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
        <link href="<?php echo Chemins::STYLES . 'style.css'; ?>" rel="stylesheet" type="text/css">
        <script type="text/javascript" src="public/js/jqueryversions/jquery-3.4.1.min.js"></script>
        <script type="text/javascript" src="public/js/jquery.autocomplete.js"></script> 

        <link rel="shortcut icon" type="image/jpeg" href="<?php echo Chemins::IMAGES . 'mini_logo.jpg'; ?>">


        <script type="text/javascript">


            $(document).ready(function () {
                var formValide;
                //TRAITEMENT DU CLICK SUR LE BOUTON VALIDER
                //-----------------------------------------
                $("#valider").click(function () {
                    formValide = true;
                    //Traitements de toutes les zones de saisies
                    $("#nouveauClient input[type=text], #nouveauClient input[type=password]").each(function ()
                    {
                        controleSaisie($(this).prop('id'));
                    });
                    //Traitement de la case � cocher
                    if (!$("#conditions").prop('checked')) {
                        $("#erreurConditions").addClass("message-erreur").text("Acceptationobligatoire !").fadeIn();
                        formValide = false;
                    } else
                        $("#erreurConditions").fadeOut();
                    //On valide ou pas le formulaire selon le booleen formValide
                    return formValide;
                });
                //TRAITEMENT DU KEYPRESS DANS LES ZONES DE SAISIES :
                // On efface le message lorsqu'on remplit les champs
                //---------------------------------------------------
                $("#nouveauClient input[type=text], #nouveauClient input[type=password]").keypress(function ()
                {
                    $(this).next().fadeOut();
                });
                //TRAITEMENT DU CLICK SUR LA CASE A COCHER (CONDITIONS GENERALES)
                //---------------------------------------------------------------
                $("#conditions").click(function () {
                    if ($(this).prop('checked'))
                        $("#erreurConditions").fadeOut();
                    else
                        $("#erreurConditions").addClass("message-erreur").text("Acceptation obligatoire !").fadeIn();
                });
                //TRAITEMENT LORSQUE LES ZONES DE SAISIES PERDENT LE FOCUS
                //--------------------------------------------------------
                $("#nouveauClient input[type=text], #nouveauClient input[type=password] ").blur(function ()
                {
                    controleSaisie($(this).attr('id'));
                });

                $("#pass1,#pass2").blur(function ()
                {
                    if ($("#pass1").val() != "")
                        
                        if ($("#pass2").val() != "")
                        {
                            
                            if ($("#pass1").val() != $("#pass2").val())
                            {
                                $("#pass2").next().removeClass("message-ok").addClass("messageerreur").
                                        text("Mot de passe non identique !").fadeIn();
                                formValide = false;
                            }
                        }
                });
                
                $("#pseudo").blur(function ()
                {
                    
                    cherchePseudoBD($("#pseudo").val())
                    /*if (pseudoExistant == true)
                        $("#pseudo").next().removeClass("message-ok").addClass("messageerreur").
                                        text("Pseuso deja utilisé !").fadeIn();
                                formValide = false;
                                */
                   
                });

                //-------------------------------------
                // TRAITEMENT DES CONTROLES DE SAISIES
                //-------------------------------------
                function controleSaisie(idchamp)
                {
                    if ($("#" + idchamp).val() == "")
                    {
                        $("#" + idchamp).next().removeClass("message-ok").addClass("messageerreur").
                                text("Le champ est vide !").fadeIn();
                        formValide = false;
                    } else {

                        var regex, messageErreur;
                        switch (idchamp) //Traitement selon l'id
                        {
                            case 'pseudo' :
                               
                                regex = /^[a-zA-Z0-9_]+$/i;
                                messageErreur = "Pseudo non valide";
                                break;
                            case 'pass1' :
                                regex = /^[0-9a-zA-Z]{6,20}$/i;
                                messageErreur = "Le mot de passe dois avoir 6 caractère minimum";
                                break;
                            case 'mail' :
                                regex = /^[^\W][a-z0-9_]+(\.[a-z0-9_]+)*\@[a-z0-9_]+(\.[a-z0-9_]+)*\.[a-z]{2,4}$/i;
                                messageErreur = "Adresse e-mail non valide!";
                                break;
                            case 'nom' :
                                regex = /^[a-z]+$/i;
                                messageErreur = "C'est pas votre vrai nom sa non ?";
                                break;
                            case 'prenom' :
                                regex = /^[a-z]+$/i;
                                messageErreur = "C'est pas votre vrai prenom sa non ?";
                                break;
                            case 'cp' :
                                regex = /^(([0-8][0-9])|(9[0-5]))[0-9]{3}$/;
                                messageErreur = "code postal incorrect";
                                break;
                            case 'ville' :
                                regex = /^[a-z]+$/i;
                                messageErreur = "Nom de ville incorrect ";
                                break;
                            default :
                                regex = "";
                        }
                        traiterRegex(idchamp, regex, messageErreur);

                    }
                }


                function traiterRegex(idchamp, regex, messageErreur)
                {
                    if (!$("#" + idchamp).val().match(regex))
                    {
                        $("#" + idchamp).next().removeClass("message-ok").addClass("messageerreur").
                                text(messageErreur).show();
                        formValide = false;
                    } else
                        $("#" + idchamp).next().removeClass("messageerreur").
                                addClass("message-ok").text("OK").show();
                }
                //-------------------------------------


                //-------------------------------------
                // TRAITEMENT verification pseuso existant
                //-------------------------------------

                function cherchePseudoBD() {
                    
                    alert("test");
                    
                    $.ajax({
                        async: false,
                        type: "POST",
                        url: "index.php?controleur=inscription&action=chercherPseudo",
                        data: "pseudo=" + $("#pseudo").val(),
                        success: function (reponse) {
                            if (reponse == 1)
                            {
                                $("#pseudo").next().removeClass("messageok").addClass("message-erreur").text("Et non ! Le pseudo existe déjà").show();
                                formValide = false;
                                pseudoExistant = true;
                            }
                        }
                    });
                }

                //-------------------------------------
// TRAITEMENT AUTOCOMPLETE CODEPOSTAL
//-------------------------------------
                $("#cp").autocomplete("libs/chercherCPVille.php", {
                    width: 200
                }); //D’autres options sont disponibles, voir doc en ligne

                $("#cp").result(function (event, data, formatted) {
                    if (data)
                    {
                        $("#cp").val(data[1]);
                        $("#ville").val(data[2]);//.attr("disabled", true);
                    }
                });


            });


        </script>


    </head>
    <body>
        <header>

            <!-- Images En-tête -->
            <a href="index.php"><img src="<?php echo Chemins::IMAGES . 'logo.jpg'; ?>" alt="logo" width="230px" title="Revenir à l'accueil"/></a>

            <h1>La Ferme - Vias </h1>
            

            <!--  Menu haut-->
            <nav id="menu_haut">
                <ul>
                    <li><a href="index.php"> Accueil </a></li>
                    <li><a href="index.php?controleur=produits&action=afficherCarte"> Notre Carte  </a></li>                
                    <li><a href="index.php?controleur=aPropos&action=afficher"> A propos de nous </a></li>
                </ul>
            </nav>
        </header>