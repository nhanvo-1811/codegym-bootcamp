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
function starZodiac()
{   let star = ["Polaris", "Aldebaran", "Deneb", "Vega", "Altair", "Dubhe", "Regulus"];
    let Zodiac = ["Ursa Minor", "Tarurus", "Cygnus", "Lyra", "Aquila", "Ursa Major", "Leo"]
    //let input = document.getElementById("input").value;
    let input = prompt("Nhập star");
    for(let i=0; i<star.length; i++)
    {
        for(let i=0; i<Zodiac.length; i++)
        {
            if(input==star[i])
            {
                document.getElementById("result").innerHTML=Zodiac[i];
                break;
            }else document.getElementById("result").innerHTML = "Không tìm thấy ngôi sao nào";
        }
    }

}
