document.getElementById('openModalBtn').addEventListener('click', function () {
    document.getElementById('modalContainer').style.display = 'block';
});

document.getElementById('closeModalBtn').addEventListener('click', function () {
    document.getElementById('modalContainer').style.display = 'none';
});

window.addEventListener('click', function (event) {
    var modal = document.getElementById('modalContainer');
    if (event.target === modal) {
        modal.style.display = 'none';
    }
});


// Armchair
const seats = Array(32).fill('empty');
const selectedData = [6, 7, 9, 11];
let userSelectedSeats = [];


function renderSeats() {
    const seatsContainer = document.querySelector('.seats-container');
    seatsContainer.innerHTML = '';

    for (let i = 0; i < seats.length; i++) {
        const seat = document.createElement('div');
        seat.classList.add('seat', seats[i]);
        seat.innerText = i + 1;

        if (selectedData.includes(i)) {
            seat.style.pointerEvents = 'none';
        } else {
            seat.addEventListener('click', () => toggleSeat(i));
        }

        seatsContainer.appendChild(seat);
    }

    const continueButton = document.getElementById('forDisabled');
    continueButton.disabled = userSelectedSeats.length === 0;
}

function toggleSeat(index) {
    if (seats[index] === 'empty') {
        seats[index] = 'taken';
        userSelectedSeats.push(index);
    } else if (seats[index] === 'taken') {
        seats[index] = 'empty';
        const selectedIndex = userSelectedSeats.indexOf(index);
        if (selectedIndex !== -1) {
            userSelectedSeats.splice(selectedIndex, 1);
        }
    }
    renderSeats();

}

window.onload = () => {
    selectedData.forEach((index) => {
        seats[index] = 'taken';
    });

    renderSeats();

    const continueButton = document.getElementById('forDisabled');
    continueButton.disabled = true;
};


function goRedirect() {
    window.location.href = '/Ticket/Index';
}