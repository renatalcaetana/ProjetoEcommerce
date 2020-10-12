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
-- Table structure for table `produtopedido`
--

DROP TABLE IF EXISTS `produtopedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produtopedido` (
  `pedidoId` varchar(36) NOT NULL,
  `produtoId` varchar(36) NOT NULL,
  PRIMARY KEY (`pedidoId`,`produtoId`),
  KEY `fk_produto` (`produtoId`),
  CONSTRAINT `fk_Pedido` FOREIGN KEY (`pedidoId`) REFERENCES `pedido` (`id`),
  CONSTRAINT `fk_produto` FOREIGN KEY (`produtoId`) REFERENCES `produto` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtopedido`
--

LOCK TABLES `produtopedido` WRITE;
/*!40000 ALTER TABLE `produtopedido` DISABLE KEYS */;
INSERT INTO `produtopedido` VALUES ('131a0256-8794-42d7-890a-d5cf4b3a44f8','fbae6d28-0be1-11eb-88f0-b8ac6fec93d1'),('3105aadb-7dc6-44d6-8a2a-1a4019389214','fbae6d28-0be1-11eb-88f0-b8ac6fec93d1'),('53fa7743-17ce-4722-bad9-5750c5600e42','fbae6d28-0be1-11eb-88f0-b8ac6fec93d1'),('6b8e0a96-7369-400d-9a64-028969e31138','fbae6d28-0be1-11eb-88f0-b8ac6fec93d1'),('c19ca24f-0be2-11eb-88f0-b8ac6fec93d1','fbae6d28-0be1-11eb-88f0-b8ac6fec93d1'),('d449e2ab-28e7-4c4f-b995-c36cb78f68d8','fbae6d28-0be1-11eb-88f0-b8ac6fec93d1'),('f0973a06-08a1-4d2a-9137-c766d8892c6e','fbae6d28-0be1-11eb-88f0-b8ac6fec93d1'),('f5e30972-f769-4e10-b0b3-5d9837ebf61c','fbae6d28-0be1-11eb-88f0-b8ac6fec93d1'),('131a0256-8794-42d7-890a-d5cf4b3a44f8','fbc8956c-0be1-11eb-88f0-b8ac6fec93d1'),('3105aadb-7dc6-44d6-8a2a-1a4019389214','fbc8956c-0be1-11eb-88f0-b8ac6fec93d1'),('53fa7743-17ce-4722-bad9-5750c5600e42','fbc8956c-0be1-11eb-88f0-b8ac6fec93d1'),('6b8e0a96-7369-400d-9a64-028969e31138','fbc8956c-0be1-11eb-88f0-b8ac6fec93d1'),('c19ca24f-0be2-11eb-88f0-b8ac6fec93d1','fbc8956c-0be1-11eb-88f0-b8ac6fec93d1'),('d449e2ab-28e7-4c4f-b995-c36cb78f68d8','fbc8956c-0be1-11eb-88f0-b8ac6fec93d1'),('f0973a06-08a1-4d2a-9137-c766d8892c6e','fbc8956c-0be1-11eb-88f0-b8ac6fec93d1'),('f5e30972-f769-4e10-b0b3-5d9837ebf61c','fbc8956c-0be1-11eb-88f0-b8ac6fec93d1'),('c19ca24f-0be2-11eb-88f0-b8ac6fec93d1','fbe64c5c-0be1-11eb-88f0-b8ac6fec93d1'),('c19ca24f-0be2-11eb-88f0-b8ac6fec93d1','fbfdeeb1-0be1-11eb-88f0-b8ac6fec93d1');
/*!40000 ALTER TABLE `produtopedido` ENABLE KEYS */;
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
