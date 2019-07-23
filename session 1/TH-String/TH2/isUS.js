function is_usCode (str)
{
    regexp = /^[0-9]{5}(?:-[0-9]{4})?$/;
    // kiểm tra xem 5 số đầu tiên có nằm trong khoảng từ 0-9 hay không, chuỗi tiếp theo có phải là -và 4 số tiếp hay không.
    if (regexp.test(str)) {
        return true;
    } 
    return false;
}