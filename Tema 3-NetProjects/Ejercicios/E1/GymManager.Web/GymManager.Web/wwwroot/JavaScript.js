

var button = document.getElementById("example");

var textbox = document.getElementById("examples");


const Keyenter = 13;
textbox.addEventListener("keypress", function (e) {

    if (e.keyCode == Keyenter) {

        ModalTest();
    }
});




button.addEventListener("click", function (event) {

    ModalTest();
    

});




function ModalTest() {
    let examples = document.getElementById("examples").value;
    document.getElementById("valueInput").innerHTML = "Check-out for " + examples + " " + moment(new Date()).format("DD-MM-YYYY h:mm:ss a");

    var myModal = new bootstrap.Modal(document.getElementById('contenido-modal'), {
        keyboard: false
      

    })
    
    
    myModal.show();
}
