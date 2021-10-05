-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Mar 20, 2021 at 04:22 PM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

CREATE DATABASE moodle;
USE moodle;

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `moodle`
--

-- --------------------------------------------------------

--
-- Table structure for table `korisnik`
--

DROP TABLE IF EXISTS `korisnik`;
CREATE TABLE IF NOT EXISTS `korisnik` (
  `idKorisnika` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `type` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idKorisnika`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `korisnik`
--

INSERT INTO `korisnik` (`idKorisnika`, `username`, `password`, `type`) VALUES
(1, '1', '1', 'admin'),
(2, '2', '2', 'student'),
(3, '3', '3', 'professor'),
(4, '4', '4', 'student');

-- --------------------------------------------------------

--
-- Table structure for table `kurs`
--

DROP TABLE IF EXISTS `kurs`;
CREATE TABLE IF NOT EXISTS `kurs` (
  `idKursa` int(11) NOT NULL,
  `idKorisnika` int(11) DEFAULT NULL,
  `naziv` varchar(45) DEFAULT NULL,
  `godina` int(11) DEFAULT NULL,
  PRIMARY KEY (`idKursa`),
  KEY `fk_Kurs_Profesor1_idx` (`idKorisnika`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `kurs`
--

INSERT INTO `kurs` (`idKursa`, `idKorisnika`, `naziv`, `godina`) VALUES
(1, 3, 'Inzenjerska Mehanika', 1),
(2, 3, 'Bioinformatika', 4),
(3, 3, 'Elektronika', 3),
(5, NULL, 'testKurs', 3),
(6, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `materijal`
--

DROP TABLE IF EXISTS `materijal`;
CREATE TABLE IF NOT EXISTS `materijal` (
  `idMaterijala` int(11) NOT NULL AUTO_INCREMENT,
  `idKursa` int(11) NOT NULL,
  `nedelja` int(11) DEFAULT NULL,
  `sadrzaj` longblob DEFAULT NULL,
  `nazivMaterijala` varchar(45) DEFAULT NULL,
  `tip` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idMaterijala`),
  KEY `fk_Materijal_Kurs1_idx` (`idKursa`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `materijal`
--

INSERT INTO `materijal` (`idMaterijala`, `idKursa`, `nedelja`, `sadrzaj`, `nazivMaterijala`, `tip`) VALUES
(1, 3, 0, 0x307833343330333032303337333532303332333033303230326432303638366636643635306430613064306133343332333532303337333032303331333133303230326432303632366336313761363532303733373036313737366536353732, 'coordinates', 'txt');

-- --------------------------------------------------------

--
-- Table structure for table `ostvarenibodovi`
--

DROP TABLE IF EXISTS `ostvarenibodovi`;
CREATE TABLE IF NOT EXISTS `ostvarenibodovi` (
  `idTesta` int(11) NOT NULL,
  `idKorisnika` int(11) NOT NULL,
  `bodovi` int(11) DEFAULT NULL,
  PRIMARY KEY (`idTesta`,`idKorisnika`),
  KEY `fk_OstvareniBodovi_Student1_idx` (`idKorisnika`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `pitanje`
--

DROP TABLE IF EXISTS `pitanje`;
CREATE TABLE IF NOT EXISTS `pitanje` (
  `idPitanja` int(11) NOT NULL AUTO_INCREMENT,
  `idTesta` int(11) NOT NULL,
  `pitanje` varchar(250) DEFAULT NULL,
  `odgovor1` varchar(100) DEFAULT NULL,
  `odgovor2` varchar(100) DEFAULT NULL,
  `odgovor3` varchar(100) DEFAULT NULL,
  `odgovor4` varchar(100) DEFAULT NULL,
  `odgovor5` varchar(100) DEFAULT NULL,
  `odgovor6` varchar(100) DEFAULT NULL,
  `tacanOdgovor1` int(11) NOT NULL,
  `tacanOdgovor2` int(11) NOT NULL,
  `tacanOdgovor3` int(11) NOT NULL,
  `tacanOdgovor4` int(11) NOT NULL,
  `tacanOdgovor5` int(11) NOT NULL,
  `tacanOdgovor6` int(11) NOT NULL,
  PRIMARY KEY (`idPitanja`),
  KEY `fk_Pitanje_Test1_idx` (`idTesta`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pitanje`
--

INSERT INTO `pitanje` (`idPitanja`, `idTesta`, `pitanje`, `odgovor1`, `odgovor2`, `odgovor3`, `odgovor4`, `odgovor5`, `odgovor6`, `tacanOdgovor1`, `tacanOdgovor2`, `tacanOdgovor3`, `tacanOdgovor4`, `tacanOdgovor5`, `tacanOdgovor6`) VALUES
(3, 2, 'a', 'a', 'b', 'c', 'd', NULL, NULL, 1, 0, 0, 1, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `profesor`
--

DROP TABLE IF EXISTS `profesor`;
CREATE TABLE IF NOT EXISTS `profesor` (
  `idKorisnika` int(11) NOT NULL,
  `ime` varchar(45) DEFAULT NULL,
  `prezime` varchar(45) DEFAULT NULL,
  `katedra` varchar(45) DEFAULT NULL,
  `slika` longblob DEFAULT NULL,
  `pol` varchar(45) DEFAULT NULL,
  `email` varchar(45) NOT NULL,
  PRIMARY KEY (`idKorisnika`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `profesor`
--

INSERT INTO `profesor` (`idKorisnika`, `ime`, `prezime`, `katedra`, `slika`, `pol`, `email`) VALUES
(3, 'Dragan', 'Draganovic', 'Elektronika', NULL, 'M', '');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
CREATE TABLE IF NOT EXISTS `student` (
  `idKorisnika` int(11) NOT NULL,
  `ime` varchar(45) DEFAULT NULL,
  `prezime` varchar(45) DEFAULT NULL,
  `brojIndeksa` int(11) DEFAULT NULL,
  `godinaUpisa` int(11) DEFAULT NULL,
  `godinaStudija` int(11) DEFAULT NULL,
  `smer` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `slika` longblob DEFAULT NULL,
  `pol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idKorisnika`),
  UNIQUE KEY `email` (`email`),
  UNIQUE KEY `brojIndeksa` (`brojIndeksa`,`godinaUpisa`),
  UNIQUE KEY `brojIndeksa_2` (`brojIndeksa`,`godinaUpisa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`idKorisnika`, `ime`, `prezime`, `brojIndeksa`, `godinaUpisa`, `godinaStudija`, `smer`, `email`, `slika`, `pol`) VALUES
(2, 'Pera', 'Peric', 420, 2017, 3, 'RTSI', 'peraperic@gmail.com', NULL, 'M'),
(4, 'pera', 'lukic', 421, 2020, 1, 'RTSI', 'peralukic@gmail.com', NULL, 'M');

-- --------------------------------------------------------

--
-- Table structure for table `test`
--

DROP TABLE IF EXISTS `test`;
CREATE TABLE IF NOT EXISTS `test` (
  `idTesta` int(11) NOT NULL AUTO_INCREMENT,
  `idKursa` int(11) NOT NULL,
  `naziv` varchar(45) DEFAULT NULL,
  `omogucen` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idTesta`),
  KEY `fk_Test_Kurs1_idx` (`idKursa`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `test`
--

INSERT INTO `test` (`idTesta`, `idKursa`, `naziv`, `omogucen`) VALUES
(2, 3, 'prviTest', 'disabled');

-- --------------------------------------------------------

--
-- Table structure for table `upisanikursevi`
--

DROP TABLE IF EXISTS `upisanikursevi`;
CREATE TABLE IF NOT EXISTS `upisanikursevi` (
  `idKursa` int(11) NOT NULL,
  `idKorisnika` int(11) NOT NULL,
  `ocena` int(11) DEFAULT NULL,
  PRIMARY KEY (`idKursa`,`idKorisnika`),
  KEY `fk_UpisaniKursevi_Student1_idx` (`idKorisnika`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `kurs`
--
ALTER TABLE `kurs`
  ADD CONSTRAINT `fk_Kurs_Profesor1` FOREIGN KEY (`idKorisnika`) REFERENCES `profesor` (`idKorisnika`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `materijal`
--
ALTER TABLE `materijal`
  ADD CONSTRAINT `fk_Materijal_Kurs1` FOREIGN KEY (`idKursa`) REFERENCES `kurs` (`idKursa`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `ostvarenibodovi`
--
ALTER TABLE `ostvarenibodovi`
  ADD CONSTRAINT `fk_OstvareniBodovi_Student1` FOREIGN KEY (`idKorisnika`) REFERENCES `student` (`idKorisnika`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_OstvareniBodovi_Test1` FOREIGN KEY (`idTesta`) REFERENCES `test` (`idTesta`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `pitanje`
--
ALTER TABLE `pitanje`
  ADD CONSTRAINT `fk_Pitanje_Test1` FOREIGN KEY (`idTesta`) REFERENCES `test` (`idTesta`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `profesor`
--
ALTER TABLE `profesor`
  ADD CONSTRAINT `fk_Profesor_Korisnik` FOREIGN KEY (`idKorisnika`) REFERENCES `korisnik` (`idKorisnika`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `student`
--
ALTER TABLE `student`
  ADD CONSTRAINT `fk_Student_Korisnik1` FOREIGN KEY (`idKorisnika`) REFERENCES `korisnik` (`idKorisnika`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `test`
--
ALTER TABLE `test`
  ADD CONSTRAINT `fk_Test_Kurs1` FOREIGN KEY (`idKursa`) REFERENCES `kurs` (`idKursa`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `upisanikursevi`
--
ALTER TABLE `upisanikursevi`
  ADD CONSTRAINT `fk_UpisaniKursevi_Student1` FOREIGN KEY (`idKorisnika`) REFERENCES `student` (`idKorisnika`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_UpisaniKursevi_Test1` FOREIGN KEY (`idKursa`) REFERENCES `kurs` (`idKursa`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
