DROP VIEW `seeds`;

CREATE VIEW `seeds` AS
  SELECT
  `fetchr_weeks`.`prefix` AS `prefix`,
  `fetchr_weeks`.`effectivedate` AS `effectivedate`,
  `fetchr_weeks`.`effectivedateUTC` AS `effectivedateUTC`,
  `fetchr_versions`.`id` AS `fetchrversionID`,
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

UPDATE `schema` SET `version` = 4;
