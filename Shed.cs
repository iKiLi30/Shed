using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shed
{
    public class Shed
    {
        public class Window
        {
            bool openWindow = false;
            int winWidth;
            int winHight;


            public bool OpenWindow() ///********************************************************
            {
                openWindow = true;
                return true;
            }
            public Window()
            {
                winWidth = 1;
                winHight = 1;
            }
            Window window = new Window();
            public int WinWidth
            {
                get { return winWidth; }
                set { winWidth = value; }
            }
            public int WinHeigth
            {
                get { return winHight; }
                set { winHight = value; }
            }
        }

        static int objecNumber = 0;

        public int GetObjectNumber()
        {
            return objecNumber;
        }
        public Shed()   //constructor
        {
            width = 1;
            Lengthwise = 1;
            this.height = 1;
            objecNumber++;
        }
            //variable
        int width;
        int height;
        string name = " ";

        //property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Heigth
        {
            get { return height; }
            set { height = value; }
        }

        public int Lengthwise { get; set; }
        public int ShedVolume()
        {
            return (width * height * Lengthwise);
        }
        public void ResizeShed(int x, int y, int z)
        {
            Width += x;
            Lengthwise += z;
            Heigth += y;

        }
        public void ResizeAndAddSize(ref int x,ref int y, ref int z)
        {
            ResizeShed(x,y,z);
            Width = x;
            Heigth = y;
            Lengthwise =z;
        }
        public void OutResizeAndAddSize( int inc, out int x, out int y, out int z)
        {
            ResizeShed(inc, inc , inc);
            x = Width;
            y = Heigth;
            z = Lengthwise;
        }

    }
}
