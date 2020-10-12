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
-- Table structure for table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedido` (
  `id` varchar(36) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `clienteId` varchar(36) NOT NULL,
  `status_entrega` char(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_cliente` (`clienteId`),
  CONSTRAINT `fk_cliente` FOREIGN KEY (`clienteId`) REFERENCES `cliente` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido` VALUES ('131a0256-8794-42d7-890a-d5cf4b3a44f8','2020-10-12 00:00:00','62a79844-2156-49ff-a5b6-2d15fe627bc9','Pendente'),('3105aadb-7dc6-44d6-8a2a-1a4019389214','2020-10-12 00:00:00','77487abc-1652-40ed-8091-7b5f945fac3a','Pendente'),('53fa7743-17ce-4722-bad9-5750c5600e42','2020-10-12 00:00:00','77487abc-1652-40ed-8091-7b5f945fac3a','Pendente'),('6b8e0a96-7369-400d-9a64-028969e31138','2020-10-12 00:00:00','62a79844-2156-49ff-a5b6-2d15fe627bc9','Pendente'),('c19ca24f-0be2-11eb-88f0-b8ac6fec93d1','2020-10-11 00:00:00','77487abc-1652-40ed-8091-7b5f945fac3a','Pendente'),('d449e2ab-28e7-4c4f-b995-c36cb78f68d8','2020-10-12 00:00:00','912ff74c-c6b5-47f6-a2d0-9610df753862','Pendente'),('f0973a06-08a1-4d2a-9137-c766d8892c6e','2020-10-12 00:00:00','912ff74c-c6b5-47f6-a2d0-9610df753862','Pendente'),('f5e30972-f769-4e10-b0b3-5d9837ebf61c','2020-10-12 00:00:00','c3891e61-1de8-4d98-a50d-d32a17cab9ab','Pendente');
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-10-12 19:00:55
