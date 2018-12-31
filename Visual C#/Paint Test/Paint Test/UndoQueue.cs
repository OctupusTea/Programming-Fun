using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Paint_Test
{
	public class UndoList
	{
		private Stack<List<Line>> undoStack;
		private Stack<List<Line>> redoStack;

		public const int DEFAULT_CAPACITY = 15;
		UndoList( int capacity = DEFAULT_CAPACITY )
		{
			undoStack = new Stack<List<Line>>( capacity );
			redoStack = new Stack<List<Line>>( capacity );
		}

		void Insert( List<Line> lineList )
		{
			
		}
	}
}

