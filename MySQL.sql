--Select
--ANSII
Select ContactName Adi,CompanyName ŞirketAdı,City Şehir From Customers

Select * from Customers where City = 'Berlin'

select * from Products where categoryId =1 or CategoryID =3

select * from Products where categoryId =1 and UnitPrice>=10

select * from Products order by UnitPrice desc --ascending asd --descending desc

select count(*) from Products where CategoryID=2


select categoryId, count(*) from Products where UnitPrice>20 group by categoryId  having count (*) <10 --kontrol edicem

select Products.CategoryID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryID= Categories.CategoryID
where Products.UnitPrice>10

select * from Products p left join [Order Details] od  --solda olup sağda olmayanlarıda getir
on p.ProductID=od.ProductID


select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null






