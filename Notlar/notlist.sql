-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 15 Eyl 2022, 14:25:28
-- Sunucu sürümü: 5.7.36
-- PHP Sürümü: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `notlist`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `notlarim`
--

DROP TABLE IF EXISTS `notlarim`;
CREATE TABLE IF NOT EXISTS `notlarim` (
  `not_id` int(10) NOT NULL AUTO_INCREMENT,
  `user_id` int(10) DEFAULT NULL,
  `not_baslik` varchar(50) NOT NULL,
  `not_icerik` text NOT NULL,
  `not_oncelik` text NOT NULL,
  `not_durum` int(5) DEFAULT NULL,
  PRIMARY KEY (`not_id`),
  UNIQUE KEY `not_id` (`not_id`)
) ENGINE=MyISAM AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `notlarim`
--

INSERT INTO `notlarim` (`not_id`, `user_id`, `not_baslik`, `not_icerik`, `not_oncelik`, `not_durum`) VALUES
(35, 9, 'Özel Sadece Sizz', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu', 'Orta', 1),
(11, 2, 'not Başlık 2', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam elit tortor, facilisis sed sapien sed, ultrices pellentesque erat. Donec a efficitur leo. Donec tempus nibh sed nulla sagittis, nec ornare augue placerat. Vestibulum eu arcu vitae elit dignissim varius. Vestibulum rutrum metus quis iaculis ', 'normal', 0),
(36, 9, 'Acil ', 'test', 'Acil', 0),
(37, 9, 'Orta', 'test', 'Orta', 0),
(38, 9, 'Normal', 'test', 'Normal', 0);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `notlist`
--

DROP TABLE IF EXISTS `notlist`;
CREATE TABLE IF NOT EXISTS `notlist` (
  `not_id` int(10) NOT NULL AUTO_INCREMENT,
  `user_id` int(10) DEFAULT NULL,
  `not_baslik` varchar(50) NOT NULL,
  `not_icerik` text NOT NULL,
  `not_oncelik` text NOT NULL,
  `not_durum` int(5) DEFAULT NULL,
  PRIMARY KEY (`not_id`),
  UNIQUE KEY `not_id` (`not_id`)
) ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `notlist`
--

INSERT INTO `notlist` (`not_id`, `user_id`, `not_baslik`, `not_icerik`, `not_oncelik`, `not_durum`) VALUES
(18, 9, 'Genel Herkese Açik', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu', 'Acil', 0);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `kulanici_id` int(11) NOT NULL AUTO_INCREMENT,
  `kulanici_adsoyad` varchar(50) DEFAULT NULL,
  `kulanici_ad` varchar(100) NOT NULL,
  `kulanici_sifre` varchar(100) NOT NULL,
  PRIMARY KEY (`kulanici_id`),
  UNIQUE KEY `kulanici_id` (`kulanici_id`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `users`
--

INSERT INTO `users` (`kulanici_id`, `kulanici_adsoyad`, `kulanici_ad`, `kulanici_sifre`) VALUES
(9, 'Test Test', 'test', 'nKsYAjxkfuo=');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `zaman`
--

DROP TABLE IF EXISTS `zaman`;
CREATE TABLE IF NOT EXISTS `zaman` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `baslangic_zamani` time DEFAULT NULL,
  `zaman` varchar(30) DEFAULT NULL,
  `time` time DEFAULT NULL,
  `tarih` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
