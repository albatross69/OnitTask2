using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnitTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.	Каким способом можно оптимизировать следующий код
            string a = "";
            for (int i = 0; i < 1000000; i++)
            {
                a += "a";
            }
            */
            // Можно обеспечить параллельное выполнение итераций цикла, используя следующий код
            string a = "";
            Parallel.For(0, 1000000, index => { a += "a"; });
            Console.Write(a);

        }

        //2.	Какой из двух методов является неправильным и почему:
        private void Method1(ref List<int> listDigits)
        {
            listDigits.Add(55);
        }
        private void Method2(ref int digit)
        {
            digit += 55;
        }
        /*
            С синтаксической точки зрения – оба метода являются правильными, а с логической 
            ошибки  не вижу, так как первому методу мы передаем оригинальную ссылку на объект, а 
            не ее копию, благодаря модификатору ref. Во втором мы передаем ссылку на участок 
            памяти, в которой хранится переменная.
        */
    }
}
