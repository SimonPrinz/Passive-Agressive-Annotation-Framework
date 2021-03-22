using System;

namespace SimonPrinz.PAAS
{
	/// <summary>
	/// When you encounter an anti pattern, you can let your fellow team members know
	/// by annotating the code with the <see cref="AntiPatternAttribute"/> and indicate
	/// the appropriate pattern such as <see cref="ePattern.BusyWaiting"/>,
	/// <see cref="ePattern.CodingByException"/>, <see cref="ePattern.ErrorHiding"/>,
	/// <see cref="ePattern.LavaFlow"/>, <see cref="ePattern.MagicNumber"/>,
	/// <see cref="ePattern.MagicString"/>, <see cref="ePattern.ObjectOrgy"/>.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class AntiPatternAttribute : Attribute
	{
		public ePattern Pattern { get; }
		
		public AntiPatternAttribute(ePattern pPattern) =>
			Pattern = pPattern;
	}
}