renderUsers();

async function renderUsers() {
    let tableBody = document.getElementById('tableBody');
    let users = await getUsers();

    for (const user of users) {
        let newRow = document.createElement('tr');
        let nameCell = document.createElement('td');
        let birthDateCell = document.createElement('td');
        let companyCell = document.createElement('td');
        let actionsCell = document.createElement('td');

        nameCell.textContent = `${user.name} ${user.surname}`;
        birthDateCell.textContent = user.birthDate;
        companyCell.textContent = user.company;
        actionsCell.textContent = 'edit delete';

        newRow.appendChild(nameCell);
        newRow.appendChild(birthDateCell);
        newRow.appendChild(companyCell);
        newRow.appendChild(actionsCell);

        tableBody.appendChild(newRow);
    }
}

async function getUsers() {
    let usersApiAddress = 'https://localhost:5001/api/users';    
    
    return await fetch(usersApiAddress)
    .then(response => response.text())
    .then(text => JSON.parse(text));
}