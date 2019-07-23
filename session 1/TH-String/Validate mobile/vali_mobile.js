function validate_Email(str)
{
    path = /^(84)\-([0-9]{10}$)/;
    
    if(path.test(str))
    {
        return true;
    }else
    {
        return false;
    }
   
}