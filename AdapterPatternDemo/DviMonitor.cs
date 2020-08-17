using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternDemo
{
    public class DviMonitor
    {
        private byte[] _inputStream;

        public void SetInput(DviStream inputStream)
        {
            _inputStream = inputStream.GetData();
        }
    }
}
