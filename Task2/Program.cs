namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();

            while (true) {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Find a number");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("Q - Quit");
                Console.Write("Enter your choice: ");

                char name = Convert.ToChar(Console.ReadLine());

                if (name == 'P' || name == 'p')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("[] - the list is empty");
                    }
                    else
                    {
                        Console.Write("[ ");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                        Console.WriteLine("]");
                    }

                }
                else if (name == 'A' || name == 'a')
                {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    numbers.Add(num);
                    Console.WriteLine(num + " added");
                }
                else if (name == 'M' || name == 'm')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("no data");
                    }
                    else
                    {
                        int sum = 0;
                        for (int y = 0; y < numbers.Count; y++)
                        {
                            sum = sum + numbers[y];
                        }
                        Console.WriteLine("The mean is " + sum / numbers.Count);
                    }
                }
                else if (name == 'S' || name == 's')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("list is empty");
                    }
                    else
                    {
                        int smallest = numbers[0];
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < smallest)
                            {
                                smallest = numbers[i];
                            }
                        }
                        Console.WriteLine("The smallest number is " + smallest);
                    }
                }
                else if (name == 'L' || name == 'l')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the largest number - list is empty");
                    }
                    else
                    {
                        int largest = numbers[0];
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > largest)
                            {
                                largest = numbers[i];
                            }
                        }
                        Console.WriteLine("The largest number is " + largest);
                    }
                }
                else if (name == 'F' || name == 'f')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("list is empty");
                    }
                    else
                    {
                        Console.Write("Enter a number to find: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        bool found = false;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == num)
                            {
                                Console.WriteLine(num + " found at index " + i);
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                            Console.WriteLine(num + " not found");
                    }
                }
                else if (name == 'C' || name == 'c')
                {
                    numbers.Clear();
                    Console.WriteLine("List cleared");
                }
                else if (name == 'Q' || name == 'q')
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                else
                {
                    Console.WriteLine("Unknown selection, please try again");
                }
            }
        }
    }
}
