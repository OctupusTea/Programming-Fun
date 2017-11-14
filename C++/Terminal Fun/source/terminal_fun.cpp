#ifdef MAKE

#include "terminal_fun.h"

#else

#include "../include/terminal_fun.h"

#endif

#include <iostream>
#include <vector>
#include <string>

using namespace std;

const uint32_t FORMAT_MASK[ 16 ] = { 0x0, 0x1, 0x2, 0x4, 0x8, 0x10, 0x20, 0x40, 0x80, 0x100, 0x200, 0x400, 0x800, 0x1000, 0x2000, 0x4000 };

Terminal_Fun::Terminal_Fun( void )
{
	_Set_Height( 24 );
	_Set_Width( 80 );
}

Terminal_Fun::Terminal_Fun( int height, int width )
{
	_Set_Height( height );
	_Set_Width( width );
}

Terminal_Fun::~Terminal_Fun( void )
{
	cout << "\033[m";
}

bool Terminal_Fun::_Set_Height( int height )
{
	if( height > 0 and height < 200 )
	{
		__height = height;
		return true;
	}
	else
	{
		return false;
	}
}

bool Terminal_Fun::_Set_Width( int width )
{
	if( width > 0 and width < 200 )
	{
		__width = width;
		return true;
	}
	else
	{
		return false;
	}
}

ostream& operator<<( ostream &output, Terminal_Fun &terminal )
{
	output << terminal.__output_string;
	terminal.__output_string.clear( );
	return output;
}

void Terminal_Fun::Set_Format( Color background_color, uint32_t format, Color foreground_color )
{
	string output_temp = "\033[";
	
	bool format_set = false;
	for( int i = 0; i < 16; i++ )
	{
		if( format & FORMAT_MASK[ i ] )
		{
			output_temp += to_string( i ) + ';';
			format_set = true;
		}
	}

	if( not format_set )
	{
		output_temp += "0;";
	}

	output_temp += '4' + to_string( background_color ) + ';';
	output_temp += '3' + to_string( foreground_color ) + 'm';

	__output_string += output_temp;
}

void Terminal_Fun::Set_Background( Color color )
{
	string output_temp = "\033[4" + to_string( color ) + 'm';
	__output_string += output_temp;
}

void Terminal_Fun::Set_Foreground( Color color )
{
	string output_temp = "\033[1" + to_string( color ) + 'm';
}

bool Terminal_Fun::Set_Position( Position position )
{
	if( position.row < __height and position.column < __width )
	{
		__current_position = position;
		string output_temp = "\033[" + to_string( __current_position.row ) + ';' + to_string( __current_position.column ) + 'H';
		__output_string += output_temp;
		return true;
	}
	else
	{
		return false;
	}
}

bool Terminal_Fun::Set_Position( int row, int column )
{
	return Set_Position( Position( row, column ) );
}

Terminal_Fun& Terminal_Fun::operator<<( const string &output )
{
	__output_string += output;
	return *this;
}

void Terminal_Fun::Clean_Screen( void )
{
	__output_string += "\033[2J";
	cout << *this;
}
