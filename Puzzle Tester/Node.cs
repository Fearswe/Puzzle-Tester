namespace Puzzle_Tester
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	/// <summary>
	/// A node in the puzzle
	/// </summary>
	internal class Node
	{
		/// <summary>
		/// Name of the node, mainly used for prettifying the output
		/// </summary>
		public String Name { get; set; } = String.Empty;
		/// <summary>
		/// List of nodes that are siblings to this node, used for traversal
		/// </summary>
		public List<Node> Siblings { get; } = new List<Node>();
	}
}
