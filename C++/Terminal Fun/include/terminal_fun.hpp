#ifndef TERMINAL_FUN
#define TERMINAL_FUN

#include "terminal.hpp"

#include <iostream>
#include <vector>
#include <string>

using namespace std;

enum Orientation{ CLOCKWISE = 0, COUNTERCLOCKWISE = 1 };

const double PI = 3.141592653589793;
const double EPSILON = 0.001;

class Terminal_Fun
{
	private:
		Terminal __terminal;

	public:
		Terminal_Fun( void );

		void Rectangular_Loop( char character = '@', Orientation orientation = CLOCKWISE );
		void Random_Print( time_t time_span = 0, string characters = "", Colors colors = COLOR_RANDOM );
		void Rectangular_Fill( char character = '@', Orientation orientation = CLOCKWISE );
		void Clear_Screen( void );
};

#endif
