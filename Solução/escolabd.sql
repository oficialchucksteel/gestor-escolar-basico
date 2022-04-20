-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 16-Abr-2022 às 02:43
-- Versão do servidor: 10.4.10-MariaDB
-- versão do PHP: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `escolabd`
--
CREATE DATABASE IF NOT EXISTS `escolabd` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `escolabd`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `admin`
--

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `senha` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id_usuario`),
  UNIQUE KEY `usuario` (`usuario`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Truncar tabela antes do insert `admin`
--

TRUNCATE TABLE `admin`;
--
-- Extraindo dados da tabela `admin`
--

INSERT INTO `admin` (`id_usuario`, `usuario`, `senha`) VALUES
(1, 'Chuck', '4f2155e69aea499c87d1850ab8a8e183'),
(2, 'Steel', '3eb38fa8079f887324e8ee1d92b3da12'),
(3, 'Chuck Steel', '50e25e970af017e825b2e6f583e3f478');

-- --------------------------------------------------------

--
-- Estrutura da tabela `alunos`
--

DROP TABLE IF EXISTS `alunos`;
CREATE TABLE IF NOT EXISTS `alunos` (
  `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `sexo` enum('M','F') COLLATE utf8_unicode_ci NOT NULL DEFAULT 'M',
  `curso` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `classe` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `data_de_nascimento` date NOT NULL,
  `data_de_entrada` date NOT NULL DEFAULT current_timestamp(),
  `data_de_criacao` date NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Truncar tabela antes do insert `alunos`
--

TRUNCATE TABLE `alunos`;
-- --------------------------------------------------------

--
-- Estrutura da tabela `professores`
--

DROP TABLE IF EXISTS `professores`;
CREATE TABLE IF NOT EXISTS `professores` (
  `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `sexo` enum('M','F') COLLATE utf8_unicode_ci NOT NULL,
  `disciplina` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `classe` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `data_de_nascimento` date NOT NULL,
  `data_de_entrada` date NOT NULL,
  `data_de_criacao` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Truncar tabela antes do insert `professores`
--

TRUNCATE TABLE `professores`;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
