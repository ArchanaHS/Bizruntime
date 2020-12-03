using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDelegates
{
    class MailService
    {
        public void onVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService : Sending an mail......"+e.Video.Title);
        }
    }
}
