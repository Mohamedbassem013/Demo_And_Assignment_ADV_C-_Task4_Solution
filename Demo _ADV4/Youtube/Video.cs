using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo__ADV4.Youtube
{
    internal class Video
    {
        public int Title { get; set; }
        public int Description { get; set; }

        public override string ToString()
        {
            return $" Title : {Title} , Description : {Description} ";
        }
    }
}
