using System;

namespace AdapterPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Setting inpit for DVI Monitor!");
            var vgaGraphicsCard = new VgaGraphicsCard();//Create a VgaGraphicsCard which contains a VgaStream
            var dviMonitor = new DviMonitor();//Create a DviMonitor which requires a Dvi stream to display
            var vgaGraphicsCardAdapter = new VgaGraphicsCardAdapter(vgaGraphicsCard);//Create a VgaGraphicsCardAdapter to accept Vga stream from VgaGraphicsCard and convert to Dvi stream
            dviMonitor.SetInput(vgaGraphicsCardAdapter.GetDviStream());//GetDviStream get vga stream to get data, and put the data to the stream of dvi
        }
    }
}
