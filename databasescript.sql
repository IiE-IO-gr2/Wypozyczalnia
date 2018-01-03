SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Klient](
	[Id_klienta] [int] NOT NULL,
	[Telefon_kontaktowy] nchar(11) NOT NULL,
	[Adres] nvarchar(max) NOT NULL,
	[Adres_email] nvarchar(30) NOT NULL,
	[Promocja] decimal(4,2) DEFAULT 0.0,
	[Aktywnosc] [int] DEFAULT 0
 CONSTRAINT [PK_Klient] PRIMARY KEY CLUSTERED 
(
	[Id_klienta] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Klient_firmy](
	[Id_klienta] [int] NOT NULL,
	[Telefon_kontaktowy] nchar(9) NOT NULL,
	[Adres] nvarchar(max) NOT NULL,
	[Adres_email] nvarchar(30) NOT NULL,
	[Promocja] decimal(4,2) DEFAULT 0.0,
	[Aktywnosc] [int] DEFAULT 0,
	[Nazwa_firmy] nvarchar(30) NOT NULL,
	[NIP] nchar(10) NOT NULL,
 CONSTRAINT [PK_Klient_firmy] PRIMARY KEY CLUSTERED 
(
	[Id_klienta] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Klient_indywidualny](
	[Id_klienta] [int] NOT NULL,
	[Telefon_kontaktowy] nchar(11) NOT NULL,
	[Adres] nvarchar(max) NOT NULL,
	[Adres_email] nvarchar(30) NOT NULL,
	[Promocja] decimal(4,2) DEFAULT 0.0,
	[Aktywnosc] [int] DEFAULT 0,
	[Imiê] nvarchar(30) NOT NULL,
	[Nazwisko] nvarchar(30) NOT NULL,
	[Numer_prawa_jazdy] nvarchar(15) NOT NULL,
	[PESEL] nchar(11) NOT NULL,
	[P³ec] bit
 CONSTRAINT [PK_Klient_indywidualny] PRIMARY KEY CLUSTERED 
(
	[Id_klienta] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Panel_administratora](
	[Login] nvarchar(30) NOT NULL,
	[haslo] nvarchar(30) NOT NULL
 CONSTRAINT [PK_Panel_administratora] PRIMARY KEY CLUSTERED 
(
	[Login], [haslo]
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Rezerwacja](
	[ID_rezerwacji] [int] NOT NULL,
	[Data_planowanego_wypozyczenia] nchar(8) NOT NULL,
	[Data_planowanego_zwrotu] nchar(8) NOT NULL
 CONSTRAINT [PK_Rezerwacja] PRIMARY KEY CLUSTERED 
(
	[ID_rezerwacji] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Rozliczenie](
	[ID_Rozliczenia] [int] NOT NULL,
	[Data_zwrotu] nchar(8) NOT NULL,
	[Czy_uszkodzony] bit NOT NULL
 CONSTRAINT [PK_Rozliczenie] PRIMARY KEY CLUSTERED 
(
	[ID_Rozliczenia] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Samochód](
	[Id_samochodu] [int] NOT NULL,
	[Marka] nvarchar(30) NOT NULL,
	[Model] nvarchar(30) NOT NULL,
	[Pojemnosc] decimal(2,1),
	[Rodzaj_paliwa] nvarchar(30) NOT NULL,
	[Typ_nadwozia] nvarchar(30),
	[Ilosc_koni] [int],
	[Skrzynia_biegow] nvarchar(30),
	[Zu¿ycie_paliwa] decimal(4,2),
	[Ilosc_miejsc] [int],
	[Ilosc_drzwi] [int],
	[Rocznik] [int],
	[Kolor] nvarchar(30),
	[Cena_za_dobê] decimal(6,2),
	[Dostepnosc] bit NOT NULL,
	[Inne] nvarchar(max),
	[Kaucja] [int] NOT NULL
 CONSTRAINT [PK_Samochódy] PRIMARY KEY CLUSTERED 
(
	[Id_samochodu] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Wypo¿yczenie](
	[ID_wypo¿yczenia] [int] NOT NULL,
	[Data_wypo¿yczenia] nchar(8) NOT NULL,
	[Data_planowanego_zwrotu] nchar(8) NOT NULL,
	[CCena_za_wypozyczenie] decimal(10,2)
 CONSTRAINT [PK_Wypo¿yczenie] PRIMARY KEY CLUSTERED 
(
	[ID_wypo¿yczenia] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO