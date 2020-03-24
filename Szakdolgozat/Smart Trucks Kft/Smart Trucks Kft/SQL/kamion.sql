-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Már 24. 10:40
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

DROP TABLE IF EXISTS `dolgozok`;
CREATE TABLE `dolgozok` (
  `id` int(60) NOT NULL DEFAULT 0,
  `nev` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `telefonszam` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `email` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `jelszo` varchar(60) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `dolgozok`
--

INSERT INTO `dolgozok` (`id`, `nev`, `telefonszam`, `email`, `jelszo`) VALUES
(1, 'Makkos Máté', '+36205887205', 'valamik@gmail.com', '1234'),
(2, 'Patka Attila', '+36205887204', 'valami@gmail.com', '12456'),
(3, 'Nyul Péter', '+36205887203', 'valam@gmail.com', '12341'),
(4, 'Bán Norbert', '+36205887202', 'val@gmail.com', 'abc');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `hely`
--

DROP TABLE IF EXISTS `hely`;
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
(1, 'Makó', '300', '4:00:00', 'Szeged'),
(2, 'Makó', '300', '4:00:00', 'Szeged'),
(3, 'Makó', '300', '4:00:00', 'Szeged'),
(4, 'Makó', '300', '4:00:00', 'Szeged');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kamionok`
--

DROP TABLE IF EXISTS `kamionok`;
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

DROP TABLE IF EXISTS `kuldes`;
CREATE TABLE `kuldes` (
  `sid` int(60) NOT NULL,
  `kid` int(60) NOT NULL,
  `heid` int(60) NOT NULL,
  `teid` int(60) NOT NULL,
  `did` int(60) NOT NULL,
  `Kikuldes` varchar(60) COLLATE utf8_hungarian_ci NOT NULL,
  `Viszaerkezes` varchar(60) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `termekek`
--

DROP TABLE IF EXISTS `termekek`;
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
(2, '200', '600', 'Zsebkendo'),
(3, '20', '100', 'Konzerv'),
(4, '200', '800', 'Fa');

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
  ADD PRIMARY KEY (`sid`),
  ADD KEY `kuldes_ibfk_1` (`kid`),
  ADD KEY `kuldes_ibfk_2` (`heid`),
  ADD KEY `kuldes_ibfk_3` (`teid`),
  ADD KEY `kuldes_ibfk_4` (`did`);

--
-- A tábla indexei `termekek`
--
ALTER TABLE `termekek`
  ADD PRIMARY KEY (`teid`);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `kuldes`
--
ALTER TABLE `kuldes`
  ADD CONSTRAINT `kuldes_ibfk_1` FOREIGN KEY (`kid`) REFERENCES `kamionok` (`tid`),
  ADD CONSTRAINT `kuldes_ibfk_2` FOREIGN KEY (`heid`) REFERENCES `hely` (`hid`),
  ADD CONSTRAINT `kuldes_ibfk_3` FOREIGN KEY (`teid`) REFERENCES `termekek` (`teid`),
  ADD CONSTRAINT `kuldes_ibfk_4` FOREIGN KEY (`did`) REFERENCES `dolgozok` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
