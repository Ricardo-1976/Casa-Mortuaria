-- MySqlBackup.NET 2.0.4
-- Dump Time: 2021-08-01 20:55:41
-- --------------------------------------
-- Server version 5.7.23 MySQL Community Server (GPL)


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of tbl_causamorte
-- 

DROP TABLE IF EXISTS `tbl_causamorte`;
CREATE TABLE IF NOT EXISTS `tbl_causamorte` (
  `id_CausaMorte` int(11) NOT NULL AUTO_INCREMENT,
  `_local_morte` longtext,
  `_causa_morte` longtext,
  `_descr_morte` longtext,
  `id_Morto` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_CausaMorte`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tbl_causamorte
-- 

/*!40000 ALTER TABLE `tbl_causamorte` DISABLE KEYS */;
INSERT INTO `tbl_causamorte`(`id_CausaMorte`,`_local_morte`,`_causa_morte`,`_descr_morte`,`id_Morto`) VALUES
(8,'Hospital','Covid_19','---------------------------','9'),
(3,'Hostital','Malaria','-------------','3'),
(6,'Hospital','Malaria','---------','7'),
(7,'Hospital','Covid-19','------------------------','8');
/*!40000 ALTER TABLE `tbl_causamorte` ENABLE KEYS */;

-- 
-- Definition of tbl_estadocivil
-- 

DROP TABLE IF EXISTS `tbl_estadocivil`;
CREATE TABLE IF NOT EXISTS `tbl_estadocivil` (
  `id_EstadoCivil` int(11) NOT NULL AUTO_INCREMENT,
  `_nome` varchar(150) DEFAULT NULL,
  `id_Morto` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id_EstadoCivil`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tbl_estadocivil
-- 

/*!40000 ALTER TABLE `tbl_estadocivil` DISABLE KEYS */;
INSERT INTO `tbl_estadocivil`(`id_EstadoCivil`,`_nome`,`id_Morto`) VALUES
(1,'Maria Bernado Feliz','2'),
(4,'António Alberto Kaka','9');
/*!40000 ALTER TABLE `tbl_estadocivil` ENABLE KEYS */;

-- 
-- Definition of tbl_filhos
-- 

DROP TABLE IF EXISTS `tbl_filhos`;
CREATE TABLE IF NOT EXISTS `tbl_filhos` (
  `id_Filhos` int(11) NOT NULL AUTO_INCREMENT,
  `_nome` varchar(150) DEFAULT NULL,
  `id_Morto` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id_Filhos`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tbl_filhos
-- 

/*!40000 ALTER TABLE `tbl_filhos` DISABLE KEYS */;
INSERT INTO `tbl_filhos`(`id_Filhos`,`_nome`,`id_Morto`) VALUES
(5,'Jose Fernando','3'),
(4,'Elieth Fernado','3'),
(11,'Gracieth Francisco Da Silva','8'),
(10,'Paulo Francisco Da Silva','8'),
(12,'Cleucio Francisco Da Silva','8'),
(13,'Junior Kaka','9');
/*!40000 ALTER TABLE `tbl_filhos` ENABLE KEYS */;

-- 
-- Definition of tbl_morto
-- 

DROP TABLE IF EXISTS `tbl_morto`;
CREATE TABLE IF NOT EXISTS `tbl_morto` (
  `id_Morto` int(11) NOT NULL AUTO_INCREMENT,
  `_nome` varchar(150) NOT NULL,
  `_nbi` varchar(50) NOT NULL,
  `_natural` varchar(100) NOT NULL,
  `_provincia` varchar(100) NOT NULL,
  `_sexo` enum('M','F') DEFAULT NULL,
  `_esta_civil` enum('S','C') DEFAULT NULL,
  `_data_nascimento` date DEFAULT NULL,
  `_data_morte` date DEFAULT NULL,
  `_data_cadastro` date DEFAULT NULL,
  `_img_morto` longtext,
  `ano` varchar(100) DEFAULT NULL,
  `mes` varchar(100) DEFAULT NULL,
  `dia` varchar(100) DEFAULT NULL,
  `id_Usuario` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_Morto`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tbl_morto
-- 

/*!40000 ALTER TABLE `tbl_morto` DISABLE KEYS */;
INSERT INTO `tbl_morto`(`id_Morto`,`_nome`,`_nbi`,`_natural`,`_provincia`,`_sexo`,`_esta_civil`,`_data_nascimento`,`_data_morte`,`_data_cadastro`,`_img_morto`,`ano`,`mes`,`dia`,`id_Usuario`) VALUES
(3,'Manuel Fermando','004508765LA467','Luanda','Lunda','M','S','1989-02-01 00:00:00','2021-06-28 00:00:00','2021-07-31 00:00:00','C:\\Users\\Ricardo\\Pictures\\Pictures\\66413808_366441807391289_1214600357418631168_n.jpg','2021','6','28','1'),
(7,'David De Sousa','0065087LA76533','Luanda','Luanda','M','S','2003-02-06 00:00:00','2021-06-29 00:00:00','2021-07-31 00:00:00','C:\\Users\\Ricardo\\Pictures\\Pictures\\13006633_508978455972979_8796831854885000908_n.jpg','2021','6','29','1'),
(8,'Maria Diogo Francisco','00987876UI7545','Uige','Uige','F','S','1969-02-06 00:00:00','2021-07-30 00:00:00','2021-08-01 00:00:00','C:\\Users\\Ricardo\\Pictures\\Pictures\\22154213_120181958663729_6635381760292992279_n.jpg','2021','7','30','1'),
(9,'Victória Manuel Kaka','000987687L5688','Luanda','Luanda','F','C','1993-02-11 00:00:00','2010-11-26 00:00:00','2021-08-01 00:00:00','C:\\Users\\Ricardo\\Pictures\\Pictures\\8-PARA PAM FLRTOS\\12-14-5.jpg','2010','11','26','1');
/*!40000 ALTER TABLE `tbl_morto` ENABLE KEYS */;

-- 
-- Definition of tbl_pais
-- 

DROP TABLE IF EXISTS `tbl_pais`;
CREATE TABLE IF NOT EXISTS `tbl_pais` (
  `id_Pais` int(11) NOT NULL AUTO_INCREMENT,
  `_nome_pai` varchar(150) DEFAULT NULL,
  `_nome_mae` varchar(150) DEFAULT NULL,
  `id_Morto` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id_Pais`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tbl_pais
-- 

/*!40000 ALTER TABLE `tbl_pais` DISABLE KEYS */;
INSERT INTO `tbl_pais`(`id_Pais`,`_nome_pai`,`_nome_mae`,`id_Morto`) VALUES
(3,'Fernando José','Maria Manuel José','3'),
(7,'José De Sousa','Marcia Manuel','7'),
(8,'Francisco Kapassa','Jurelma Diogo','8'),
(9,'Manuel José','Safira Alberto','9');
/*!40000 ALTER TABLE `tbl_pais` ENABLE KEYS */;

-- 
-- Definition of tbl_rec_causamorte
-- 

DROP TABLE IF EXISTS `tbl_rec_causamorte`;
CREATE TABLE IF NOT EXISTS `tbl_rec_causamorte` (
  `id_CausaMorte` int(11) NOT NULL AUTO_INCREMENT,
  `_local_morte` longtext,
  `_causa_morte` longtext,
  `_descr_morte` longtext,
  `id_Morto` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_CausaMorte`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tbl_rec_causamorte
-- 

/*!40000 ALTER TABLE `tbl_rec_causamorte` DISABLE KEYS */;

/*!40000 ALTER TABLE `tbl_rec_causamorte` ENABLE KEYS */;

-- 
-- Definition of tbl_rec_estadocivil
-- 

DROP TABLE IF EXISTS `tbl_rec_estadocivil`;
CREATE TABLE IF NOT EXISTS `tbl_rec_estadocivil` (
  `id_EstadoCivil` int(11) NOT NULL AUTO_INCREMENT,
  `_nome` varchar(150) DEFAULT NULL,
  `id_Morto` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id_EstadoCivil`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tbl_rec_estadocivil
-- 

/*!40000 ALTER TABLE `tbl_rec_estadocivil` DISABLE KEYS */;

/*!40000 ALTER TABLE `tbl_rec_estadocivil` ENABLE KEYS */;

-- 
-- Definition of tbl_rec_filhos
-- 

DROP TABLE IF EXISTS `tbl_rec_filhos`;
CREATE TABLE IF NOT EXISTS `tbl_rec_filhos` (
  `id_Filhos` int(11) NOT NULL AUTO_INCREMENT,
  `_nome` varchar(150) DEFAULT NULL,
  `id_Morto` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id_Filhos`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tbl_rec_filhos
-- 

/*!40000 ALTER TABLE `tbl_rec_filhos` DISABLE KEYS */;
INSERT INTO `tbl_rec_filhos`(`id_Filhos`,`_nome`,`id_Morto`) VALUES
(6,'Mario João Da Silva','5'),
(5,'Marcia João Da Silva','5');
/*!40000 ALTER TABLE `tbl_rec_filhos` ENABLE KEYS */;

-- 
-- Definition of tbl_rec_morto
-- 

DROP TABLE IF EXISTS `tbl_rec_morto`;
CREATE TABLE IF NOT EXISTS `tbl_rec_morto` (
  `id_Morto` int(11) NOT NULL AUTO_INCREMENT,
  `_nome` varchar(150) NOT NULL,
  `_nbi` varchar(50) NOT NULL,
  `_natural` varchar(100) NOT NULL,
  `_provincia` varchar(100) NOT NULL,
  `_sexo` enum('M','F') DEFAULT NULL,
  `_esta_civil` enum('S','C') DEFAULT NULL,
  `_data_nascimento` date DEFAULT NULL,
  `_data_morte` date DEFAULT NULL,
  `_data_cadastro` date DEFAULT NULL,
  `_img_morto` longtext,
  `ano` varchar(100) DEFAULT NULL,
  `mes` varchar(100) DEFAULT NULL,
  `dia` varchar(100) DEFAULT NULL,
  `id_Usuario` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_Morto`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tbl_rec_morto
-- 

/*!40000 ALTER TABLE `tbl_rec_morto` DISABLE KEYS */;

/*!40000 ALTER TABLE `tbl_rec_morto` ENABLE KEYS */;

-- 
-- Definition of tbl_rec_pais
-- 

DROP TABLE IF EXISTS `tbl_rec_pais`;
CREATE TABLE IF NOT EXISTS `tbl_rec_pais` (
  `id_Pais` int(11) NOT NULL AUTO_INCREMENT,
  `_nome_pai` varchar(150) DEFAULT NULL,
  `_nome_mae` varchar(150) DEFAULT NULL,
  `id_Morto` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id_Pais`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tbl_rec_pais
-- 

/*!40000 ALTER TABLE `tbl_rec_pais` DISABLE KEYS */;

/*!40000 ALTER TABLE `tbl_rec_pais` ENABLE KEYS */;

-- 
-- Definition of tbl_rec_usuario
-- 

DROP TABLE IF EXISTS `tbl_rec_usuario`;
CREATE TABLE IF NOT EXISTS `tbl_rec_usuario` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `_nome` varchar(100) NOT NULL,
  `_nbi` varchar(50) NOT NULL,
  `_sexo` enum('M','F') NOT NULL,
  `_data_nascimento` date NOT NULL,
  `_email` varchar(100) NOT NULL,
  `_senha` varchar(50) NOT NULL,
  `_telefone` varchar(20) DEFAULT NULL,
  `_papel` enum('Administrador','Operador') NOT NULL,
  `_img` longtext,
  PRIMARY KEY (`id_usuario`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tbl_rec_usuario
-- 

/*!40000 ALTER TABLE `tbl_rec_usuario` DISABLE KEYS */;

/*!40000 ALTER TABLE `tbl_rec_usuario` ENABLE KEYS */;

-- 
-- Definition of tbl_sem_morto
-- 

DROP TABLE IF EXISTS `tbl_sem_morto`;
CREATE TABLE IF NOT EXISTS `tbl_sem_morto` (
  `id_Morto` int(11) NOT NULL AUTO_INCREMENT,
  `_sexo` enum('M','F') DEFAULT NULL,
  `_data_morte` date DEFAULT NULL,
  `_data_cadastro` date DEFAULT NULL,
  `_local_morte` longtext,
  `_causa_morte` longtext,
  `_descr_morte` longtext,
  `_img_morto` longtext,
  `ano` varchar(100) DEFAULT NULL,
  `mes` varchar(100) DEFAULT NULL,
  `dia` varchar(100) DEFAULT NULL,
  `id_Usuario` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_Morto`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tbl_sem_morto
-- 

/*!40000 ALTER TABLE `tbl_sem_morto` DISABLE KEYS */;
INSERT INTO `tbl_sem_morto`(`id_Morto`,`_sexo`,`_data_morte`,`_data_cadastro`,`_local_morte`,`_causa_morte`,`_descr_morte`,`_img_morto`,`ano`,`mes`,`dia`,`id_Usuario`) VALUES
(1,'M','2008-10-23 00:00:00','2021-07-31 00:00:00','São Paulo','Acidente','-----------------------','C:\\Users\\Ricardo\\Pictures\\Pictures\\58714750_2142026525872866_7305405926415007744_n.jpg','2008','10','23','1'),
(2,'F','2021-05-31 00:00:00','2021-08-01 00:00:00','Luanda,Viana,Rua-B2','Asalto','-------------------','C:\\Users\\Ricardo\\Pictures\\Pictures\\82846571_1489516844538413_6731814238035116032_n[1].jpg','2021','5','31','1');
/*!40000 ALTER TABLE `tbl_sem_morto` ENABLE KEYS */;

-- 
-- Definition of tbl_usuario
-- 

DROP TABLE IF EXISTS `tbl_usuario`;
CREATE TABLE IF NOT EXISTS `tbl_usuario` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `_nome` varchar(100) NOT NULL,
  `_nbi` varchar(50) NOT NULL,
  `_sexo` enum('M','F') NOT NULL,
  `_data_nascimento` date NOT NULL,
  `_email` varchar(100) NOT NULL,
  `_senha` varchar(50) NOT NULL,
  `_telefone` varchar(20) DEFAULT NULL,
  `_papel` enum('Administrador','Operador') NOT NULL,
  `_img` longtext,
  PRIMARY KEY (`id_usuario`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tbl_usuario
-- 

/*!40000 ALTER TABLE `tbl_usuario` DISABLE KEYS */;
INSERT INTO `tbl_usuario`(`id_usuario`,`_nome`,`_nbi`,`_sexo`,`_data_nascimento`,`_email`,`_senha`,`_telefone`,`_papel`,`_img`) VALUES
(1,'Ricardo João António','0045567451LA56','M','2000-01-01 00:00:00','ricardo','bn6ggMGJmOE=','941711574','Administrador','C:\\Users\\Ricardo\\Pictures\\Pictures\\65788127_2082030332100463_4479694479351087104_n.jpg'),
(2,'Ismélio Cori','0000875467LA88','M','2001-08-19 00:00:00','ismelio','8Og2/d27fdA=','943611345','Operador','C:\\Users\\Ricardo\\Pictures\\Pictures\\16298959_748030715363796_358520980936517315_n.jpg');
/*!40000 ALTER TABLE `tbl_usuario` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2021-08-01 20:55:42
-- Total time: 0:0:0:0:812 (d:h:m:s:ms)
