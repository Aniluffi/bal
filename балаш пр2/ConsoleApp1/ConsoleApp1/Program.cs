class Program 
{
    static void Main(string[] args)
    {
        int[] array = new int[] {3,4,6,8,9,10,11,23,54,60,70,80,90,100 };//отсортированый массив

        foreach (int el in array) // вывод отсортированого массива
        {
            Console.WriteLine(el);
        }

        Console.WriteLine();

        int search = Convert.ToInt32(Console.ReadLine());

        for (int i = 0;i < array.Length;i++)
        {
            if (array[i] == search)
            {
                Console.WriteLine("Yes");
                break;
            } else if (i == array.Length - 1)
            {
                Console.WriteLine("No");
            }
        }
        
    }

}