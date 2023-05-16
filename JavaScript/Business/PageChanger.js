import { store } from "./LocalStorage.js"

export function CambiarPagina(ruta, data) 
{
    store(data);
    window.location.href = ruta;
}