CREATE TABLE `fetchr_seeds`
(
  `prefix` tinyint UNSIGNED NOT NULL,
  `card` tinyint UNSIGNED NOT NULL,
  `seed` int NOT NULL,
  `credit` varchar(255) NULL
);

ALTER TABLE `fetchr_seeds`
  ADD PRIMARY KEY (`prefix`,`card`),
  ADD UNIQUE KEY `U_seed` (`seed`);

CREATE TABLE `fetchr_weeks`
(
  `prefix` tinyint NOT NULL,
  `effectivedate` int UNSIGNED NULL,
  `effectivedateUTC` datetime GENERATED ALWAYS AS (from_unixtime(`effectivedate`)) VIRTUAL,
  `fetchrversion` varchar(255) NOT NULL DEFAULT '5.1.1',
  `mcversion` varchar(255) NOT NULL DEFAULT '1.20.2',
  `showpreviews` tinyint(1) NOT NULL DEFAULT 1
);

ALTER TABLE `fetchr_weeks`
  ADD PRIMARY KEY (`prefix`),
  ADD UNIQUE KEY `U_effectivedate` (`effectivedate`);

CREATE VIEW `seeds` AS
  SELECT 
  `fetchr_weeks`.`prefix` AS `prefix`, 
  `fetchr_weeks`.`effectivedate` AS `effectivedate`, 
  `fetchr_weeks`.`effectivedateUTC` AS `effectivedateUTC`, 
  `fetchr_weeks`.`fetchrversion` AS `fetchrversion`, 
  `fetchr_weeks`.`mcversion` AS `mcversion`, 
  `fetchr_weeks`.`showpreviews` AS `showpreviews`, 
  `s1`.`seed` AS `seed1`, 
  `s2`.`seed` AS `seed2`, 
  `s3`.`seed` AS `seed3`, 
  `s4`.`seed` AS `seed4`, 
  `s4`.`credit` AS `seed4credit` 
  FROM `fetchr_weeks`
  LEFT JOIN `fetchr_seeds` `s1` ON `fetchr_weeks`.`prefix` = `s1`.`prefix` AND `s1`.`card` = 1
  LEFT JOIN `fetchr_seeds` `s2` ON `fetchr_weeks`.`prefix` = `s2`.`prefix` AND `s2`.`card` = 2
  LEFT JOIN `fetchr_seeds` `s3` ON `fetchr_weeks`.`prefix` = `s3`.`prefix` AND `s3`.`card` = 3
  LEFT JOIN `fetchr_seeds` `s4` ON `fetchr_weeks`.`prefix` = `s4`.`prefix` AND `s4`.`card` = 4
;

CREATE TABLE `schema`
(
  `version` smallint UNSIGNED NOT NULL
);

INSERT INTO `schema` (`version`) VALUES (1);
