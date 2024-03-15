
CREATE TABLE Sale_Item (
    Sale_Item_Num    NUMBER(20) NOT NULL,
    Sale_Item_State  VARCHAR2(50) NOT NULL,
    Item_Price       NUMBER(20) NOT NULL,
    Sale_Item_Name VARCHAR2(50) NOT NULL,
    CONSTRAINT PK_Sale_Item PRIMARY KEY (Sale_Item_Num, Item_Price)
);


CREATE TABLE Stock_Manage (
    Stock_Item_Num NUMBER(20) NOT NULL,
    Sale_Item_Num NUMBER(20) NOT NULL,
    Item_Price NUMBER(20) NOT NULL,
    Stock_Item_Name VARCHAR2(50) NOT NULL,
    CONSTRAINT Stock_Manage_PK PRIMARY KEY (Stock_Item_Num, Sale_Item_Num, Item_Price)
);


CREATE TABLE OrderDetails (
    Sale_Item_Num   NUMBER(20) NOT NULL,
    Payment_Method  VARCHAR2(50) NOT NULL,
    Order_Num       NUMBER(20) NOT NULL,
    Order_Time      DATE,
    Item_Name       VARCHAR2(50) NOT NULL,
    Order_Request   VARCHAR2(50) NOT NULL,
    Item_Quantity   NUMBER(20) NOT NULL,
    Item_Price      NUMBER(20) NOT NULL,
    PRIMARY KEY (Sale_Item_Num, Payment_Method, Order_Num, Item_Price, Item_Quantity),
    FOREIGN KEY (Sale_Item_Num, Item_Price) REFERENCES Sale_Item (Sale_Item_Num, Item_Price) ON DELETE CASCADE
);


CREATE TABLE Payment_Record (
    Payment_Method    VARCHAR2(50),
    Sale_Item_Num    NUMBER(20) NOT NULL,
    Order_Num    NUMBER(20) NOT NULL,
    Total_Amount    NUMBER(20),
    Item_Quantity    NUMBER(20),
    Item_Price    NUMBER(20),
    PRIMARY KEY (Sale_Item_Num, Order_Num),
    FOREIGN KEY (Sale_Item_Num, Item_Price, Item_Quantity, Payment_Method, Order_Num) REFERENCES OrderDetails (Sale_Item_Num, Item_Price, Item_Quantity, Payment_Method, Order_Num) ON DELETE CASCADE
);

CREATE TABLE Revenue_item (
    Revenue_Item_Num    VARCHAR2(50),
    Revenue_Item_Name   VARCHAR2(50),
    Revenue_Date        DATE,
    Total_Revenue       NUMBER(20),
    Sale_Item_Num       NUMBER(20) NOT NULL,
    Payment_Method      VARCHAR2(50) NOT NULL,
    Order_Num           NUMBER(20) NOT NULL,
    Item_Quantity       NUMBER(20) NOT NULL,
    Item_Price          NUMBER(20) NOT NULL,
    PRIMARY KEY (Revenue_Item_Num, Sale_Item_Num, Payment_Method, Order_Num, Item_Quantity, Item_Price),
    FOREIGN KEY (Sale_Item_Num, Item_Price, Item_Quantity, Payment_Method, Order_Num)
        REFERENCES OrderDetails (Sale_Item_Num, Item_Price, Item_Quantity, Payment_Method, Order_Num) ON DELETE CASCADE
);


commit;

INSERT INTO Sale_Item (Sale_Item_Num, Sale_Item_State, Item_Price,Sale_Item_Name)
VALUES (1, '판매가능', 3000,'아메리카노');

INSERT INTO Sale_Item (Sale_Item_Num, Sale_Item_State, Item_Price,Sale_Item_Name)
VALUES (2, '판매가능', 3500,'카페라떼');

INSERT INTO Sale_Item (Sale_Item_Num, Sale_Item_State, Item_Price,Sale_Item_Name)
VALUES (3, '판매가능', 4000,'카페모카');

INSERT INTO Sale_Item (Sale_Item_Num, Sale_Item_State, Item_Price,Sale_Item_Name)
VALUES (4, '판매가능', 4000,'카푸치노');

INSERT INTO Sale_Item (Sale_Item_Num, Sale_Item_State, Item_Price,Sale_Item_Name)
VALUES (5, '판매가능', 4000,'바닐라라떼');

INSERT INTO Sale_Item (Sale_Item_Num, Sale_Item_State, Item_Price,Sale_Item_Name)
VALUES (6, '판매가능', 6000,'초코라떼');



INSERT INTO Stock_Manage (Stock_Item_Num, Sale_Item_Num, Item_Price, Stock_Item_Name)
VALUES (1, 1, 3000, '원두');

INSERT INTO Stock_Manage (Stock_Item_Num, Sale_Item_Num, Item_Price, Stock_Item_Name)
VALUES (2, 2, 3500, '우유');

INSERT INTO Stock_Manage (Stock_Item_Num, Sale_Item_Num, Item_Price, Stock_Item_Name)
VALUES (2, 3, 4000, '우유');

INSERT INTO Stock_Manage (Stock_Item_Num, Sale_Item_Num, Item_Price, Stock_Item_Name)
VALUES (2, 4, 4000, '우유');

INSERT INTO Stock_Manage (Stock_Item_Num, Sale_Item_Num, Item_Price, Stock_Item_Name)
VALUES (2, 5, 4000, '우유');

INSERT INTO Stock_Manage (Stock_Item_Num, Sale_Item_Num, Item_Price, Stock_Item_Name)
VALUES (2, 6, 6000, '우유');

INSERT INTO Stock_Manage (Stock_Item_Num, Sale_Item_Num, Item_Price, Stock_Item_Name)
VALUES (3, 3, 4000, '모카시럽');

INSERT INTO Stock_Manage (Stock_Item_Num, Sale_Item_Num, Item_Price, Stock_Item_Name)
VALUES (4, 5, 4000, '바닐라시럽');

INSERT INTO Stock_Manage (Stock_Item_Num, Sale_Item_Num, Item_Price, Stock_Item_Name)
VALUES (5, 6, 6000, '초코파우더');

commit;
