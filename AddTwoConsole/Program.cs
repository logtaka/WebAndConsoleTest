using AddTwoShared;

Console.Write("数字を入力してください: ");
var input = Console.ReadLine();

if (int.TryParse(input, out int value))
{
    int result = MathService.AddTwo(value);
    Console.WriteLine($"結果: {result}");
}
else
{
    Console.WriteLine("数字ではありません。");
}

Console.WriteLine("終了するには Enter を押してください。");
Console.ReadLine();
