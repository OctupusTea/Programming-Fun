#ifndef TERMINAL_FUN
#define TERMINAL_FUN

#ifdef MAKE
#include "terminal.hpp"
#else
#include "../include/terminal.hpp"
#endif

#include <iostream>
#include <vector>
#include <string>

using namespace std;

enum Orientation{ CLOCKWISE = 0, COUNTERCLOCKWISE = 1 };

class Terminal_Fun
{
	private:
		Terminal __terminal;

	public:
		Terminal_Fun( void );

		void Circle_Loop( char character = '@', Orientation orientation = CLOCKWISE );
		void Random_Print( time_t time_span = 0, string characters = "", Colors colors = COLOR_RANDOM );
		void Clear_Screen( void );
};

#endif
