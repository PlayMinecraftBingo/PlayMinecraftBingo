<?php

$dbHost = "localhost";
$dbUser = "PlayMinecraftBingo";
$dbPass = "zjNaFZu4CsipTqI7";
$dbName = "PlayMinecraftBingo";

function RenderBingoCard($seed)
{
	global $dbHost, $dbUser, $dbPass, $dbName;

	$dbConn = mysqli_connect($dbHost, $dbUser, $dbPass, $dbName);
	$dbQuery = mysqli_prepare($dbConn, "SELECT slot, item FROM cards WHERE seed = ? ORDER BY slot");
	mysqli_stmt_bind_param($dbQuery, "i", $seed);
	mysqli_stmt_execute($dbQuery);
	$dbResult = mysqli_stmt_get_result($dbQuery);

	while ($dbRow = mysqli_fetch_assoc($dbResult))
	{
		$slot = $dbRow["slot"];
		$item = $dbRow["item"];

		if ($slot % 5 == 0)
		{
			if ($slot > 0) echo "\n";
			echo "\t\t\t\t";
		} else {
			echo " ";
		}
		echo "\"" . $item . "\"";
		if ($slot == 24)
		{
			echo "\n";
		} else {
			echo ",";
		}
	}

	mysqli_free_result($dbResult);
	mysqli_close($dbConn);
}

if (isset($_GET["prefix"]))
{
	if (preg_match("/^[0-9]+$/", $_GET["prefix"]))
	{
		$prefix = $_GET["prefix"];
	} else {
		echo "<p><strong>ERROR:</strong> Unknown prefix.</p>";
		exit;
	}
}

$dbConn = mysqli_connect($dbHost, $dbUser, $dbPass, $dbName);
$dbQuery = mysqli_prepare($dbConn, "SELECT fetchrversion, seed1, seed2, seed3, seed4 FROM seeds WHERE prefix = ?");
mysqli_stmt_bind_param($dbQuery, "i", $prefix);
mysqli_stmt_execute($dbQuery);
$dbResult = mysqli_stmt_get_result($dbQuery);

if (mysqli_num_rows($dbResult) < 1)
{
	echo "<p><strong>ERROR:</strong> Unknown prefix.</p>";
	exit;
}

$dbRow = mysqli_fetch_assoc($dbResult);

$fver = $dbRow["fetchrversion"];
$seed1 = $dbRow["seed1"];
$seed2 = $dbRow["seed2"];
$seed3 = $dbRow["seed3"];
$seed4 = $dbRow["seed4"];

mysqli_free_result($dbResult);
mysqli_close($dbConn);

?>
namespace libFetchrCardGen.Tests
{
	[TestClass()]
	public class CardGenerationTests<?php echo $prefix . "\n"; ?>
	{
		private readonly FetchrCardGen CardGeneration = new("<?php echo $fver; ?>");

		[TestMethod()]
		public void GenerateFromSeedTestA_<?php echo $seed1; ?>()
		{
			List<string> generatedCard = CardGeneration.GenerateFromSeed(<?php echo $seed1; ?>);
			List<string> correctCard = new()
			{
<?php RenderBingoCard($seed1); ?>
			};

			CollectionAssert.AreEqual(correctCard, generatedCard);
		}

		[TestMethod()]
		public void GenerateFromSeedTestB_<?php echo $seed2; ?>()
		{
			List<string> generatedCard = CardGeneration.GenerateFromSeed(<?php echo $seed2; ?>);
			List<string> correctCard = new()
			{
<?php RenderBingoCard($seed2); ?>
			};

			CollectionAssert.AreEqual(correctCard, generatedCard);
		}

		[TestMethod()]
		public void GenerateFromSeedTestC_<?php echo $seed3; ?>()
		{
			List<string> generatedCard = CardGeneration.GenerateFromSeed(<?php echo $seed3; ?>);
			List<string> correctCard = new()
			{
<?php RenderBingoCard($seed3); ?>
			};

			CollectionAssert.AreEqual(correctCard, generatedCard);
		}

		[TestMethod()]
		public void GenerateFromSeedTestD_<?php echo str_replace("-", "Minus", $seed4); ?>()
		{
			List<string> generatedCard = CardGeneration.GenerateFromSeed(<?php echo $seed4; ?>);
			List<string> correctCard = new()
			{
<?php RenderBingoCard($seed4); ?>
			};

			CollectionAssert.AreEqual(correctCard, generatedCard);
		}
	}
}
