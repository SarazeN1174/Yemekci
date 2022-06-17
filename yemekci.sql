create database Kutuphane;
use Kutuphane;

CREATE TABLE Musteriler
(
	musteri_id  	varchar(64) 	not null,
    musteri_ad		varchar(64) 	not null,
    musteri_soyad 	varchar(64) 	not null,
    musteri_tel 	varchar(25) 	not null,
    musteri_mail 	varchar(250) 	not null,
    musteri_adres 	varchar(250) 	not null,
    
    primary key(musteri_id)
);

CREATE TABLE Kitaplar
(
	Kitap_id			varchar(64) 	not null,
    Kitap_ad 		varchar(250) 	not null,
    Kitap_kategori 	varchar(250) 	not null,
	Kitap_fiyat 		float 			not null,
    Kitap_stok		float 			not null,
    Kitap_detay	   	varchar(250) 	not null,
    
	primary key(Kitap_id)
);

CREATE TABLE Satislar
(
	satis_id		varchar(64) 	not null,
	musteri_id		varchar(64) 	not null,
	Kitap_id			varchar(64) 	not null,    
    satis_tarih 	datetime 		not null,
	satis_fiyat 	float 			not null,
    
	primary key(satis_id),
   
	foreign key(musteri_id)	references musteriler(musteri_id)
		on delete cascade on update cascade,
        
	foreign key(Kitap_id)	references Kitaplar(Kitap_id)
		on delete cascade on update cascade                         
);

CREATE TABLE ödemeler
(
	ödeme_id		varchar(64) 	not null,
	musteri_id		varchar(64) 	not null,    
    ödeme_tarih 	datetime 		not null,
	ödeme_tutar 	float 			not null,    
    ödeme_aciklama	varchar(250) 	not null,
    
   primary key(ödeme_id),
   
   foreign key(musteri_id) 	references musteriler(musteri_id)
		on delete cascade on update cascade
);

DELIMITER $$
CREATE PROCEDURE MusterilerHepsi ()
BEGIN
	SELECT 
		musteri_id 		as ID,
		musteri_ad 		as Adı,
		musteri_soyad 	as Soyadı,
		musteri_tel		as Telefon, 
		musteri_mail 	as Mail,
		musteri_adres 	as Adres
    FROM musteriler;
END $$
DELIMITER ;

DELIMITER $$

DELIMITER $$
CREATE PROCEDURE MusteriEkle (
	id  	varchar(64) ,
    ad		varchar(64) ,
    soy 	varchar(64) ,
    tel 	varchar(25) ,
    mail 	varchar(250),
    adr 	varchar(250)
)
BEGIN
	INSERT INTO musteriler
    VALUES 	(id, ad, soy, tel, mail, adr);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE MusteriGuncelle (
	id  	varchar(64) ,
    ad		varchar(64) ,
    soy 	varchar(64) ,
    tel 	varchar(25) ,
    mail 	varchar(250),
    adr 	varchar(250)
)
BEGIN
	UPDATE musteriler
    SET 
		musteri_ad		= ad,
		musteri_soyad 	= soy,
		musteri_tel 	= tel,
		musteri_mail 	= mail,
		musteri_adres 	= adr
	WHERE 
    	musteri_id  	= id;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE MusteriSil (
	id  	varchar(64) 
)
BEGIN
	DELETE FROM musteriler
	WHERE  	musteri_id  = id;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE MusteriBul (
	filtre  varchar(32) 
)
BEGIN
	SELECT * FROM musteriler
    WHERE 
    	musteri_id  	LIKE  CONCAT('%',filtre,'%') OR
		musteri_ad		LIKE  CONCAT('%',filtre,'%') OR
		musteri_soyad 	LIKE  CONCAT('%',filtre,'%') OR
		musteri_tel 	LIKE  CONCAT('%',filtre,'%') OR
		musteri_mail 	LIKE  CONCAT('%',filtre,'%') OR
		musteri_adres 	LIKE  CONCAT('%',filtre,'%');
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE MusteriSatislar(
	id			varchar(64)  
)
BEGIN
	SELECT * FROM satislar
    WHERE musteri_id = id;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE kitaplarHepsi ()
