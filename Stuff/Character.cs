using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
	public class Character
	{
		private int lvl;
		private int str;	// strenght
		private int inte;	//inteligence 
		private int dex;	// dexterity
		private int hp;
		private int mp;
		private string name;

		public int lvl
		{
			get { return index; }
			set { index = value; }
		}

		public int str
		{
			get { return index; }
			set { index = value; }
		}

		public int inte
		{
			get { return index; }
			set { index = value; }
		}

		public int dex
		{
			get { return index; }
			set { index = value; }
		}
		
		/*public int hp
		{
			get { return index; }
			set { index = value; }
		}

		public int mp
		{
			get { return index; }
			set { index = value; }
		}*/

		public void a()
		{
			private decimal smth = 0.75;
			
			hp = Math.Round(_str * smth, 0);
			mp = Math.Round(_inte * smth, 0);
		}
		
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		
		/*public Character Leveling(Character char)
		{
			char.lvl++;
			char.str ?;
			char.inte ?;
			char.dex ?;
			a();
			return char;
		}*/

		public Character(int _lvl, int _str, int _inte, int _dex, string _name)
		{
			lvl = _lvl;
			str = _str;
			inte = _inte;
			dex = _dex;
			/*hp = Math.Round(_str * 0.75, 0);
			mp = Math.Round(_inte * 0.75, 0);*/
			a();
			name = _name;
		}
	}
}
