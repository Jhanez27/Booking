CREATE DATABASE  IF NOT EXISTS `bookingsystem` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `bookingsystem`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: bookingsystem
-- ------------------------------------------------------
-- Server version	8.3.0

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
-- Table structure for table `accomodation`
--

DROP TABLE IF EXISTS `accomodation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `accomodation` (
  `acc_trip_id` int NOT NULL,
  `accomodation_id` int NOT NULL AUTO_INCREMENT,
  `accomodation_name` varchar(45) DEFAULT NULL,
  `accomodation_price` int DEFAULT NULL,
  `seatAvailable` int DEFAULT NULL,
  PRIMARY KEY (`accomodation_id`),
  KEY `acc_trip_id_idx` (`acc_trip_id`),
  CONSTRAINT `acc_trip_id` FOREIGN KEY (`acc_trip_id`) REFERENCES `trip` (`trip_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=127 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accomodation`
--

LOCK TABLES `accomodation` WRITE;
/*!40000 ALTER TABLE `accomodation` DISABLE KEYS */;
INSERT INTO `accomodation` VALUES (1,1,'Economy',1100,20),(1,2,'Tourist',1100,20),(1,3,'Business',1500,20),(2,4,'Economy',1100,20),(2,5,'Tourist',1100,19),(2,6,'Business',1500,20),(3,7,'Economy',1100,20),(3,8,'Tourist',1100,20),(3,9,'Business',1500,20),(4,10,'Economy',1100,20),(4,11,'Tourist',1100,20),(4,12,'Business',1500,20),(5,13,'Economy',1100,20),(5,14,'Tourist',1100,20),(5,15,'Business',1500,20),(6,16,'Economy',1100,20),(6,17,'Tourist',1100,20),(6,18,'Business',1500,20),(7,19,'Economy',1100,20),(7,20,'Tourist',1100,20),(7,21,'Business',1500,20),(8,22,'Open Air',800,20),(8,23,'Tourist',800,20),(8,24,'Business',1200,20),(9,25,'Open Air',800,20),(9,26,'Tourist',800,20),(9,27,'Business',1200,20),(10,28,'Open Air',800,20),(10,29,'Tourist',800,20),(10,30,'Business',1200,20),(11,31,'Standard A',600,50),(11,32,'Tourist',780,40),(12,33,'Standard A',600,50),(12,34,'Tourist',780,40),(13,35,'Aircon A',640,40),(13,36,'Economy A',520,50),(13,37,'Economy B',510,50),(13,38,'Economy C',450,50),(14,39,'Tourist',1100,30),(14,40,'Premium',1500,30),(15,41,'Tourist',1100,30),(15,42,'Premium',1500,30),(16,43,'Economy',1100,20),(16,44,'Tourist',1100,20),(16,45,'Business',1500,20),(17,46,'Economy',1100,20),(17,47,'Tourist',1100,20),(17,48,'Business',1500,20),(18,49,'Economy',1100,20),(18,50,'Tourist',1100,20),(18,51,'Business',1500,20),(19,52,'Economy',1100,20),(19,53,'Tourist',1100,20),(19,54,'Business',1500,20),(20,55,'Economy',1100,20),(20,56,'Tourist',1100,20),(20,57,'Business',1500,20),(21,58,'Economy',1100,20),(21,59,'Tourist',1100,20),(21,60,'Business',1500,20),(22,61,'Economy',1100,20),(22,62,'Tourist',1100,20),(22,63,'Business',1500,20),(23,64,'Open Air',800,20),(23,65,'Tourist',800,20),(23,66,'Business',1200,20),(24,67,'Open Air',800,20),(24,68,'Tourist',800,20),(24,69,'Business',1200,20),(25,70,'Open Air',800,20),(25,71,'Tourist',800,20),(25,72,'Business',1200,20),(26,73,'Standard A',600,40),(26,74,'Tourist',780,30),(27,75,'Standard A',600,40),(27,76,'Tourist',780,30),(28,77,'Aircon A',640,30),(28,78,'Economy A',520,40),(28,79,'Economy B',510,50),(28,80,'Economy C',450,50),(29,81,'Tourist',1100,30),(29,82,'Premium',1200,30),(30,83,'Tourist',1100,30),(30,84,'Premium',1200,30),(31,85,'Economy',1100,20),(31,86,'Tourist',1100,20),(31,87,'Business',1500,20),(32,88,'Economy',1100,20),(32,89,'Tourist',1100,20),(32,90,'Business',1500,20),(33,91,'Economy',1100,20),(33,92,'Tourist',1100,20),(33,93,'Business',1500,20),(34,94,'Economy',1100,20),(34,95,'Tourist',1100,20),(34,96,'Business',1500,20),(35,97,'Economy',1100,20),(35,98,'Tourist',1100,20),(35,99,'Business',1500,20),(36,100,'Economy',1100,20),(36,101,'Tourist',1100,20),(36,102,'Business',1500,20),(37,103,'Economy',1100,20),(37,104,'Tourist',1100,20),(37,105,'Business',1500,20),(38,106,'Open Air',800,20),(38,107,'Tourist',800,20),(38,108,'Business',1200,20),(39,109,'Open Air',800,20),(39,110,'Tourist',800,20),(39,111,'Business',1200,20),(40,112,'Open Air',800,20),(40,113,'Tourist',800,20),(40,114,'Business',1200,20),(41,115,'Standard A',600,50),(41,116,'Tourist',780,40),(42,117,'Standard A',600,50),(42,118,'Tourist',780,40),(43,119,'Aircon A',640,40),(43,120,'Economy A',520,50),(43,121,'Economy B',510,50),(43,122,'Economy C',450,50),(44,123,'Tourist',1100,30),(44,124,'Premium',1500,30),(45,125,'Tourist',1100,30),(45,126,'Premium',1500,30);
/*!40000 ALTER TABLE `accomodation` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `update_availableseat_after_insert` AFTER INSERT ON `accomodation` FOR EACH ROW BEGIN
    DECLARE total_accommodations INT;
    -- Corrected the field name to use a valid field for the SUM
    SELECT COALESCE(SUM(seatAvailable), 0) INTO total_accommodations 
    FROM bookingsystem.accomodation 
    WHERE acc_trip_id = NEW.acc_trip_id;

    -- Update availableSeat in the trip table for the related trip
    UPDATE bookingsystem.trip
    SET availableSeat = total_accommodations
    WHERE trip_id = NEW.acc_trip_id;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `update_availableseat_after_update` AFTER UPDATE ON `accomodation` FOR EACH ROW BEGIN
    DECLARE total_accommodations INT;
    -- Corrected the field name to use a valid field for the SUM
    SELECT COALESCE(SUM(seatAvailable), 0) INTO total_accommodations 
    FROM bookingsystem.accomodation 
    WHERE acc_trip_id = NEW.acc_trip_id;

    -- Update availableSeat in the trip table for the related trip
    UPDATE bookingsystem.trip
    SET availableSeat = total_accommodations
    WHERE trip_id = NEW.acc_trip_id;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `boat`
--

DROP TABLE IF EXISTS `boat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `boat` (
  `boat_id` int NOT NULL AUTO_INCREMENT,
  `boat_name` varchar(45) DEFAULT NULL,
  `shipping_line` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`boat_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `boat`
--

LOCK TABLES `boat` WRITE;
/*!40000 ALTER TABLE `boat` DISABLE KEYS */;
INSERT INTO `boat` VALUES (1,'St. Braquiel','Supercat'),(2,'St. Sariel','Supercat'),(3,'St. Jhudiel','Supercat'),(4,'Lite Ferry 16','Lite Shipping'),(5,'MV Rosalia 3','Lapu-Lapu'),(6,'Mv Oasis','Seacat');
/*!40000 ALTER TABLE `boat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `booking`
--

DROP TABLE IF EXISTS `booking`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `booking` (
  `booking_id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(45) DEFAULT NULL,
  `passenger_id` int DEFAULT NULL,
  `trip_id` int DEFAULT NULL,
  `booking_amount` double DEFAULT NULL,
  `booking_date` date DEFAULT NULL,
  `booking_status` varchar(20) DEFAULT NULL,
  `date_cancelled` date DEFAULT NULL,
  PRIMARY KEY (`booking_id`),
  KEY `passenger_id_idx` (`passenger_id`),
  KEY `trip_id_idx` (`trip_id`),
  KEY `username_idx` (`username`),
  CONSTRAINT `passenger_id` FOREIGN KEY (`passenger_id`) REFERENCES `passenger` (`passenger_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `trip_id` FOREIGN KEY (`trip_id`) REFERENCES `trip` (`trip_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `username` FOREIGN KEY (`username`) REFERENCES `user` (`Username`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=69 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `booking`
--

LOCK TABLES `booking` WRITE;
/*!40000 ALTER TABLE `booking` DISABLE KEYS */;
INSERT INTO `booking` VALUES (65,'Jhanez22',72,5,1035,'2024-05-03','Refunded','2024-05-03'),(66,'Jhanez22',73,6,650,'2024-05-03','Cancelled','2024-05-04'),(67,'Jhanez22',74,13,542,'2024-05-04','Refunded','2024-05-04'),(68,'jhanez22',75,2,1035,'2024-05-04','Paid',NULL);
/*!40000 ALTER TABLE `booking` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `passenger`
--

DROP TABLE IF EXISTS `passenger`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `passenger` (
  `passenger_id` int NOT NULL AUTO_INCREMENT,
  `passenger_fname` varchar(45) DEFAULT NULL,
  `passenger_lname` varchar(45) DEFAULT NULL,
  `passenger_age` int DEFAULT NULL,
  `passenger_gender` varchar(1) DEFAULT NULL,
  `passenger_contactNum` varchar(11) DEFAULT NULL,
  `passenger_email` varchar(45) DEFAULT NULL,
  `passenger_ticket_number` varchar(45) NOT NULL,
  `passenger_accomodation` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`passenger_id`),
  UNIQUE KEY `passenger_ticket_number_UNIQUE` (`passenger_ticket_number`)
) ENGINE=InnoDB AUTO_INCREMENT=76 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `passenger`
--

LOCK TABLES `passenger` WRITE;
/*!40000 ALTER TABLE `passenger` DISABLE KEYS */;
INSERT INTO `passenger` VALUES (72,'rigen','suringa',12,'F','09123456789','rigensuringa@gmail.com','2830956957','Economy'),(73,'dean','suringa',12,'M','09123457891','rigensuringa@gmail.com','3009456734','Tourist'),(74,'dssad','dsd',12,'M','09123456789','rigensuringa@gmail.com','1618564883','Economy A'),(75,'adsds','dsad',2,'F','09123456789','rigensuringa@gmail.com','1959043498','Tourist');
/*!40000 ALTER TABLE `passenger` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trip`
--

DROP TABLE IF EXISTS `trip`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trip` (
  `trip_id` int NOT NULL AUTO_INCREMENT,
  `boat_id` int DEFAULT NULL,
  `origin` varchar(45) NOT NULL,
  `destination` varchar(45) NOT NULL,
  `date_departure` datetime DEFAULT NULL,
  `availableSeat` int DEFAULT NULL,
  `trip_ETA` int NOT NULL,
  PRIMARY KEY (`trip_id`),
  KEY `boat_id_idx` (`boat_id`),
  CONSTRAINT `boat_id` FOREIGN KEY (`boat_id`) REFERENCES `boat` (`boat_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trip`
--

LOCK TABLES `trip` WRITE;
/*!40000 ALTER TABLE `trip` DISABLE KEYS */;
INSERT INTO `trip` VALUES (1,1,'Ormoc','Cebu','2024-05-08 05:30:00',60,3),(2,2,'Ormoc','Cebu','2024-05-08 09:00:00',59,3),(3,1,'Ormoc','Cebu','2024-05-08 12:30:00',60,3),(4,2,'Ormoc','Cebu','2024-05-08 04:00:00',60,3),(5,1,'Cebu','Ormoc','2024-05-08 09:00:00',60,3),(6,2,'Cebu','Ormoc','2024-05-08 12:30:00',60,3),(7,1,'Cebu','Ormoc','2024-05-08 04:00:00',60,3),(8,3,'Cebu','Tagbilaran City,Bohol','2024-05-08 05:40:00',60,3),(9,3,'Cebu','Tagbilaran City,Bohol','2024-05-08 10:20:00',60,3),(10,3,'Cebu','Tagbilaran City,Bohol','2024-05-08 15:00:00',60,3),(11,4,'Ormoc','Cebu','2024-05-08 22:00:00',90,6),(12,4,'Cebu','Ormoc','2024-05-08 11:00:00',90,6),(13,5,'Baybay','Cebu','2024-05-08 20:00:00',190,7),(14,6,'Ormoc','Cebu','2024-05-08 10:30:00',60,3),(15,6,'Cebu','Ormoc','2024-05-08 17:30:00',60,3),(16,1,'Ormoc','Cebu','2024-05-09 05:30:00',60,3),(17,2,'Ormoc','Cebu','2024-05-09 09:00:00',60,3),(18,1,'Ormoc','Cebu','2024-05-09 12:30:00',60,3),(19,2,'Ormoc','Cebu','2024-05-09 04:00:00',60,3),(20,1,'Cebu','Ormoc','2024-05-09 09:00:00',60,3),(21,2,'Cebu','Ormoc','2024-05-09 12:30:00',60,3),(22,1,'Cebu','Ormoc','2024-05-09 04:00:00',60,3),(23,3,'Cebu','Tagbilaran City,Bohol','2024-05-09 05:40:00',60,3),(24,3,'Cebu','Tagbilaran City,Bohol','2024-05-09 10:20:00',60,3),(25,3,'Cebu','Tagbilaran City,Bohol','2024-05-09 15:00:00',60,3),(26,4,'Ormoc','Cebu','2024-05-09 22:00:00',70,6),(27,4,'Cebu','Ormoc','2024-05-09 11:00:00',70,6),(28,5,'Baybay','Cebu','2024-05-09 20:00:00',170,7),(29,6,'Ormoc','Cebu','2024-05-09 10:30:00',60,3),(30,6,'Cebu','Ormoc','2024-05-09 17:30:00',60,3),(31,1,'Ormoc','Cebu','2024-05-10 05:30:00',60,3),(32,2,'Ormoc','Cebu','2024-05-10 09:00:00',60,3),(33,1,'Ormoc','Cebu','2024-05-10 12:30:00',60,3),(34,2,'Ormoc','Cebu','2024-05-10 04:00:00',60,3),(35,1,'Cebu','Ormoc','2024-05-10 09:00:00',60,3),(36,2,'Cebu','Ormoc','2024-05-10 12:30:00',60,3),(37,1,'Cebu','Ormoc','2024-05-10 04:00:00',60,3),(38,3,'Cebu','Tagbilaran City,Bohol','2024-05-10 05:40:00',60,3),(39,3,'Cebu','Tagbilaran City,Bohol','2024-05-10 10:20:00',60,3),(40,3,'Cebu','Tagbilaran City,Bohol','2024-05-10 15:00:00',60,3),(41,4,'Ormoc','Cebu','2024-05-10 22:00:00',90,6),(42,4,'Cebu','Ormoc','2024-05-10 11:00:00',90,6),(43,5,'Baybay','Cebu','2024-05-10 20:00:00',190,7),(44,6,'Ormoc','Cebu','2024-05-10 10:30:00',60,3),(45,6,'Cebu','Ormoc','2024-05-10 17:30:00',60,3);
/*!40000 ALTER TABLE `trip` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `Username` varchar(20) NOT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `Email_Address` varchar(45) DEFAULT NULL,
  `Contact_Number` varchar(11) DEFAULT NULL,
  `Fname` varchar(25) DEFAULT NULL,
  `Lname` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES ('Jhanez','1234','rigensuringa@gmail.com','09662313505','rigen','suringa'),('jhanez22','123','rigensuringa2@gmail.com','09662313505','rigen','suringa');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-04  9:10:32
