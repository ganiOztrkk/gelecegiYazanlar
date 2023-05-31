--hangi siparişi 
--hangi müşteri, ne zaman vermiş
--hangi çalışan onaylamış
--hangi kargo şirketiyle gonderilmis
--bu siparişte hangi tedarikçiden 
--hangi kategoriden
--ve kaç adet ürün alınmış
--ne kadar ödenmiş
select 
od.OrderID,
cus.CompanyName as 'Müşteri',
OrderDate,
emp.FirstName + ' ' + emp.LastName as 'Çalışan',
Sh.CompanyName as 'Kargo',
s.CompanyName 'Tedarikçi',
c.CategoryName,
od.Quantity,
od.UnitPrice
from [Order Details] od 
JOIN Products p 
on od.ProductID = p.ProductID
JOIN Suppliers s 
ON s.SupplierID = p.SupplierID
JOIN Categories c 
on c.CategoryID = p.CategoryID
JOIN Orders o 
on o.OrderID = od.OrderID
JOIN Shippers sh 
on sh.ShipperID = o.ShipVia
JOIN Customers cus 
on o.CustomerID = cus.CustomerID
JOIN Employees emp
on o.EmployeeID = emp.EmployeeID

select MAX(UnitPrice)
from Products

SELECT *
FROM Products
WHERE UnitPrice = (select MAX(UnitPrice) from Products)