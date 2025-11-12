using Workshop;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operators op = new Operators();
            op.Add(12, 5);
            op.Subtract(30, 15);
            op.Multiply(12, 4);
            op.Divide(12, 2);
            op.OddEvenFinder(7);
        }
    }
}
