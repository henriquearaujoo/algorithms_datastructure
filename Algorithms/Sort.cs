namespace Algorithms
{
    public class Sort
    {
        public int[] Execute(int[] unsortedArray)
        {
            var itemMoved = true;
            while (itemMoved)
            {
                itemMoved = false;
                for (int i = 0; i < unsortedArray.Length - 1; i++)
                {
                    if (unsortedArray[i] > unsortedArray[i + 1])
                    {
                        var lower = unsortedArray[i + 1];
                        unsortedArray[i + 1] = unsortedArray[i];
                        unsortedArray[i] = lower;
                        itemMoved = true;
                    }
                }
            }

            Console.WriteLine(string.Join(",", unsortedArray));

            return unsortedArray;
        }

        public int[] CreateArray(int length)
        {
            var array = new int[length];
            var random = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(-1000, 1000);
            }
            Console.WriteLine(string.Join(",", array));
            return array;
        }
    }
}
