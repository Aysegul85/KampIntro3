--Select
Select ContactName Adi , CompanyName Sirketadi, City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive büyük küçük harf duyarsız
select * from Products where CategoryId =1 and UnitPrice >=10


--order by sıralamak
select * from Products order by UnitPrice asc --ascending artan fiyata göre sırala
                                        --desc --düşene göre sırala

--CategoryId s 1 olanları artan fiyata göre sırala
select * from Products where CategoryId=1  order by UnitPrice asc


--CategoryId si 2 olan kaç ürün vardır
select count(*) Adet from Products where CategoryId = 2

--Hangi kategoride kaç ürün vardır
select count(*) Adet from Products


--group by her bir grup için arka planda tablo oluşturuluyor gibi düşünebilirsin
--içerisinde on taneden az ürün çeşidi olan kategorileri ver
--ilk where kısmı çalışır 

select CategoryId, count(*) from  Products where UnitPrice>20 group by CategoryId having count(*)<10



--Join-----------------
select Pproducts.ProductID, Products.ProductName,Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID --bunların eşit olması durumunda
where Products.UnitPrice>10
--fiyatı ondan büyük olan ürünler için kategori ismiyle getir 
--DTO Data Transformation Object


--inner join sadece eşleşen kayıtları getirir
--left solda olup sağda olmayanları da getir ürünler tablosunda ama satışı yok
select * from Products left join  [Order Details] od
on p.ProductId = od.ProductId


select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null --null o data yok demek olmayan datayı getirir

--right join sağda olup solda olmayanları getir demek
