
CREATE DATABASE KickBlast_Judo ;

USE KickBlast_Judo ;

INSERT INTO Athlete ( Ath_Name, Age, Contact, Curr_Weight, Admin_ID, Category_ID, Plan_ID) VALUES 
( 'Nimal Perera', 20, 771234567, 78.50,8, 8,1),
( 'Ravi', 19, 771122334, 72.50,9, 9, 2),
( 'Kumar', 24, 775566778, 85.00, 10, 10, 3);

SELECT * from Athlete

SELECT * from Athlete WHERE Athlete_ID = 2;

SELECT 
    A.Athlete_ID,
    A.Ath_Name,
    A.Age,
    A.Curr_Weight,
    W.Category_Name,
    T.Plan_Name,
    AD.Name AS Admin_Name
FROM Athlete A
JOIN Weight_catagory W 
    ON A.Category_ID = W.Category_ID
JOIN Training_plan T 
    ON A.Plan_ID = T.Plan_ID
JOIN Admin AD 
    ON A.Admin_ID = AD.Admin_ID;

    COUNT(DISTINCT) ac.Register_Date) AS This_Month_Count,
    SUM(DATEDIFF(Minute, pc.Starting_Date, pc.Ending_Date)) as Total_Min_For_Private_Coaching
    

    Left join Ath_Competiton ac on ath.Athlete_ID = ac.Athlete_ID and ac.Register_Date Between '2025-12-01'
    Left join Private_coaching pc on Ath.Athlete_ID = pc.Athlete_ID and pc.Starting_Date Between '2025-09-03'

    Ath.Name,
    Ath.join_Date,
    a.Name,
    wc.Category_Name,
    p.Plan_Name,
    p.Mon_Fee;



    SELECT 
    A.Athlete_ID,
    A.Ath_Name,
    A.Age,
    A.Contact,
    A.Curr_Weight,
    M.Pay_ID,
    M.Month,
    M.Train_Fee,
    M.Pri_coach_fee,
    M.Competition_fee,
    M.Total
FROM Athlete A
INNER JOIN MonthlyPay M
    ON A.Athlete_ID = M.Athlete_ID;

UPDATE Athlete SET Curr_Weight = 80.00, Contact = 779876543 WHERE Athlete_ID = 20;

DELETE FROM Athlete WHERE Athlete_ID = 21;

INSERT INTO Training_plan ( Plan_Name, Session_Per_Week, Mon_Fee) VALUES
( 'Intermediate', 3, 1200.00),
('Beginner', 2, 1000.00),
('Elite', 5, 1500.00);

SELECT * from Training_plan

UPDATE Training_plan SET Mon_Fee = 1400.00 WHERE Plan_ID = 1;

DELETE FROM Training_plan WHERE Plan_ID = 2;

INSERT INTO Weight_catagory ( Category_Name, min_weight, max_weight) VALUES 
('Lightweight', 66, 73),
( 'Middleweight', 74, 90),
( 'Light-Middleweight', 74, 81);

SELECT 
    W.Category_ID,
    W.Category_Name,
    W.min_weight,
    W.max_weight,
    C.Competition_ID,
    C.Competition_Name,
    C.Competition_Date,
    C.Entry_Fee
FROM Weight_catagory W
INNER JOIN Competition C
    ON W.Category_ID = C.Category_ID;

SELECT * from Weight_catagory


UPDATE Weight_catagory SET max_weight = 75 WHERE Category_ID = 8;

DELETE FROM Weight_catagory WHERE Category_ID = 9;

INSERT INTO Competition ( Competition_Name, Competition_Date, Entry_Fee,Category_ID) VALUES 
( 'Monthly Judo Championship', '2026-03-14', 220.00,8),
( 'City Judo Open', '2026-04-11', 220.00, 9),
( 'National Judo Championship', '2026-05-09', 220.00, 10);

SELECT * from Competition

UPDATE Competition SET Entry_Fee = 250.00 WHERE Competition_ID = 11;

DELETE FROM Competition WHERE Competition_ID = 12;

INSERT INTO Private_coaching ( Coach_Name, Hourly_Rate)VALUES
( 'Mr. Silva', 90.50),
('Mr. John', 100.00),
('Ms.Hema ', 95.00);

SELECT * from Private_coaching

UPDATE Private_coaching SET Hourly_Rate = 100.00 WHERE Coach_ID = 1;

DELETE FROM Private_coaching WHERE Coach_ID = 2;

INSERT INTO MonthlyPay ( Month, Train_Fee, Pri_coach_fee, Competition_fee, Total, Athlete_ID)VALUES
( '2026-02-01', 1200.00, 362.00, 440.00, 2002.00, 20),
 ('2026-03-01', 1500.00, 180.00, 0.00, 1680.00, 21),
  ('2026-04-01', 1300.00, 270.00, 220.00, 1790.00, 22);

