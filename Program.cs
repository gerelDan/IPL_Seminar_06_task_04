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