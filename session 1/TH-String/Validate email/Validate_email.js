function validate_Email(str)
{
    path = /^[A-Za-z0-9]+[A-Za-z0-9]*@[A-Za-z0-9]+(\.[A-Za-z0-9]+)$/;
    if(path.test(str))
    {
        return true;
    }else
    {
        return false;
    }
   
}