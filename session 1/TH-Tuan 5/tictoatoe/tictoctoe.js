let board = [];
function ready(){
    let b = document.getElementById("carogame");
    let data = "";
    for (let i = 0; i < 15; i++) {
        board[i] = new Array("*", "*", "*", "*", "*","*","*","*","*","*","*","*","*","*","*",);
    }
    for (let i = 0; i < 15; i++) {
        data += "&emsp;";
        for (let j = 0; j < 15; j++) {
            data += board[i][j] + "&emsp;";
        }
        data += "<br/>";
    }
    b.innerHTML = data;
    document.getElementById("player1").onclick = function () {
        let positionX = prompt("X: ");
        let positionY = prompt("Y: ");
        data = "";
        if (board[positionX][positionY] === "x" || board[positionX][positionY] === "o"){
            alert("Ô đó đã được đánh!");
        } else board[positionX][positionY] = "x";
        for (let i = 0; i < 15; i++) {
            data += "&emsp;";
            for (let j = 0; j < 15; j++) {
                data += board[i][j] + "&emsp;";
            }
            data += "<br/>";
        }
        b.innerHTML = data;
        test();
    }
    document.getElementById("player2").onclick = function () {
        let positionX = prompt("X: ");
        let positionY = prompt("Y: ");
        data = "";
        if (board[positionX][positionY] === "x" || board[positionX][positionY] === "o"){
            alert("Ô đó đã được đánh!");
        } else board[positionX][positionY] = "o";
        for (let i = 0; i < 15; i++) {
            data += "&emsp;";
            for (let j = 0; j < 15; j++) {
                data += board[i][j] + "&emsp;";
            }
            data += "<br/>";
        }
        b.innerHTML = data;
        test();
    }
}

function test(){
    for (let i = 0; i < 15; i++){
        for (let j = 0; j < 15; j++){
            if (board[i][j] === "x"){
                if (board[i+1][j+1] === "x" && board[i+2][j+2] === "x" && board[i+3][j+3] === "x" && board[i+4][j+4] === "x"){
                    alert("Người chơi 1 đã chiến thắng");
                    break;
                }
                if (board[i][j+1] === "x" && board[i][j+2] === "x" && board[i][j+3] === "x" && board[i][j+4] === "x"){
                    alert("Người chơi 1 đã chiến thắng");
                    break;
                }
                if (board[i+1][j] === "x" && board[i+2][j] === "x" && board[i+3][j] === "x" && board[i+4][j] === "x"){
                    alert("Người chơi 1 đã chiến thắng");
                    break;
                }                
            }
            if (board[i][j] === "o"){
                if (board[i+1][j+1] === "o" && board[i+2][j+2] === "o" && board[i+3][j+3] === "o" && board[i+4][j+4] === "x"){
                    alert("Người chơi 2 đã chiến thắng");
                    break;
                }
                if (board[i][j+1] === "o" && board[i][j+2] === "o" && board[i][j+3] === "o" && board[i][j+4] === "x"){
                    alert("Người chơi 2 đã chiến thắng");
                    break;
                }
                if (board[i+1][j] === "o" && board[i+2][j] === "o" && board[i+3][j] === "o" && board[i+4][j] === "x"){
                    alert("Người chơi 2 đã chiến thắng");
                    break;
                }
            } 
        }
    }
}
