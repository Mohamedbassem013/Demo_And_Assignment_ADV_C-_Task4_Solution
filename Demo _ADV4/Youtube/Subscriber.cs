using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo__ADV4.Youtube
{
    internal class Subscriber
    {
        public int SubscriberName { get; set; }

        public void Notify(Video video , Channel channel)
        {
            Console.WriteLine($" {channel.ChannelName} is Add New Videos !!  ,{SubscriberName}");
        }
        public override string ToString()
        {
            return $" SubscriberName : {SubscriberName}  ";
        }
    }
}
