using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_opyat
{
    public class Class1
    {
        public double first = 0;
        public double second = 0;
        public string oper;
        public double answ = 0;

        public void Start()
        {
            Console.Write("Первое число: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Действие(+, -, /, *, ^): ");
            oper = Convert.ToString(Console.ReadLine());
            Console.Write("Второе число: ");
            second = Convert.ToDouble(Console.ReadLine());
        }
        public void aboba()
        {
            switch (oper)
            {
                case "+":
                    sum();
                    break;
                case "-":
                    min();
                    break;
                case "*":
                    umn();
                    break;
                case "/":
                    del();
                    break;
                case "^":
                    step();
                    break;
            }
            if (oper != "+" && oper != "-" && oper != "/" && oper != "*" && oper != "^"){
                Console.Write("Действие введено не верно, введите заново: ");
                oper = Convert.ToString(Console.ReadLine());
                aboba();
            }
        }
        public void sum()
        {
            answ = first + second;
            Console.WriteLine("Ответ: " + answ);
        }
        public void min()
        {
            answ = first - second;
            Console.WriteLine("Ответ: " + answ);
        }
        public void umn()
        {
            answ = first * second;
            Console.WriteLine("Ответ: " + answ);
        }
        public void del()
        {
            answ = first / second;
            Console.WriteLine("Ответ: " + answ);
        }
        public void step()
        {
            answ = Math.Pow(first, second);
            Console.WriteLine("Ответ: " + answ);
        }
    }
}
