-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 20.03.2023 klo 13:17
-- Palvelimen versio: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pizza_app`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `ainekset`
--

CREATE TABLE `ainekset` (
  `aines` varchar(35) NOT NULL,
  `hinta` int(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `ainekset`
--

INSERT INTO `ainekset` (`aines`, `hinta`) VALUES
('salami', 1),
('kinkku', 1),
('ananas', 1),
('herkkusieni', 1),
('jalapeno', 1),
('paprika', 1),
('oliivi', 1),
('sipuli', 1),
('pepperoni', 1),
('aura-sinihomejuusto', 1),
('tonnikala', 1),
('katkarapu', 1);

-- --------------------------------------------------------

--
-- Rakenne taululle `asiakkaat`
--

CREATE TABLE `asiakkaat` (
  `tilausnumero` int(5) NOT NULL,
  `etunimi` varchar(35) NOT NULL,
  `sukunimi` varchar(35) NOT NULL,
  `lahiosoite` varchar(50) NOT NULL,
  `postinumero` varchar(10) NOT NULL,
  `puhelin` varchar(20) NOT NULL,
  `email` varchar(40) NOT NULL,
  `tuotteet` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `asiakkaat`
--

INSERT INTO `asiakkaat` (`tilausnumero`, `etunimi`, `sukunimi`, `lahiosoite`, `postinumero`, `puhelin`, `email`, `tuotteet`) VALUES
(1, 'Petri', 'Nurmi', 'pizzatie 10 a 1', '00510', '0408272734', 'pete666@hotmail.com', 'Americana 8€     Americana 8€     Americana 8€          '),
(2, 'Ville', 'Mikkonen', 'pizzatie 10', '00660', '04082423556', 'ville@hotmail.com', 'Americana 8€     Oma valinta 10€ salami salami salami salami Americana 8€          ');

-- --------------------------------------------------------

--
-- Rakenne taululle `pizzat`
--

CREATE TABLE `pizzat` (
  `pizza` varchar(35) NOT NULL,
  `hinta` int(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `pizzat`
--

INSERT INTO `pizzat` (`pizza`, `hinta`) VALUES
('Americana', 8),
('Margarita', 10),
('Mexicana', 10),
('Oma valinta', 10),
('Quattro Stagioni', 11);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  ADD PRIMARY KEY (`tilausnumero`);

--
-- Indexes for table `pizzat`
--
ALTER TABLE `pizzat`
  ADD PRIMARY KEY (`pizza`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  MODIFY `tilausnumero` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
