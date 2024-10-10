CREATE TABLE `alertbox` (
  `path` varchar(255) NOT NULL,
  `enabled` tinyint(1) NOT NULL,
  `message` text NOT NULL
);

ALTER TABLE `alertbox` ADD PRIMARY KEY (`path`);

UPDATE `schema` SET `version` = 7;
