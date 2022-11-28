CREATE DATABASE manage_coffee;
GO

USE manage_coffee
GO

-- Create table Account
CREATE TABLE account
(
id INT IDENTITY(1,1) PRIMARY KEY,
user_name NVARCHAR(100) NOT NULL,
pass_word NVARCHAR(100) NOT NULL,
isDelete BIT NOT NULL DEFAULT 0,
account_type BIT NOT NULL
);
GO


/* Password: 123456 */
INSERT INTO ACCOUNT (user_name, pass_word, account_type) 
VALUES ('admin', 'crMWTjzo8CJqg9kXzGRVddhSy/zRr9+2JmD8YAc1oO8=', 1),
('staff', 'crMWTjzo8CJqg9kXzGRVddhSy/zRr9+2JmD8YAc1oO8=', 0)
GO


-- create table PEOPLE_INFO
CREATE TABLE people_info
(
id INT IDENTITY(1,1) PRIMARY KEY,
account_id INT NOT NULL,
name NVARCHAR(50) NOT NULL, 
gender BIT,
address NVARCHAR(200),
phone_number NVARCHAR(20),
email NVARCHAR(30),
FOREIGN KEY (account_id) REFERENCES account(id)
)
GO

-- create table FOOD_TYPE
CREATE TABLE food_type
(
id INT IDENTITY(1,1) PRIMARY KEY,
name NVARCHAR(100) NOT NULL,
isDelete BIT DEFAULT 0
)
GO

-- create table FOOD 
CREATE TABLE food 
(
id INT IDENTITY(1,1) PRIMARY KEY,
name NVARCHAR(100) NOT NULL,
price FLOAT,
food_type_id INT NOT NULL,
isDelete BIT DEFAULT 0,
FOREIGN KEY (food_type_id) REFERENCES food_type(id)
)
GO

CREATE TABLE coffee_table
(
id INT IDENTITY(1,1) PRIMARY KEY,
name NVARCHAR(20) NOT NULL,
status NVARCHAR(100) NOT NULL CHECK (status IN (N'Trống', N'Đang có khách')) DEFAULT N'Trống',
isDelete BIT DEFAULT 0
)
GO

CREATE TABLE bill
(
id INT IDENTITY(1,1) PRIMARY KEY,
table_id INT NOT NULL,
account_id INT ,
bill_date DATE,
discount INT,
FOREIGN KEY (table_id) REFERENCES coffee_table(id),
FOREIGN KEY (account_id) REFERENCES account(id)
)
GO

CREATE TABLE bill_info
(
id INT PRIMARY KEY IDENTITY(1,1),
bill_id INT NOT NULL,
food_id INT NOT NULL,
amount INT,
total FLOAT
FOREIGN KEY (bill_id) REFERENCES bill(id),
FOREIGN KEY (food_id) REFERENCES food(id)
)
GO

CREATE PROC usp_get_table_list
AS 
BEGIN 
SELECT id, name, status FROM coffee_table WHERE isDelete = 0;
END;
GO

CREATE PROC usp_get_foods_list
AS SELECT id, name, food_type_id, price FROM food WHERE isDelete = 0;
GO

CREATE PROC usp_get_food_type_list
AS SELECT id, name FROM food_type WHERE isDelete = 0;
GO

EXEC usp_get_table_list
EXEC usp_get_foods_list
GO

EXEC usp_get_food_type_list


CREATE PROC delete_account
@id INT
AS
BEGIN
	UPDATE account SET isDelete = 1 WHERE id = @id;
END;
GO

CREATE PROC delete_people_info
@account_id INT
AS
BEGIN
	DELETE FROM people_info WHERE account_id = @account_id;
END;
GO

CREATE PROC add_account
@user_name NVARCHAR(50),
@pass_word NVARCHAR(50),
@account_type BIT
AS
	BEGIN
		INSERT INTO account(user_name, pass_word, account_type) VALUES (@user_name, @pass_word, @account_type);
	END
GO

CREATE PROC add_people_info
@name NVARCHAR(50),
@gender BIT,
@address NVARCHAR(50),
@phone_number NVARCHAR(50),
@email NVARCHAR(50)
AS
	BEGIN
		DECLARE @account_id INT
		SELECT @account_id = id FROM ACCOUNT WHERE id = (SELECT Max(id) FROM ACCOUNT)
		INSERT INTO PEOPLE_INFO VALUES (@account_id, @name, @gender, @address, @phone_number, @email);
	END
GO

