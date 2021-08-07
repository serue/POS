USE POS_DATABASE;

DROP TABLE IF EXISTS CATEGORY;
CREATE TABLE CATEGORY(
	ID INT IDENTITY(1,1) NOT NULL,
	CATEGORY VARCHAR(50) NOT NULL UNIQUE,
	NOTES VARCHAR(1000) NULL,
	PRIMARY KEY(ID)
);

DROP TABLE IF EXISTS INVENTORY;
CREATE TABLE INVENTORY(
	ID INT IDENTITY(1,1) NOT NULL,
	DATE DATE NOT NULL,
	CATEGORY VARCHAR(50) NULL REFERENCES CATEGORY(CATEGORY),
	BARCODE VARCHAR(50) NOT NULL UNIQUE,
	NAME VARCHAR(500) NOT NULL UNIQUE,
	QUANTITY DECIMAL(18,2) NOT NULL,
	RE_ORDER DECIMAL(18,2) NULL,
	SALE_QTY DECIMAL(18,2) NULL,
	COST DECIMAL(18,2) NOT NULL,
	PRICE DECIMAL(18,2) NOT NULL,
	MARGIN DECIMAL(18,2) NOT NULL,
	VENDOR_CODE VARCHAR(100) NULL,
	SKU VARCHAR(70) NULL,
	PRODUCT_STATUS INT NOT NULL,
	PRIMARY KEY(ID)
);

DROP TABLE IF EXISTS USERS;
CREATE TABLE USERS(
	ID INT IDENTITY(1,1) NOT NULL,
	NAME VARCHAR(255) NOT NULL,
	ID_NO VARCHAR(15) NOT NULL UNIQUE,
	ADDRESS VARCHAR(1000) NOT NULL,
	GENDER VARCHAR(50) NOT NULL,
	AGE INT NOT NULL,
	CONTACT VARCHAR(100) NOT NULL,
	USERNAME VARCHAR(500) NOT NULL UNIQUE,
	PASSWORD VARCHAR(500) NOT NULL,
	PRIMARY KEY(ID)
	);

DROP TABLE IF EXISTS M_PAYMENTS;
CREATE TABLE M_PAYMENTS(
	ID INT IDENTITY(1,1) NOT NULL,
	METHOD VARCHAR(100) NOT NULL UNIQUE,
	NOTES VARCHAR(500) NULL,
	PRIMARY KEY(ID)
	);

DROP TABLE IF EXISTS TILLS;
CREATE TABLE TILLS(
	ID INT IDENTITY(1,1) NOT NULL,
	TILL_NAME VARCHAR(100) NOT NULL UNIQUE,
	TILL_NUMBER VARCHAR(100) NOT NULL UNIQUE,
	PRIMARY KEY(ID)
	);

DROP TABLE IF EXISTS TRANSACTIONS;
CREATE TABLE TRANSACTIONS(
	ID INT IDENTITY(1,1) NOT NULL,
	TRANSACTION_ID VARCHAR(100) NOT NULL UNIQUE,
	TRANS_DATE DATETIME NOT NULL,
	TRANS_TIME VARCHAR(255) NOT NULL,
	AMOUNT DECIMAL(18,2) NOT NULL,
	PAID DECIMAL(18,2) NOT NULL,
	CHANGE DECIMAL(18,2) NOT NULL,
	TAX DECIMAL(18,2) NOT NULL,
	PAYMENT VARCHAR(100) NOT NULL REFERENCES M_PAYMENTS(METHOD),
	CASHIER VARCHAR(500) NOT NULL REFERENCES USERS(USERNAME),
	TILL VARCHAR(100) NOT NULL REFERENCES TILLS(TILL_NUMBER),
	PRIMARY KEY(ID)
	);
DROP TABLE IF EXISTS TRANS_DETAILS;
CREATE TABLE TRANS_DETAILS(
	ID INT IDENTITY(1,1) NOT NULL,
	TRANSACTION_ID VARCHAR(100) NOT NULL REFERENCES TRANSACTIONS(TRANSACTION_ID),
	BARCODE VARCHAR(50) NOT NULL REFERENCES INVENTORY(BARCODE),
	QUANTITY DECIMAL(18,2) NOT NULL,
	AMOUNT DECIMAL(18,2) NOT NULL,
	PRIMARY KEY(ID)
	);

DROP TABLE IF EXISTS USER_PERMISSIONS;
CREATE TABLE USER_PERMISSIONS(
	ID INT IDENTITY(1,1) NOT NULL,
	USERNAME VARCHAR(500) NOT NULL REFERENCES USERS(USERNAME),
	PERMISSION VARCHAR(100) NOT NULL,
	STATUS INT NOT NULL,
	PRIMARY KEY(ID)
);

