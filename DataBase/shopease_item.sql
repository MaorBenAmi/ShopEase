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
-- Table structure for table `item`
--

DROP TABLE IF EXISTS `item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `item` (
  `CatalogNumber` int(11) NOT NULL,
  `Gender` varchar(12) NOT NULL,
  `Class` varchar(12) NOT NULL,
  `Type` varchar(12) NOT NULL,
  `Model` varchar(12) NOT NULL,
  PRIMARY KEY (`CatalogNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item`
--

LOCK TABLES `item` WRITE;
/*!40000 ALTER TABLE `item` DISABLE KEYS */;
INSERT INTO `item` VALUES (1,'Male','Clothing','Shirt','Casual'),(2,'Male','Clothing','Shirt','Pajamas'),(3,'Male','Clothing','Shirt','Buttoned'),(4,'Male','Clothing','Shirt','Polo'),(5,'Male','Clothing','Shirt','Training'),(6,'Male','Clothing','Shirt','Sport'),(7,'Male','Clothing','Pants','Casual'),(8,'Male','Clothing','Pants','Pajamas'),(9,'Male','Clothing','Pants','Training'),(10,'Male','Clothing','Pants','Sport'),(11,'Male','Clothing','Pants','Elegant'),(12,'Male','Clothing','Pants','Jeans'),(13,'Male','Footwear','Shoes','Casual'),(14,'Male','Footwear','Shoes','Sport'),(15,'Male','Footwear','Shoes','Elegant'),(16,'Male','Footwear','Shoes','Boots'),(17,'Male','Footwear','Shoes','Flip Flops'),(18,'Male','Footwear','Shoes','Sandals'),(19,'Male','Lingerie','Socks','Casual'),(20,'Male','Lingerie','Socks','Sport'),(21,'Male','Lingerie','Socks','Elegant'),(22,'Male','Lingerie','Socks','Wool'),(23,'Male','Accssorise','Hat','Baseball'),(24,'Male','Accssorise','Hat','Wide margins'),(25,'Male','Accssorise','Hat','Wool'),(26,'Male','Lingerie','Underpants','Boxer'),(27,'Male','Lingerie','Underpants','Tanga'),(28,'Female','Clothing','Shirt','Casual'),(29,'Female','Clothing','Shirt','Pajamas'),(30,'Female','Clothing','Shirt','Buttoned'),(31,'Female','Clothing','Shirt','Training'),(32,'Female','Clothing','Shirt','Sport'),(33,'Female','Clothing','Shirt','Polo'),(34,'Female','Clothing','Pants','Casual'),(35,'Female','Clothing','Pants','Pajamas'),(36,'Female','Clothing','Pants','Training'),(37,'Female','Clothing','Pants','Sport'),(38,'Female','Clothing','Pants','Elegant'),(39,'Female','Clothing','Pants','Jeans'),(40,'Female','Clothing','Pants','Tights'),(41,'Female','Clothing','Dress','Mini'),(42,'Female','Clothing','Dress','Maxi'),(43,'Female','Footwear','Shoes','Casual'),(44,'Female','Footwear','Shoes','Sport'),(45,'Female','Footwear','Shoes','Elegant'),(46,'Female','Footwear','Shoes','Boots'),(47,'Female','Footwear','Shoes','Flip Flops'),(48,'Female','Footwear','Shoes','Sandals'),(49,'Female','Lingerie','Socks','Casual'),(50,'Female','Lingerie','Socks','Sport'),(51,'Female','Lingerie','Socks','Elegant'),(52,'Female','Lingerie','Socks','Wool'),(53,'Female','Lingerie','Bra','Bikini'),(54,'Female','Lingerie','Bra','Sport'),(55,'Female','Accssorise','Hat','Baseball'),(56,'Female','Accssorise','Hat','Wide Margins'),(57,'Female','Accssorise','Hat','Wool'),(58,'Female','Lingerie','Underpants','Thong'),(59,'Female','Lingerie','Underpants','Tanga'),(60,'Female','Lingerie','Underpants','Bikini'),(61,'Children','Clothing','Shirt','Casual'),(62,'Children','Clothing','Shirt','Pajamas'),(63,'Children','Clothing','Shirt','Buttoned'),(64,'Children','Clothing','Shirt','Polo'),(65,'Children','Clothing','Shirt','Training'),(66,'Children','Clothing','Shirt','Sport'),(67,'Children','Clothing','Pants','Casual'),(68,'Children','Clothing','Pants','Pajamas'),(69,'Children','Clothing','Pants','Training'),(70,'Children','Clothing','Pants','Sport'),(71,'Children','Clothing','Pants','Elegant'),(72,'Children','Clothing','Pants','Jeans'),(73,'Children','Clothing','Pants','Tights'),(74,'Children','Clothing','Dress','Mini'),(75,'Children','Clothing','Dress','Maxi'),(76,'Children','Footwear','Shoes','Casual'),(77,'Children','Footwear','Shoes','Sport'),(78,'Children','Footwear','Shoes','Elegant'),(79,'Children','Footwear','Shoes','Boots'),(80,'Children','Footwear','Shoes','Flip Flops'),(81,'Children','Footwear','Shoes','Sandals'),(82,'Children','Lingerie','Socks','Casual'),(83,'Children','Lingerie','Socks','Sport'),(84,'Children','Lingerie','Socks','Elegant'),(85,'Children','Lingerie','Socks','Wool'),(86,'Children','Accssorise','Hat','Baseball'),(87,'Children','Accssorise','Hat','Wide Margins'),(88,'Children','Accssorise','Hat','Wool'),(89,'Children','Lingerie','Underpants','Tanga'),(90,'Children','Books','Book','Childrens'),(91,'Adults','Books','Book','Nonfiction'),(92,'Adults','Books','Book','Novel'),(93,'Adults','Books','Book','Thriller'),(94,'Adults','Books','Book','Information'),(95,'Adults','Books','Book','Tourist'),(96,'Adults','Books','Book','Cooking'),(97,'Adults','Books','Book','Parenthood'),(98,'Adults','Books','Book','Psychology'),(99,'Adults','Books','Book','Gift'),(100,'Youth','Books','Book','Nonfiction'),(101,'Youth','Books','Book','Novel'),(102,'Youth','Books','Book','Thriller'),(103,'Youth','Books','Book','Gift');
/*!40000 ALTER TABLE `item` ENABLE KEYS */;
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
