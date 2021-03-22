using System;

namespace SimonPrinz.PAAS
{
	/// <summary>
	/// Whenever there was a team decision and you were the only one on the whiteboard
	/// that did not agree with the decision - because it was a very bad idea - but they
	/// chose you to implement the bad idea, you can use the <see cref="CalimeroAttribute"/>
	/// to express the fact that you did not intend to write this code, but since you are
	/// a team player, you follow the team.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class CalimeroAttribute : Attribute
	{
	}
}