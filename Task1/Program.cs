int PromptQuantity()
{
    Console.Write("Введите количество чисел для ввода с клавиатуры: ");
    int numbersQuantity = int.Parse(Console.ReadLine());
    return numbersQuantity;
}

int[] FillArrayWithPromptedNumbers(int num)
{
    int[] promptedArray = new int[num]; 
    
    for (int i=0; i<num; i++)
    {
        Console.Write($"Введите целое число #{i+1}: ");
        promptedArray[i]=int.Parse(Console.ReadLine());
    }
    return promptedArray; 

}

int CheckNegativeNumbers(int[] arr) 
{   
    int count = 0; 
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]>0)
        count++; 
    }
    return count;
}

Console.WriteLine($"Количество введенных чисел больше 0 равно: {CheckNegativeNumbers(FillArrayWithPromptedNumbers(PromptQuantity()))}");