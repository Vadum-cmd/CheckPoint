-- DROP DATABASE warehouse_db;
CREATE DATABASE warehouse_db;

/*
DROP TABLE employee_session;
DROP TABLE employee;
DROP TABLE employee_permission;
DROP TABLE sale_statistic;
DROP TABLE product_receipt;
DROP TABLE product_invoice;
DROP TABLE invoice;
DROP TABLE receipt;
DROP TABLE action;
DROP TABLE product;
*/

CREATE TABLE warehouse_db.product (
	id INT UNIQUE NOT NULL,
    name VARCHAR(255),
    price FLOAT,
    category VARCHAR(64),
    description VARCHAR(1024),
    date_manufacture DATE,
    date_expiration DATE,
    in_stock INT,
    
    PRIMARY KEY (id)
);

CREATE TABLE warehouse_db.action (
	id INT UNIQUE NOT NULL,
    product_id INT NOT NULL,
    discount FLOAT(3),
    date_from DATE,
    date_to DATE,
    amount INT,
    
    FOREIGN KEY (product_id) REFERENCES product(id),
    PRIMARY KEY (id)
);

CREATE TABLE warehouse_db.receipt (
	id INT UNIQUE NOT NULL,
    total_price FLOAT,
    date_of DATETIME,
    
    PRIMARY KEY (id)    
);

CREATE TABLE warehouse_db.invoice (
	id INT UNIQUE NOT NULL,
    date_of DATETIME,
    provider VARCHAR(255),
    total_price FLOAT,
    
    PRIMARY KEY (id)    
);

CREATE TABLE warehouse_db.product_receipt (
	receipt_id INT NOT NULL,
    product_id INT NOT NULL,
    amount INT,
    price FLOAT,
    action_id INT NOT NULL,
    
    FOREIGN KEY (receipt_id) REFERENCES receipt(id),
    FOREIGN KEY (product_id) REFERENCES product(id),
    FOREIGN KEY (action_id) REFERENCES action(id),
    CONSTRAINT PK_product_receipt PRIMARY KEY (receipt_id, product_id)
);

CREATE TABLE warehouse_db.product_invoice (
	invoice_id INT NOT NULL,
    product_id INT NOT NULL,
    amount INT,
    
    FOREIGN KEY (invoice_id) REFERENCES invoice(id),
    FOREIGN KEY (product_id) REFERENCES product(id),
    CONSTRAINT PK_product_invoice PRIMARY KEY (invoice_id, product_id)
);

CREATE TABLE warehouse_db.sale_statistic (
	id INT UNIQUE NOT NULL,
    product_id INT NOT NULL,
    sold_out INT,
    sale_date DATETIME,
    expired INT,
    
    FOREIGN KEY (product_id) REFERENCES product(id),
    PRIMARY KEY (id)
);

CREATE TABLE warehouse_db.employee_permission (
	id INT UNIQUE NOT NULL,
    title VARCHAR(64),
    acts json,
    
    PRIMARY KEY (id)
);

CREATE TABLE warehouse_db.employee (
	id INT UNIQUE NOT NULL,
    name VARCHAR(64),
    surname VARCHAR(64),
    position VARCHAR(64),
    login VARCHAR(64),
    password VARCHAR(64),
    employee_permission_id INT NOT NULL,
    
    FOREIGN KEY (employee_permission_id) REFERENCES employee_permission(id),
    PRIMARY KEY (id)
);

CREATE TABLE warehouse_db.employee_session (
	id INT UNIQUE NOT NULL,
    employee_id INT NOT NULL,
    time DATETIME,
    
    FOREIGN KEY (employee_id) REFERENCES employee(id),
    PRIMARY KEY (id)
);