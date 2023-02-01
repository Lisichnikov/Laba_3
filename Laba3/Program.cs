namespace лаба3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 10000, max = 0;
            Random rnd = new Random();
            int[] array = new int[1000];
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(1, 10000);
            for (int i = 0; i < array.Length; i++)


            {

                if (array[i] < min && array[i] % 37 == 0)
                    min = array[i];
                if (array[i] > max && array[i] % 73 == 0)
                    max = array[i];
            }

            int parCount = 0;
            int buffIndex = 0;
            int minSumma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int digit = array[i];
                if (min > max)
                {
                    if (digit < min && digit > max)
                    {
                        buffIndex = i;
                        continue;
                    }
                }
                else
                {
                    if (digit > min && digit < max)
                    {
                        buffIndex = i;
                        continue;
                    }
                }
                if (buffIndex == i - 1  buffIndex == i + 1)
                {
                parCount++;
                if (minSumma == 0  minSumma > digit + array[buffIndex])
                    {
                    minSumma = digit + array[buffIndex];
                }
                Console.WriteLine(parCount);
        Console.WriteLine(minSumma);
            }
        }

    }
}
