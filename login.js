var objectLogins = [
    {
        user: "kuba",
        password: "kuba123"
    },
    {
        user: "jacek",
        password: "jacek123"
    }
]

function getInfo() {
    var user = document.getElementById("user").value;
    var password = document.getElementById("password").value;

    for (var i = 0; i < objectLogins.length; i++) {
        if (user == objectLogins[i].user
            && password == objectLogins[i].password){
                alert(user + " został zalogowany");
                console.log(user + " został zalogowany");
                return;
            }
    }
    alert("Nieprawidłowy login lub hasło");
    console.log("Nieprawidłowy login lub hasło");
}