window.ball = window.ball || {}



window.ball.boundaryCondition = function () {

    var height = window.innerHeight - 200;
    var width = window.innerWidth - 200;
    if (window.ball.xPosition < 0) {
        window.ball.xDirection = true;
        window.ball.xPosition = 0;
    }
    if  (window.ball.xPosition >= (width)) {
        window.ball.xDirection = false;
        window.ball.xPosition = (width);
    }


    if (window.ball.yPosition < 0) {
        window.ball.yDirection = true;
        window.ball.yPosition = 0;
    }
    if (window.ball.yPosition >= height) {
        window.ball.yDirection = false;
        window.ball.yPosition = height;
    }
}

//window.ball.monitor=function() {
//    var interval = setInterval('window.ball.boundaryCondition()', 10);
//}

//window.onload = window.ball.monitor();