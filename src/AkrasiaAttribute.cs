using System;

namespace SimonPrinz.PAAS
{
	/// <summary>
	/// When you are coding a solution while you actually know that another solution would
	/// be far better, you can annotate that code with the <see cref="AkrasiaAttribute"/>.
	/// Akrasia is the phenomenon that people sometimes act against one's better judgment.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class AkrasiaAttribute : Attribute
	{
	}
}