CREATE PROC get_all_account
AS
	BEGIN
		Select id, user_name, pass_word, account_type from account WHERE isDelete = 0;
	END
GO

CREATE PROC get_all_people_info
AS
	BEGIN
		SELECT * FROM people_info
	END
GO

CREATE PROC edit_account
@id INT,
@user_name NVARCHAR(50),
@account_type BIT
AS
	BEGIN
		UPDATE account SET user_name = @user_name, account_type = @account_type WHERE id = @ID;
	END;
GO

CREATE PROC edit_people_info
@account_id INT,
@name NVARCHAR(50),
@gender BIT,
@address NVARCHAR(50),
@phone_number NVARCHAR(50),
@email NVARCHAR(50)
AS
	BEGIN
		UPDATE people_info SET name = @name, gender = @gender, address = @address, 
		phone_number = @phone_number, email = @email 
		WHERE account_id = @account_id;
	END
GO

CREATE PROC get_all_account_by_user_name
@user_name NVARCHAR(50)
AS
BEGIN
	SELECT account.id, user_name, pass_word, account_type FROM account  WHERE user_name LIKE '%'+@user_name+'%' AND isDelete = 0;
END;
GO

CREATE PROC get_people_info_by_account_id
@account_id INT
AS
BEGIN
	SELECT * FROM people_info WHERE account_id = @account_id
END;
GO

CREATE PROC change_pass_word_account
@id INT,
@pass_word NVARCHAR(50)
AS
	BEGIN
		UPDATE account SET pass_word = @pass_word WHERE id = @id
	END
GO
	
CREATE PROC change_email_people_info
@ID INT,
@EM NVARCHAR(50)
AS
	BEGIN
		UPDATE people_info SET email = @EM WHERE id = @ID
	END
GO

CREATE PROC get_bill_info
@ID INT
AS
SELECT name, amount, total FROM bill_info INNER JOIN FOOD ON bill_info.food_id = food.id WHERE bill_id = @ID
GO

EXEC get_bill_info @ID = 1

CREATE TRIGGER calculate_total_money
ON bill_info
FOR INSERT, UPDATE
AS
	UPDATE bill_info
	SET total = amount * food.price
	FROM bill_info INNER JOIN FOOD ON bill_info.food_id = food.id;

CREATE PROC calculate_percentage
AS
	BEGIN
		SELECT food_type.name,CAST(COUNT(food_type_id)*100.0/(SELECT COUNT(*) FROM food) AS DECIMAL(16,2)) AS percentage
		FROM food_type INNER JOIN food ON food_type.id = food.food_type_id
		GROUP BY food_type.name
	END
GO
--top 5 mon ban chay nhat trong mot thang
CREATE PROC calculate_percentage1
@year INT,
@month INT
AS
	BEGIN
		select top(5) food.name, sum(amount) as 'count'
		from bill_info inner join bill on bill_info.bill_id = bill.id 
		inner join food on food.id = bill_info.food_id 
		where YEAR(bill_date)=@year AND MONTH(bill_date) = @month
		group by food.name
	END
GO
--lay ra tung doanh thu cua tung ngay
CREATE PROC calculate_percentage2
@year INT,
@month INT
AS
	BEGIN
		select DAY(bill_date) as 'day',sum(total) as 'count'
		from bill_info inner join bill on bill_info.bill_id = bill.id
		where YEAR(bill_date) = @year and MONTH(bill_date) = @month
		group by bill_date
	END
GO
--tong so mon ban duoc trong mot thang
CREATE PROC calculate_percentage3
@year INT,
@month INT
AS
	BEGIN
		select sum(amount) as count
		from bill_info inner join bill on bill_info.bill_id = bill.id 
		where YEAR(bill_date)=@year AND MONTH(bill_date) = @month
	END
GO
--tong doanh thu trong mot thang
CREATE PROC calculate_percentage4
@year INT,
@month INT
AS
	BEGIN
		select sum(total) as count
		from bill_info inner join bill on bill_info.bill_id = bill.id 
		where YEAR(bill_date)=@year AND MONTH(bill_date) = @month
	END
GO
--tong so hoa don ban ra trong mot thang
CREATE PROC calculate_percentage5
@year INT,
@month INT
AS
	BEGIN
		select count(bill.id) as count
		from bill
		where YEAR(bill_date)=@year AND MONTH(bill_date) = @month
	END
GO

CREATE PROC get_bill
AS
	BEGIN
		Select * from bill
	END
GO  

