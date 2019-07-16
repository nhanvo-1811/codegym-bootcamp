//BT1
function alertMessage()
{
    alert("Xin Chào!!!");
}
//BT2
function increase(x)
{
    x+=1;
    return x;
}
//BT3
function check(a,b)
{
    if(a>b) 
    {
        alert("a lớn hơn be")
    }else return a+b;
    // a>b ? alert("a lớn hơn be")
    // :  return a+b
}
//BT4
function addNumbers() 
{
    firstNum = 4;
    secondNum = 8;
    result = firstNum + secondNum;
    return result;
}
//BT5
function find(A,c)
{
    for(let i=0; i<A.length;i++)
    {
        if(A[i]===c)
        {
            return i;
        } 
    }
    return -1;
}