DROP TABLE IF EXISTS CUSTOMERS;
CREATE TABLE CUSTOMERS(
	ID INT IDENTITY(1,1) NOT NULL,
	NAME VARCHAR(100) NOT NULL UNIQUE,
	ADDRESS VARCHAR(500) NULL,
	GENDER VARCHAR(50) NULL,
	CONTACT VARCHAR(50) NULL,
	PRIMARY KEY(ID),
	);

DROP TABLE IF EXISTS SUPPLIERS;
CREATE TABLE SUPPLIERS(
	ID INT IDENTITY(1,1) NOT NULL,
	NAME VARCHAR(100) NOT NULL UNIQUE,
	ADDRESS VARCHAR(500) NULL,
	GENDER VARCHAR(50) NULL,
	CONTACT VARCHAR(50) NULL,
	PRIMARY KEY(ID),
	);

DROP TABLE IF EXISTS PRODUCTS;
CREATE TABLE PRODUCTS(
	ID INT IDENTITY(1,1) NOT NULL,
	NAME VARCHAR(200) NOT NULL,
	SUPPLIER VARCHAR(100) NOT NULL REFERENCES SUPPLIERS(NAME),
	PRIMARY KEY(ID)
	);

DROP TABLE IF EXISTS SALES;
CREATE TABLE SALES(
	ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TRANS_DATE DATE NOT NULL,
	BARCODE VARCHAR(50) NOT NULL REFERENCES INVENTORY(BARCODE),
	QUANTITY INT NOT NULL,
	AMOUNT DECIMAL(18,2) NOT NULL,
	PROFIT DECIMAL(18,2) NOT NULL,
	SALE_TYPE VARCHAR(100) NOT NULL REFERENCES M_PAYMENTS(METHOD),
	
	);

DROP TABLE IF EXISTS SUMMARY_SALES;
CREATE TABLE SUMMARY_SALES(
	ID INT IDENTITY(1,1) NOT NULL,
	SALE_MONTH VARCHAR(100) NOT NULL,
	BARCODE VARCHAR(50) NOT NULL REFERENCES INVENTORY(BARCODE),
	QUANTITY INT NOT NULL,
	AMOUNT DECIMAL(18,2) NOT NULL,
	PROFIT DECIMAL(18,2) NOT NULL
	PRIMARY KEY(ID)
	);

DROP TABLE IF EXISTS COMPANY;
CREATE TABLE COMPANY(
	ID INT IDENTITY(1,1) NOT NULL,
	NAME VARCHAR(255) NOT NULL UNIQUE,
	TRADENAME VARCHAR(500) NULL,
	ADDRESS VARCHAR(500) NOT NULL,
	DESCRIPTION VARCHAR(2000) NOT NULL,
	CONTACT VARCHAR(100) NOT NULL,
	PRIMARY KEY(ID)
	);

DROP TABLE IF EXISTS CURRENCIES;
CREATE TABLE CURRENCIES(
	ID INT IDENTITY(1,1) NOT NULL,
	CURRENCY VARCHAR(100) NOT NULL UNIQUE,
	SYMBOL VARCHAR(50) NOT NULL,
	RATE DECIMAL(18,2) NOT NULL,
	PRIMARY KEY(ID)
	);

DROP TABLE IF EXISTS BASE_CURRENCY;
CREATE TABLE BASE_CURRENCY(
	ID INT IDENTITY(1,1) NOT NULL,
	CURRENCY VARCHAR(100) NOT NULL UNIQUE,
	SYMBOL VARCHAR(50) NOT NULL,
	PRIMARY KEY(ID)
	);

DROP TABLE IF EXISTS TAX;
CREATE TABLE TAX(
	ID INT IDENTITY PRIMARY KEY,
	COMPANY VARCHAR(255) NOT NULL REFERENCES COMPANY(NAME),
	VAT_NO VARCHAR(100) NOT NULL,
	VAT DECIMAL(18,2)  NOT NULL,
	NOTES VARCHAR(500) NOT NULL
	);

DROP TABLE IF EXISTS OTHER_METHODS;
CREATE TABLE OTHER_METHODS(
	ID INT IDENTITY PRIMARY KEY,
	TRANSACTION_ID VARCHAR(100) REFERENCES TRANSACTIONS(TRANSACTION_ID) NOT NULL,
	METHOD VARCHAR(100) REFERENCES M_PAYMENTS(METHOD) NOT NULL,
	AMOUNT DECIMAL(18,2) NOT NULL,
	);
INSERT INTO M_PAYMENTS(METHOD, NOTES) VALUES('CASH','For all cash Transaactions in the system');
INSERT INTO M_PAYMENTS(METHOD, NOTES) VALUES('CARD','For all card Transaactions in the system');
INSERT INTO M_PAYMENTS(METHOD, NOTES) VALUES('ECOCASH','For all ecocash Transaactions in the system');
INSERT INTO M_PAYMENTS(METHOD, NOTES) VALUES('FOREX','For all forex Transaactions in the system');