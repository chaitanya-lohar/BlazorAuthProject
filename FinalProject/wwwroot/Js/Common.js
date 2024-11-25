
var showConfirmation = () => {
    bootstrap.Modal.getOrCreateInstance(document.getElementById('exampleModal')).show();
};

var hideConfirmation = () => {
    bootstrap.Modal.getOrCreateInstance(document.getElementById('exampleModal')).hide();
}