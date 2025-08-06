using libFetchr;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace PlayMinecraftBingo
{
	internal class FetchrWeeklySeeds
	{
		public byte Prefix { get; init; }
		public DateTime EffectiveDate { get; init; }
		public required FetchrVersion FetchrVersion { get; init; }
        public string McVersion => FetchrVersion.Minecraft.ToString();
		public bool ShowPreviews { get; init; }
		public int Seed1 { get; init; }
		public int Seed2 { get; init; }
		public int Seed3 { get; init; }
		public int Seed4 { get; init; }
		public string? Seed4Credit { get; init; }

		internal static SortedDictionary<DateTime,byte> GetPreviousWeeks()
		{
			SortedDictionary<DateTime, byte> previousWeeks = [];

			using (MySqlConnection dbConn = new(Database.ConnectionString))
			{
				dbConn.Open();
				using (MySqlCommand dbQuery = new("SELECT effectivedate, prefix FROM fetchr_weeks WHERE effectivedate <= UNIX_TIMESTAMP() ORDER BY effectivedate DESC", dbConn))
				{
					using (MySqlDataReader dbResult = dbQuery.ExecuteReader())
					{
						while (dbResult.Read())
						{
							previousWeeks.Add(Util.FromUnixTimestamp(dbResult.GetUInt32(0)), dbResult.GetByte(1));
						}
					}
				}
			}

			return previousWeeks;
		}

		internal static byte GetCurrentPrefix()
		{
			using (MySqlConnection dbConn = new(Database.ConnectionString))
			{
				dbConn.Open();
				using (MySqlCommand dbQuery = new("SELECT prefix FROM fetchr_weeks WHERE effectivedate <= UNIX_TIMESTAMP() ORDER BY effectivedate DESC LIMIT 1", dbConn))
				{
					return Convert.ToByte(dbQuery.ExecuteScalar());
				}
			}
		}

		internal static bool IsValidPrefix(byte prefix)
		{
			if (prefix <= 0) return false;

			using (MySqlConnection dbConn = new(Database.ConnectionString))
			{
				dbConn.Open();
				using (MySqlCommand dbQuery = new("SELECT prefix FROM seeds WHERE effectivedate <= UNIX_TIMESTAMP() AND prefix = @P", dbConn))
				{
					dbQuery.Parameters.AddWithValue("@P", prefix);
					using (MySqlDataReader dbResult = dbQuery.ExecuteReader())
					{
						return dbResult.HasRows;
					}
				}
			}
		}

		internal static FetchrWeeklySeeds? GetByPrefix(byte prefix)
		{
			if (prefix <= 0) return null;

			using (MySqlConnection dbConn = new(Database.ConnectionString))
			{
				dbConn.Open();
				using (MySqlCommand dbQuery = new("SELECT prefix, effectivedate, fetchrversionID, mcversionID, showpreviews, seed1, seed2, seed3, seed4, seed4credit FROM seeds WHERE prefix = @P", dbConn))
				{
					dbQuery.Parameters.AddWithValue("@P", prefix);
					using (MySqlDataReader dbResult = dbQuery.ExecuteReader())
					{
						if (dbResult.HasRows == false) return null;

						dbResult.Read();

                        return new()
                        {
                            Prefix = dbResult.GetByte(0),
                            EffectiveDate = Util.FromUnixTimestamp(dbResult.GetUInt32(1)),
                            FetchrVersion = FetchrVersion.FromId(dbResult.GetByte(2)),
							ShowPreviews = dbResult.GetBoolean(4),
							Seed1 = dbResult.GetInt32(5),
							Seed2 = dbResult.GetInt32(6),
							Seed3 = dbResult.GetInt32(7),
							Seed4 = dbResult.GetInt32(8),
							Seed4Credit = dbResult.IsDBNull(9) ? null : dbResult.GetString(9)
						};
					}
				}
			}
		}
	}
}
