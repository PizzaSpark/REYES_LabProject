CREATE DATABASE  IF NOT EXISTS `db_hospital` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `db_hospital`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: db_hospital
-- ------------------------------------------------------
-- Server version	8.0.34

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
-- Table structure for table `tbl_admin`
--

DROP TABLE IF EXISTS `tbl_admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_admin` (
  `admin_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `admin_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`admin_id`),
  KEY `fk_tbl_admin_tbl_user_idx` (`user_id`),
  CONSTRAINT `fk_tbl_admin_tbl_user` FOREIGN KEY (`user_id`) REFERENCES `tbl_user` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_admin`
--

LOCK TABLES `tbl_admin` WRITE;
/*!40000 ALTER TABLE `tbl_admin` DISABLE KEYS */;
INSERT INTO `tbl_admin` VALUES (9,6,'Dr Eko'),(10,12,'adminSean');
/*!40000 ALTER TABLE `tbl_admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_audit`
--

DROP TABLE IF EXISTS `tbl_audit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_audit` (
  `audit_id` int NOT NULL AUTO_INCREMENT,
  `audit_user_id` int NOT NULL,
  `audit_context` varchar(45) DEFAULT NULL,
  `audit_datetime` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`audit_id`),
  KEY `fk_tbl_audit_tbl_user1_idx` (`audit_user_id`),
  CONSTRAINT `fk_tbl_audit_tbl_user1` FOREIGN KEY (`audit_user_id`) REFERENCES `tbl_user` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_audit`
--

