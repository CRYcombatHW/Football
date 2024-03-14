using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DAL.Entities
{
	public class Team
	{
		public int Id { get; set; }
		
		public string Name { get; set; }
		public string City { get; set; }
		public int Victories { get; set; }
		public int Looses { get; set; }
		public int Draws { get; set; }

		public override string ToString() {
			return @$"{Id}: {Name} [
	City: {City}
	-
	Victories: {Victories}
	Looses: {Looses}
	Draws: {Draws}
]";
		}
	}
}
