class Vecto
{
    constructor(x=0, y=0)
    {
        this.x = x;
        this.y = y;
    }
}

class Rect
{
    constructor(width, height)
    {
        this.postion = new Vecto;
        this.size = new Vecto(width, height);
    }
    get left()
    {
        return this.postion.x - this.size.x /2;
    }
    get right()
    {
        return this.postion.x + this.size.x /2;
    }
    get top()
    {
        return this.postion.y - this.size.y /2;
    }
    get bottom()
    {
        return this.postion.y + this.size.y /2;
    }
}

class  Ball extends Rect
{
    constructor()
    {
        super(10, 10);
        this.vel = new Vecto;
    }
}

class Pong
{
    constructor(canvas)
    {
        this.canvas = canvas;
        this.context = canvas.getContext("2d");
        this.ball = new Ball;

        this.ball.postion.x = 100;
        this.ball.postion.y = 50;

        this.ball.vel.x = 100;
        this.ball.vel.y = 100;

        let LastTime;
        let callback = (millis) =>
        {
            if (LastTime)
            {
                this.update((millis - LastTime) / 1000);
            }
            LastTime = millis;
            requestAnimationFrame(callback);
        };
        callback();

    }
    update(dt) 
    {
        this.ball.postion.x +=this.ball.vel.x * dt;
        this.ball.postion.y += this.ball.vel.y * dt;

        if (this.ball.left < 0 || this.ball.right > this.canvas.width)
        {
            this.ball.vel.x = -this.ball.vel.x;
        }

        if (this.ball.top < 0 || this.ball.bottom > this.canvas.height)
        {
            this.ball.vel.y = -this.ball.vel.y;
        }
        this.context.fillStyle = "black";    
        this.context.fillRect(0, 0, this.canvas.width, this.canvas.height );                                                                   

        this.context.fillStyle = "green";    
        this.context.fillRect(this.ball.postion.x, this.ball.postion.y,
                              this.ball.size.x, this.ball.size.y);    
    }
}

let canvas = document.getElementById("pong");
let pong = new Pong(canvas);
