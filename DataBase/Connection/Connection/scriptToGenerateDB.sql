CREATE TABLE IF NOT EXISTS `employee` (
	`id` int NOT NULL AUTO_INCREMENT,
	`name` varchar(64) NOT NULL,
	`surname` varchar(64) NOT NULL,
	`position` varchar(64) NOT NULL,
	`login` varchar(64) NOT NULL UNIQUE,
	`password` varchar(64) NOT NULL,
	`employee_permission_id` int NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `employee_session` (
	`id` int NOT NULL AUTO_INCREMENT,
	`employee_id` int NOT NULL,
	`time` DATETIME NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `product` (
	`id` int NOT NULL AUTO_INCREMENT,
	`name` varchar(255) NOT NULL,
	`price` FLOAT NOT NULL,
	`category` varchar(64) NOT NULL,
	`description` varchar(1024),
	`date_manufacture` DATE NOT NULL,
	`date_expiration` DATE NOT NULL,
	`in_stock` int NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `sale_statistic` (
	`id` int NOT NULL AUTO_INCREMENT,
	`product_id` int NOT NULL UNIQUE,
	`sold_out` int NOT NULL,
	`sale_date` DATETIME NOT NULL,
	`expired` int,
	PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `action` (
	`id` int NOT NULL AUTO_INCREMENT,
	`product_id` int NOT NULL UNIQUE,
	`discount` FLOAT(3) NOT NULL,
	`date_from` DATE NOT NULL,
	`date_to` DATE NOT NULL,
	`amount` int NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `invoice` (
	`id` int NOT NULL AUTO_INCREMENT,
	`date_of` DATETIME NOT NULL,
	`provider` varchar(255) NOT NULL,
	`total_price` int NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `product_invoice` (
	`invoice_id` int NOT NULL,
	`product_id` int NOT NULL,
	`amount` int NOT NULL,
	PRIMARY KEY (`invoice_id`,`product_id`)
);

CREATE TABLE IF NOT EXISTS `employee_permission` (
	`id` int NOT NULL AUTO_INCREMENT,
	`title` varchar(64) NOT NULL UNIQUE,
	`acts` json NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `receipt` (
	`id` int NOT NULL AUTO_INCREMENT,
	`total_price` FLOAT NOT NULL,
	`date_of` DATETIME NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `product_receipt` (
	`receipt_id` int NOT NULL,
	`product_id` int NOT NULL,
	`amount` int NOT NULL,
	`price` FLOAT NOT NULL,
	`action_id` int NOT NULL,
	PRIMARY KEY (`receipt_id`,`product_id`)
);

ALTER TABLE `employee` ADD CONSTRAINT `employee_fk0` FOREIGN KEY (`employee_permission_id`) REFERENCES `employee_permission`(`id`);

ALTER TABLE `employee_session` ADD CONSTRAINT `employee_session_fk0` FOREIGN KEY (`employee_id`) REFERENCES `employee`(`id`);

ALTER TABLE `sale_statistic` ADD CONSTRAINT `sale_statistic_fk0` FOREIGN KEY (`product_id`) REFERENCES `product`(`id`);

ALTER TABLE `action` ADD CONSTRAINT `action_fk0` FOREIGN KEY (`product_id`) REFERENCES `product`(`id`);

ALTER TABLE `product_invoice` ADD CONSTRAINT `product_invoice_fk0` FOREIGN KEY (`invoice_id`) REFERENCES `invoice`(`id`);

ALTER TABLE `product_invoice` ADD CONSTRAINT `product_invoice_fk1` FOREIGN KEY (`product_id`) REFERENCES `product`(`id`);

ALTER TABLE `product_receipt` ADD CONSTRAINT `product_receipt_fk0` FOREIGN KEY (`receipt_id`) REFERENCES `receipt`(`id`);

ALTER TABLE `product_receipt` ADD CONSTRAINT `product_receipt_fk1` FOREIGN KEY (`product_id`) REFERENCES `product`(`id`);

ALTER TABLE `product_receipt` ADD CONSTRAINT `product_receipt_fk2` FOREIGN KEY (`action_id`) REFERENCES `action`(`id`);
