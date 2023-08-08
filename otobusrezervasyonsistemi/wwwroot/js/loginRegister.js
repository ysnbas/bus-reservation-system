function loginPage() {
    document.getElementById("registerPage").classList.remove("active");
    document.getElementById("loginPage").classList.add("active");

    document.getElementById("registerForm").style.display = "none"
    document.getElementById("loginForm").style.display="flex"
}
function registerPage() {
    document.getElementById("loginPage").classList.remove("active");
    document.getElementById("registerPage").classList.add("active");


    document.getElementById("loginForm").style.display = "none"
    document.getElementById("registerForm").style.display = "flex"
}

var modal = document.getElementById("modalContainer");
modal.style.display = "block";

document.getElementById('closeModalBtn').addEventListener('click', function () {
    document.getElementById('modalContainer').style.display = 'none';
});

window.addEventListener('click', function (event) {
    var modal = document.getElementById('modalContainer');
    if (event.target === modal) {
        modal.style.display = 'none';
    }
});