using System;

namespace SimonPrinz.PAAS
{
	/// <summary>
	/// Sometimes you encounter crappy code, but there is no way you can refactor it,
	/// because it's written by the manager at the times he was still a developer.
	/// He got promotion to get rid of him as a developer, but he still won't bear
	/// with changes to his code, since he is God now. Protect your fellow developers
	/// from fiddling with this code by annotating it using the <see cref="GodChildAttribute"/>.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class GodChildAttribute : Attribute
	{
	}
}