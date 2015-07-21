var marked;
var boxes;
var winningCombinations;
var turn = 0;
var currentBox;
var c;
var context;
var squaresFilled = 0;
var w;
var y;

window.onload = function () {

    marked = new Array();
    boxes = new Array();
    winningCombinations = [[0, 1, 2], [3, 4, 5], [6, 7, 8], [0, 3, 6], [1, 4, 7], [2, 5, 8], [0, 4, 8], [2, 4, 6]];
    for (var l = 0; l <= 8; l++) {
        marked[l] = false;
        boxes[l] = '';
    }
}

function boxClicked(boxNumber) {

    currentBox = document.getElementById("box" + boxNumber);
    context = currentBox.getContext("2d");
    if (marked[boxNumber - 1] == false) {
        if (turn % 2 == 0) {
            context.beginPath();
            context.moveTo(10, 10);
            context.lineTo(40, 40);
            context.moveTo(40, 10);
            context.lineTo(10, 40);
            context.stroke();
            context.closePath();
            boxes[boxNumber - 1] = 'X';
        }

        else {
            context.beginPath();
            context.arc(25, 25, 20, 0, Math.PI * 2, true);
            context.stroke();
            context.closePath();
            boxes[boxNumber - 1] = 'O';
        }

        turn++;
        marked[boxNumber - 1] = true;
        squaresFilled++;
        checkForWinners(boxes[boxNumber - 1]);

        if (squaresFilled == 9) {
            alert("DRAW!");
            location.reload(true);
        }

    }
    else {
        alert("BOX ALREADY OCCUPIED ");
    }

}
function checkForWinners(symbol) {

    for (var i = 0; i < winningCombinations.length; i++) {
        if (boxes[winningCombinations[i][0]] == symbol && boxes[winningCombinations[i][1]] == symbol && boxes[winningCombinations[i][2]] == symbol) {
            alert(symbol + " WON!");
            restartGame();
        }
    }
}
function restartGame() {
    y = confirm("PLAY AGAIN?");
    if (y == true) {
        location.reload(true);
    }
}