-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: shopease
-- ------------------------------------------------------
-- Server version	5.7.11-log

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
-- Table structure for table `shoppingcenter`
--

DROP TABLE IF EXISTS `shoppingcenter`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `shoppingcenter` (
  `ShoppingCenterName` varchar(12) NOT NULL,
  `ShoppingCenterCity` varchar(25) NOT NULL,
  `ShoppingCenterLatitude` double NOT NULL,
  `ShoppingCenterLongitude` double NOT NULL,
  PRIMARY KEY (`ShoppingCenterName`,`ShoppingCenterCity`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shoppingcenter`
--

LOCK TABLES `shoppingcenter` WRITE;
/*!40000 ALTER TABLE `shoppingcenter` DISABLE KEYS */;
INSERT INTO `shoppingcenter` VALUES ('arena','herzeliya',32.16304,34.797256),('ayalon','ramat gan',32.1008865,34.8266763),('azrieli','holon',32.0129511,34.7813408),('big','eilat',29.5661028,34.9598577),('big fashion','ashdod',31.7762093,34.6820999),('center','tel aviv',32.0754538,34.7755606),('cinema city','rishon lezion',31.983454,34.771213),('grand canyon','haifa',32.789711,35.0078224),('hazahav','rishon lezion',31.9903016,34.774205),('ishpro','modiin',31.8890365,34.9634743),('mall','kiryat shmona',33.2073828,35.5900212),('mamila','jerusalem',31.7781893,35.2234078),('mol hayam','eilat',29.5497876,34.9539158),('ofer','rehovot',31.8933048,34.8068481);
/*!40000 ALTER TABLE `shoppingcenter` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-31 14:30:08
