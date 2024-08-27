document.querySelector("#FormularioLogin").addEventListener('submit', validarCampo);

function validarCampo(evt) {

    evt.preventDefault();

    let email = document.querySelector("#email").value;
    let password = document.querySelector("#password").value;

    if (email != "" || password != "") {

        this.submit();

    } else {

        document.querySelector("#msgLogin").innerHTML = "No se pueden ingresar datos vacios JS";
    }


} 