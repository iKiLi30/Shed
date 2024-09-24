namespace Shed
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Shed myShed = new Shed();

            Console.WriteLine(myShed.GetObjectNumber());
            
            Shed myShed1 = new Shed();

            Console.WriteLine(myShed1.GetObjectNumber());
            
            Shed myShed2 = new Shed();

            Console.WriteLine(myShed2.GetObjectNumber());

            Shed myShed3 = new Shed();

            Console.WriteLine(myShed3.GetObjectNumber());

            myShed.Heigth = 10;
            myShed.Width = 10;
            myShed.Lengthwise = 10;

            int resizeWidth = 2;
            int resizeHeigth = 3;
            int resizeLenthwise = 4;

            int befoResize = myShed.ShedVolume();

            Console.WriteLine($"{myShed.Width}\n{myShed.Heigth}\n{myShed.Lengthwise}\n{befoResize}");

            myShed.ResizeShed(resizeWidth, resizeHeigth, resizeLenthwise);

            int afterResize = myShed.ShedVolume();

            Console.WriteLine($"After resize\n{myShed.Width}\n{myShed.Heigth}\n{myShed.Lengthwise}\n{afterResize}\t");



            myShed.ResizeAndAddSize(ref resizeWidth, ref resizeHeigth, ref resizeLenthwise);
            Console.WriteLine("Size of shed changed at : " + resizeWidth + " " + resizeHeigth + " " + resizeLenthwise);

            myShed.OutResizeAndAddSize(10, out resizeWidth, out resizeHeigth, out resizeLenthwise);
            Console.WriteLine("Size of shed OUT changed at : " + resizeWidth + " " + resizeHeigth + " " + resizeLenthwise);*/
            
            Shed myShed = new Shed();
            Shed.Window shedWindow = new Shed.Window();
            shedWindow.OpenWindow();



        }
    }    
}   
