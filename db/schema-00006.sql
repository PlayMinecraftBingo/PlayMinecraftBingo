CREATE TABLE fbtm_events (
  `id` int UNSIGNED NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `event_type` tinyint UNSIGNED NOT NULL DEFAULT '0',
  `seed` int NOT NULL DEFAULT '0',
  `team` varchar(255) DEFAULT NULL,
  `player` varchar(255) DEFAULT NULL,
  `item` varchar(255) DEFAULT NULL,
  `state` tinyint UNSIGNED NOT NULL DEFAULT '0'
);

ALTER TABLE `fbtm_events`
  ADD PRIMARY KEY (`id`),
  ADD KEY `I_event_type` (`event_type`),
  ADD KEY `I_seed` (`seed`),
  ADD KEY `I_team` (`team`),
  ADD KEY `I_state` (`state`);

ALTER TABLE `fbtm_events`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT;

UPDATE `schema` SET `version` = 6;
