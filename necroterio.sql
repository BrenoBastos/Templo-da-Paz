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
  `Nome` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Cpf` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Rg` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Endereco` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `DataNasc` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Contato` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `EstadoCivil` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Sexo` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Senha` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Status` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  PRIMARY KEY (`Id`,`Cpf`,`Rg`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assistente`
--

LOCK TABLES `assistente` WRITE;
/*!40000 ALTER TABLE `assistente` DISABLE KEYS */;
INSERT INTO `assistente` VALUES (1,'Beatriz','213,123,123-12','31,231,231-2','321','31/23/1232','(12)09876-2313','União Estável','Não definido','123','Ativo'),(2,'Lucas','333,333,333-33','33,333,333-3','asd','22/22/2222','(12)12345-1234','União Estável','Não definido','abc','Ativo'),(3,'Juliana','763,563,646-35','63,563,634-5','Rua Cachoeira.89','10/06/2000','(12)1234-2345','Solteiro(a)','Feminino','123','Inativo');
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
  `Nome` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Gaveta` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Assistente` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Legista` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci DEFAULT NULL,
  `Laudo` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci DEFAULT NULL,
  `Material` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci DEFAULT NULL,
  `Quantidade` int DEFAULT NULL,
  `DataChegada` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `HorarioChegada` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Dataretirada` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Horarioretirada` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `DataObito` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `HorarioObito` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Retirada` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cadaver`
--

LOCK TABLES `cadaver` WRITE;
/*!40000 ALTER TABLE `cadaver` DISABLE KEYS */;
INSERT INTO `cadaver` VALUES (1,'Guilherme','A','Lucas','Vanderlei','a','Tesoura',1,'22/12/2023','22:00','22/01/2023','23:12','22/12/2023','10:13','Velório Municipal'),(2,'Ruan','A','Beatriz','Vanderlei','a','Mouse',1,'22/12/2023','23:00','23/10/2023','12:30','22/12/2023','22:10','Espera'),(3,'Igor','C','Beatriz','Vanderlei','b','Mouse',1,'15/05/2023','20:30','16/05/2023','23:00','15/05/2023','19:00','Velório Municipal'),(4,'Joao','B','Beatriz','Vanderlei','b','Mouse',1,'15/05/2023','20:40','16/05/2023','20:00','14/05/2023','23:00','Espera'),(6,'Ruan','D','Beatriz','VAnderlei','a','Mouse',2,'22/22/2222','22:22','22/22/2222','22:22','22/22/2222','22:22','Velório Municipal'),(7,'Caio','E','Beatriz','Vanderlei','a','Mouse',12,'15/02/2000','00:00','16/02/2000','23:00','14/02/2000','00:00','Espera'),(8,'Juan','F','Beatriz','Vanderlei','c','mouse',1,'16/05/2023','22:00','17/05/2023','23:00','16/05/2023','21:00','Funerária'),(9,'Estevam','G','Lucas','Rafael','c','Algodão',12,'18/05/2023','22:22','19/05/2023','20:00','18/05/2023','20:00','Velório Municipal'),(11,'Nathan','I','Beatriz','Rafael','a','Tesoura',2,'18/05/2023','22:22','19/05/2023','22:22','17/05/2023','23:00','Funerária'),(12,'Angelo','J','Beatriz','Vanderlei','d','Algodão',3,'20/06/2022','22:22','21/07/2022','00:01','20/26/2022','20:00','Velório Municipal');
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
  `Material` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci DEFAULT NULL,
  `Quantidade` int NOT NULL,
  `Fornecedor` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Total` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estoque`
--

LOCK TABLES `estoque` WRITE;
/*!40000 ALTER TABLE `estoque` DISABLE KEYS */;
INSERT INTO `estoque` VALUES (1,'Formol',2,'Juliana',NULL),(2,'Formol',2,'Juliana',NULL),(3,'Tesoura',2,'Claudia',NULL),(4,'Algodão',2,'Gustavo',NULL),(5,'Algodão',2,'Gustavo',NULL),(6,'Algodão',3,'Claudia',NULL);
/*!40000 ALTER TABLE `estoque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estoquee`
--

DROP TABLE IF EXISTS `estoquee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estoquee` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Material` varchar(45) COLLATE utf8mb3_general_mysql500_ci DEFAULT NULL,
  `Quantidade` int NOT NULL,
  `Fornecedor` varchar(45) COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Total` int DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estoquee`
--

LOCK TABLES `estoquee` WRITE;
/*!40000 ALTER TABLE `estoquee` DISABLE KEYS */;
INSERT INTO `estoquee` VALUES (1,'Álcool',2,'Juliana',NULL),(2,'Álcool',2,'Gustavo',NULL),(3,'Formol',2,'Claudia',NULL);
/*!40000 ALTER TABLE `estoquee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fornecedor`
--

DROP TABLE IF EXISTS `fornecedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fornecedor` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Cpf` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Endereco` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Contato` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Status` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  PRIMARY KEY (`Id`,`Cpf`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedor`
--

LOCK TABLES `fornecedor` WRITE;
/*!40000 ALTER TABLE `fornecedor` DISABLE KEYS */;
INSERT INTO `fornecedor` VALUES (1,'Juliana','333,333,333-33','dasd','(12)1234-1234','Ativo'),(2,'Pedro','323,143,543-53','das','(12)1234-1234','Inativo'),(3,'Gustavo','645,373,563-65','Rua dez,90','(12)12345-1234','Inativo'),(4,'Claudia','635,875,673-63','Rua Silva,67','(12)1234-1234','Ativo');
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
  `Cpf` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Rg` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Endereco` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `DataNasc` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Contato` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Crm` int NOT NULL,
  `EstadoCivil` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Sexo` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Senha` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  `Status` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci NOT NULL,
  PRIMARY KEY (`Id`,`Cpf`,`Rg`,`Crm`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `legista`
--

LOCK TABLES `legista` WRITE;
/*!40000 ALTER TABLE `legista` DISABLE KEYS */;
INSERT INTO `legista` VALUES (1,'Vanderlei','123,324,456-45','33,333,333-3','das','22/22/2222','(12)12345-1235',2222222,'Viúvo(a)','Feminino','123','Ativo'),(2,'Guilherme','957,896,346-78','98,745,645-9','Rua Ipiranga,78','20/06/1990','(12)12345-1234',6536453,'União Estável','Não definido','123','Inativo'),(3,'Rafael','566,747,647-46','73,657,563-7','Rua Portugal,23','53/42/3423','(12)12345-1234',4134232,'União Estável','Feminino','123','Ativo');
/*!40000 ALTER TABLE `legista` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'necroterio'
--

--
-- Dumping routines for database 'necroterio'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-18 20:09:41
