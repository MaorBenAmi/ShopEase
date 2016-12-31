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
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `client` (
  `FirstName` varchar(12) NOT NULL,
  `LastName` varchar(12) NOT NULL,
  `ClientId` int(11) NOT NULL,
  `Gender` varchar(12) NOT NULL,
  `DateOfBirth` datetime NOT NULL,
  `Phone` int(11) DEFAULT NULL,
  `Latitude` double NOT NULL,
  `Longitude` double NOT NULL,
  `SizeOfShirt` varchar(5) NOT NULL,
  `SizeOfPants` int(11) NOT NULL,
  `SizeOfHat` int(11) NOT NULL,
  `SizeOfShoe` int(11) NOT NULL,
  `SizeOfBra` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES ('tomer','lavie',1,'Male','1994-04-06 00:00:00',528461399,32.12584,34.797256,'S',36,2,42,'NULL'),('omer','levy',2,'Male','1955-04-24 00:00:00',507821937,32.1008865,34.8283563,'M',56,4,46,'NULL'),('yoav','livne',3,'Male','1962-11-19 00:00:00',533955183,32.0134621,34.7813408,'L',44,3,44,'NULL'),('nadav','cohen',4,'Male','1959-06-08 00:00:00',549266493,29.5661028,34.9532277,'M',34,2,41,'NULL'),('yarden','bar',5,'Male','1978-10-12 00:00:00',503855027,31.7778393,34.6820999,'S',40,4,43,'NULL'),('shahar','levin',6,'Male','1976-07-04 00:00:00',528263511,32.0753918,34.7755606,'M',38,3,46,'NULL'),('liran','gat',7,'Male','1973-03-17 00:00:00',538361106,31.983454,34.111213,'L',52,4,45,'NULL'),('shay','beck',8,'Male','1992-12-28 00:00:00',547583089,32.784321,35.0078414,'M',38,1,38,'NULL'),('rona','dakar',9,'Female','1983-05-11 00:00:00',559381538,31.9934616,34.774205,'XL',40,1,37,'B-70'),('alona','peer',10,'Female','1987-07-01 00:00:00',507365513,31.8890365,34.9622243,'M',42,3,40,'C-85'),('yael','shtern',11,'Female','1989-09-18 00:00:00',522468396,33.2073353,35.5900212,'S',38,2,39,'D-75'),('noya','koren',12,'Female','2000-01-01 00:00:00',537351349,31.7781893,35.3884078,'XL',32,1,36,'C-70'),('hila','sela',13,'Female','2010-08-14 00:00:00',548903647,29.5454376,34.9539158,'M',10,0,30,'DD-80'),('hen','wolf',14,'Female','2006-02-05 00:00:00',556385295,31.8933048,34.8437781,'S',14,1,34,'C-90'),('hadar','asulin',15,'Female','2014-06-02 00:00:00',508361439,31.8931248,34.8068481,'M',32,0,20,'B-70'),('maor','ben ami',16,'Male','1993-06-02 00:00:00',548102976,32.015833,34.787384,'L',28,1,40,'NULL'),('beni','cohen',17,'Male','2004-06-16 00:00:00',548131968,32.013186,34.748019,'M',30,1,42,'NULL'),('mira','levi',18,'Female','1944-06-13 00:00:00',534582926,31.943507,34.83904,'XL',34,2,38,'C-75'),('koral','levi',19,'Female','1992-09-25 00:00:00',545841024,31.9784555,34.7608149,'M',26,2,37,'B-70'),('noy','malca',20,'Female','1988-08-15 00:00:00',548107008,32.8146739,35.0778714,'L',30,2,37,'B-75'),('mor','vaknin',21,'Male','1993-04-04 00:00:00',506587008,32.0948957,34.8184986,'XL',38,3,47,'NULL'),('michal','gordon',22,'Female','1990-06-14 00:00:00',534582119,32.085814,34.774667,'M',28,3,46,'C-34'),('moshe','kala',23,'Female','1993-01-04 00:00:00',546982016,32.4482016,34.9068298,'S',40,2,42,'C-75'),('nir','yosi',24,'Female','1983-07-29 00:00:00',543166016,32.107199,34.793351,'L',40,3,41,'B-90'),('barak','yacov',25,'Male','1991-07-03 00:00:00',523857309,31.8806129,34.7274423,'M',40,2,45,'NULL'),('amit','lechiani',26,'Male','1988-12-26 00:00:00',556378402,31.972789,34.784079,'M',40,2,39,'NULL'),('lior','asulin',27,'Female','2003-02-19 00:00:00',548102976,32.970665,35.564776,'S',40,2,42,'DD-70');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
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
