 --select
 --ANSII
 --Select CustomerID Siralama,CompanyName Sirket ,City Sehir from Customers

 --Select * from Customers where City = 'Berlin'


 -- sElEcT * from Products where CategoryID = 1 or CategoryID = 3
-- select * from Product where CategoryhId = 1 and UnitPrice >= 10
-- select * from Products order by UnitsInStock desc --  ascendin // Düşen - descending // Arta
-- select * from Products where CategoryID=1 order by UnitPrice desc

--select count(*) Adet  from Products 

--select CategoryID,count(*) Toplam from Products where UnitPrice>=18  
--group by CategoryID having count(*)<13

-- 
--select Products.ProductID, Products.ProductName, Products.UnitPrice,Categories.CategoryName 
--from Products inner join Categories 
--on products.CategoryID = Categories.CategoryID  -- koşul
--order by UnitPrice desc
-- DTO - Data Transformation object

--select * from Products p left join [Order Details] od
--on p.ProductID = od.ProductID


-- Distinc Farklı olanları getir.
--SELECT COUNT (DISTINCT ProductName) FROM Products;

-- Germany hariç diğerlerini getir
--select * from Customers
--where not Country='Germany'

--select Country Ulke,City Sehir
--from Customers
--Order By Ulke,Sehir ASC

--insert into Customers (CustomerID, CompanyName,ContactName,ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax)
--values ('AADES','Dogan Kardesler Gida',' Mustafa Dogan',' Dad,Ayazaga Mh 130 sk no78','Istanbul','Sarıyer','34478','Turkiye','90541 960 8920', NULL)

--select * from Customers 
--where Region is null

update Customers
set CompanyName='Dogan Kardesler', ContactName ='Abdussamed',ContactTitle='CEO',Address='Huzur Mh.', City='Istanbul',Region='Sariyer',Country='Turkey', Phone='0212 289 2026',Fax=null
where CustomerID='ALFKI'
update Customers
set CompanyName='Dogan Kardesler', ContactName ='Yasin',ContactTitle='CTO',Address='Huzur Mh.', City='Istanbul',Region='Sariyer',Country='Turkey', Phone='0212 289 2026',Fax=null
where CustomerID='ANATR'
update Customers
set CompanyName='Dogan Kardesler', ContactName ='Irmak',ContactTitle='CTO',Address='Huzur Mh.', City='Istanbul',Region='Sariyer',Country='Turkey', Phone='0212 289 2026',Fax=null
where CustomerID='ANTON'
update Customers
set CompanyName='Dogan Kardesler', ContactName ='Abdurrahman',ContactTitle='Kurye',Address='Huzur Mh.', City='Istanbul',Region='Sariyer',Country='Turkey', Phone='0212 289 2026',Fax=null
where CustomerID='AROUT'
update Customers
set CompanyName='Dogan Kardesler', ContactName ='Bilal',ContactTitle='Kurye',Address='Huzur Mh.', City='Istanbul',Region='Sariyer',Country='Turkey', Phone='0212 289 2026',Fax=null
where CustomerID='BERGS'

--delete from Customers
--where ContactName ='Ana Trujillo Emparedados y helados'


--select max(Freight) from Orders

--select sum(Freight) from Orders

select top 10 * from Customers
where Country='Turkey'

--WHERE CustomerName LIKE 'a%'	Finds any values that start with "a"
--WHERE CustomerName LIKE '%a'	Finds any values that end with "a"
--WHERE CustomerName LIKE '%or%'	Finds any values that have "or" in any position
--WHERE CustomerName LIKE '_r%'	Finds any values that have "r" in the second position
--WHERE CustomerName LIKE 'a_%'	Finds any values that start with "a" and are at least 2 characters in length
--WHERE CustomerName LIKE 'a__%'	Finds any values that start with "a" and are at least 3 characters in length
--WHERE ContactName LIKE 'a%o'	Finds any values that start with "a" and ends with "o"

select p.ProductName [Ürün Adı], sum(od.Quantity*od.UnitPrice) [Kazanılan Toplam Miktar] from [Order Details] od 
inner join Products p on od.ProductID = p.ProductID 
inner join Orders o  on od.OrderID = o.OrderID
group by p.ProductName