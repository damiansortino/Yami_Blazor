function ModalToggle() {

    $("#modal").modal('toggle');
}

function ModalConfirmToggle() {

    $("#modalConfirm").modal('toggle');
}
function DisabledFieldFormulario() {

    $("#FieldSetFormulario")[0].disabled = true;
    console.log($("#FieldSetFormulario")[0]);
}

function EnabledFieldFormulario() {
    $("#FieldSetFormulario")[0].disabled = false;
}

function alerta(posicion, icono, mensaje) {
    Swal.fire({
        position: posicion,
        icon: icono,
        title: mensaje,
        showConfirmButton: false,
        timer: 1500
    })
}

function alertaConfirmar() {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Sí'
    }).then((result) => {
        return result.value;
    })

}


function saveAsFile(filename, bytesBase64) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64," + bytesBase64;
    document.body.appendChild(link); // Needed for Firefox
    link.click();
    document.body.removeChild(link);
}
function saveAsFile(filename, bytesBase64) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64," + bytesBase64;
    document.body.appendChild(link); // Needed for Firefox
    link.click();
    document.body.removeChild(link);
}


function focusCodeBarString() { 
    var cadena = $("searchStringProduct");
    cadena.focus();

}