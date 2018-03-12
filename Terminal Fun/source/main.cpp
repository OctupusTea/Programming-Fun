#ifdef MAKE
#include "terminal.hpp"
#include "terminal_fun.hpp"
#else
#include "../include/terminal.hpp"
#include "../include/terminal_fun.hpp"
#endif

#include <iostream>
#include <string>

using namespace std;

int main( void )
{
	srand( time( NULL ) );
	Terminal_Fun fun;
	
	fun.Circle_Loop( );
	fun.Random_Print( 5 );
	fun.Circle_Loop( ' ', COUNTERCLOCKWISE );
	fun.Clear_Screen( );

	return 0;
}
