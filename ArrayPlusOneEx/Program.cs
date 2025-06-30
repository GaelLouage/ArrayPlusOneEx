internal class Program
{
    private static void Main(string[] args)
    {
        var num = new int[] { 0, 4, 2 };
        var upArray = UpArray(num);
        foreach (var n in upArray)
        {
            Console.WriteLine(n);
          
        }
    }
    public static int[] UpArray(int[] num)
    {
        if(num.Any( x => x < 0) || num.Any(x => x > 9)) return null;

        
        var plusOneResult = int.Parse(string.Concat(num)) + 1;
        var plusToToString = plusOneResult.ToString();
        var result = new List<int>();

        for(int i = 0; i< plusToToString.Length; i++)
        {
            result.Add((int)char.GetNumericValue(plusToToString[i]));
        }

        return result.ToArray();
    }
}