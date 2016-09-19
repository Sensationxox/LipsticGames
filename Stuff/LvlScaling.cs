using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipsticgames
{
	class LvlScaling
	{	
		public int LowestLvl (int _lvl)
		{
			return _lvl - 5;
		}
		
		public int HighestLvl (int _lvl)
		{
			return _lvl + 5;
		}
		
		public int RandomHighLvl (int _lvl)
		{
			return _lvl + 7;
		}

		public int Scale(int _lvl)
		{
			Random rnd = new Random();
			if (rnd.Next(101) > 75)
				RandomHighLvl(_lvl);
		}
	}
}