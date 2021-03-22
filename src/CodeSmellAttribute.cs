using System;

namespace SimonPrinz.PAAS
{
	/// <summary>
	/// When you encounter a code smell, you can let your fellow team members know by
	/// annotating the code with the <see cref="CodeSmellAttribute"/> and indicate
	/// the appropriate smell such as <see cref="eSmell.GodClass"/>,
	/// <see cref="eSmell.RefusedBequest"/>, <see cref="eSmell.InappropriateIntimacy"/>,
	/// <see cref="eSmell.FeatureEnvy"/> or <see cref="eSmell.CyclomaticComplexity"/>.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class CodeSmellAttribute : Attribute
	{
		public eSmell Smell { get; }

		public CodeSmellAttribute(eSmell pSmell) =>
			Smell = pSmell;
	}
}