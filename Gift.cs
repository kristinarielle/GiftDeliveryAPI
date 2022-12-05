using System;
namespace GiftDeliveryAPI.Models
{
	public class Gift
	{
		public int GiftId { get; set; }
		public bool IsSigned { get; set; }
		public string ReceiverFirstName { get; set; }
        public string ReceiverLastName { get; set; }
        public string Message { get; set; }
    }
}


