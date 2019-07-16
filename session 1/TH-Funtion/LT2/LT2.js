//BT1
function square()
{   let num =document.getElementById("num").value;
    document.getElementById("result").innerHTML= "Bình phưởng của " + num + " là: "+Math.pow(num,2);;
}
//BT2
function acreage()
{
    let num =document.getElementById("num").value;
    document.getElementById("result").innerHTML= "Diện tích của hình tròn " + (Math.pow(num,2)*3.14);
}

function perimeter()
{
    let num =document.getElementById("num").value;
    document.getElementById("result").innerHTML= "Chu vi của hình tròn "+ (num*2*3.14);
}
//BT3
function factorial()
{   let f=1;
    let num =document.getElementById("num").value;
    for(let i=1; i<=num;i++)
    f*=i;
    document.getElementById("result").innerHTML= "Giai thừa của " +num+ ": "+ f;
}
//BT4
function checkNum()
{
    let num = prompt("Nhập ký tự kiểm tra");
    !isNaN(num) ? alert(true)
        : alert(false)
}
//BT5
function Min(num1,num2,num3)
{  
    let min=num1;
    if(min>num2)
        {
            min=num2;
        }    
    if(min>num3)
    {
        min=num3        
    }
    return min;
}
//BT6
function checkNumpositive()
{
    let num = prompt("Nhập ký tự kiểm tra");
   
    !isNaN(num) ? 
            num>0 ?
                alert(true)
                :alert(false)
    :alert("Bạn nhập vào không phải là số")
    // if(!isNaN(num))
    //     {
    //         if(num>0)
    //         { 
    //         alert(true)
    //         }
    //         else 
    //             alert(false)
    //     }   
    //     else 
    //         alert("Bạn nhập vào không phải là số")
    
}
//BT7
function swap(a,b)
{
   return [a,b]=[b,a];
}
//BT8
function reverse(Arr)
{
    let leng = Arr.length;
    for(let i=0 ; i<leng; i++)
    {   
        let t=Arr[i];
        Arr[i]=Arr[leng - 1];
        Arr[leng - 1]=t;
        leng--;
        console.log(Arr)
    }
    return Arr;
}
//BT9

function checkstring(Arr,c)
{    
    let  count = 0;
    for(let i=0; i< Arr.length ; i++)
    {
        if(Arr[i]===c)
        {
            count++;       
        }
    }
    if(count>0) 
    {
        return count;
    }
    else return -1;
}
