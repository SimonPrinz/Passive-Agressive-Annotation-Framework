using System;

namespace SimonPrinz.PAAS
{
	/// <summary>
	/// If you started coding a method yourself with too much confidence and you thought
	/// you would pull it off, but 8 hours later, you are left with a method that seems
	/// to work, but you are not really a hundred percent sure why, you can indicate your
	/// overconfidence with the <see cref="HybrisAttribute"/>.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class HybrisAttribute : Attribute
	{
	}
}