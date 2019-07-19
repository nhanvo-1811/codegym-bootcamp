function racetrack(ctx)
{
    this.show = function(ctx)
    { 
        let image = new Image();
        image.src = 'racetrack.jpg';
        image.onload = function()
        {
            ctx.drawImage(image , 0 , 0 , 500, 800);
        };
    }
}


function Car()
{   
    this.xPosition =  250;
    this.yPosition = 700;
    this.orientation = "up";
    this.speed = 20;
    this.step = 1;
    
    this.show = function(ctx)
    {  
        let xPosition = this.xPosition;
        let image = new Image();
        image.src = 'xe.png';
        image.onload = function()
        {
            ctx.drawImage(image , xPosition , 700 , 40, 100);
        };
    };
}

function Game(){
    this.car = new Car();
    this.racetrack = new racetrack();
    this.ctx = undefined;
    this.Start = function(){
        this.ctx = document.getElementById('myCanvas').getContext('2d');
        this.ctx.clearRect(0, 0, 500, 800);
        this.racetrack.show(this.ctx);
        this.car.show(this.ctx);
        
        this.moveCar(event);
    };
    this.moveCar = function(event){
        switch (event)
        {
            case 39: //right
            {
                this.car.xPosition += this.car.speed;
                this.car.xPosition = this.car.xPosition >= 460 ? 460 : this.car.xPosition;
                break;
            }
            case 37: //left
            {
                this.car.xPosition -= this.car.speed;
                this.car.xPosition = this.car.xPosition<= 0 ? 0 : this.car.xPosition;
                break;
            }   
        };
    };
}
let game = new Game();
setInterval(game.Start(),50);
