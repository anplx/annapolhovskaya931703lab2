using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2.Models
{
    public class MyModel
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public string act { get; set; }
       
        public Tuple<string, string> Actions(int? num1, string act, int? num2)
        {
            string answ = "";
            int? res = 0;
            var map = new Tuple<string, string>("","");
            switch (act)
            {
                case "add":
                    res = num1 + num2;
                    answ = res.ToString();
                    act = "+";
                    break;
                case "sub":
                    res = num1 - num2;
                    answ = res.ToString();
                    act = "-";
                    break;
                case "mult":
                    res = num1 * num2;
                    answ = res.ToString();
                    act = "*";
                    break;
                case "div":
                    if (num2 == 0)
                    {
                        answ = "Divide by zero!";
                        act = "/";
                        break;
                    }
                    else
                    {
                        res = num1 / num2;
                        answ = res.ToString();
                        act = "/";
                        break;
                    }
            }
            map = Tuple.Create(act, answ);
            return map;
        }
    }
}
