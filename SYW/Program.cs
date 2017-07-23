using SYW.GB;

namespace SYW
{
    class Program
    {
        static void Main(string[] args)
        {
            var greenBox = new GreenBox();
            var sue = new SUE.SUE();

            greenBox.Run(); 
            sue.Run();
        }
    }
}
