CREATE TABLE `minecraft_versions` (
  `id` tinyint UNSIGNED NOT NULL,
  `name` varchar(255) NOT NULL
) COMMENT='Must match the Enum defined in libMinecraftVersion';

ALTER TABLE `minecraft_versions`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `U_name` (`name`);

INSERT INTO `minecraft_versions` (`id`, `name`) VALUES(0, 'Unknown');
INSERT INTO `minecraft_versions` (`id`, `name`) VALUES(1, '1.16.5');
INSERT INTO `minecraft_versions` (`id`, `name`) VALUES(2, '1.20.2');
INSERT INTO `minecraft_versions` (`id`, `name`) VALUES(3, '1.20.6');
INSERT INTO `minecraft_versions` (`id`, `name`) VALUES(4, '1.21');
INSERT INTO `minecraft_versions` (`id`, `name`) VALUES(5, '1.21.1');
INSERT INTO `minecraft_versions` (`id`, `name`) VALUES(6, '1.21.2');
INSERT INTO `minecraft_versions` (`id`, `name`) VALUES(7, '1.21.3');
INSERT INTO `minecraft_versions` (`id`, `name`) VALUES(8, '1.21.4');

INSERT INTO `fetchr_versions` (`id`, `name`) VALUES ('7', '5.2');

UPDATE `fetchr_weeks` SET `mcversion` = 2 WHERE `mcversion` = '1.20.2';
UPDATE `fetchr_weeks` SET `mcversion` = 3 WHERE `mcversion` = '1.20.6';

ALTER TABLE `fetchr_weeks`
CHANGE `fetchrversion` `fetchrversion` TINYINT UNSIGNED NOT NULL DEFAULT '7';

ALTER TABLE `fetchr_weeks`
CHANGE `mcversion` `mcversion` TINYINT UNSIGNED NOT NULL DEFAULT '8';

CREATE OR REPLACE VIEW `seeds` AS
  SELECT
  `fetchr_weeks`.`prefix` AS `prefix`,
  `fetchr_weeks`.`effectivedate` AS `effectivedate`,
  `fetchr_weeks`.`effectivedateUTC` AS `effectivedateUTC`,
  `fetchr_versions`.`id` AS `fetchrversionID`,
  `fetchr_versions`.`name` AS `fetchrversion`,
  `minecraft_versions`.`id` AS `mcversionID`,
  `minecraft_versions`.`name` AS `mcversion`,
  `fetchr_weeks`.`showpreviews` AS `showpreviews`,
  `s1`.`seed` AS `seed1`,
  `s2`.`seed` AS `seed2`,
  `s3`.`seed` AS `seed3`,
  `s4`.`seed` AS `seed4`,
  `s4`.`credit` AS `seed4credit`
  FROM `fetchr_weeks`
  LEFT JOIN `fetchr_versions` ON `fetchr_weeks`.`fetchrversion` = `fetchr_versions`.`id`
  LEFT JOIN `minecraft_versions` ON `fetchr_weeks`.`mcversion` = `minecraft_versions`.`id`
  LEFT JOIN `fetchr_seeds` `s1` ON `fetchr_weeks`.`prefix` = `s1`.`prefix` AND `s1`.`card` = 1
  LEFT JOIN `fetchr_seeds` `s2` ON `fetchr_weeks`.`prefix` = `s2`.`prefix` AND `s2`.`card` = 2
  LEFT JOIN `fetchr_seeds` `s3` ON `fetchr_weeks`.`prefix` = `s3`.`prefix` AND `s3`.`card` = 3
  LEFT JOIN `fetchr_seeds` `s4` ON `fetchr_weeks`.`prefix` = `s4`.`prefix` AND `s4`.`card` = 4
;

UPDATE `schema` SET `version` = 8;
