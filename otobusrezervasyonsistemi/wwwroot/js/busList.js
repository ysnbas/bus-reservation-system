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

const seats = Array(32).fill('empty');

function renderSeats() {
    const seatsContainer = document.querySelector('.seats-container');
    seatsContainer.innerHTML = '';

    for (let i = 0; i < seats.length; i++) {
        const seat = document.createElement('div');
        seat.classList.add('seat', seats[i]);
        seat.innerText = i + 1;
        seat.addEventListener('click', () => toggleSeat(i));
        seatsContainer.appendChild(seat);
    }
}

function toggleSeat(index) {
    if (seats[index] === 'empty') {
        seats[index] = 'taken';
    } else {
        seats[index] = 'empty';
    }
    renderSeats();
}

window.onload = () => {
    renderSeats();
};
