using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Paint_Test
{
	/// <summary>
	/// MainWindow.xaml 的互動邏輯
	/// </summary>
	public partial class MainWindow : Window
	{
		Point currentPoint = new Point( );
		UndoList undoQueue = new UndoList( );

		public MainWindow( )
		{
			InitializeComponent( );
		}

		private void PaintBoard_MouseDown( object sender, MouseButtonEventArgs e )
		{
			if( e.ButtonState == MouseButtonState.Pressed )
			{
				currentPoint = e.GetPosition( PaintBoard );
			}
		}

		private void PaintBoard_MouseMove( object sender, MouseEventArgs e )
		{
			if( e.LeftButton == MouseButtonState.Pressed )
			{
				Line line = new Line( );

				line.Stroke = SystemColors.WindowTextBrush;

				line.X1 = currentPoint.X;
				line.Y1 = currentPoint.Y;

				line.X2 = e.GetPosition( PaintBoard ).X;
				line.Y2 = e.GetPosition( PaintBoard ).Y;

				currentPoint = e.GetPosition( PaintBoard );

				PaintBoard.Children.Add( line );
			}
		}

		private void PaintBoard_MouseUp( object sender, MouseButtonEventArgs e )
		{
			
		}

		private void UndoButton_Click( object sender, RoutedEventArgs e )
		{
			
		}

		private void RedoButton_Click( object sender, RoutedEventArgs e )
		{

		}
	}
}