LOCK TABLES `tbl_audit` WRITE;
/*!40000 ALTER TABLE `tbl_audit` DISABLE KEYS */;
INSERT INTO `tbl_audit` VALUES (101,12,'logged in','27/11/2023 8:31:45 pm'),(102,12,'logged in','27/11/2023 8:37:56 pm'),(103,12,'logged in','27/11/2023 8:43:26 pm'),(104,12,'logged in','27/11/2023 8:50:58 pm'),(105,12,'logged in','27/11/2023 9:15:41 pm');
/*!40000 ALTER TABLE `tbl_audit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_billing`
--

DROP TABLE IF EXISTS `tbl_billing`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_billing` (
  `billing_id` int NOT NULL AUTO_INCREMENT,
  `patient_id` int NOT NULL,
  `doctor_id` int NOT NULL,
  `record_id` int NOT NULL,
  `billing_date` varchar(45) DEFAULT NULL,
  `billing_total` varchar(45) DEFAULT NULL,
  `billing_paymentstatus` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`billing_id`),
  KEY `fk_tbl_billing_tbl_doctor1_idx` (`doctor_id`),
  KEY `fk_tbl_billing_tbl_patient1_idx` (`patient_id`),
  KEY `fk_tbl_billing_tbl_medical_record1_idx` (`record_id`),
  CONSTRAINT `fk_tbl_billing_tbl_doctor1` FOREIGN KEY (`doctor_id`) REFERENCES `tbl_doctor` (`doctor_id`),
  CONSTRAINT `fk_tbl_billing_tbl_medical_record1` FOREIGN KEY (`record_id`) REFERENCES `tbl_medical_record` (`record_id`),
  CONSTRAINT `fk_tbl_billing_tbl_patient1` FOREIGN KEY (`patient_id`) REFERENCES `tbl_patient` (`patient_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_billing`
--

LOCK TABLES `tbl_billing` WRITE;
/*!40000 ALTER TABLE `tbl_billing` DISABLE KEYS */;
INSERT INTO `tbl_billing` VALUES (1,1,5,2,'Sunday, 26 November 2023','500','PAID'),(2,3,5,3,'Monday, 27 November 2023','1000','PAID');
/*!40000 ALTER TABLE `tbl_billing` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_doctor`
--

DROP TABLE IF EXISTS `tbl_doctor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_doctor` (
  `doctor_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `doctor_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`doctor_id`),
  KEY `fk_tbl_doctor_tbl_user1_idx` (`user_id`),
  CONSTRAINT `fk_tbl_doctor_tbl_user1` FOREIGN KEY (`user_id`) REFERENCES `tbl_user` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_doctor`
--

LOCK TABLES `tbl_doctor` WRITE;
/*!40000 ALTER TABLE `tbl_doctor` DISABLE KEYS */;
INSERT INTO `tbl_doctor` VALUES (5,7,'Maddieee'),(6,10,'Gracias');
/*!40000 ALTER TABLE `tbl_doctor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_medical_record`
--

DROP TABLE IF EXISTS `tbl_medical_record`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_medical_record` (
  `record_id` int NOT NULL AUTO_INCREMENT,
  `patient_id` int NOT NULL,
  `doctor_id` int NOT NULL,
  `record_date` varchar(45) DEFAULT NULL,
  `record_diagnosis` varchar(45) DEFAULT NULL,
  `record_prescription` varchar(45) DEFAULT NULL,
  `record_treatmentplan` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`record_id`),
  KEY `fk_tbl_medical_record_tbl_patient1_idx` (`patient_id`),
  KEY `fk_tbl_medical_record_tbl_doctor1_idx` (`doctor_id`),
  CONSTRAINT `fk_tbl_medical_record_tbl_doctor1` FOREIGN KEY (`doctor_id`) REFERENCES `tbl_doctor` (`doctor_id`),
  CONSTRAINT `fk_tbl_medical_record_tbl_patient1` FOREIGN KEY (`patient_id`) REFERENCES `tbl_patient` (`patient_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_medical_record`
--

LOCK TABLES `tbl_medical_record` WRITE;
/*!40000 ALTER TABLE `tbl_medical_record` DISABLE KEYS */;
INSERT INTO `tbl_medical_record` VALUES (2,1,5,'Sunday, 26 November 2023','aaaa','ccccc','bbbbbb'),(3,3,5,'Monday, 27 November 2023','uwuinator','yes','3x water');
/*!40000 ALTER TABLE `tbl_medical_record` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_patient`
--

DROP TABLE IF EXISTS `tbl_patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_patient` (
  `patient_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `patient_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`patient_id`),
  KEY `fk_tbl_patient_tbl_user1_idx` (`user_id`),
  CONSTRAINT `fk_tbl_patient_tbl_user1` FOREIGN KEY (`user_id`) REFERENCES `tbl_user` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_patient`
--

LOCK TABLES `tbl_patient` WRITE;
/*!40000 ALTER TABLE `tbl_patient` DISABLE KEYS */;
INSERT INTO `tbl_patient` VALUES (1,8,'please'),(2,9,''),(3,11,NULL);
/*!40000 ALTER TABLE `tbl_patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_user`
--

DROP TABLE IF EXISTS `tbl_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_user` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `user_name` varchar(45) DEFAULT NULL,
  `user_password` varchar(200) DEFAULT NULL,
  `user_isactive` int DEFAULT '0',
  `user_role` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_user`
--

LOCK TABLES `tbl_user` WRITE;
/*!40000 ALTER TABLE `tbl_user` DISABLE KEYS */;
INSERT INTO `tbl_user` VALUES (5,'adminn','471e6604ad6b4f9b85a81305feefb4f7',2,'Admin'),(6,'ekoako','48f6653b9e739014ddc7782df9a2d7c8',1,'Admin'),(7,'donna','83e926426234a579128e08b488e8e0c3',1,'Doctor'),(8,'shane','c02a4c2e497494764881b390fd6dd55f',1,'Patient'),(9,'kerty','4f8bf4cbef18c2e7bb6f3d36d0c60455',1,'Patient'),(10,'doctor','6ce4be7607d13b0bf3119d47b62404c1',1,'Doctor'),(11,'patient','f71b03b9710c39949ed6770bf601fa83',1,'Patient'),(12,'admin','3225cb195fc2b6c5fd8d1fce48994e6c',1,'Admin');
/*!40000 ALTER TABLE `tbl_user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'db_hospital'
--

--
-- Dumping routines for database 'db_hospital'
--
/*!50003 DROP PROCEDURE IF EXISTS `GetDataFromUserId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetDataFromUserId`(IN tableName VARCHAR(255), IN primaryKeyColumnName VARCHAR(255), IN primaryKeyId INT)
BEGIN
    SET @sql_query = CONCAT('SELECT * FROM ', tableName, ' WHERE ', primaryKeyColumnName, ' = ', primaryKeyId);
    PREPARE stmt FROM @sql_query;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-28  0:25:42
