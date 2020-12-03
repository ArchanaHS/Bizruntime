using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDelegates
{
    class MessageService
    {
        public void onVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService : Sending a text Message...."+args.Video.Title);
        }
    }
}
