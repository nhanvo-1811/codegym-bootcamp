function validate_Email(str)
{
    path = /^[_a-z0-9]{6}/;
    //kiểm tra nhập vào có nằm trong a-z,0-9 và xuất hiện từ kí tự thứ 6 trở đi. 
    if(path.test(str))
    {
        return true;
    }else
    {
        return false;
    }
   
}