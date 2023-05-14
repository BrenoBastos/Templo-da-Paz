CREATE DATABASE  IF NOT EXISTS `necroterio` /*!40100 DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `necroterio`;
-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: necroterio
-- ------------------------------------------------------
-- Server version	8.0.33

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
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `admin` (
  `Nome` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Senha` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin`
--

LOCK TABLES `admin` WRITE;
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin` VALUES ('Caio','Caio1'),('Caio','Caio1');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `assistente`
--

DROP TABLE IF EXISTS `assistente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `assistente` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Cpf` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Rg` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Endereco` varchar(100) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `DataNasc` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Contato` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `EstadoCivil` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Sexo` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Senha` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Status` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  PRIMARY KEY (`Id`,`Cpf`,`Rg`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assistente`
--

LOCK TABLES `assistente` WRITE;
/*!40000 ALTER TABLE `assistente` DISABLE KEYS */;
INSERT INTO `assistente` VALUES (1,'Beatriz','213,123,123-12','31,231,231-2','321','31/23/1232','(12)09876-2313','União Estável','Não definido','321','Ativo'),(2,'Lucas','333,333,333-33','33,333,333-3','asd','22/22/2222','(12)12345-1234','União Estável','Não definido','abc','Ativo');
/*!40000 ALTER TABLE `assistente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cadaver`
--

DROP TABLE IF EXISTS `cadaver`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cadaver` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Gaveta` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Assistente` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Legista` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci DEFAULT NULL,
  `Laudo` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci DEFAULT NULL,
  `Material` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci DEFAULT NULL,
  `Quantidade` int DEFAULT NULL,
  `DataCheg` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `HorarioCheg` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Datareti` varchar(45) COLLATE utf8mb3_general_mysql500_ci DEFAULT NULL,
  `Horarioreti` varchar(45) COLLATE utf8mb3_general_mysql500_ci DEFAULT NULL,
  `DataObi` varchar(45) COLLATE utf8mb3_general_mysql500_ci DEFAULT NULL,
  `HorarioObi` varchar(45) COLLATE utf8mb3_general_mysql500_ci DEFAULT NULL,
  `Retirada` varchar(45) COLLATE utf8mb3_general_mysql500_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cadaver`
--

LOCK TABLES `cadaver` WRITE;
/*!40000 ALTER TABLE `cadaver` DISABLE KEYS */;
/*!40000 ALTER TABLE `cadaver` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estoque`
--

DROP TABLE IF EXISTS `estoque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estoque` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Material` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Quantidade` int NOT NULL,
  `Fornecedor` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Total` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estoque`
--

LOCK TABLES `estoque` WRITE;
/*!40000 ALTER TABLE `estoque` DISABLE KEYS */;
INSERT INTO `estoque` VALUES (1,'Mouse',12,'Juliana',12),(2,'das',21,'Juliana',NULL),(3,'mouse',312,'Juliana',12),(4,'Mouse',1,'Juliana',NULL),(5,'Mouse',1,'Juliana',NULL);
/*!40000 ALTER TABLE `estoque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fornecedor`
--

DROP TABLE IF EXISTS `fornecedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fornecedor` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Cpf` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Endereco` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Contato` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Status` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  PRIMARY KEY (`Id`,`Cpf`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedor`
--

LOCK TABLES `fornecedor` WRITE;
/*!40000 ALTER TABLE `fornecedor` DISABLE KEYS */;
INSERT INTO `fornecedor` VALUES (1,'Juliana','333,333,333-33','dasd','(12)12345-1234','Ativo'),(2,'Pedro','323,143,543-53','das','(12)1234-1234','Inativo');
/*!40000 ALTER TABLE `fornecedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `legista`
--

DROP TABLE IF EXISTS `legista`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `legista` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Cpf` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Rg` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Endereco` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `DataNasc` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Contato` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Crm` int NOT NULL,
  `EstadoCivil` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Sexo` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Senha` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Status` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  PRIMARY KEY (`Id`,`Cpf`,`Rg`,`Crm`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `legista`
--

LOCK TABLES `legista` WRITE;
/*!40000 ALTER TABLE `legista` DISABLE KEYS */;
INSERT INTO `legista` VALUES (1,'Vanderlei','123,324,456-45','33,333,333-3','das','22/22/2222','(12)12345-1234',2222222,'Viúvo(a)','Feminino','123','Ativo');
/*!40000 ALTER TABLE `legista` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-14 11:49:45
