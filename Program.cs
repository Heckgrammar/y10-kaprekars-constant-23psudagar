namespace Y10_Challenge_Kaprikars_Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kaprekar's Constant is 6174
            //1. take a 4 digit start number using at least two different digits...e.g. 9218
            //2. order the digits descending 4321, then ascending to get two 4 digit numbers (add leading zeros if needed)
            //3. subtract smaller number from bigger number e.g. 9821-1289=8532
            //4. Go back to step 2 replacing start number with result of step 3, repeat until numbers converge to 6174

            //Task: Write a program to compute Kaprekar's constant using any four digit start number
            //Ext: Display the number of iterations needed until 6174 is reached

            Console.WriteLine("Hello, Type a four digit number:"); //starter code for students 
            int x = Convert.ToInt32(Console.ReadLine()); //starter for students
            //YOUR CODE GOES HERE...TEST


        }
    }
}
