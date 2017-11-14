#ifndef TERMINAL_FUN
#define TERMINAL_FUN

#include <iostream>
#include <vector>
#include <string>

using namespace std;

struct Position
{
	int row;
	int column;

	Position( void )
	{
		row = 0;
		column = 0;
	}

	Position( int in_row, int in_column )
	{
		row = in_row;
		column = in_column;
	}
};

enum Format{ NONE = 0, BRIGHT = 0x1, UNDERLINE = 0x10, BLINK = 0x20, HIGHLIGHT = 0x80, INVISIBLE = 0x100 };
enum Color{ BLACK = 0, RED = 1, GREEN = 2, YELLOW = 3, BLUE = 4, MAGENTA = 5, CYAN = 6, WHITE = 7 };

class Terminal_Fun
{
	private :
		int __height;
		int __width;
		bool _Set_Height( int );
		bool _Set_Width( int );

		Position __current_position;
		
		string __output_string;

	public :
		Terminal_Fun( void );
		Terminal_Fun( int, int );
		~Terminal_Fun( void );

		friend ostream& operator<<( ostream&, Terminal_Fun& );

		void Set_Format( Color = BLACK, uint32_t = NONE, Color = WHITE );
		void Set_Background( Color = BLACK );
		void Set_Foreground( Color = WHITE );
		
		bool Set_Position( Position = Position( 0, 0 ) );
		bool Set_Position( int = 0, int = 0 );
		
		Terminal_Fun& operator<<( const string& );

		void Clean_Screen( void );
};

#endif
