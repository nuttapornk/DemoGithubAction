// See https://aka.ms/new-console-template for more information


foreach (var item in RandomNumbers(15))
    Console.WriteLine($"{item} {(item % 2 == 0 ? "EVEN" : "ODD")}");


static int[] RandomNumbers(int times)
{
    Random random = new();   
    List<int> result = new();
    for (int i = 0; i < times; i++)
        result.Add(random.Next(1, 10));
    
    return result.ToArray();
}