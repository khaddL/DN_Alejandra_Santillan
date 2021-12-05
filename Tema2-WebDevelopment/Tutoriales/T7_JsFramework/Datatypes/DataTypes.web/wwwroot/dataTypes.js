
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

    t.innerHTML += "<tr><td>" + b.getAttribute("name") + "</td></td>" + moment(new Date()).format("DD-MM-YYYY") + "</td></tr>" ;

   


}




//var button = document.getElementsByClassName("Button")[0];

var buttons = document.getElementsByTagName("button");

for (var i = 0; i < buttons.length; i++) {

    buttons[i].addEventListener("click", onButtonClick);

}


(function () {

    document.getElementById("button1").addEventListener("click", function () {

        var option = {
            style: {

                main: {
                    background: "#364685",
                    color: "#fff",
                },
            },

        };

        iqwerty.toast.toast("Hello Word", option);
    })

    var bv = new Bideo();
    bv.init({
        // Video element
        videoEl: document.querySelector('#background_video'),

        // Container element
        container: document.querySelector('body'),

        // Resize
        resize: true,

        // autoplay: false,

        

        // Array of objects containing the src and type
        // of different video formats to add
        src: [
            {
                src: '/lib/bideo/night.mp4',
                type: 'video/mp4'
            }
           
        ],

        // What to do once video loads (initial frame)
        onLoad: function () {
            document.querySelector('#video_cover').style.display = 'none';
        }
    });
}());


