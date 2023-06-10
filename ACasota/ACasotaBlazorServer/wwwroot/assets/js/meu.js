
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