-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Ápr 07. 11:56
-- Kiszolgáló verziója: 10.4.11-MariaDB
-- PHP verzió: 7.2.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `kamion`
--
CREATE DATABASE IF NOT EXISTS `kamion` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `kamion`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `dolgozok`
--

CREATE TABLE `dolgozok` (
  `id` int(11) NOT NULL,
  `nev` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `telefonszam` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `email` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `jelszo` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `dolgozok`
--

INSERT INTO `dolgozok` (`id`, `nev`, `telefonszam`, `email`, `jelszo`) VALUES
(1, 'Teszt Elek', '+36205887205', 'teszt@gmail.com', 'Jelszo123!'),
(2, 'Teszt Attila', '+36205887204', 'teszt2@gmail.com', 'Jelszo123!'),
(3, 'Nyúl Péter', '+36205887203', 'valamik@gmail.com', 'Jelszo123!'),
(4, 'Makkos Péter', '+36205887202', 'makker@gmail.com', 'Jelszo123!');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `hely`
--

CREATE TABLE `hely` (
  `hid` int(60) NOT NULL DEFAULT 0,
  `Felvetelezohely` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `Tavolsag` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `Ido` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `Lerakohely` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `hely`
--

INSERT INTO `hely` (`hid`, `Felvetelezohely`, `Tavolsag`, `Ido`, `Lerakohely`) VALUES
(1, 'Makó', '330', '1:34:00', 'Budapest'),
(2, 'Szeged', '367', '4:23:00', 'Debrecen'),
(3, 'Budapest', '150', '1:30:00', 'Kecskemét'),
(4, 'Kiszombor', '10', '0:15:00', 'Makó');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kamionok`
--

CREATE TABLE `kamionok` (
  `tid` int(60) NOT NULL DEFAULT 0,
  `Muszakierv` date NOT NULL DEFAULT '2017-01-01',
  `Rendszam` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `Motor` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `Uzemanyag` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `Suly` int(60) NOT NULL DEFAULT 0,
  `Hajtas` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `kamionok`
--

INSERT INTO `kamionok` (`tid`, `Muszakierv`, `Rendszam`, `Motor`, `Uzemanyag`, `Suly`, `Hajtas`) VALUES
(1, '2020-02-27', 'AAA-123', '570', 'Dízel', 7450, 'Negykerek'),
(2, '2020-03-27', 'AAB-123', '770', 'Dízel', 8600, 'Negykerek'),
(3, '2020-06-27', 'CAS-123', '200', 'Dízel', 6730, 'Negykerek'),
(4, '2020-02-27', 'AGW-123', '300', 'Dízel', 8710, 'Negykerek');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kuldes`
--

CREATE TABLE `kuldes` (
  `sid` int(60) NOT NULL,
  `kid` int(60) NOT NULL,
  `heid` int(60) NOT NULL,
  `teid` int(60) NOT NULL,
  `did` int(60) NOT NULL,
  `Kikuldes` varchar(60) COLLATE utf8_hungarian_ci NOT NULL,
  `Viszaerkezes` varchar(60) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `kuldes`
--

INSERT INTO `kuldes` (`sid`, `kid`, `heid`, `teid`, `did`, `Kikuldes`, `Viszaerkezes`) VALUES
(1, 1, 1, 1, 1, '2020-02-27', '2020-02-28'),
(2, 1, 2, 1, 1, '2020-03-20', '2020-03-28'),
(3, 1, 3, 2, 1, '2020-04-01', '2020-04-03'),
(4, 2, 2, 4, 2, '2020-01-27', '2020-02-02'),
(5, 2, 2, 2, 2, '2020-02-03', '2020-02-05'),
(6, 2, 3, 2, 2, '2020-02-10', '2020-02-15'),
(7, 2, 2, 1, 3, '2019-12-27', '2019-12-31'),
(8, 3, 2, 2, 3, '2020-01-28', '2020-02-01'),
(9, 3, 1, 4, 3, '2020-02-27', '2020-02-28'),
(10, 4, 3, 3, 4, '2020-02-22', '2020-02-27'),
(11, 4, 4, 2, 4, '2020-03-23', '2020-03-25'),
(12, 4, 4, 1, 4, '2020-04-10', '2020-04-12');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `termekek`
--

CREATE TABLE `termekek` (
  `teid` int(60) NOT NULL DEFAULT 0,
  `Mennyiseg` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `Termeksuly` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `TermekNev` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `termekek`
--

INSERT INTO `termekek` (`teid`, `Mennyiseg`, `Termeksuly`, `TermekNev`) VALUES
(1, '200', '400', 'Chips'),
(2, '200', '600', 'Zsebkendő'),
(3, '20', '100', 'Konzerv'),
(4, '200', '800', 'Sportcipő');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `dolgozok`
--
ALTER TABLE `dolgozok`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `hely`
--
ALTER TABLE `hely`
  ADD PRIMARY KEY (`hid`);

--
-- A tábla indexei `kamionok`
--
ALTER TABLE `kamionok`
  ADD PRIMARY KEY (`tid`);

--
-- A tábla indexei `kuldes`
--
ALTER TABLE `kuldes`
  ADD PRIMARY KEY (`sid`);

--
-- A tábla indexei `termekek`
--
ALTER TABLE `termekek`
  ADD PRIMARY KEY (`teid`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `dolgozok`
--
ALTER TABLE `dolgozok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
