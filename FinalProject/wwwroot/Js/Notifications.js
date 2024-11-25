


function ShowToastr(type, message) {
    if (type == "success") {
        toastr.success(message);
    }
    if (type == "error") {
        toastr.error(message);
    }
    if (type == "warning") {
        toastr.warning(message);
    }
    if (type == "info") {
        toastr.info(message);
    }
};

function showSweetAlert(type, message) {
    if (type == "success") {
        Swal.fire({
            position: "center",
            icon: "success",
            title: message,
            showConfirmButton: false,
            timer: 1500
        });
    }
    if (type == "error") {
        Swal.fire({
            icon: "error",
            title: "Oops...",
            text: message
        });
    }
};