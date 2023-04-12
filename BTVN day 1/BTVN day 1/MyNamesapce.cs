using System;
using System.IO;
using static  System.Console;
using MyNameSpaceChild;            


namespace MyNameSpace
{
    public class MyNamesapce
    {
        public static void Main(string[] args)
        {
            Test1 t1 = new Test1();     //khai báo t1 là tên biến mới như string name = ...
            t1.Hello();                 //gọi biến: tên biến.hàm. Biến cho ra màn hình câu lệnh như bên Test1

            Test2 t2 = new Test2();
            t2.Hello();
            //WriteLine("Hello, I am Jesus Christ!");
        }
    }
}
