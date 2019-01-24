using System;
namespace ClaimIt.DayViewComponent
{
	public struct InteractionItem
	{
		public Guid Id { get; set; }
		public InteractionType Type { get; set; }
		public InteractionState State { get; set; }
	}
}
