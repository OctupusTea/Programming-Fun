#ifndef CHARACTER_H
#define CHARACTER_H

#include "lib.h"

#include <iostream>
#include <vector>
#include <string>

#define _DEFAULT_HEALTH ( 10000 )
#define _DEFAULT_MAGE ( 1000 )

virtual class Character
{
	private :
		unsigned _health;
		unsigned _mage;
		bool _status[ 16 ];
		bool _skill[ 16 ];
		unsigned _skill_cooldown[ 16 ];
		unsigned _cooldown_counter[ 16 ];

	public :
		//	constructor for void
		virtual Character( void );

		//	constructor for _health and _mage
		virtual Character( const int&, const int& );

		//	constructor for _health, _mage and _skill_cooldown
		virtual Character( const int&, const int&, const bool[ 16 ], const bool[ 16 ], const int[ 16 ] )

		virtual void attack( Character& );
}

#endif
