using System;

namespace SimonPrinz.PAAS
{
	/// <summary>
	/// When you are working at night, the effects of sleep deprivation will sneak
	/// into your code and things like small typo's start to appear. Since you are
	/// not able to detect those early in the morning, you can proactively indicate
	/// that you are working hard at night to justify your likely-to-appear errors
	/// by using the <see cref="MelatoninAttribute"/>.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class MelatoninAttribute : Attribute
	{
	}
}