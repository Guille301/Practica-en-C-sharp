document.querySelector("#FormularioAltaEmpleado").addEventListener('submit', validarCampos);

function validarCampos(evt) {

    evt.preventDefault();

    let nombre = document.querySelector("#nombre").value;
    let email = document.querySelector("#mail").value;
    let password = document.querySelector("#contra").value;
    let fecha = document.querySelector("#fechaIngreso").value;
    let tipo = document.querySelector("#tipo").value;
    let residente = document.querySelector("#residenteInstancia").value;

    if (nombre != "" && email != "" && password != "" && fecha != "" && tipo != "" && residente != "") {

        this.submit();

    } else {

        document.querySelector("#msgAltaEmpleado").innerHTML = "No se pueden ingresar datos vacios ";
    }



}