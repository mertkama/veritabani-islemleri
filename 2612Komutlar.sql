INSERT INTO SistemKullanici VALUES(NEWID(),'ahmet','1')


CREATE TABLE Personeller
(
PersonelID uniqueidentifier primary key,
Isim nvarchar(50),
Soyisim nvarchar(50),
Emailadres nvarchar(100),
TelefonNumarasi nvarchar(11)
)


Create proc SP_SistemKullanici_Kontrol
(
@KullaniciAd nvarchar(50),
@Sifre nvarchar(50)
)
as
BEGIN
SELECT COUNT(*) from SistemKullanici WHERE KullaniciAdi=@KullaniciAd AND Sifre=@Sifre

END


create proc SP_Personel_Ekle
(
@PersonelID uniqueidentifier,
@Isim nvarchar(50),
@Soyisim nvarchar(50),
@EmailAdres nvarchar(100),
@TelefonNumarasi nvarchar(11)
)
as
BEGIN

INSERT INTO Personeller VALUES (@PersonelID,@Isim,@Soyisim,@EmailAdres,@TelefonNumarasi)

END


Create proc SP_Personel_Duzenle
(
@PersonelId uniqueidentifier,
@Isim nvarchar(50),
@Soyisim nvarchar(50),
@EmailAdres nvarchar(100),
@TelefonNumarasi nvarchar(50)
)
as

BEGIN

Update Personeller SET
Isim=@Isim,
Soyisim=@Soyisim,
Emailadres=@EmailAdres,
TelefonNumarasi=@TelefonNumarasi
WHERE
PersonelID=@PersonelId

END


CReate proc SP_Personel_Sil
(
@PersonelId uniqueidentifier
)
as
BEGIN

DELETE Personeller where PersonelID=@PersonelId

END


create proc SP_Personeller_Getir
as
BEGIN

select * from Personeller

END


create proc SP_Personeller_ID_Getir
(
@PersonelId uniqueidentifier
)
as
BEGIN

SELECT * from Personeller where PersonelID=@PersonelId

ENd