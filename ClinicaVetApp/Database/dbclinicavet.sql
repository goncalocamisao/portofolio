-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: dbclinicavet
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
-- Table structure for table `agendamentoconsultas`
--

DROP TABLE IF EXISTS `agendamentoconsultas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `agendamentoconsultas` (
  `IdAgendamento` int NOT NULL AUTO_INCREMENT,
  `NomeAnimal` varchar(100) DEFAULT NULL,
  `TipoConsulta` varchar(100) DEFAULT NULL,
  `Colaborador` varchar(100) DEFAULT NULL,
  `ContatoTelefonico` varchar(100) DEFAULT NULL,
  `DataConsulta` varchar(100) DEFAULT NULL,
  `HoraConsulta` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdAgendamento`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agendamentoconsultas`
--

LOCK TABLES `agendamentoconsultas` WRITE;
/*!40000 ALTER TABLE `agendamentoconsultas` DISABLE KEYS */;
INSERT INTO `agendamentoconsultas` VALUES (1,'ace','vacinacao','','','7/22/2023',''),(2,'luna','vacinacao','luisa','29484934','7/22/2023','14:00');
/*!40000 ALTER TABLE `agendamentoconsultas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `atosmedicos`
--

DROP TABLE IF EXISTS `atosmedicos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `atosmedicos` (
  `IdAtosMedicos` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(200) DEFAULT NULL,
  `Preco` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdAtosMedicos`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `atosmedicos`
--

LOCK TABLES `atosmedicos` WRITE;
/*!40000 ALTER TABLE `atosmedicos` DISABLE KEYS */;
INSERT INTO `atosmedicos` VALUES (1,'Vacinação','20');
/*!40000 ALTER TABLE `atosmedicos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `IdCliente` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) DEFAULT NULL,
  `DataNascimento` varchar(100) DEFAULT NULL,
  `NIF` varchar(100) DEFAULT NULL,
  `Contatos` varchar(100) DEFAULT NULL,
  `Estado` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (1,'João Rosa','2/9/2022','351222999','911111111','Inativo'),(2,'Henrique','7/22/2023','','','');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fichamedica`
--

DROP TABLE IF EXISTS `fichamedica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fichamedica` (
  `IdFichaMedica` int NOT NULL AUTO_INCREMENT,
  `PacienteId` varchar(100) DEFAULT NULL,
  `DataAtendimento` varchar(100) DEFAULT NULL,
  `TipoConsulta` varchar(100) DEFAULT NULL,
  `Colaborador` varchar(100) DEFAULT NULL,
  `Diagnostico` varchar(100) DEFAULT NULL,
  `AtoMedico` varchar(100) DEFAULT NULL,
  `Peso` varchar(100) DEFAULT NULL,
  `Observacoes` varchar(100) DEFAULT NULL,
  `PrescricaoMedica` varchar(100) DEFAULT NULL,
  `ProximaVisita` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdFichaMedica`),
  KEY `PacienteId` (`PacienteId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fichamedica`
--

LOCK TABLES `fichamedica` WRITE;
/*!40000 ALTER TABLE `fichamedica` DISABLE KEYS */;
/*!40000 ALTER TABLE `fichamedica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `funcionarios`
--

DROP TABLE IF EXISTS `funcionarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `funcionarios` (
  `IdFuncionario` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) DEFAULT NULL,
  `DataNascimento` varchar(100) DEFAULT NULL,
  `NIF` varchar(100) DEFAULT NULL,
  `TipoColaborador` varchar(100) DEFAULT NULL,
  `Funcao` varchar(100) DEFAULT NULL,
  `DataInicioColaboracao` varchar(100) DEFAULT NULL,
  `DataFimColaboracao` varchar(100) DEFAULT NULL,
  `Contatos` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdFuncionario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcionarios`
--

LOCK TABLES `funcionarios` WRITE;
/*!40000 ALTER TABLE `funcionarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `funcionarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacientes`
--

DROP TABLE IF EXISTS `pacientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pacientes` (
  `IdPaciente` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) DEFAULT NULL,
  `DataNascimento` varchar(100) DEFAULT NULL,
  `DataFalecimento` varchar(100) DEFAULT NULL,
  `DataUltimaConsulta` varchar(100) DEFAULT NULL,
  `TipoAnimal` varchar(100) DEFAULT NULL,
  `Raca` varchar(100) DEFAULT NULL,
  `Sexo` varchar(100) DEFAULT NULL,
  `Peso` varchar(100) DEFAULT NULL,
  `Estado` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdPaciente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacientes`
--

LOCK TABLES `pacientes` WRITE;
/*!40000 ALTER TABLE `pacientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `pacientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produtos` (
  `IdProduto` int NOT NULL AUTO_INCREMENT,
  `TipoFamilia` varchar(100) DEFAULT NULL,
  `Descricao` varchar(200) DEFAULT NULL,
  `QuantidadeArmazem` varchar(100) DEFAULT NULL,
  `PrecoUnitario` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdProduto`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtos`
--

LOCK TABLES `produtos` WRITE;
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` VALUES (1,'Desparasitação','','100','10');
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-07-28 15:03:11
