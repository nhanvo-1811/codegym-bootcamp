        let n;
        function fibo(n)
        {   
            
            if(n<0)
            {
                return -1;
            }else if(n==0||n==1)
            {
                return n;
            } else 
            {
                n=fibo(n-1) + fibo(n-2);
                return n;
            }
        }