using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo__ADV4.Youtube
{
    internal class Channel
    {
        public int ChannelName { get; set; }
        public List<Video> videos { get; set; } = new List<Video>();

        public void AddVideo(Video video)
        {
            videos.Add(video);
            uploadvideo.Invoke();
        }

        public event Action uploadvideo;
        public override string ToString()
        {
            return $" ChannelName : {ChannelName} , Videos : {videos} ";
        }

        //ublic Channel()
        //
        //       videos = new List<Video>();
        //
    }
}
