function DateTimePicker() {
    // Datepicker
    var datepickers = [].slice.call(d.querySelectorAll('[data-datepicker]'))
    var datepickersList = datepickers.map(function (el) {
        return new Datepicker(el, {
            buttonClass: 'btn',
            format: 'dd/mm/yyyy',
            language: 'pt',
            autohide: true
        });
    })
}

function GetDatesInitial() {
    return document.getElementById("datainicio").value;
}

function GetHoursInitial() {
    return document.getElementById("horainicio").value;
}

function GetDatesEnd() {
    return document.getElementById("datafim").value;
}

function GetHoursEnd() {
    return document.getElementById("horafim").value;
}