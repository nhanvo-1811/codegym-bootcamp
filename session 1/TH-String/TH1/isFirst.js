function isUpperCase(str)
{
    let path = /^[A-Z]/;
    if(path.test(str))
    {
        console.log("String's first character is uppercase");
    }else
    {
        console.log("String's first character is not uppercase");
    }
}