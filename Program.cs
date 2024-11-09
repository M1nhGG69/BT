using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("123456","10000");
            Console.WriteLine(account);
            Console.WriteLine("Thong tin tai khoan sau khi cap nhat");
            account.Money = "800000";
            Console.WriteLine(account);
            Console.ReadLine(); 
        }
    }
}
