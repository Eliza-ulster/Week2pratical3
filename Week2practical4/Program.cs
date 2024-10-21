using System.Collections.Specialized;
using System.Globalization;

Main();

static void Main()
{
    Console.WriteLine("Enter a string:");
    string str = Console.ReadLine();

    Console.WriteLine("Enter no of rotation");
    int noOfrotation= Convert.ToInt32(Console.ReadLine());

    string decrypt = Decrypt( str,  noOfrotation);

    Console.WriteLine($"The sentence is,{str}");
    Console.WriteLine($"The decrypted sentence is , {decrypt}");


}
static string Decrypt( string line, int Rotation)
{
    string decdedText = " ";

    foreach( char c in line)
    {
        int decoded = c + Rotation;
        decdedText += (char)decoded;

    }
    return decdedText;
}


