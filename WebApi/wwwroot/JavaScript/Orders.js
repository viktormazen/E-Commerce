let getAllOrdersBtn = document.getElementById("btnAllOrders");

let getOrderByIdBtn = document.getElementById("btnById");


let getById = function () { getOrderById(document.getElementById("inputById").value) };


getAllOrdersBtn.addEventListener("click", getAllOrders);
getOrderByIdBtn.addEventListener("click", getById);