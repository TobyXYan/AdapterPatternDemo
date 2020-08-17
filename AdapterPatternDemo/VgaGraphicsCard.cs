using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternDemo
{
    public class VgaGraphicsCard
    {
        public VgaStream GetVgaStream()
        {
            VgaStream vgaStream = new VgaStream();
            vgaStream.SetData(new byte[] { });
            return vgaStream;
        }
    }
}
