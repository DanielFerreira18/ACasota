var button = true;

containsNumber = (str) => /[0-9]/.test(str);

var checkFirstName = function () {
	var firstname = String(document.getElementById('firstname').value);

	if (firstname.length < 2 || containsNumber(firstname)) {
		button = true;
		document.getElementById('firstname').classList.remove('is-valid');
		document.getElementById('firstname').classList.add('is-invalid');
	} else {
		button = false;
		document.getElementById('firstname').classList.remove('is-invalid');
		document.getElementById('firstname').classList.add('is-valid');
	}
}

var checkLastName = function () {
	var lastname = String(document.getElementById('lastname').value);

	if (lastname.length < 2 || containsNumber(lastname)) {
		button = true;
		document.getElementById('lastname').classList.remove('is-valid');
		document.getElementById('lastname').classList.add('is-invalid');
	} else {
		button = false;
		document.getElementById('lastname').classList.remove('is-invalid');
		document.getElementById('lastname').classList.add('is-valid');
	}
}

var checkDate = function () {
	if (!document.getElementById('birthday').hidden) {
		var date = String(document.getElementById('birthday').value);
	} else {
		var date = String(document.getElementById('birthdays').value);
	}

	if (date != "" || moment(date, "DD/MM/YYYY", true).isValid()) {
		button = false;
		document.getElementById('birthday').classList.remove('is-invalid');
		document.getElementById('birthday').classList.add('is-valid');
		document.getElementById('birthdays').classList.remove('is-invalid');
		document.getElementById('birthdays').classList.add('is-valid');
	} else {
		button = true;
		document.getElementById('birthday').classList.remove('is-valid');
		document.getElementById('birthday').classList.add('is-invalid');
		document.getElementById('birthdays').classList.remove('is-valid');
		document.getElementById('birthdays').classList.add('is-invalid');

	}
}

var checkEmail = function () {
	var email = String(document.getElementById('email').value);
	var validRegex = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
	alert(email.value.match(validRegex));

	if (email.value.match(validRegex)) {
		button = false;
		document.getElementById('email').classList.remove('is-invalid');
		document.getElementById('email').classList.add('is-valid');
	} else {
		button = true;
		document.getElementById('email').classList.remove('is-valid');
		document.getElementById('email').classList.add('is-invalid');
	}
}

var checkPassword = function () {
	var password = String(document.getElementById('password').value);

	if (password == "" || password.length < 5) {
		button = true;
		document.getElementById('password').classList.remove('is-valid');
		document.getElementById('password').classList.add('is-invalid');
	} else {
		button = false;
		document.getElementById('password').classList.remove('is-invalid');
		document.getElementById('password').classList.add('is-valid');
	}
}

var checkConfPassword = function () {
	if (document.getElementById('password').value ==
		document.getElementById('confirm_password').value &&
		document.getElementById('password').value != "") {
		button = false;
		document.getElementById('confirm_password').classList.remove('is-invalid');
		document.getElementById('confirm_password').classList.add('is-valid');
	} else {
		button = true;
		document.getElementById('confirm_password').classList.remove('is-valid');
		document.getElementById('confirm_password').classList.add('is-invalid');

	}
}

var checkButton = function () {
	document.getElementById('formButton').disabled = button;
}	


var changevalue = function () {
	document.getElementById('birthday').hidden = true;
	document.getElementById('birthdays').hidden = false;

	document.getElementById('birthday').required = false;
	document.getElementById('birthdays').required = true;
}
