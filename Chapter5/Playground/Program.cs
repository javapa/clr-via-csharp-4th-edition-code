using System.Text;
namespace Playground;

class Program
{
    static void Main(string[] args)
    {
        char c = 'x';
        string s = "aaa";
        Console.WriteLine(sizeof(bool));

        //int byteCount = Encoding.UTF8.GetByteCount(s);
        int byteCount = Encoding.UTF8.GetByteCount(new char[]{c});
        Console.WriteLine(byteCount);                
    }
}
