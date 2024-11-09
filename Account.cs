using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1demo
{
    internal class Account
    {
        private string stk;
        private string money;

        public Account(string stk, string money)
        {
             this.Stk = stk;
            this.Money = money;
        }

        public string Stk { get => stk; set => stk = value; }
        public string Money { get => money; set => money = value; }

        public override string ToString()
        {
            return $"Mã số tài khoản: {stk} \nSố tiền: {money}";
        }

    }
}
