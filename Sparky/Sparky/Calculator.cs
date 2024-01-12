namespace Sparky
{
    public class Calculator
    {
        List<int> numberRange = new List<int>();
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public bool IsOddNumber(int a)
        {
            return (a % 2 != 0);
        }

        public List<int> OddRange(int min, int max){
            numberRange.Clear();
            for(int i = min; i <= max; i++)
            {
                if (i%2 != 0)
                {
                    numberRange.Add(i);
                }
            }
            return numberRange;
        }
    }
}