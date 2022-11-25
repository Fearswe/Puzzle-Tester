namespace Puzzle_Tester
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Start");
			
			// Create nodes
 			var topLeft = new Node { Name = "Top Left" };
			var topRight = new Node { Name = "Top Right" };
			var bottomLeft = new Node { Name = "Bottom Left" };
			var bottomRight = new Node { Name = "Bottom Right" };
			var center = new Node { Name = "Center" };
			
			// Assign the siblings to each node
			topLeft.Siblings.Add(topRight);
			topLeft.Siblings.Add(bottomLeft);		
			topLeft.Siblings.Add(center);

			topRight.Siblings.Add(topLeft);
			topRight.Siblings.Add(bottomRight);
			topRight.Siblings.Add(center);

			bottomLeft.Siblings.Add(topLeft);
			bottomLeft.Siblings.Add(bottomRight);
			bottomLeft.Siblings.Add(center);

			bottomRight.Siblings.Add(topRight);
			bottomRight.Siblings.Add(bottomLeft);
			bottomRight.Siblings.Add(center);

			center.Siblings.Add(topLeft);
			center.Siblings.Add(topRight);
			center.Siblings.Add(bottomLeft);
			center.Siblings.Add(bottomRight);

			// Start traversing
			Traverse(topLeft, new List<Line>());			

			Console.WriteLine("End");


		}


		static void Traverse(Node start, List<Line> lines)
		{
			// There will be total of 8 lines once completed
			/* 
			 	    1
				  o---o
				  |\ /|
				2 | o | 3
				  |/ \|
				  o---o				
					4
			
				And lines connecting the center node with each corner makes 8
			 */
			if (lines.Count == 8)
			{
				// Write the complete pattern to the console
				Console.WriteLine(String.Join(", ", lines));
			}
			else
			{
				// Loop through all the siblings
				foreach (var sibling in start.Siblings)
				{
					// Check if the line already exists
					if (!lines.Any(l => l.IsLine(start, sibling)))
					{
						// If it doesn't exist, copy the list and add the new line
						var newLines = new List<Line>(lines) {
							new Line { Start = start, End = sibling }
						};
						// Keep traversing
						Traverse(sibling, newLines);
					}
				}
			}
		}
		
	}
}