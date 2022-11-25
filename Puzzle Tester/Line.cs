namespace Puzzle_Tester
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	/// <summary>
	/// Represents a line between two nodes. Used to make sure we don't go the same path twice.
	/// </summary>
	internal class Line
	{
		public required Node Start { get; set; }
		public required Node End { get; set; }

		/// <summary>
		/// Pretty print the line
		/// </summary>
		/// <returns>NAME -> NAME</returns>
		public override String ToString()
		{
			return $"{this.Start.Name} -> {this.End.Name}";
		}

		/// <summary>
		/// Helper method for when we want to check if a line exists in a list of lines.
		/// Since we can't create a line between the same nodes we check either direction.
		/// </summary>
		/// <param name="first">One of the nodes</param>
		/// <param name="second">The other node</param>
		/// <returns>True if this line is made up of the two provided nodes</returns>
		public Boolean IsLine(Node first, Node second)
		{
			if (first == this.Start && second == this.End)
			{
				return true;
			}
			else if (first == this.End && second == this.Start)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
