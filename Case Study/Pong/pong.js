class Vecto
{
    constructor(x=0, y=0)
    {
        this.x = x;
        this.y = y;
    }
    get len()
    {   
        //tính cạnh huyền 
        return Math.sqrt(this.x * this.x + this.y * this.y)
    }
    set len (value)
    {
        let fact = value / this.len;
        this.x  *= fact;
        this.y  *= fact;
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
        super(12, 12);
        this.vel = new Vecto;
    }
}

class Player extends Rect
{
    constructor()
    {
        super(15,100);
        this.score = 0;
    }
}

class Pong
{
    constructor(canvas)
    {
        this.canvas = canvas;
        this.context = canvas.getContext("2d");
        
        this.ball = new Ball;

        this.players =
        [
            new Player,
            new Player,
        ];
        
        this.players[0].postion.x = 40;  
        this.players[1].postion.x = this.canvas.width - 40
        this.players.forEach(player =>
        {
            player.postion.y = this.canvas.height/2;
        });  
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
        
        this.reset();

    }
    
    //Va chạm
    collide(player,ball)
    {   
        
        if(player.left < ball.right && player.right > ball.left
            && player.top < ball.bottom && player.bottom > ball.top)
        {   
            ball.vel.x =- ball.vel.x;// bóng dội trả về theo hướng x
            ball.postion.x = player.postion.x + (ball.vel.x < 0 ? (-(player.size.x / 2) - 
                        (ball.size.x / 2)) - 1 : player.size.x / 2 + (ball.size.x / 2));
            ball.vel.y += 300 * (Math.random()- 0.5)
            ball.vel.len *= 1.05; // tăng tốc sau mỗi lần dội
        }
    }
    
    //vẽ nền
    draw()
    {
        this.context.fillStyle = "black";    
        this.context.fillRect(0, 0, this.canvas.width, this.canvas.height );       
        
        this.drawRect(this.ball);
        this.players.forEach(Player => this.drawRect2(Player))

        this.drawscore();

    }

    //Vẽ 2 player
    drawRect2(player)
    {
        this.context.fillStyle = "White";    
        this.context.fillRect(player.left, player.top,
                                player.size.x, player.size.y);    
                                // console.log(player.top) 
    }
    //Vẽ hình vuông bóng
    drawRect(rect)
    {
        this.context.fillStyle = "green";    
        this.context.fillRect(rect.postion.x, rect.postion.y,
                              rect.size.x, rect.size.y);   
                    
    }
    //Vẽ điêm số trên canvas
    drawscore()
    {   
        let align = this.canvas.width / 4;
        let align2 = this.canvas.height / 5;
    
        this.context.fillStyle = "#FFF";
        this.context.font = "75px fantasy";
        this.context.fillText(this.players[0].score, align, align2);
        this.context.fillText(this.players[1].score, 3*align, align2);
    }

    reset()
    {
        this.ball.postion.x = this.canvas.width/2;
        this.ball.postion.y = this.canvas.height/2;
        
        this.ball.vel.x = 0;
        this.ball.vel.y = 0;
    }

    start()
    {
        if(this.ball.vel.x === 0 && this.ball.vel.y === 0)
        {
            this.ball.vel.x = 300 * (Math.random() > 0.5 ? 1 : -1) ;
            this.ball.vel.y = 300 * (Math.random() * 2-1 );
            this.ball.vel.len = 200;
        }
    }

    update(dt) 
    {   
        //bóng đi theo đường x,y
        this.ball.postion.x +=this.ball.vel.x * dt;
        this.ball.postion.y += this.ball.vel.y * dt;

        //bóng va chạm tường
        if (this.ball.left < 0 || this.ball.right > this.canvas.width)
        {
            let playerId;
            if(this.ball.vel.x < 0)
            {
                playerId = 1;
            }else
            {
                playerId = 0;
            }
            this.players[playerId].score++;
            
            this.reset();   
        }
        //bóng va chạm trên dưới
        if (this.ball.top < 0 || this.ball.bottom > this.canvas.height)
        {
            this.ball.vel.y = -this.ball.vel.y;
        }
        //Com: players[1] di chuyển
        this.players[1].postion.y = this.ball.postion.y;

        //gọi hàm collide để xử lí va chạm
        this.players.forEach(player => this.collide(player,this.ball) );

        this.draw();

    }
}

let canvas = document.getElementById("pong");
let pong = new Pong(canvas);

//điều khiển players[0] bằng chuột
canvas.addEventListener('mousemove', event =>
{
    pong.players[0].postion.y = event.offsetY
});

//Play start
canvas.addEventListener('click', event =>
{
    pong.start();
});