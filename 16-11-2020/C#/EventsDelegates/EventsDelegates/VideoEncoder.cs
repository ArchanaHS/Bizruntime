using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsDelegates
{
    class VideoEventArgs : EventArgs
    {
      public Video Video { get; set; }
    

        
    }
    class VideoEncoder
    {
        //1-> we need to define a delegate.
        //2-> defines a Event based on the delegates.
        //3-> Raise the events.


        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //EventHandler
        //EventHandler<TEventArgs>
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video......");
            Thread.Sleep(3000);
            onVideoEncoded(video);

        }
       public   virtual void onVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });

        }

    }
}
