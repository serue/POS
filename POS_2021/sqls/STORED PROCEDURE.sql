
CREATE PROCEDURE INSERT_INVENTORY
	-- Add the parameters for the stored procedure here
	@DATE DATE,
	@CATEGORY VARCHAR(50), 
	@SUB_CATEGORY1 VARCHAR(200),
	@SUB_CATEGORY2 VARCHAR(200),
	@SUB_CATEGORY3 VARCHAR(200),
	@BARCODE VARCHAR(50) ,
	@NAME VARCHAR(500), 
	@QUANTITY DECIMAL(18,2) ,
	@RE_ORDER DECIMAL(18,2),
	@SALE_QTY DECIMAL(18,2),
	@COST DECIMAL(18,2),
	@PRICE DECIMAL(18,2),
	@W_PRICE DECIMAL(18,2),
	@W_QTY DECIMAL(18,2),
	@MARGIN DECIMAL(18,2),
	@VENDOR_CODE VARCHAR(100),
	@SKU VARCHAR(70),
	@PRODUCT_STATUS INT,
	@EXTRA1 VARCHAR(1000),
	@EXTRA2 VARCHAR(1000),
	@EXTRA3 VARCHAR(1000)	
AS
BEGIN

	INSERT INTO INVENTORY(DATE,CATEGORY,SUB_CATEGORY1,SUB_CATEGORY2,SUB_CATEGORY3,BARCODE,NAME,QUANTITY,RE_ORDER,SALE_QTY,COST,PRICE,W_PRICE,W_QTY,MARGIN,VENDOR_CODE,SKU,PRODUCT_STATUS,EXTRA1,EXTRA2,EXTRA3) VALUES(@DATE,@CATEGORY,@SUB_CATEGORY1,@SUB_CATEGORY2,@SUB_CATEGORY3,@BARCODE,@NAME,@QUANTITY,@RE_ORDER,@SALE_QTY,@COST,@PRICE,@W_PRICE,@W_QTY,@MARGIN,@VENDOR_CODE,@SKU,@PRODUCT_STATUS,@EXTRA1,@EXTRA2,@EXTRA3)

	
END
GO

CREATE PROCEDURE UPDATE_INVENTORY
	@ID INT ,
	@CATEGORY VARCHAR(50), 
	@SUB_CATEGORY1 VARCHAR(200),
	@SUB_CATEGORY2 VARCHAR(200),
	@SUB_CATEGORY3 VARCHAR(200),
	@BARCODE VARCHAR(50) ,
	@NAME VARCHAR(500), 
	@QUANTITY DECIMAL(18,2) ,
	@RE_ORDER DECIMAL(18,2),
	@SALE_QTY DECIMAL(18,2),
	@COST DECIMAL(18,2),
	@PRICE DECIMAL(18,2),
	@W_PRICE DECIMAL(18,2),
	@W_QTY DECIMAL(18,2),
	@MARGIN DECIMAL(18,2),
	@VENDOR_CODE VARCHAR(100),
	@SKU VARCHAR(70),
	@EXTRA1 VARCHAR(1000),
	@EXTRA2 VARCHAR(1000),
	@EXTRA3 VARCHAR(1000)	
AS 
BEGIN
	UPDATE INVENTORY SET CATEGORY=@CATEGORY,BARCODE=@BARCODE,NAME=@NAME,QUANTITY=@QUANTITY,RE_ORDER=@RE_ORDER,SALE_QTY=@SALE_QTY,COST=@COST,PRICE=@PRICE,MARGIN=@MARGIN,VENDOR_CODE=@VENDOR_CODE,SKU=@SKU,SUB_CATEGORY1=@SUB_CATEGORY1,SUB_CATEGORY2=@SUB_CATEGORY2,SUB_CATEGORY3=@SUB_CATEGORY3,W_PRICE=@W_PRICE,W_QTY=@W_QTY,EXTRA1=@EXTRA1,EXTRA2=@EXTRA2,EXTRA3=@EXTRA3 WHERE ID=@ID
END
GO

CREATE PROCEDURE UPDATE_INVENTORY_PRICE
	@BARCODE VARCHAR(50) ,
	@QUANTITY DECIMAL(18,2) ,
	@PRICE DECIMAL(18,2),
	@MARGIN DECIMAL(18,2)
AS 
BEGIN
	UPDATE INVENTORY SET QUANTITY=@QUANTITY,PRICE=@PRICE,MARGIN=@MARGIN WHERE BARCODE=@BARCODE
END
GO

CREATE PROCEDURE INSERT_CATEGORY
	@CATEGORY VARCHAR(50),
	@NOTES VARCHAR(1000),
	@SUB_CATEGORY1 VARCHAR(200),
	@SUB_CATEGORY2 VARCHAR(200),
	@SUB_CATEGORY3 VARCHAR(200)
AS 
BEGIN
	INSERT INTO CATEGORY(CATEGORY,NOTES,SUB_CATEGORY1,SUB_CATEGORY2,SUB_CATEGORY3) VALUES(@CATEGORY,@NOTES,@SUB_CATEGORY1,@SUB_CATEGORY2,@SUB_CATEGORY3)
END
GO

CREATE PROCEDURE UPDATE_CATEGORY
	@ID INT,
	@CATEGORY VARCHAR(50),
	@NOTES VARCHAR(1000),
	@SUB_CATEGORY1 VARCHAR(200),
	@SUB_CATEGORY2 VARCHAR(200),
	@SUB_CATEGORY3 VARCHAR(200)
AS 
BEGIN
	UPDATE CATEGORY SET CATEGORY=@CATEGORY,NOTES=@NOTES,SUB_CATEGORY1=@SUB_CATEGORY1,SUB_CATEGORY2=@SUB_CATEGORY2,SUB_CATEGORY3=@SUB_CATEGORY3 WHERE ID=@ID
END
GO

CREATE PROCEDURE INSERT_USERS
	@NAME VARCHAR(255),
	@ID_NO VARCHAR(15),
	@ADDRESS VARCHAR(1000),
	@GENDER VARCHAR(50),
	@AGE INT,
	@CONTACT VARCHAR(100),
	@EMP_ID VARCHAR(255)
AS 
BEGIN
	INSERT INTO USERS(NAME,ID_NO,ADDRESS,GENDER,AGE,CONTACT,EMP_ID) VALUES(@NAME,@ID_NO,@ADDRESS,@GENDER,@AGE,@CONTACT,@EMP_ID)
END
GO

CREATE PROCEDURE UPDATE_USERS
	@ID INT,
	@NAME VARCHAR(255),
	@ID_NO VARCHAR(15),
	@ADDRESS VARCHAR(1000),
	@GENDER VARCHAR(50),
	@AGE INT,
	@CONTACT VARCHAR(100),
	@EMP_ID VARCHAR(255)
AS 
BEGIN
	UPDATE USERS SET NAME=@NAME,ID_NO=@ID_NO,ADDRESS=@ADDRESS,GENDER=@GENDER,AGE=@AGE,CONTACT=@CONTACT,EMP_ID=@EMP_ID WHERE EMP_ID=@ID
END
GO