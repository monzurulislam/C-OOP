using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventandDelegates
{
    class Program
    {
        static void Main(string[] args) 
         {
            var video = new Video() {Title = " Video 1"};
            var videoEncoder = new VideoEncoder();///publisher
            var mailService = new Mailservice();///subscriber

            videoEncoder.VideoEncoded += mailService.OnvideoEncoded;

            videoEncoder.Encode(video);
        }
    }

    public class Mailservice
    {
        public void OnvideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine(" Mail Service: Sending an Email.......");
            //Console.Read();
        }
    }
}
