INSERT INTO `fetchr_versions` (`id`, `name`) VALUES ('6', '5.1.3');

UPDATE `fetchr_weeks` SET `fetchrversion` = 6, `mcversion` = '1.20.6' WHERE `prefix` >= 40;

UPDATE `schema` SET `version` = 5;
