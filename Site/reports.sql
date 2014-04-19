-- phpMyAdmin SQL Dump
-- version 4.0.7
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Apr 19, 2014 at 05:24 PM
-- Server version: 5.5.35
-- PHP Version: 5.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `cl40-blckchk`
--

-- --------------------------------------------------------

--
-- Table structure for table `reports`
--

CREATE TABLE IF NOT EXISTS `reports` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ip` varchar(15) NOT NULL,
  `isp` varchar(250) NOT NULL,
  `locatie` varchar(60) NOT NULL,
  `openbittorrent` tinyint(1) NOT NULL,
  `publicbt` tinyint(1) NOT NULL,
  `istoleit` tinyint(1) NOT NULL,
  `ccc` tinyint(1) NOT NULL,
  `demonoid` tinyint(1) NOT NULL,
  `traces` longtext NOT NULL,
  `insdate` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=315 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
