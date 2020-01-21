let port = "49731";
let Url = "http://localhost:" + port + "/api/order"

let getAllOrders = async () => {
    let url = Url + "/GetAll";

    let response = await fetch(url);
    let data = await response.json();
    console.log(data);

    let col = [];
    for (let i = 0; i < data.length; i++) {
        for (let key in data[i]) {
            if (col.indexOf(key) === -1) {
                col.push(key);
            }
        }
    }

    let table = document.createElement("table");

    let tr = table.insertRow(-1);

    for (let i = 0; i < col.length; i++) {
        let th = document.createElement("th");
        th.innerHTML = col[i];
        tr.appendChild(th);
    }

    for (let i = 0; i < data.length; i++) {

        tr = table.insertRow(-1);

        for (let j = 0; j < col.length; j++) {
            let tabCell = tr.insertCell(-1);
            tabCell.innerHTML = data[i][col[j]];
        }
    }

    let divContainer = document.getElementById("showData");
    divContainer.innerHTML = "";
    divContainer.appendChild(table);
}

let getOrderById = async (id) => {
    let url = Url + "/GetById?id=" + id;

    let response = await fetch(url, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        }
    });

    let data = await response.json();

    let divContainer = document.getElementById("showDataById");
    divContainer.innerHTML = `Id: ${data.id}; Date created: ${data.dateCreated}; Product description: 
    ${data.productDescription}; Delivery status: ${data.deliveryStatus}; Delivery date: ${data.deliveryDate};
    isDeleted: ${data.isDeleted};`;
    console.log(data);
}