SELECT * from MonthlyPay

UPDATE MonthlyPay SET Total = 2100.00 WHERE Pay_ID = 5;

DELETE FROM MonthlyPay WHERE Pay_ID = 6;

INSERT INTO Ath_pri_coaching ( Athlete_ID, Coach_ID, Starting_Date, Ending_Date) VALUES
( 20, 1, '2026-01-01 14:00:00', '2026-01-30 15:30:00'),
( 21, 2, '2026-02-01 10:00:00', '2026-02-28 11:30:00'),
( 22, 3, '2026-03-01 16:00:00', '2026-03-30 17:30:00');

SELECT 
    A.Athlete_ID,
    A.Ath_Name,
    A.Age,
    PC.Coach_ID,
    PC.Coach_Name,
    PC.Hourly_Rate,
    APC.Starting_Date,
    APC.Ending_Date
FROM Athlete A
INNER JOIN Ath_pri_coaching APC
    ON A.Athlete_ID = APC.Athlete_ID
INNER JOIN Private_coaching PC
    ON APC.Coach_ID = PC.Coach_ID;

SELECT * from Ath_pri_coaching

UPDATE Ath_pri_coaching SET Ending_Date = '2026-04-05' WHERE Ath_pri_coach_ID = 25;

DELETE FROM Ath_pri_coaching WHERE Ath_pri_coach_ID = 26;

INSERT INTO Ath_Competiton (Register_Date, Athlete_ID, Competition_ID) VALUES
('2026-03-05', 20, 11 ),
('2026-03-05', 21, 12 ),
('2026-04-11', 22, 13 ); 

SELECT 
    A.Athlete_ID,
    A.Ath_Name,
    A.Age,
    C.Competition_ID,
    C.Competition_Name,
    C.Competition_Date,
    C.Entry_Fee,
    AC.Register_Date
FROM Athlete A
INNER JOIN Ath_Competiton AC
    ON A.Athlete_ID = AC.Athlete_ID
INNER JOIN Competition C
    ON AC.Competition_ID = C.Competition_ID;

SELECT * from Ath_Competiton

UPDATE Ath_Competiton SET Register_Date = '2026-03-06' WHERE Ath_comp_ID = 23;

DELETE FROM Ath_Competiton WHERE Ath_comp_ID = 24;

INSERT INTO Admin( Name, Contact, User_Name, Password) VALUES
( 'Kamal', 774567890, 'Kamal10', 'kamal@12'),
( 'Nadeesha', 771122334, 'Nadeesha20', 'Nadee@20'),
( 'Saman Perera', 779876543, 'saman30', 'saman@30');

SELECT * from Admin


UPDATE Admin SET Contact = 779998888 WHERE Admin_ID = 8;

DELETE FROM Admin WHERE Admin_ID = 9;


-- Athlete AS "a"  --Training_Plan AS "t"
SELECT a.Athlete_ID,a.Ath_Name,t.Plan_Name, t.Mon_Fee from Athlete a join Training_plan t
on a.Plan_ID = t.Plan_ID where a.Athlete_ID = 6;


-- Private_Coaching_For_Athlete AS "P"  -- Private_Coach AS "PC" -- Athlete AS "A"
SELECT A.Ath_Name AS Ath_Name, PC.Coach_Name AS Coach_Name, P.Starting_Date, P.Ending_Date,
DATEDIFF (MINUTE, P.Starting_Date, P.Ending_Date) AS Total_MINUTES, Hourly_Rate
FROM Ath_pri_coaching P INNER JOIN Private_coaching PC ON P.Coach_ID = PC.Coach_ID
INNER JOIN Athlete A ON P.Athlete_ID = A.Athlete_ID WHERE P.Athlete_ID = 6
AND P.Starting_Date BETWEEN '2025-01-01' AND '2026-01-30' ORDER BY P.Starting_Date;


-- Competition_Register AS "CR"   --Competition AS "C"  -- Athlete AS "A" 
SELECT CR.Athlete_ID, A.Ath_Name AS Ath_Name, CR.Register_Date, C.Competition_Name, C.Entry_Fee
FROM Ath_Competiton CR INNER JOIN Competition C ON CR.Competition_ID = C.Competition_ID INNER JOIN Athlete A
ON CR.Athlete_ID = A.Athlete_ID WHERE CR.Athlete_ID = 6 AND CR.Register_Date
BETWEEN '2025-01-01' AND '2026-03-30' ORDER BY CR.Register_Date;


-- 1. Delete child tables first
DELETE FROM Ath_Competiton;
DELETE FROM Ath_pri_coaching;
DELETE FROM MonthlyPay;

-- 2. Delete parent table data
DELETE FROM Athlete;

DELETE FROM Competition;
DELETE FROM Private_coaching;
DELETE FROM Training_plan;
DELETE FROM Weight_catagory;
DELETE FROM Admin;