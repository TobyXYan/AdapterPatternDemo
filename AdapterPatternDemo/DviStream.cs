using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternDemo
{
    public class DviStream
    {
        private byte[] _stream;
        public void SetData(byte[] data)
        {
            _stream = data;
        }

        public byte[] GetData()
        {
            return _stream;
        }
    }
}
