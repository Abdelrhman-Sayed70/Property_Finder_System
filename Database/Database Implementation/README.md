# Database Script
```sql
DROP TABLE Current_Users;
DROP TABLE In_market_properties;
DROP TABLE Properties;
DROP TABLE Users;

CREATE TABLE Users (
user_id NUMBER(7) PRIMARY KEY,
user_name VARCHAR2(14) UNIQUE NOT NULL,
user_email VARCHAR2(30) UNIQUE NOT NULL,
user_type VARCHAR2(14) NOT NULL,
user_phone_number VARCHAR2(11) NOT NULL,
user_password VARCHAR2(14) NOT NULL,
user_balance Number(10) NOT NULL CHECK (user_balance>=0)
);

CREATE TABLE Properties (
property_id NUMBER(7) PRIMARY KEY,
property_name VARCHAR2(14) NOT NULL,
property_location VARCHAR2(14) NOT NULL,
property_cost NUMBER(7) CHECK (property_cost>0),
market_status VARCHAR2(14) NOT NULL,
current_status VARCHAR2(1) NOT NULL,
no_rooms NUMBER(7) CHECK (no_rooms>0),
user_id NUMBER(7) REFERENCES Users (user_id)
);

CREATE TABLE In_market_properties(
reservation_id NUMBER(7) PRIMARY KEY,
start_date DATE,
end_date DATE,
traveler_id NUMBER(7) REFERENCES Users (user_id),
property_id NUMBER(7) REFERENCES Properties (property_id)
);

CREATE TABLE Current_Users (
user_id NUMBER(7) PRIMARY KEY REFERENCES Users (user_id)
);

commit;
```

# Database Procedures
```sql
create or replace
PROCEDURE getBalance (userId in number, userbalance out NUMBER)
as
begin
select user_balance
into userbalance
from users
where user_id = userid;
end;
```

```sql
create or replace
PROCEDURE getPropsOnLoad(props out sys_refcursor)
as
begin
open props for 
select *
from properties
WHERE current_status = 'y';
end;
```

```sql
create or replace
PROCEDURE getCurrentUser(currentId out Number)
as
begin
SELECT user_id
into currentid
from current_users;
exception
       when no_data_found then
         currentId := -1;
end;
```

```sql
create or replace PROCEDURE logout
as
begin
delete from current_users;
end;
```

```sql
create or replace PROCEDURE getUserID
(mxid out NUMBER)
as
begin
  select max(user_id)
  into mxid
  from users;
end;
```

```sql
CREATE PROCEDURE GetUserById
    (userEmail OUT NUMBER, userID OUT VARCHAR2, userName OUT VARCHAR2 , userPassword OUT VARCHAR2) 
AS
BEGIN
    SELECT USER_ID, USER_NAME , USER_PASSWORD into userID, userName ,userPassword FROM users WHERE USER_EMAIL =    userEmail;
END;
```

```sql
create or replace PROCEDURE getPropertyID
(mxid out NUMBER)
as
begin
  select max(property_id)
  into mxid
  from properties;
end;
```

```sql
create or replace PROCEDURE GetReservationID
(mxid out NUMBER)
as
begin
  select max(reservation_id)
  into mxid
  from in_market_properties;
end;
```
