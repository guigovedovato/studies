-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 13-Nov-2017 às 18:30
-- Versão do servidor: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sqlexercises`
--

--
-- Extraindo dados da tabela `customer`
--

INSERT INTO `customer` (`id`, `first_name`, `last_name`, `salary`, `department`) VALUES
(1, 'Rodrigo', 'Vedovato', '42000', 'it'),
(2, 'Gabriel', 'Lemos', '25000', 'adm'),
(3, 'Giovana', 'Marques', '30000', 'finc'),
(4, 'Vanessa', 'Passos', '28000', 'cook'),
(5, 'Alberto', 'Bueno', '55000', 'it'),
(6, NULL, 'Marques', '35000', 'finc'),
(7, 'Vanessa', NULL, '22000', 'cook'),
(8, NULL, NULL, '50000', 'it');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
