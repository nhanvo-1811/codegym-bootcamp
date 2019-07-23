function vali_class(str)
{
    path = /^[C|A|P]+[0-9]{4}[G|H|I|K|L|M]$/
    if(path.test(str))
    {
        return true;
    }else
    {
        return false;
    }

}