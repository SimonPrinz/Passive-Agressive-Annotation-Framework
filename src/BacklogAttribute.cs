using System;

namespace SimonPrinz.PAAS
{
	/// <summary>
	/// A lot of times you are forced by management to implement a quick hack and
	/// after heavy fighting the only thing you got in return is a lousy ticket in the
	/// backlog, with the promise that the hack will some day, in some universe be
	/// fixed and resolved in an appropriate, clean way. However, that ticket will
	/// always stay on the backlog due to priority suffocation. In those cases, you can
	/// use the <see cref="BacklogAttribute"/> and indicate the appropriate ticket number.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class BacklogAttribute : Attribute
	{
		public string TicketNumber { get; }
		
		public BacklogAttribute(string pTicketNumber) =>
			TicketNumber = pTicketNumber;
	}
}