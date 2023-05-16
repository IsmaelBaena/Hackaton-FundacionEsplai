import { GetUserById } from "../ModulosAPI/ServiceAPI.js"
import { show } from "./LocalStorage.js"

var email = show();

GetUserById(email).then(user => {
    document.getElementById("nombre").innerHTML = "Bienvenido " + user.nombre + " " + user.apellido;
    document.getElementById("email").innerHTML = "Email " + user.email;
});