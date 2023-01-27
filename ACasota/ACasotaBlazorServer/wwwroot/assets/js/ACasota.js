var language = 'pt';

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
}

var checkDate = function () {
	var date = String(document.getElementById('birthday_pt').value);

	if (document.getElementById('birthday_pt').hidden) {
		date = String(document.getElementById('birthday_en').value);
	}

	if (date != "" && moment(date, "DD/MM/YYYY", true).isValid()) {
		document.getElementById('birthday_pt').classList.remove('is-invalid');
		document.getElementById('birthday_pt').classList.add('is-valid');
		document.getElementById('birthday_en').classList.remove('is-invalid');
		document.getElementById('birthday_en').classList.add('is-valid');

	} else {
		document.getElementById('birthday_pt').classList.remove('is-valid');
		document.getElementById('birthday_pt').classList.add('is-invalid');
		document.getElementById('birthdays_en').classList.remove('is-valid');
		document.getElementById('birthdays_en').classList.add('is-invalid');

	}
}

var checkEmail = function () {
	var email = String(document.getElementById('email').value);
	var validRegex = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;

	if (validRegex.test(email)) {
		document.getElementById('email').classList.remove('is-invalid');
		document.getElementById('email').classList.add('is-valid');

	} else {
		document.getElementById('email').classList.remove('is-valid');
		document.getElementById('email').classList.add('is-invalid');
	}
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
}

var checkConfPassword = function () {
	if (document.getElementById('password').value == document.getElementById('confirm_password').value) {
		document.getElementById('confirm_password').classList.remove('is-invalid');
		document.getElementById('confirm_password').classList.add('is-valid');

	} else {
		document.getElementById('confirm_password').classList.remove('is-valid');
		document.getElementById('confirm_password').classList.add('is-invalid');

	}
}

var checkButton = function () {
	var datepickerActivated = 'birthday_pt';

	if (document.getElementById('birthday_pt').hidden) {
		datepickerActivated = 'birthday_en';
	}

	if (document.getElementById('firstname').classList.contains('is-valid') &&
		document.getElementById('lastname').classList.contains('is-valid') &&
		document.getElementById(datepickerActivated).classList.contains('is-valid') &&
		document.getElementById('email').classList.contains('is-valid') &&
		document.getElementById('password').classList.contains('is-valid') &&
		document.getElementById('confirm_password').classList.contains('is-valid') &&
		document.getElementById('terms').checked) {

		document.getElementById('formButton').disabled = false;

	} else {
		document.getElementById('formButton').disabled = true;
	}
}	


var changeFormLanguage = function () {
	if (language = 'pt') {
		document.getElementById('birthday_pt').required = false;
		document.getElementById('birthday_pt').hidden = true;
		document.getElementById('birthday_en').required = true;
		document.getElementById('birthday_en').hidden = false;

		language = 'en';
	} else {
		document.getElementById('birthday_pt').required = true;
		document.getElementById('birthday_pt').hidden = false;
		document.getElementById('birthday_en').required = true;
		document.getElementById('birthday_en').hidden = false;

		language = 'pt';
	}
}
