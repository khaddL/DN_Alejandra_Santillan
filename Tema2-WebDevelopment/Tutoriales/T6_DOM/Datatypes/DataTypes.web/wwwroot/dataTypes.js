
function onButtonClick(evt) {

    var b = evt.currentTarget;

    var classes = b.classList;

    var isGreen = false;

    for (var i = 0; i < classes.length; i++) {

        var c = classes[i];

        if (c == "greenButton") {

            isGreen = true;

            break;
        }

    }
    if (isGreen) {
        b.className = "btn redButton";

    }
    else {
        b.className = "btn greenButton";

    }

    var t = document.getElementById("simpleTable");

    var currentHTML = t.innerHTML;

    t.innerHTML += "<tr><td>" + b.getAttribute("name") + "</td></td>" + new Date() + "</td></tr>" ;

   


}




//var button = document.getElementsByClassName("Button")[0];

var buttons = document.getElementsByTagName("button");

for (var i = 0; i < buttons.length; i++) {

    buttons[i].addEventListener("click", onButtonClick);

}


/*debugger;

button.addEventListener("click", onButtonClick);*/