BEGIN
	SELECT * FROM kitaplar;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE kitapEkle (
	id			varchar(64)  ,
    ad 			varchar(250) ,
    kategori 	varchar(250) ,
	fiyat 		float		 ,
    stok		float 		 ,
    detay	   	varchar(250) 
)
BEGIN
	INSERT INTO kitaplar
    VALUES 	(id, ad, kategori, fiyat, stok, detay);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE kitapGuncelle (
	id			varchar(64)  ,
    ad 			varchar(250) ,
    kategori 	varchar(250) ,
	fiyat 		float 	     ,
    stok		float 		 ,
    detay	   	varchar(250) 
)
BEGIN
	UPDATE kitaplar
    SET 
		kitap_ad 	  = ad,
		kitap_kategori = kategori,
		kitap_fiyat 	  = fiyat,
		kitap_stok	  = stok,
		kitap_detay	  = detay
	WHERE 
    	kitap_id  	  = id;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE kitapStokGuncelle (
	id			varchar(64)  ,
    stok		float 		 
)
BEGIN
	UPDATE kitaplar
    SET 
		kitap_stok	  = stok
	WHERE 
    	kitap_id  	  = id;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE KitapSil (
	id			varchar(64)  
)
BEGIN
	DELETE FROM kitaplar
	WHERE kitap_id  = id;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE KitapBul (
	filtre		varchar(32)
)
BEGIN
	SELECT * FROM kitaplar
    WHERE 
    	kitap_id  	  LIKE  CONCAT('%',filtre,'%') OR
		kitap_ad 	  LIKE  CONCAT('%',filtre,'%') OR
		kitap_kategori LIKE  CONCAT('%',filtre,'%') OR
		kitap_fiyat 	  LIKE  CONCAT('%',filtre,'%') OR
		kitap_stok	  LIKE  CONCAT('%',filtre,'%') OR
		kitap_detay	  LIKE  CONCAT('%',filtre,'%') ;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE KitapSatislar(
	id			varchar(64)  
)
BEGIN
	SELECT * FROM satislar
    WHERE kitap_id = id;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE SatisEkle (
	sid		varchar(64) ,
	mid		varchar(64) ,
	uid		varchar(64) ,    
    tarih 	datetime 	,
	fiyat 	float 		
)
BEGIN
	INSERT INTO satislar
    VALUES 	(sid, mid, uid, tarih, fiyat);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE SatisGuncelle (
	sid			varchar(64),
	mid			varchar(64),
    uid 		varchar(64),
    tarih 		datetime   ,
	fiyat 		float      
)
BEGIN
	UPDATE satislar
    SET 
		musteri_id    = mid,
		urun_id 	  = uid,
		satis_tarih	  = tarih,
		satis_fiyat	  = fiyat
	WHERE 
		satis_id 	  = sid;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE SatisSil (
	id			varchar(64)  
)
BEGIN
	DELETE FROM satislar
	WHERE satis_id  = id;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE SatisDetay (
)
BEGIN
SELECT   
		s.satis_id,
        m.musteri_id,
        u.kitap_id,
        CONCAT(musteri_ad,' ', musteri_soyad ) as `Müşteri Ad Soyad`,
        kitap_ad as `Ürün`,
        kitap_kategori as `Kategori`,
        kitap_fiyat as `Birim Fiyat`,
        satis_fiyat as `Satış Fiyatı`,
		satis_tarih as `Satış Tarihi`
FROM  	musteriler m inner join  satislar s 
	on m.musteri_id = s.musteri_id 
		inner join kitaplar u on s.kitap_id = u.kitap_id;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE ÖdemeEkle (
	öid		varchar(64) ,
	mid		varchar(64) ,   
    tarih 	datetime 	,
	tutar 	float 		,
    aciklama varchar(250)
)
BEGIN
	INSERT INTO ödemeler
    VALUES 	(öid, mid, tarih, tutar, aciklama);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE ÖdemeDetay (
)
BEGIN
SELECT   
		ö.odeme_id,
        m.musteri_id,
        CONCAT(musteri_ad,' ', musteri_soyad ) as `Müşteri Ad Soyad`,
        ö.odeme_tarih as `Ödeme Tarihi`,
        ö.odeme_tutar as `Ödeme Tutarı`,
        ö.odeme_aciklama as `Açıklama`
		
FROM  	musteriler m inner join  ödemeler ö 
	on m.musteri_id = ö.musteri_id;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE ÖdemeGuncelle (
	öid		varchar(64) ,
	mid		varchar(64) ,   
    tarih 	datetime 	,
	tutar 	float 		,
    aciklama varchar(250)
)
BEGIN
	UPDATE ödemeler
    SET
		musteri_id		= mid,
        ödeme_tarih		= tarih,
        ödeme_tutar		= tutar,
        ödeme_aciklama 	= aciklama
 	WHERE 
		ödeme_id = öid; 
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE ÖdemeSil (
	öid		varchar(64) 
)
BEGIN
	DELETE FROM ödemeler
    WHERE ödeme_id = öid;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE MusteriBakiye(
	id		varchar(64)
)
BEGIN
	declare borc  float;
    declare ödeme float;
    
	SELECT 	SUM(satis_fiyat) into borc  
    FROM 	satislar 
    WHERE 	musteri_id = id;
    
    SELECT 	SUM(ödeme_tutar) into odeme  
    FROM 	ödemeler 
    WHERE 	musteri_id = id;
    
    SELECT ödeme - borc;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE SatislarToplam()
BEGIN
	SELECT 	SUM(satis_fiyat)  
    FROM 	satislar ;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE ÖdemelerToplam()
BEGIN
    SELECT 	SUM(ödeme_tutar)  
    FROM 	ödemeler ;
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE OdemeDetay (
)
BEGIN
SELECT   
		o.odeme_id,
        m.musteri_id,
        CONCAT(ad,' ', soyad ) as `Müşteri Ad Soyad`,
        o.odeme_tarih as `Ödeme Tarihi`,
        o.odeme_tutar as `Ödeme Tutarı`,
        o.odeme_tur as `Ödeme Türü`		
FROM  	musteriler m inner join  odeme o 
	on m.musteri_id = o.musteri_id;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE SiparisDetay (
)
BEGIN
SELECT   
		s.siparis_id,
        m.musteri_ID,
        y.yemekID,
        CONCAT(ad,' ', soyad ) as `Müşteri Ad Soyad`,
        yemek_ad as `Ürün`,
        yemek_kategori as `Kategori`,
        yemek_fiyat as `Birim Fiyat`,
        siparis_fiyat as `Siparis Fiyatı`,
		siparis_tarih as `Siparis Tarihi`
FROM  	musteriler m inner join  siparis s 
	on m.musteri_ID = s.musteri_ID 
		inner join yemekler y on s.yemekID = y.yemekID;
END $$
DELIMITER ;
