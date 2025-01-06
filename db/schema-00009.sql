INSERT INTO `fetchr_versions` (`id`, `name`) VALUES ('8', '5.2.1');

ALTER TABLE `fetchr_weeks`
CHANGE `fetchrversion` `fetchrversion` TINYINT UNSIGNED NOT NULL DEFAULT '8';

UPDATE `fetchr_weeks` SET `fetchrversion` = 8 WHERE `fetchrversion` = 7;

ALTER TABLE `fetchr_versions` ADD `hidden` BOOLEAN NOT NULL DEFAULT FALSE AFTER `name`; 

UPDATE `fetchr_versions` SET `hidden` = '1' WHERE `fetchr_versions`.`id` = 0; 
UPDATE `fetchr_versions` SET `hidden` = '1' WHERE `fetchr_versions`.`id` = 1; 
UPDATE `fetchr_versions` SET `hidden` = '1' WHERE `fetchr_versions`.`id` = 3; 
UPDATE `fetchr_versions` SET `hidden` = '1' WHERE `fetchr_versions`.`id` = 5; 
UPDATE `fetchr_versions` SET `hidden` = '1' WHERE `fetchr_versions`.`id` = 7; 

UPDATE `schema` SET `version` = 9;
