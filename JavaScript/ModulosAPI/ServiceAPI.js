import { GetQuery, SetQuery } from "./ConsultorAPI.js"

const ROOT = "https://localhost:7095/api";

const USUARIO = "/Usuarios/";

const BYID = "GetById/";
const CREDENTIALS = "CheckCredentials/";
const EMAILEXIST = "EmailExist/";
const POST = "Post";

const EMAIL = "email_";
const PSSWRD = "psswrd_";


function Post(endpoint, model) { return SetQuery(ROOT + endpoint + POST, model); }
function Get(endpoint) { return GetQuery(ROOT + endpoint); }
function GetWhithBody(endpoint) { return GetQuery(ROOT + endpoint); }


//Crud Usuario
export function PostUser(model) { return Post(USUARIO, model); }
export function GetUserById(id) { return Get(USUARIO + BYID + id); }
export function CheckEmailExist(id) { return Get(USUARIO + EMAILEXIST + id); }
export function CheckCredentialsUser(email, psswrd) { return GetWhithBody(USUARIO + CREDENTIALS + EMAIL + email + "," + PSSWRD + psswrd); }