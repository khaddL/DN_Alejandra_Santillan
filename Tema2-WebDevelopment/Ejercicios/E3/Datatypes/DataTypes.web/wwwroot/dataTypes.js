
var hoy = new Date();
var fecha = hoy.getDate() + '-' + (hoy.getMonth() + 1) + '-' + hoy.getFullYear();

var myArray = [
    {
        "name": "Fernando",
        "date": fecha,
       
    },
    {
        "name": "Rodolfo",
        "date": fecha,
    },
    {
        "name": "Alejandro",
        "date": fecha,
    },
    {
        "name": "Maria",
        "date": fecha,
    },
    {
        "name": "Rogelio",
        "date": fecha,

    },
    {
        "name": "Carmina",
        "date": fecha,
    },
    {
        "name": "Maria",
        "date": fecha,
    },
    {
        "name": "Cesar",
        "date": fecha,
    },
    {
        "name": "Nina",
        "date": fecha,
    },
    {
        "name": "Neska",
        "date": fecha,
    }]
var foo = myArray.map(function (bar) {
    return '<li>' + bar.name + ' ' + bar.date + '</li>';
})
document.getElementById("foo").innerHTML = foo;