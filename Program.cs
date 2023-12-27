void Final(string[] arr){
    int length = arr.Length;
    List<string> mass = new();
    for (int i = 0; i < length; i++) //цикл для переключения элементов массива строк
    {
        int len = arr[i].Length;
        int max = 3; //максимальная длинна элемента
        if (len<=max)
        {
            mass.Add(arr[i]);
        }
    }
    int lrange = mass.Count;
    string[] arr2 = new string[lrange];
    for (int i = 0; i < lrange; i++)
    {
        arr2[i] = mass[i];
        Console.WriteLine(arr2[i]);
    }
}
string[] example = {"a","ab","abc","abcd"};
Final(example);