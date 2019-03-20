CREATE DATABASE  IF NOT EXISTS `smith_restaurant_chain_db` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `smith_restaurant_chain_db`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: smith_restaurant_chain_db
-- ------------------------------------------------------
-- Server version	5.7.19-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `branches`
--

DROP TABLE IF EXISTS `branches`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `branches` (
  `Branch_Num` int(11) NOT NULL,
  `Branch_Name` varchar(45) NOT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Phone` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Branch_Num`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `branches`
--

LOCK TABLES `branches` WRITE;
/*!40000 ALTER TABLE `branches` DISABLE KEYS */;
INSERT INTO `branches` VALUES (1,'McDonalds','212 Creek Way','478-952-4525'),(2,'Zaxbys','224 Angel Road','478-741-3232'),(3,'Steak and Shake','123 Andrew Drive','678-702-0356'),(4,'Red Lobster','456 Rose Way','678-856-1289'),(5,'Longhorns','1241 Bass Road','478-957-5288');
/*!40000 ALTER TABLE `branches` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customers` (
  `Customer_Num` int(11) NOT NULL,
  `Customer_Name` varchar(45) NOT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Phone` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `Last_Date_Visited` date DEFAULT NULL,
  PRIMARY KEY (`Customer_Num`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (65,'Samantha','95 Queen Blvd','478-361-9595','samantha98@gmail.com','2017-08-28'),(140,'Jackson','842 Trout Drive','478-255-2153','jackson.marks@yahoo.com','2016-05-26'),(156,'Trevor','550 Juliette Road','478-835-9149','trevorbass102@gmail.com','2017-09-19'),(195,'Marissa','2152 New Hope Road','678-295-8279','marissaprice95@yahoo.com','2017-01-05'),(200,'John','152 Hawthorne Court','678-195-3569','john.doe01@yahoo.com','2017-04-16');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `food`
--

DROP TABLE IF EXISTS `food`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `food` (
  `Food_Num` int(11) NOT NULL,
  `Food_Name` varchar(45) NOT NULL,
  `Unit_Price` decimal(8,2) NOT NULL,
  PRIMARY KEY (`Food_Num`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `food`
--

LOCK TABLES `food` WRITE;
/*!40000 ALTER TABLE `food` DISABLE KEYS */;
INSERT INTO `food` VALUES (20,'Big Mac',8.00),(21,'Steak and Cheese Melt',11.00),(22,'Wings and Things Meal',9.00),(23,'Crab Legs',15.00),(24,'Filet Mignon',18.00);
/*!40000 ALTER TABLE `food` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sales`
--

DROP TABLE IF EXISTS `sales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sales` (
  `Server_Num` int(11) NOT NULL,
  `Customer_Num` int(11) NOT NULL,
  `Food_Num` int(11) NOT NULL,
  `Date` datetime NOT NULL,
  `Price` decimal(8,2) NOT NULL,
  PRIMARY KEY (`Server_Num`,`Customer_Num`,`Food_Num`),
  KEY `Customer_Num_idx` (`Customer_Num`),
  KEY `Food_Num_idx` (`Food_Num`),
  CONSTRAINT `Customer_Num` FOREIGN KEY (`Customer_Num`) REFERENCES `customers` (`Customer_Num`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Food_Num` FOREIGN KEY (`Food_Num`) REFERENCES `food` (`Food_Num`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Server_Num` FOREIGN KEY (`Server_Num`) REFERENCES `servers` (`Server_Num`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sales`
--

LOCK TABLES `sales` WRITE;
/*!40000 ALTER TABLE `sales` DISABLE KEYS */;
INSERT INTO `sales` VALUES (11,140,20,'2016-02-15 00:00:00',8.00),(25,195,22,'2015-09-07 00:00:00',9.00),(50,65,24,'2017-08-28 00:00:00',18.00),(95,200,23,'2017-01-23 00:00:00',15.00),(113,156,21,'2016-10-27 00:00:00',11.00);
/*!40000 ALTER TABLE `sales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servers`
--

DROP TABLE IF EXISTS `servers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `servers` (
  `Server_Num` int(11) NOT NULL,
  `Server_Name` varchar(45) NOT NULL,
  `Phone` varchar(45) DEFAULT NULL,
  `Hire_Date` date NOT NULL,
  `Branch_Num` int(11) NOT NULL,
  PRIMARY KEY (`Server_Num`,`Branch_Num`),
  KEY `Branch_Num_idx` (`Branch_Num`),
  CONSTRAINT `Branch_Num` FOREIGN KEY (`Branch_Num`) REFERENCES `branches` (`Branch_Num`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servers`
--

LOCK TABLES `servers` WRITE;
/*!40000 ALTER TABLE `servers` DISABLE KEYS */;
INSERT INTO `servers` VALUES (11,'Jane','478-956-3341','2004-01-01',1),(25,'Maurice','678-203-2565','2010-07-08',3),(50,'Timothy','478-250-2023','2013-12-02',5),(95,'Ellen','678-957-8439','2009-02-15',4),(113,'Edward','478-878-7142','2007-11-21',2);
/*!40000 ALTER TABLE `servers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-10-07 11:21:24
