using System;

namespace SimonPrinz.PAAS
{
	/// <summary>
	/// How many times did you encounter a method with jigglish code that you have no
	/// idea what it's doing? To indicate to your fellow team members that you have
	/// literally no idea what this code is doing, use the <see cref="BlackBoxAttribute"/>,
	/// it is less intrusive than using the <see cref="ObsoleteAttribute"/>.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class BlackBoxAttribute : Attribute
	{
	}
}