using MySql.Data.MySqlClient;

namespace PlayMinecraftBingo
{
	internal class AlertBox(bool enabled, string message)
	{
		public bool Enabled { get; init; } = enabled;
		public string Message { get; init; } = message;

		public static AlertBox GetConfig(string path)
		{
			using (MySqlConnection dbConn = new(Database.ConnectionString))
			{
				dbConn.Open();
				using (MySqlCommand dbQuery = new("SELECT enabled, message FROM alertbox WHERE path = @P", dbConn))
				{
					dbQuery.Parameters.AddWithValue("@P", path);
					using (MySqlDataReader dbResult = dbQuery.ExecuteReader())
					{
						if (dbResult.HasRows == false) return new(false, "");

						dbResult.Read();
						return new(dbResult.GetBoolean(0), dbResult.GetString(1));
					}
				}
			}
		}
	}
}
