// creating a showtoastr and using window. to make it globally available
// passing 2 parameters: type of notification and the message
window.ShowToastr = (type, message) => {
    if (type === "success") {
        // using the default options from the toastr guide
        toastr.success(message, "Operation Successful", { timeOut: 5000 });
    }
    if (type === "error") {
        // using the default options from the toastr guide
        toastr.error(message, "Operation Failed", { timeOut: 5000 });
    }
}

window.ShowSwal = (type, message) => {
    if (type === "success") {
        Swal.fire(
            'Success Notification!',
            message,
            'success'
        )
    }
    if (type === "error") {
        Swal.fire(
            'Error Notification!',
            message,
            'error'
        )
    }
}