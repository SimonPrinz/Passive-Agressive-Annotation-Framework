using System;

namespace SimonPrinz.PAAS
{
	/// <summary>
	/// Whenever you are coding something that an other team should actually be coding,
	/// but they didn't have time to do it since their own code is so screwed up they
	/// are consuming every minute to deal with their own legacy, you can use the
	/// <see cref="AltruisticAttribute"/>. Since you are so altruistic, you are offering
	/// your own time to fix their code (albeit in 1/10th of the time they would need).
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class AltruisticAttribute : Attribute
	{
	}
}