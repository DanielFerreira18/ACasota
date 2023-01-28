containsNumber = (str) => /[0-9]/.test(str);

var checkFirstName = function () {
    var firstname = String(document.getElementById('firstname').value);

    if (firstname.length < 2 || containsNumber(firstname)) {
        document.getElementById('firstname').classList.remove('is-valid');
        document.getElementById('firstname').classList.add('is-invalid');

    } else {
        document.getElementById('firstname').classList.remove('is-invalid');
        document.getElementById('firstname').classList.add('is-valid');
    }

    checkButton();
}

var checkLastName = function () {
    var lastname = String(document.getElementById('lastname').value);

    if (lastname.length < 2 || containsNumber(lastname)) {
        document.getElementById('lastname').classList.remove('is-valid');
        document.getElementById('lastname').classList.add('is-invalid');

    } else {
        document.getElementById('lastname').classList.remove('is-invalid');
        document.getElementById('lastname').classList.add('is-valid');
    }

    checkButton();
}

var checkDate = function () {
    var date = String(document.getElementById('birthday_pt').value);

    if (date != "" && moment(date, "DD/MM/YYYY", true).isValid()) {
        document.getElementById('birthday_pt').classList.remove('is-invalid');
        document.getElementById('birthday_pt').classList.add('is-valid');

    } else {
        document.getElementById('birthday_pt').classList.remove('is-valid');
        document.getElementById('birthday_pt').classList.add('is-invalid');

    }

    checkButton();
}

var checkEmail = function () {
    var email = String(document.getElementById('email').value);
    var validRegex = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

    if (email.match(validRegex)) {
        document.getElementById('email').classList.remove('is-invalid');
        document.getElementById('email').classList.add('is-valid');

    } else {
        document.getElementById('email').classList.remove('is-valid');
        document.getElementById('email').classList.add('is-invalid');
    }

    checkButton();
}

var checkPassword = function () {
    var password = String(document.getElementById('password').value);

    if (password == "" || password.length < 5) {
        document.getElementById('password').classList.remove('is-valid');
        document.getElementById('password').classList.add('is-invalid');

    } else {
        document.getElementById('password').classList.remove('is-invalid');
        document.getElementById('password').classList.add('is-valid');
    }

    checkConfPassword();
    checkButton();
}

var checkConfPassword = function () {
    var confPass = String(document.getElementById('confirm_password').value);

    if (String(document.getElementById('password').value).length >= 5) {
        if (document.getElementById('password').value == confPass && confPass.length >= 5) {
            document.getElementById('confirm_password').classList.remove('is-invalid');
            document.getElementById('confirm_password').classList.add('is-valid');

        } else {
            document.getElementById('confirm_password').classList.remove('is-valid');
            document.getElementById('confirm_password').classList.add('is-invalid');

        }
    } else {
        document.getElementById('confirm_password').classList.remove('is-valid');
        document.getElementById('confirm_password').classList.remove('is-invalid');
    }

    checkButton();
}

var checkButton = function () {
    if (document.getElementById('firstname').classList.contains('is-valid') &&
        document.getElementById('lastname').classList.contains('is-valid') &&
        document.getElementById('birthday_pt').classList.contains('is-valid') &&
        document.getElementById('email').classList.contains('is-valid') &&
        document.getElementById('password').classList.contains('is-valid') &&
        document.getElementById('confirm_password').classList.contains('is-valid') &&
        document.getElementById('terms').checked) {

        document.getElementById('formButton').disabled = false;

    } else {
        document.getElementById('formButton').disabled = true;
    }
}
