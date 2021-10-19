using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        public StreamProgressInfo()
        {
            
        }

        public int CalculateCurrentPercent(IStreamble file)
        {
            return (file.BytesSent * 100) / file.Length;
        }
    }
}
