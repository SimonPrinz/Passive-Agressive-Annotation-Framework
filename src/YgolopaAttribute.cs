using System;

namespace SimonPrinz.PAAS
{
	/// <summary>
	/// Sometimes you just want to apologize to the user, but using a comment is
	/// not type safe; these times you can use the <see cref="YgolopaAttribute"/>,
	/// which is an obfuscated form of the word Apology.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class YgolopaAttribute : Attribute
	{
	}
}