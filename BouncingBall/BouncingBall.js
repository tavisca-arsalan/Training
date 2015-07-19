var yDirection = false;
var xDirection = false;
var interval;
var xPosition = 20;
var yPosition = 20;
var increment = 5;
var height = 0;
var width = 0;


function changePosition() {

    height = window.innerHeight-200;
    width = window.innerWidth-200;
    document.getElementById('ball').style.top = yPosition;
    document.getElementById('ball').style.left = xPosition;
    
    //increment X coordinate
    if (xDirection) {
        xPosition = xPosition + increment;
    }
    else {
        xPosition = xPosition - increment;
    }
    if (xPosition < 0) {
        xDirection = true;
        xPosition = 0;
    }
    if (xPosition >= (width)) {
        xDirection = false;
        xPosition = (width);
    }

    // Increment Y coordinate
    if (yDirection)
        yPosition = yPosition + increment;
    else
        yPosition = yPosition - increment;
    if (yPosition < 0) {
        yDirection = true;
        yPosition = 0;
    }
    if (yPosition >= height) {
        yDirection = false;
        yPosition = height;
    }
    
 
    
}
function start() {
    interval = setInterval('changePosition()', 10);
}

window.onload=start();
