<?php

$dbHost = "localhost";
$dbUser = "PlayMinecraftBingo";
$dbPass = "zjNaFZu4CsipTqI7";
$dbName = "PlayMinecraftBingo";

function RenderBingoCard($seed)
{
	global $dbHost, $dbUser, $dbPass, $dbName;

	$dbConn = mysqli_connect($dbHost, $dbUser, $dbPass, $dbName);
	$dbQuery = mysqli_prepare($dbConn, "SELECT slot, identifier, label, invicon FROM cards LEFT JOIN mcitems ON cards.item = mcitems.identifier WHERE seed = ? ORDER BY slot");
	mysqli_stmt_bind_param($dbQuery, "i", $seed);
	mysqli_stmt_execute($dbQuery);
	$dbResult = mysqli_stmt_get_result($dbQuery);

	echo "<table class=\"bingocard\">";

	while ($dbRow = mysqli_fetch_assoc($dbResult))
	{
		$slot = $dbRow["slot"];
		$label = $dbRow["label"];
		$invicon = $dbRow["invicon"];

		if ($slot % 5 == 0) echo "<tr>";
		echo "<td><img src=\"../images/mc-items/Invicon_" . $invicon . "\" alt=\"" . $label . "\" title=\"" . $label . "\" /></td>";
		if ($slot % 5 == 4) echo "</tr>";
	}

	echo "</table>";

	mysqli_free_result($dbResult);
	mysqli_close($dbConn);
}

function GetCurrentPrefix()
{
	global $dbHost, $dbUser, $dbPass, $dbName;

	$dbConn = mysqli_connect($dbHost, $dbUser, $dbPass, $dbName);
	$dbResult = mysqli_query($dbConn, "SELECT prefix FROM seeds WHERE effectivedate <= UNIX_TIMESTAMP() ORDER BY effectivedate DESC LIMIT 1");

	$dbRow = mysqli_fetch_assoc($dbResult);
	return $dbRow["prefix"];

	mysqli_free_result($dbResult);
	mysqli_close($dbConn);
}

$prefix = GetCurrentPrefix();

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
$dbQuery = mysqli_prepare($dbConn, "SELECT effectivedate, fetchrversion, mcversion, seed1, seed2, seed3, seed4, seed4credit, showpreviews FROM seeds WHERE prefix = ? AND effectivedate <= UNIX_TIMESTAMP()");
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
$mcver = $dbRow["mcversion"];
$timestamp = $dbRow["effectivedate"];
$seed1 = $dbRow["seed1"];
$seed2 = $dbRow["seed2"];
$seed3 = $dbRow["seed3"];
$seed4 = $dbRow["seed4"];
$seed4credit = $dbRow["seed4credit"];
$showpreviews = $dbRow["showpreviews"];

mysqli_free_result($dbResult);
mysqli_close($dbConn);

$bingodate = gmdate("l d F Y", $timestamp);

?>
<html>
	<head>
		<title>Fetchr Weekly Challenge Seeds - <?php echo $bingodate; ?></title>
		<link rel="stylesheet" type="text/css" href="styles.css">
		<link rel="icon" type="image/png" href="../images/mc-items/Invicon_Buried_Treasure_Map.png">
	</head>
	<body>
		<p class="bingotitle">Fetchr Weekly Challenge Seeds</p>
		<p class="alertbox">Due to the large number of breaking changes announced in snapshot <a href="https://www.minecraft.net/en-us/article/minecraft-snapshot-24w09a" target="_blank">24w09a</a>, and in anticipation of the large amount of work it will likely take NeunEinser to update Fetchr to accommodate for them, <strong>the weekly seed challenges will be remaining on 1.20.2</strong> for the foreseeable future.</p>
		<p class="version">Version <?php echo $fver; ?> for Minecraft <?php echo $mcver; ?></p>
		<p class="bingodate"><?php echo $bingodate; ?></p>
		<div class="bingoseedrow">
			<?php if ($seed1 != NULL) { ?>
			<div class="bingoseed">
				<p class="bingoseedtitle">Bingo 1</p>
				<p class="bingoseednumber"><?php echo $seed1; ?></p>
				<?php if ($seed4credit != NULL) { ?><p>&nbsp;</p><?php } ?>
				<?php if ($showpreviews) RenderBingoCard($seed1); ?>
			</div>
			<?php } ?>
			<?php if ($seed2 != NULL) { ?>
			<div class="bingoseed">
				<p class="bingoseedtitle">Bingo 2</p>
				<p class="bingoseednumber"><?php echo $seed2; ?></p>
				<?php if ($seed4credit != NULL) { ?><p>&nbsp;</p><?php } ?>
				<?php if ($showpreviews) RenderBingoCard($seed2); ?>
			</div>
			<?php } ?>
			<?php if ($seed3 != NULL) { ?>
			<div class="bingoseed">
				<p class="bingoseedtitle">25 Items in 25 Minutes</p>
				<p class="bingoseednumber"><?php echo $seed3; ?></p>
				<?php if ($seed4credit != NULL) { ?><p>&nbsp;</p><?php } ?>
				<?php if ($showpreviews) RenderBingoCard($seed3); ?>
			</div>
			<?php } ?>
			<?php if ($seed4 != NULL) { ?>
			<div class="bingoseed">
				<p class="bingoseedtitle">Practice</p>
				<p class="bingoseednumber"><?php echo $seed4; ?></p>
				<?php if ($seed4credit != NULL) { ?><p>(suggested by <?php echo $seed4credit; ?>)</p><?php } ?>
				<?php if ($showpreviews) RenderBingoCard($seed4); ?>
			</div>
			<?php } ?>
		</div>
	</body>
</html>
