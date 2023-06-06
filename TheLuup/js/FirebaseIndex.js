firebase.auth().onAuthStateChanged(function (user) {

    if (user) {
        // user is signed in.

        document.getElementById('email_id').style.display = "block";
        document.getElementById('password_id').style.display = "none";

    } else {
        //No user is signed in.
        document.getElementById('email_id').style.display = "none";
        document.getElementById('password_id').style.display = "block";
    }
});

function login() {

    var userEmail = document.getElementById('email_id').value;
    var userPass = document.getElementById('password_id').value;

    firebase.auth().signInWithEmailAndPassword(userEmail, userPass)
        .then((user) => {
            // Signed in 
            // ...
        })
        .catch((error) => {
            var errorCode = error.code;
            var errorMessage = error.message;

            window.alert("Error : " + errorMessage);
        });
}