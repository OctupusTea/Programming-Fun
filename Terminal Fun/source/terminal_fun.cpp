#ifdef MAKE
#include "terminal.hpp"
#include "terminal_fun.hpp"
#else
#include "../include/terminal.hpp"
#include "../include/terminal_fun.hpp"
#endif

#include <iostream>
#include <vector>
#include <string>

extern "C"
{
#include <sys/ioctl.h>
#include <unistd.h>
}

using namespace std;

#define ALL_CHARACTERS " !\"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~"

Terminal_Fun::Terminal_Fun( void ) : __terminal( )
{
	//	empty
}

void Terminal_Fun::Circle_Loop( char character, Orientation orientation )
{
	winsize terminal_size;
	ioctl( STDOUT_FILENO, TIOCGWINSZ, &terminal_size );
	
	int left = 1, right = terminal_size.ws_col;
	int top = 1, bottom = terminal_size.ws_row;

	if( orientation == CLOCKWISE )
	{
		while( left < right and top < bottom )
		{
			for( int i = left; i != right; ++i )
			{
				__terminal.Position( Position( top, i ) );
				__terminal << character;
				cout << __terminal;
				usleep( 1 );
			}

			for( int j = top; j != bottom; ++j )
			{
				__terminal.Position( Position( j, right ) );
				__terminal << character;
				cout << __terminal;
				usleep( 1 );
			}

			for( int i = right; i != left; --i )
			{
				__terminal.Position( Position( bottom, i ) );
				__terminal << character;
				cout << __terminal;
				usleep( 1 );
			}

			for( int j = bottom; j != top; --j )
			{
				__terminal.Position( Position( j, left ) );
				__terminal << character;
				cout << __terminal;
				usleep( 1 );
			}

			++left, --right;
			++top, --bottom;
		}
	}
	else
	{
		while( left < right and top < bottom )
		{
			for( int j = top; j != bottom; ++j )
			{
				__terminal.Position( Position( j, left ) );
				__terminal << character;
				cout << __terminal;
				usleep( 1 );
			}

			for( int i = left; i != right; ++i )
			{
				__terminal.Position( Position( bottom, i ) );
				__terminal << character;
				cout << __terminal;
				usleep( 1 );
			}

			for( int j = bottom; j != top; --j )
			{
				__terminal.Position( Position( j, right ) );
				__terminal << character;
				cout << __terminal;
				usleep( 1 );
			}

			for( int i = right; i != left; --i )
			{
				__terminal.Position( Position( top, i ) );
				__terminal << character;
				cout << __terminal;
				usleep( 1 );
			}

			++left, --right;
			++top, --bottom;
		}
	}
}

void Terminal_Fun::Random_Print( time_t time_span, string characters, Colors color )
{
	winsize terminal_size;
	ioctl( STDOUT_FILENO, TIOCGWINSZ, &terminal_size );

	if( characters == "" )
	{
		characters = ALL_CHARACTERS;
	}
	
	time_t start_time = time( nullptr );
	while( time_span == 0 or time( nullptr ) - start_time < time_span )
	{
		__terminal.Position( Position( rand( ) % terminal_size.ws_row + 1, rand( ) % terminal_size.ws_col + 1 ) );

		class Format temp = __terminal.Format( );
		temp.Foreground( color );
		temp.Background( color );
		temp.Formats( rand( ) % 2 );
		__terminal.Format( temp );
		
		__terminal << characters[ rand( ) % characters.length( ) ];
		cout << __terminal;

		usleep( 1 );
	}

	__terminal.Format( Format( ) );
	cout << __terminal;
}

void Terminal_Fun::Clear_Screen( void )
{
	cout << "\e[2J" << "\e[;H" << flush;
}
