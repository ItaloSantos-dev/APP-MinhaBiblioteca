CREATE DATABASE  IF NOT EXISTS `biblioteca` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `biblioteca`;
-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: biblioteca
-- ------------------------------------------------------
-- Server version	8.4.3

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `livros`
--

DROP TABLE IF EXISTS `livros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `livros` (
  `id_livro` int NOT NULL AUTO_INCREMENT,
  `autor` varchar(50) DEFAULT NULL,
  `titulo` varchar(50) DEFAULT NULL,
  `emprestado` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_livro`),
  UNIQUE KEY `titulo` (`titulo`)
) ENGINE=InnoDB AUTO_INCREMENT=192 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `livros`
--

LOCK TABLES `livros` WRITE;
/*!40000 ALTER TABLE `livros` DISABLE KEYS */;
INSERT INTO `livros` VALUES (3,'George Orwell','1984',0),(8,'Isaac Asimov','Fundação',0),(9,'Gabriel García','Cem Anos de Solidão',0),(164,'Machado de Assis','Dom Casmurro',0),(165,'José de Alencar','Iracema',0),(166,'Graciliano Ramos','Vidas Secas',0),(167,'Clarice Lispector','A Hora da Estrela',0),(168,'Jorge Amado','Gabriela, Cravo e Canela',0),(169,'Monteiro Lobato','Reinações de Narizinho',0),(170,'Rachel de Queiroz','O Quinze',0),(171,'Erico Verissimo','O Tempo e o Vento',0),(172,'Cecília Meireles','Romanceiro da Inconfidência',0),(173,'Ariano Suassuna','O Auto da Compadecida',0),(174,'Euclides da Cunha','Os Sertões',0),(175,'Manuel Bandeira','Estrela da Manhã',0),(176,'Carlos Drummond de Andrade','Alguma Poesia',0),(177,'Aluísio Azevedo','O Cortiço',0),(178,'Mário de Andrade','Macunaíma',0),(179,'Paulo Coelho','O Alquimista',0),(180,'Lygia Fagundes Telles','As Meninas',0),(181,'Rubem Fonseca','Agosto',0),(182,'Guimarães Rosa','Grande Sertão: Veredas',0),(183,'João Ubaldo Ribeiro','Viva o Povo Brasileiro',0);
/*!40000 ALTER TABLE `livros` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-09-21 11:42:36
