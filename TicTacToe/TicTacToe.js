var painted;
var content;
var winningCombinations;
var turn = 0;
var currentBox;
var c;
var context;
var squaresFilled = 0;
var w;
var y;


window.onload = function () {

    painted = new Array();
    content = new Array();
    winningCombinations = [[0, 1, 2], [3, 4, 5], [6, 7, 8], [0, 3, 6], [1, 4, 7], [2, 5, 8], [0, 4, 8], [2, 4, 6]];

    for (var l = 0; l <= 8; l++) {
        painted[l] = false;
        content[l] = '';
    }
}

//Game methods
function boxClicked(boxNumber) {
    currentBox = "box" + boxNumber;
    c = document.getElementById(currentBox);
    context = c.getContext("2d");

    if (painted[boxNumber - 1] == false) {
        if (turn % 2 == 0) {
            context.beginPath();
            context.moveTo(10, 10);
            context.lineTo(40, 40);
            context.moveTo(40, 10);
            context.lineTo(10, 40);
            context.stroke();
            context.closePath();
            content[boxNumber - 1] = 'X';
        }

        else {
            context.beginPath();
            context.arc(25, 25, 20, 0, Math.PI * 2, true);
            context.stroke();
            context.closePath();
            content[boxNumber - 1] = 'O';
        }

        turn++;
        painted[boxNumber - 1] = true;
        squaresFilled++;
        checkForWinners(content[boxNumber - 1]);

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
        if (content[winningCombinations[i][0]] == symbol && content[winningCombinations[i][1]] == symbol && content[winningCombinations[i][2]] == symbol) {
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