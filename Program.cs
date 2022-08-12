Console.WriteLine("Введите строки для массива последовательно, используя Enter");
List<string> arr_origin = new List<string>();
List<string> arr_modified = new List<string>();
while (true)
{
    string? m = Console.ReadLine();
    if (string.IsNullOrEmpty(m))
    {
        break;
    }
    arr_origin.Add(m);
}
foreach (string item in arr_origin)
{
    if (item.Length <= 3)
    {
        arr_modified.Add(item);
    }
}
Console.WriteLine("Оригинальный массив ["+String.Join(',', arr_origin)+"]");
Console.WriteLine("Обработанный массив ["+String.Join(',', arr_modified)+"]");

// альтернативное решение без использования коллекций
string[] origin = new string[]{"hello", "2", "world", ":-)"};
string[] modified = new string[]{};

for (int i=0; i < origin.Length; i++)
{
    if (origin[i].Length <= 3)
    {
        modified = modified.Append(origin[i]).ToArray();
    }
}

Console.WriteLine("Оригинальный массив ["+String.Join(',', origin)+"]");
Console.WriteLine("Обработанный массив ["+String.Join(',', modified)+"]");
