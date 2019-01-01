#include "terminal.hpp"
#include "terminal_fun.hpp"

#include <iostream>
#include <string>

using namespace std;

int main( void )
{
	srand( time( NULL ) );
	Terminal_Fun fun;
	
	fun.Rectangular_Loop( );
	fun.Random_Print( 5 );
	fun.Rectangular_Loop( ' ', COUNTERCLOCKWISE );
	fun.Clear_Screen( );

	return 0;
}
