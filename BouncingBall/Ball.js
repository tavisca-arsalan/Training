
window.ball = window.ball || {
     yDirection :false,
     xDirection : false,
     
     xPosition :20,
     yPosition : 20,
     
    
}

var increment = 5;

window.ball.changePosition=function() {

   
    document.getElementById('ball').style.top = window.ball.yPosition;
    document.getElementById('ball').style.left = window.ball.xPosition;
    
    window.ball.boundaryCondition();
    if (window.ball.xDirection) {
        window.ball.xPosition = window.ball.xPosition + increment;
        
    }
    else {
        window.ball.xPosition = window.ball.xPosition - increment;
        
    }
    
    if (window.ball.yDirection) {
        window.ball.yPosition = window.ball.yPosition + increment;
        
    }
    else {
        window.ball.yPosition = window.ball.yPosition - increment;
    }

    }
    
 
    

window.ball.start=function() {
    var interval = setInterval(ball.changePosition, 10);
}


