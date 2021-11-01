using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventandDelegates
{
    class VideoEncoder
    {
        public delegate void VideoEncoderEventHandler(object source, EventArgs args);

        public event VideoEncoderEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine(" Encoding Video.......");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        public virtual void OnVideoEncoded()
        {
            if(VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}
