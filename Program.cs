// написать программу которая из имеющегося массива строк
//формирует массив из строк, длина которых меньше либо равна 3 символа.


// Печать результата
void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine();
}

// метод генерации и заполнения массива
string[] GenArray(string[] arr)
{
    string[] arr2 = new string[arr.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i].Length <= 3) 
        {
            arr2[count] = arr[i];
            count++;
        }
    }
    return arr2;
}



string[] array = {"hello", "2", "world", ":-)"};
PrintArr(array);
string[] newarray = GenArray(array);
PrintArr(newarray);



