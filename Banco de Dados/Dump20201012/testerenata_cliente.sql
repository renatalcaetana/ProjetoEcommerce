CREATE DATABASE  IF NOT EXISTS `testerenata` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `testerenata`;
-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: testerenata
-- ------------------------------------------------------
-- Server version	8.0.21

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
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `id` varchar(36) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `data_cadastro` date NOT NULL,
  `status` char(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES ('0adb5c42-3bc9-4734-805e-52450605f518','Lorena Caetano','2020-10-11','Ativo'),('0b5be54d-2ee4-4370-91ff-ca902165ef78','Lorena Caetano','2020-10-11','Ativo'),('0ef00454-bef3-4f4e-9b0e-b20d6bf3cbf8','Jose Bonifacio','2020-10-08','Ativo'),('1abcc7f0-809a-4acf-a853-825ccb4e2724','string','2020-10-11','Ativo'),('2318fa13-4142-4d22-a828-d2d7bc35a675','','2020-10-11','Ativo'),('2b835486-2cb3-42a9-9ae6-4e9c037107dc','testessssss','2020-10-11','Ativo'),('50a2a3d5-0e0d-4330-bed3-7ffceef9e870','Jose Bonifacio','2020-10-08','Ativo'),('55c62d56-ba8d-4d22-b3ac-29c94a14e7e6','Jose Bonifacio','2020-10-08','Ativo'),('596f82d6-8170-4cb5-b400-75ef94e46924','Jose Bonifacio','2020-10-08','Ativo'),('59a76ddd-b419-43ee-ab53-341d5350859c','Jose Bonifacio','2020-10-08','Ativo'),('62a79844-2156-49ff-a5b6-2d15fe627bc9','mmmkmkmkmk','2020-10-11','Ativo'),('77487abc-1652-40ed-8091-7b5f945fac3a','Lana Bonifacio','2020-10-08','Ativo'),('912ff74c-c6b5-47f6-a2d0-9610df753862','testessssss','2020-10-11','Ativo'),('c3891e61-1de8-4d98-a50d-d32a17cab9ab','Jose Bonifacio','2020-10-08','Ativo'),('ef15e543-de1c-4c1a-a221-c9ab05c9e7ac','Lorena','2020-10-08','Ativo');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-10-12 19:00:56
