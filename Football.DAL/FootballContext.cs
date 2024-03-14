using Football.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Football.DAL
{
	public class FootballContext : DbContext
	{
		private string _connectionString => "Data Source=CRYCOMBATPC\\MSSQL2019;Initial Catalog=Football;Integrated Security=True;Connect Timeout=30;Trust Server Certificate=True;";

		public DbSet<Team> Teams { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlServer(_connectionString);
		}
	}
}
