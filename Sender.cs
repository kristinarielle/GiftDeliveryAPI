using System;
namespace GiftDeliveryAPI.Models
{
	public class Sender
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool DiscountApplied { get; set; }
        public int SenderId { get; set; }
    }
}

