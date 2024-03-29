﻿using Football.DAL;
using Football.DAL.Entities;

namespace Football
{
	internal class Program
	{
		static void Main(string[] args) {
			using FootballContext context = new FootballContext();

			AddData(context);
			context.SaveChanges();

			WriteData(context);
		}

		private static void AddData(FootballContext context) {
			context.Teams.Add(new Team() {
				Name = "Baguette",
				City = "London",
				Victories = 4,
				Looses = 6,
				Draws = 1,
				ScoredGoals = 7,
				LoosedGoals = 11,
			});
			context.Teams.Add(new Team() {
				Name = "Croissant",
				City = "Fontain",
				Victories = 13,
				Looses = 5,
				Draws = 0,
				ScoredGoals = 67,
				LoosedGoals = 31,
			});
			context.Teams.Add(new Team() {
				Name = "Quaso",
				City = "Fontain",
				Victories = 14,
				Looses = 7,
				Draws = 0,
				ScoredGoals = 65,
				LoosedGoals = 33,
			});
		}

		private static void WriteData(FootballContext context) {
			foreach (Team team in context.Teams) {
				Console.WriteLine(team);
			}
		}
	}
}
