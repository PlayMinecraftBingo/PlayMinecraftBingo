using MySql.Data.MySqlClient;

namespace PlayMinecraftBingo
{
	internal class Database
	{
		private static readonly MySqlConnectionStringBuilder dbConnString = new()
		{
			Server = "db-mysql",
			UserID = "PlayMinecraftBingo",
			Password = "zjNaFZu4CsipTqI7",
			Database = "PlayMinecraftBingo"
		};

		public static string ConnectionString
		{
			get
			{
				return dbConnString.ConnectionString;
			}
		}
	}
}
