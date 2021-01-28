--Select
select ContactName Adi,CompanyName ŞirketAdi,City Şehir from Customers

select * from Customers where City='Berlin'

select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) Adet from Products where CategoryID=2

select CategoryID,count(*) Adet from Products where UnitPrice>20
group by CategoryID having count(*)<10

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID=od.OrderID

select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null


