UPDATE `fetchr_weeks` SET `fetchrversion` = 4 WHERE `fetchrversion` = '5.1.1';

ALTER TABLE `fetchr_weeks`
CHANGE `fetchrversion` `fetchrversion` TINYINT UNSIGNED NOT NULL DEFAULT '4';

CREATE TABLE `fetchr_versions`
(
  `id` TINYINT UNSIGNED NOT NULL,
  `name` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE `U_name` (`name`)
)
ENGINE = InnoDB COMMENT='Must match the Enum defined in libFetchrVersion';

INSERT INTO `fetchr_versions` (`id`, `name`) VALUES ('0', 'Unknown');
INSERT INTO `fetchr_versions` (`id`, `name`) VALUES ('1', '5.0');
INSERT INTO `fetchr_versions` (`id`, `name`) VALUES ('2', '5.0.1');
INSERT INTO `fetchr_versions` (`id`, `name`) VALUES ('3', '5.1');
INSERT INTO `fetchr_versions` (`id`, `name`) VALUES ('4', '5.1.1');
INSERT INTO `fetchr_versions` (`id`, `name`) VALUES ('5', '5.1.2');

DROP VIEW `seeds`;

CREATE VIEW `seeds` AS
  SELECT
  `fetchr_weeks`.`prefix` AS `prefix`,
  `fetchr_weeks`.`effectivedate` AS `effectivedate`,
  `fetchr_weeks`.`effectivedateUTC` AS `effectivedateUTC`,
  `fetchr_versions`.`name` AS `fetchrversion`,
  `fetchr_weeks`.`mcversion` AS `mcversion`,
  `fetchr_weeks`.`showpreviews` AS `showpreviews`,
  `s1`.`seed` AS `seed1`,
  `s2`.`seed` AS `seed2`,
  `s3`.`seed` AS `seed3`,
  `s4`.`seed` AS `seed4`,
  `s4`.`credit` AS `seed4credit`
  FROM `fetchr_weeks`
  LEFT JOIN `fetchr_versions` ON `fetchr_weeks`.`fetchrversion` = `fetchr_versions`.`id`
  LEFT JOIN `fetchr_seeds` `s1` ON `fetchr_weeks`.`prefix` = `s1`.`prefix` AND `s1`.`card` = 1
  LEFT JOIN `fetchr_seeds` `s2` ON `fetchr_weeks`.`prefix` = `s2`.`prefix` AND `s2`.`card` = 2
  LEFT JOIN `fetchr_seeds` `s3` ON `fetchr_weeks`.`prefix` = `s3`.`prefix` AND `s3`.`card` = 3
  LEFT JOIN `fetchr_seeds` `s4` ON `fetchr_weeks`.`prefix` = `s4`.`prefix` AND `s4`.`card` = 4
;

UPDATE `schema` SET `version` = 3;
