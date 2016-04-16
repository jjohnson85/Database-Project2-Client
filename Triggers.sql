CREATE TRIGGER pr2.Increment 
ON pr2.Engineer 
AFTER INSERT AS
UPDATE pr2.Company
SET pr2.Company.totalEngineer = pr2.Company.totalEngineer + 1
WHERE pr2.Company.name IN (SELECT cName FROM inserted)

GO
CREATE TRIGGER pr2.Decrement
ON pr2.Engineer
AFTER DELETE AS
UPDATE pr2.Company
SET pr2.Company.totalEngineer = pr2.Company.totalEngineer - 1
WHERE pr2.Company.name IN (SELECT cName FROM deleted)