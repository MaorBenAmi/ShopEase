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
-- Table structure for table `shoppinglist`
--

DROP TABLE IF EXISTS `shoppinglist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `shoppinglist` (
  `ListName` varchar(25) NOT NULL,
  `ClientId` int(11) NOT NULL,
  `Gender` varchar(12) NOT NULL,
  `Class` varchar(12) NOT NULL,
  `Type` varchar(12) NOT NULL,
  `Model` varchar(12) NOT NULL,
  PRIMARY KEY (`ListName`,`ClientId`,`Gender`,`Class`,`Type`,`Model`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shoppinglist`
--

LOCK TABLES `shoppinglist` WRITE;
/*!40000 ALTER TABLE `shoppinglist` DISABLE KEYS */;
INSERT INTO `shoppinglist` VALUES ('for my childrens',10,'Children','Clothing','shirt','casual'),('for my childrens',10,'Female','Accssorise','hat','wool'),('for my childrens',10,'Female','Footwear','shoes','sport'),('friend\'s birthday',1,'Adults','Books','book','cooking'),('my brotherw\'s wedding',2,'female','Clothing','dress','elegant'),('my brotherw\'s wedding',2,'female','Clothing','pants','Tights'),('my brotherw\'s wedding',2,'female','Footwear','shoes','elegant'),('my brotherw\'s wedding',2,'female','Lingerie','bra','bikini'),('my brotherw\'s wedding',2,'female','Lingerie','underpants','thong'),('my brotherw\'s wedding',2,'male','Accssorise','hat','baseball'),('my brotherw\'s wedding',2,'male','Clothing','pants','jeans'),('my brotherw\'s wedding',2,'male','Clothing','shirt','elegant'),('my brotherw\'s wedding',2,'male','Lingerie','socks','elegant'),('renew my closet',1,'male','Clothing','pants','elegant'),('renew my closet',1,'male','Clothing','pants','jeans'),('renew my closet',1,'male','Clothing','shirt','casual'),('renew my closet',1,'male','Clothing','shirt','polo'),('renew my closet',1,'male','Footwear','shoes','boots'),('renew my closet',1,'male','Footwear','shoes','elegant'),('renew my closet',1,'male','Footwear','shoes','sandals'),('renew my closet',1,'male','Lingerie','underpants','boxer');
/*!40000 ALTER TABLE `shoppinglist` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-31 14:30:09
