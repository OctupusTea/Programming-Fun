#ifdef MAKE

#include "terminal_fun.h"

#else

#include "../include/terminal_fun.h"

#endif

#include <iostream>
#include <string>

#include <unistd.h>

using namespace std;

int main( void )
{
	srand( time( NULL ) );
	Terminal_Fun out;
	
	out.Set_Format( BLUE, BRIGHT, GREEN );
	out << "Testing text....\n";
	out.Set_Position( Position( 1, 12 ) );
	out.Set_Format( BLACK, BRIGHT, YELLOW );
	out << "Position test....";

	cout << out;
	sleep( 2 );

	out.Clean_Screen( );
	out.Set_Format( );
	
	int top = 1, bottom = 23;
	int left = 1, right = 79;
	int direction = 0;

	while( top <= bottom and left <= right )
	{
		switch( direction )
		{
			case 0:
			{
				for( int i = left; i <= right; ++i )
				{
					out.Set_Position( top, i );
					out << "@";
					cout << out << flush;
					usleep( 250 );
				}
				++top;
				direction = 1;
				break;
			}
			
			case 1:
			{
				for( int j = top; j <= bottom; ++j )
				{
					out.Set_Position( j, right );
					out << "@";
					cout << out << flush;
					usleep( 250 );
				}
				--right;
				direction = 2;
				break;
			}

			case 2:
			{
				for( int i = right; i >= left; --i )
				{
					out.Set_Position( bottom, i );
					out << "@";
					cout << out << flush;
					usleep( 250 );
				}
				--bottom;
				direction = 3;
				break;
			}

			case 3:
			{
				for( int j = bottom; j >= top; --j )
				{
					out.Set_Position( j, left );
					out << "@";
					cout << out << flush;
					usleep( 250 );
				}
				++left;
				direction = 0;
				break;
			}
		}
	}
	
	string temp( 1, 0 );
	while( true )
	{
		out.Set_Position( rand( ) % 24, rand( ) % 80 );
		out.Set_Format( Color( rand( ) % 8 ), Format( rand( ) % 2 ), Color( rand( ) % 8 ) );
		temp[ 0 ] = (char)( rand( ) % 95 + 32 );
		cout << temp;
		cout << out << flush;

		out.Set_Position( rand( ) % 24, rand( ) % 80 );
		out.Set_Format( );
		temp[ 0 ] = (char)( rand( ) % 95 + 32 );
		cout << temp;
		cout << out << flush;
	}

	return 0;
}
