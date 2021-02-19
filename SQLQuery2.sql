--Select
select ContactName Adi, CompanyName SirketAdi,City from Customers
select * from Customers where City ='London'
select * from Products where CategoryID=1 and UnitPrice>=10
select * from Products order by CategoryID,ProductID
select * from Products order by UnitPrice asc  --ascending
select * from Products where CategoryID=1 order by UnitPrice desc --descending
select count(*) adet from Products where CategoryID=2
--hangi kategoride kaç farklı ürünümüz var
select CategoryID , count(*)adet from Products group by CategoryID
--urun sayısı 10 dan az olan kategoriler
select CategoryID , count(*)adet from Products group by CategoryID having count(*)<10

select CategoryID , count(*)adet from Products where UnitPrice>20 group by CategoryID having count(*)<10
-- on durumunda şartında demek
select Products.ProductID, Products.ProductName, Categories.CategoryID from Products inner join Categories 
on  Products.CategoryID = Categories.CategoryID
--DTO Data Transformation object
--inner join sadece eşleşen kayıtları getirir
select * from Products p inner join [Order Details] od 
on p.ProductID = od.ProductID
-- solda olup sağda olmayanlarıda getir
select * from Products p left join [Order Details] od 
on p.ProductID = od.ProductID

select * from Customers c left join Orders o 
on  c.CustomerID = o.CustomerID
where o.CustomerID is null