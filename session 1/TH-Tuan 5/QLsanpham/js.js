function ready(){
    showProduct();
    document.getElementById("editProduct").onclick = function(){
        arrProduct[idEdit] = document.getElementById("valueEditProduct").value;
        showProduct();
    }
    document.getElementById("addProduct").onclick = function(){
        let valueAdd = document.getElementById("valueAddProduct").value;
        arrProduct[arrProduct.length] = valueAdd;
        showProduct();
    }
}

let arrProduct = ["Bút bi AA","Thước Thiên Long", "Máy tính Cầm tay Casio 570ES plus","Bút chì màu","Vở Hồng Hà"];

function showProduct(){
    let valueShow = "";
    for (let i in arrProduct){
        valueShow += "<tr onclick='popupValueEdit("+ i +")'><td style='width:50px'>" + i + "</td><td>"+ arrProduct[i] +"</td><td style='width:100px'><input type='button' class='btn btn-danger'  value='Delete' onclick='deleteProduct("+ i +")'></td></tr>";
    }
    document.getElementById("showProduct").innerHTML = valueShow;
}

function deleteProduct(id){
    arrProduct.splice(id,1);
    showProduct();
}
let idEdit;
function popupValueEdit(id){
    idEdit = id;
    document.getElementById("valueEditProduct").value = arrProduct[id];
}