// Задача 4*(не обязательная):
//Задайте строку, состоящую из слов,
//разделенных пробелами. Сформировать строку,
//в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.
string str = "Для реализации автозапуска в Linux написано уже"+
            " немало и на разных языках но приходится искать"+
            " потому постарался свести большую часть тут";
Console.WriteLine(str);
string ReversString(string str)
{
    string[] arr = str.Split(" ");
    string result = String.Join(" ", arr.Reverse());
    return result;
}
string revStr = ReversString(str);
Console.WriteLine(revStr);
//Вариант 2
string ReversString02(string str)
{
    //int spaceCount = str.Count();
    //Console.WriteLine(spaceCount);
    string[] arr = new string[0];
    int start = 0;
    int countWord = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].ToString() == " ")
        {
            Array.Resize(ref arr, arr.Length+1);
            arr[countWord] = str.Substring(start, i - start);
            countWord++;
            start = i+1;
        }
    }
    Array.Resize(ref arr, arr.Length+1);
    arr[countWord] = str.Substring(start);
    string result = String.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        result += arr[arr.Length-i-1] + " ";
    }
    result = result.Trim();
    return result;
}
string revStr02 = ReversString02(str);
Console.WriteLine(revStr02);