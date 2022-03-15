/****** Script for SelectTopNRows command from SSMS  ******/

--Alanlarý çekme
SELECT [MusteriId]
      ,[Isim]
      ,[Soyisim]
  FROM [AdoNet].[dbo].[Musteri]


-- tüm alanlarý çekme
select * from Musteri


-- Tablo Oluþturma
  Create table Musteri
(
MusteriId int,
Isim nvarchar(100),
Soyisim nvarchar(100)
)

-- Stored Procedure

Create proc SP_Musteri_YeniKayit
(
@MusteriID int,
@Isim nvarchar(100),
@Soyisim nvarchar(100) 
)
as
BEGIN
 INSERT INTO Musteri values (@MusteriID,@Isim,@Soyisim)
END


-- belli alanlara insert

 INSERT INTO Musteri (MusteriId,Isim) values (@MusteriID,@Isim)

 --tüm alanlara insert

  INSERT INTO Musteri values (@MusteriID,@Isim,@Soyisim)


SELECT Isim from Musteri Where MusteriId=3


-- sp

CREATE proc SP_Musteri_Isim_Getir
(
@MusteriID int
)
as
BEGIN
SELECT Isim from Musteri Where MusteriId=@MusteriID
END

create proc SP_Musteri_Liste
as
BEGIN
select * from Musteri
END