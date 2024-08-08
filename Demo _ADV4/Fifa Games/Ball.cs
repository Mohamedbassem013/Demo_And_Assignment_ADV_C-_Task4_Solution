using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo__ADV4.Fifa_Games
{
    internal class Ball
    {
        public int Id { get; set; }
		private int Location;

		public int location
		{
			get { return Location; }
			set { 
                if(value != Location)
                {
                    Location = value;


                    //Notify Subscriber
                    BallLocationChanged?.Invoke();
                }
            }
		}

        //Event
        public Action? BallLocationChanged;

        public override string ToString()
        {
            return $" Id : {Id} , Location : {location}";
        }

    }
}
