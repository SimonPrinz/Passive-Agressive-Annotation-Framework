using System;

namespace SimonPrinz.PAAS
{
	/// <summary>
	/// Sometimes you encounter code that should be refactored, but whatever you change
	/// in the code has side effects in parts of the codebase that seem totally unrelated.
	/// Since those effects are only visible after you run your test suites of the other
	/// modules in your codebase, you should prevent other developers in your team to
	/// fiddle with this code as they won't be smart enough to understand the ripple effects.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class QuantumEntanglementAttribute : Attribute
	{
		public eSmell Smell { get; }

		public QuantumEntanglementAttribute(eSmell pSmell) =>
			Smell = pSmell;
	}
}