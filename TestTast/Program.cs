void PrintArrayMethod(string[] array, int filtrElementsCount)
{
    int counterFiltr = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= filtrElementsCount)
        {
            counterFiltr++;
            
            if(array.Length == 1 && counterFiltr == 1)
            {
                Console.Write("[\"" + array[i] + "\"]");
            }
            else if(i == 0 && array.Length != 1 || array.Length != 1 && counterFiltr == 1)
            {
                Console.Write("[\"" + array[i] + "\"");
            }
            else if(i == (array.Length - 1))
            {
                Console.Write(",\"" + array[i] + "\"]");
            }
            else
            {
                Console.Write(",\"" + array[i] + "\"");
            }
        }
    }

    if(counterFiltr == 1) Console.Write("]");
    if(array.Length == 0 || counterFiltr == 0) Console.Write("[]");
    Console.WriteLine();
}

int filtrElements = 3;

string[] array1 = { "hello", "2", "world", ":-)"};
string[] array2 = { "1234", "1567", "-2", "Computer science"};
string[] array3 = { "Russia", "Denmark", "Kazan" };

PrintArrayMethod(array1,filtrElements);
PrintArrayMethod(array2,filtrElements);
PrintArrayMethod(array3,filtrElements);