using System.Collections.Generic;

namespace RatTracker_WPF.Models.Api
{
    public class Datum
    {
        public bool Active { get; set; }
        public bool Archive { get; set; }
        public Client Client { get; set; }
        public bool CodeRed { get; set; }
        public string CreatedAt { get; set; }
        public bool Epic { get; set; }
        public string LastModified { get; set; }
        public bool Open { get; set; }
        public string Notes { get; set; }
        public string Platform { get; set; }
        public List<string> Quotes { get; set; }
        public List<string> Rats { get; set; }
        public List<string> unidentifiedRats { get; set; }
        public bool? Successful { get; set; }
        public string System { get; set; }
        // ReSharper disable once InconsistentNaming
        public string _id { get; set; }
        public float Score { get; set; }

		public string id { get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}
		
    }
}