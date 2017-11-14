using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Everwing_Egg_Chance_Optimizor
{
    public partial class Form1 : Form
    {
		private decimal current_coin;
		private decimal current_trophy;
		private decimal current_bonus;

		private int rare_count;
		private int legend_count;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			current_coin = 0;
			current_trophy = 0;
			current_bonus = 5;
            value_initial_coin.Focus();
        }

        private void button_initial_start_Click(object sender, EventArgs e)
        {
            value_initial_coin.Enabled = false;
            value_initial_trophy.Enabled = false;
            value_initial_bonus.Enabled = false;

			button_golden_rare.Enabled = true;
			button_golden_legend.Enabled = true;
			button_magical_rare.Enabled = true;
			button_magical_legend.Enabled = true;
			button_legend_bonus.Enabled = true;
        }

        private void button_initial_reset_Click(object sender, EventArgs e)
        {
            value_initial_coin.Enabled = true;
            value_initial_coin.Value = 0;

            value_initial_trophy.Enabled = true;
            value_initial_trophy.Value = 0;

            value_initial_bonus.Enabled = true;
            value_initial_bonus.Value = 0;

			button_golden_rare.Enabled = false;
			button_golden_legend.Enabled = false;
			button_magical_rare.Enabled = false;
			button_magical_legend.Enabled = false;
			button_legend_bonus.Enabled = false;

			value_initial_coin.Focus();
        }

        private void value_initial_coin_ValueChanged( object sender, EventArgs e)
        {
			current_coin = value_initial_coin.Value;
			value_current_coin.Text = current_coin.ToString( "N0" );
        }

        private void value_initial_trophy_ValueChanged( object sender, EventArgs e)
        {
			current_trophy = value_initial_trophy.Value;
			value_current_trophy.Text = current_trophy.ToString( "N0" );
        }

        private void value_initial_bonus_ValueChanged( object sender, EventArgs e)
        {
			current_bonus = value_initial_bonus.Value;
			value_current_bonus.Text = current_bonus.ToString( "N0" );

			value_golden_legend.Text = ( ( double )Math.Floor( current_coin / 28000 ) * 0.12 * ( 1.0 + ( double )current_bonus / 100.0 ) ).ToString( "N3" );
			value_magical_legend.Text = ( ( double )Math.Floor( current_trophy / 1100 ) * 0.3 * ( 1.0 + ( double )current_bonus / 100.0 ) ).ToString( "N3" );
		}

		private void value_current_coin_TextChanged( object sender, EventArgs e )
		{
			value_golden_egg.Text = Math.Floor( current_coin / 28000 ).ToString( "N0" );
		}

		private void value_current_trophy_TextChanged( object sender, EventArgs e )
		{
			value_magical_egg.Text = Math.Floor( current_trophy / 1100 ).ToString( "N0" );
		}

		private void value_golden_egg_TextChanged( object sender, EventArgs e )
		{
			value_golden_legend.Text = ( ( double )Math.Floor( current_coin / 28000 ) * 0.12 * ( 1.0 + ( double )current_bonus / 100.0 ) ).ToString( "N3" );

			if( current_coin / 28000 < 1 )
			{
				button_golden_rare.Enabled = false;
				button_golden_legend.Enabled = false;
			}
		}

		private void value_magical_egg_TextChanged( object sender, EventArgs e )
		{
			value_magical_legend.Text = ( ( double )Math.Floor( current_trophy / 1100 ) * 0.3 * ( 1.0 + ( double )current_bonus / 100.0 ) ).ToString( "N3" );

			if( current_trophy / 1100 < 1 )
			{
				button_magical_rare.Enabled = false;
				button_magical_legend.Enabled = false;
			}
		}

		private void value_golden_legend_TextChanged( object sender, EventArgs e )
		{
			value_legend.Text = ( ( double )Math.Floor( current_coin / 28000 ) * 0.12 * ( 1.0 + ( double )current_bonus / 100.0 ) + ( double )Math.Floor( current_trophy / 1100 ) * 0.3 * ( 1.0 + ( double )current_bonus / 100.0 ) ).ToString( "N3" );
		}

		private void value_magical_legend_TextChanged( object sender, EventArgs e )
		{
			value_legend.Text = ( ( double )Math.Floor( current_coin / 28000 ) * 0.12 * ( 1.0 + ( double )current_bonus / 100.0 ) + ( double )Math.Floor( current_trophy / 1100 ) * 0.3 * ( 1.0 + ( double )current_bonus / 100.0 ) ).ToString( "N3" );
		}

		private void button_exit_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void button_golden_rare_Click( object sender, EventArgs e )
		{
			current_coin -= 28000;
			value_current_coin.Text = current_coin.ToString( "N0" );

			rare_count++;
			value_rare_count.Text = rare_count.ToString( "N0" );
		}

		private void button_golden_legend_Click( object sender, EventArgs e )
		{
			current_coin -= 28000;
			value_current_coin.Text = current_coin.ToString( "N0" );

			legend_count++;
			value_legend_count.Text = legend_count.ToString( "N0" );

			current_bonus = ( current_bonus == 50 ? 50 : current_bonus + 5 );
			value_current_bonus.Text = current_bonus.ToString( "N0" );
		}

		private void button_magical_rare_Click( object sender, EventArgs e )
		{
			current_trophy -= 1100;
			value_current_trophy.Text = current_trophy.ToString( "N0" );

			rare_count++;
			value_rare_count.Text = rare_count.ToString( "N0" );
		}

		private void button_magical_legend_Click( object sender, EventArgs e )
		{
			current_trophy -= 1100;
			value_current_trophy.Text = current_trophy.ToString( "N0" );

			legend_count++;
			value_legend_count.Text = legend_count.ToString( "N0" );

			current_bonus = ( current_bonus == 50 ? 50 : current_bonus + 5 );
			value_current_bonus.Text = current_bonus.ToString( "N0" );
		}

		private void value_rare_count_TextChanged( object sender, EventArgs e )
		{
			value_dragon_count.Text = ( rare_count + legend_count ).ToString( "N0" );
		}

		private void value_legend_count_TextChanged( object sender, EventArgs e )
		{
			value_dragon_count.Text = ( rare_count + legend_count ).ToString( "N0" );
		}

		private void button_legend_bonus_Click( object sender, EventArgs e )
		{
			current_bonus = ( current_bonus == 50 ? 50 : current_bonus + 5 );
			value_current_bonus.Text = current_bonus.ToString( "N0" );
		}

		private void value_current_bonus_TextChanged( object sender, EventArgs e )
		{
			value_golden_legend.Text = ( ( double )Math.Floor( current_coin / 28000 ) * 0.12 * ( 1.0 + ( double )current_bonus / 100.0 ) ).ToString( "N3" );
			value_magical_legend.Text = ( ( double )Math.Floor( current_trophy / 1100 ) * 0.3 * ( 1.0 + ( double )current_bonus / 100.0 ) ).ToString( "N3" );
		}

		private double expectation_value_optimize( double[ ][ ][ ] dynamic_table, int megical_egg_count, int golden_egg_count, int bonus )
		{
			if( dynamic_table[ megical_egg_count ][ golden_egg_count ][ bonus ] != 0.0 )
			{
				return dynamic_table[ megical_egg_count ][ golden_egg_count ][ bonus ];
			}
			else if( megical_egg_count == 0 )
			{
				if( golden_egg_count == 0 )
				{
					return 0.0;
				}
				else
				{
					return expectation_value_optimize( dynamic_table, megical_egg_count, golden_egg_count - 1, bonus );
				}
			}
			else if( golden_egg_count == 0 )
			{

			}
			else
			{

			}
			return 0.0;
		}
	}
}
