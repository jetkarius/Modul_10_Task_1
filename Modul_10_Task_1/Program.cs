using System;

namespace Modul_10_Task_1
{
    public interface ICalculator
    {
        void Sum(int a, int b);
    }

    public class MyCalc : ICalculator
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("Ответ: {0} ", a + b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICalculator mycalc;
            try
            {
                Console.WriteLine("Значение 1: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Значение 2: ");
                int b = Convert.ToInt32(Console.ReadLine());

                mycalc = new MyCalc();
                mycalc.Sum(a, b);
            }
            catch (FormatException)
            {
                Console.WriteLine("Не корректное значение!");
            }
            finally
            {
                Console.WriteLine("Расчёт окончен");
            }
        }
    }
}
