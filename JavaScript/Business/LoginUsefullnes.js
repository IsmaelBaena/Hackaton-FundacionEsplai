import { PostUser, CheckCredentialsUser, CheckEmailExist } from "../ModulosAPI/ServiceAPI.js"
import { User } from "../Entidades/UserClass.js"
import { CambiarPagina } from "./PageChanger.js"


document.getElementById("btnLogin").addEventListener('click', event => 
{
    var email = document.getElementById("emailLogin").value;
    var psswrd = document.getElementById("pswrdLogin").value;

    CheckCredentialsUser(email, psswrd).then(credentialsCorrect => 
    {
        if (credentialsCorrect) 
            ChangePage(email);
        else
            ErrorMssg("Datos Incorrectos");
    });
});


document.getElementById("btnEnviar").addEventListener('click', event => 
{
    var email = document.getElementById("emailRegister").value;

    
    if (email != "")
    {
        CheckEmailExist(email).then(emailExits => 
            {
                if (!emailExits) 
                {
                    var name = document.getElementById("nombre").value;
                    var surname = document.getElementById("apellido").value;
                    var psswrd = document.getElementById("pswrdRegister").value;
                    var psswrdRepeat = document.getElementById("pswrdRepeat").value;

                    if (CheckFormNotEmpty(name, surname, psswrd, psswrdRepeat)) 
                    {
                        if (psswrd == psswrdRepeat)
                        {
                            var user = new User(email, name, surname, psswrd);
        
                            PostUser(user)
                            ChangePage(email);
                        }
                        else
                        ErrorMssg("Contraseñas no coinciden");
                    }
                    else
                        ErrorMssg("Rellene todos los campos");
                    
                }
                else
                    ErrorMssg("Email ya existe");
            });
    }
    else
        ErrorMssg("Email no valido");
});


function ChangePage(email) 
{
    CambiarPagina("./home.html", email);
}

function ErrorMssg(error) 
{
    alert("ERROR: " + error);
}


function CheckFormNotEmpty(name, surname, psswrd, psswrdRepeat) 
{
    return name != "" 
        && surname != ""
        && psswrd != ""
        && psswrdRepeat != "";
}
