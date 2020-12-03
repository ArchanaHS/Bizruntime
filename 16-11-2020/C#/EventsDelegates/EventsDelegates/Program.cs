using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "video 1" };
            var videoEncoder = new VideoEncoder();//publisher
            var MailService = new MailService();//Subscriber
            var MessageService = new MessageService();//subscriber

            videoEncoder.VideoEncoded += MailService.onVideoEncoded;
            videoEncoder.VideoEncoded += MessageService.onVideoEncoded;

            videoEncoder.Encode(video);
            Console.ReadKey();
        }
    }

}
