# SQL-Front 5.1  (Build 4.16)

/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE */;
/*!40101 SET SQL_MODE='' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES */;
/*!40103 SET SQL_NOTES='ON' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;


# Host: localhost    Database: bdcadastro
# ------------------------------------------------------
# Server version 5.5.16

DROP DATABASE IF EXISTS `bdcadastro`;
CREATE DATABASE `bdcadastro` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bdcadastro`;

#
# Source for table cadastrosalas
#

DROP TABLE IF EXISTS `cadastrosalas`;
CREATE TABLE `cadastrosalas` (
  `codigo` int(2) NOT NULL,
  `ndesalas` int(4) NOT NULL,
  `ndelugares` int(4) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table cadastrosalas
#

LOCK TABLES `cadastrosalas` WRITE;
/*!40000 ALTER TABLE `cadastrosalas` DISABLE KEYS */;
/*!40000 ALTER TABLE `cadastrosalas` ENABLE KEYS */;
UNLOCK TABLES;

#
# Source for table tblcadastrofornecedor
#

DROP TABLE IF EXISTS `tblcadastrofornecedor`;
CREATE TABLE `tblcadastrofornecedor` (
  `codigo` int(4) NOT NULL AUTO_INCREMENT,
  `nome` varchar(40) NOT NULL,
  `natureza` varchar(20) NOT NULL,
  `nomefantasia` varchar(20) NOT NULL,
  `cnpj` varchar(18) NOT NULL,
  `endereco` varchar(40) NOT NULL,
  `cidade` varchar(20) NOT NULL,
  `complemento` varchar(20) NOT NULL,
  `bairro` varchar(30) NOT NULL,
  `estado` varchar(12) NOT NULL,
  `cep` varchar(9) NOT NULL,
  `email` varchar(40) NOT NULL,
  `telefone1` varchar(10) NOT NULL,
  `telefone2` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table tblcadastrofornecedor
#

LOCK TABLES `tblcadastrofornecedor` WRITE;
/*!40000 ALTER TABLE `tblcadastrofornecedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblcadastrofornecedor` ENABLE KEYS */;
UNLOCK TABLES;

#
# Source for table tblcadastrosessoes
#

DROP TABLE IF EXISTS `tblcadastrosessoes`;
CREATE TABLE `tblcadastrosessoes` (
  `filme` varchar(40) NOT NULL,
  `horario` varchar(6) NOT NULL,
  `d3` varchar(3) NOT NULL,
  `sala` int(3) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `try` varchar(8) NOT NULL,
  PRIMARY KEY (`try`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table tblcadastrosessoes
#

LOCK TABLES `tblcadastrosessoes` WRITE;
/*!40000 ALTER TABLE `tblcadastrosessoes` DISABLE KEYS */;
INSERT INTO `tblcadastrosessoes` VALUES ('','','',0,'','');
INSERT INTO `tblcadastrosessoes` VALUES ('filmea','01:00','Sim',1,'-filmea ?s 01:00 Sala1 - Sim\t','01:00-1');
INSERT INTO `tblcadastrosessoes` VALUES ('filmea','01:01','N?o',3,'filmea (12) ?s 01:01 na Sala 3 - 3D(N?o)','01:01-3');
INSERT INTO `tblcadastrosessoes` VALUES ('filmea','09:00','N?o',1,'- ?s 09:00 Sala1 - N?o','09:00-1');
INSERT INTO `tblcadastrosessoes` VALUES ('filmeb','12:00','Sim',3,'-filmeb ?s 12:00 Sala3 - Sim\t','12:00-3');
INSERT INTO `tblcadastrosessoes` VALUES ('filmea','13:00','Sim',3,'-filmea ?s 13:00 Sala3 - Sim\t','13:00-3');
INSERT INTO `tblcadastrosessoes` VALUES ('filmec','14:14','Sim',1,'filmec (comedia) ?s 14:14 na Sala 1 - 3D(Sim\t)','14:14-1');
INSERT INTO `tblcadastrosessoes` VALUES ('filmeb','14:00','N?o',1,'-filmeb ?s 15:00 Sala1 - N?o','15:00-1');
INSERT INTO `tblcadastrosessoes` VALUES ('filmeb','15:00','Sim',3,'-filmeb ?s 15:00 Sala3 - Sim\t','15:00-3');
INSERT INTO `tblcadastrosessoes` VALUES ('filmea','16:00','Sim',1,'filmea (12) ?s 16:00 na Sala 1 - 3D(Sim\t)','16:00-1');
INSERT INTO `tblcadastrosessoes` VALUES ('filmeb','17:00','N?o',3,'-filmeb ?s 15:00 Sala1 - N?o','17:00-3');
INSERT INTO `tblcadastrosessoes` VALUES ('filmeb','18:00','Sim',1,'-filmeb ?s 18:00 Sala1 - Sim\t','18:00-1');
INSERT INTO `tblcadastrosessoes` VALUES ('filmeb','18:00','Sim',3,'filmeb (comedia) ?s 18:00 na Sala 3 - 3D(Sim\t)','18:00-3');
INSERT INTO `tblcadastrosessoes` VALUES ('filmea','24:00','Sim',3,'filmea(12) ?s 24:00 na Sala 3 - 3D(Sim)','24:00-3');
INSERT INTO `tblcadastrosessoes` VALUES ('filmea','35:46','Sim',1,'filmea (12) ?s 35:46 na Sala 1 - 3D(Sim\t)','35:46-1');
/*!40000 ALTER TABLE `tblcadastrosessoes` ENABLE KEYS */;
UNLOCK TABLES;

#
# Source for table tblcliente
#

DROP TABLE IF EXISTS `tblcliente`;
CREATE TABLE `tblcliente` (
  `cod_cli` int(11) NOT NULL AUTO_INCREMENT,
  `nome_cli` varchar(100) DEFAULT NULL,
  `tel_cli` varchar(13) DEFAULT NULL,
  `end_cli` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`cod_cli`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;

#
# Dumping data for table tblcliente
#

LOCK TABLES `tblcliente` WRITE;
/*!40000 ALTER TABLE `tblcliente` DISABLE KEYS */;
INSERT INTO `tblcliente` VALUES (4,'Bruno ','(19)9246-9856','fdsfsdf');
INSERT INTO `tblcliente` VALUES (11,'Erasmo','(19)9246-5986','Rua Filomena ');
INSERT INTO `tblcliente` VALUES (12,'Anelix','(19)1916-5464','Ggrh ih oirghroghbrivnb ivnrefiofvnoirnvl nvlo nfv nrlvne lf f fvf');
INSERT INTO `tblcliente` VALUES (13,'Bruno1','','jjyjytjyjtyj');
INSERT INTO `tblcliente` VALUES (15,'eu','','fdhfdhfdh');
INSERT INTO `tblcliente` VALUES (16,'brun','','12321');
INSERT INTO `tblcliente` VALUES (17,'23','','uykuymm jy');
INSERT INTO `tblcliente` VALUES (18,'gdfgfg','','hfdhdf');
INSERT INTO `tblcliente` VALUES (19,'fdhdf','','fgfdghfd');
INSERT INTO `tblcliente` VALUES (21,'fdhfd','(  )    -','liliuliu');
INSERT INTO `tblcliente` VALUES (22,'hfdhfdh','(  )    -','fdhfdhfd');
INSERT INTO `tblcliente` VALUES (23,'gghgfhg','(  )    -','jkjhk');
INSERT INTO `tblcliente` VALUES (24,'nhnghghghgh','(  )    -','hghghg');
INSERT INTO `tblcliente` VALUES (25,'hdhd','(  )    -','fdhdfhfd');
INSERT INTO `tblcliente` VALUES (26,'hfdhf','(  )    -','fdhdfhfd');
INSERT INTO `tblcliente` VALUES (27,'Guilherme','(19)3562-3478','Rua nois');
/*!40000 ALTER TABLE `tblcliente` ENABLE KEYS */;
UNLOCK TABLES;

#
# Source for table tblcontas
#

DROP TABLE IF EXISTS `tblcontas`;
CREATE TABLE `tblcontas` (
  `codigo` int(6) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(20) NOT NULL,
  `vencimento` varchar(15) NOT NULL,
  `pagamento` varchar(15) NOT NULL,
  `valor` decimal(12,2) NOT NULL,
  `credor` varchar(40) NOT NULL,
  `multa` decimal(12,2) NOT NULL,
  `descricao` varchar(300) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

#
# Dumping data for table tblcontas
#

LOCK TABLES `tblcontas` WRITE;
/*!40000 ALTER TABLE `tblcontas` DISABLE KEYS */;
INSERT INTO `tblcontas` VALUES (2,'?gua','04-06-2013','12/32/1546',8578,'Luz',98,'adhk,');
INSERT INTO `tblcontas` VALUES (3,'?gua','76-57-4577','75/47/4575',4555467,'?gua',7747575,'74574574754');
/*!40000 ALTER TABLE `tblcontas` ENABLE KEYS */;
UNLOCK TABLES;

#
# Source for table tblfilme
#

DROP TABLE IF EXISTS `tblfilme`;
CREATE TABLE `tblfilme` (
  `filme` varchar(40) NOT NULL DEFAULT '',
  `genero` varchar(20) NOT NULL,
  `preco` decimal(12,2) NOT NULL,
  `preco3d` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table tblfilme
#

LOCK TABLES `tblfilme` WRITE;
/*!40000 ALTER TABLE `tblfilme` DISABLE KEYS */;
INSERT INTO `tblfilme` VALUES ('filmea','12',12,50);
INSERT INTO `tblfilme` VALUES ('filmeb','comedia',5,50);
INSERT INTO `tblfilme` VALUES ('filmec','comedia',15,50);
INSERT INTO `tblfilme` VALUES ('filmec','google',50.75,50);
/*!40000 ALTER TABLE `tblfilme` ENABLE KEYS */;
UNLOCK TABLES;

#
# Source for table tblfuncionario
#

DROP TABLE IF EXISTS `tblfuncionario`;
CREATE TABLE `tblfuncionario` (
  `codigo` int(6) NOT NULL AUTO_INCREMENT,
  `nome` varchar(40) NOT NULL,
  `sexo` varchar(20) NOT NULL,
  `cpf` varchar(20) NOT NULL,
  `rg` varchar(20) NOT NULL,
  `estadocivil` varchar(20) NOT NULL,
  `endereco` varchar(40) NOT NULL,
  `cidade` varchar(40) NOT NULL,
  `numero` int(10) NOT NULL,
  `complemento` varchar(20) NOT NULL,
  `bairro` varchar(40) NOT NULL,
  `estado` varchar(40) NOT NULL,
  `email` varchar(40) NOT NULL,
  `telefone1` varchar(12) NOT NULL,
  `telefone2` varchar(12) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

#
# Dumping data for table tblfuncionario
#

LOCK TABLES `tblfuncionario` WRITE;
/*!40000 ALTER TABLE `tblfuncionario` DISABLE KEYS */;
INSERT INTO `tblfuncionario` VALUES (1,'bruhn65','5','5  ,   ,   -','hhkhkkjkh6','56','jik65','lk565',2147483647,'jk65','jk6','6','h65','(6 )    -','(56)    -');
/*!40000 ALTER TABLE `tblfuncionario` ENABLE KEYS */;
UNLOCK TABLES;

#
# Source for table tblingresso
#

DROP TABLE IF EXISTS `tblingresso`;
CREATE TABLE `tblingresso` (
  `filme` varchar(40) NOT NULL,
  `horario` datetime NOT NULL,
  `pre?o` decimal(12,2) NOT NULL,
  `ndemeias` int(4) NOT NULL,
  `ndeinteiras` int(4) NOT NULL,
  `total` decimal(12,2) NOT NULL,
  `valorpago` decimal(12,2) NOT NULL,
  `troco` decimal(12,2) NOT NULL,
  `lugaresocupados` int(4) NOT NULL,
  `lugaresvagos` int(4) NOT NULL,
  PRIMARY KEY (`filme`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table tblingresso
#

LOCK TABLES `tblingresso` WRITE;
/*!40000 ALTER TABLE `tblingresso` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblingresso` ENABLE KEYS */;
UNLOCK TABLES;

#
# Source for table tblprodutos
#

DROP TABLE IF EXISTS `tblprodutos`;
CREATE TABLE `tblprodutos` (
  `codigo` int(4) NOT NULL AUTO_INCREMENT,
  `produto` varchar(40) NOT NULL,
  `quantidade` int(5) NOT NULL,
  `valordecompra` decimal(12,2) NOT NULL,
  `valordevenda` decimal(12,2) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table tblprodutos
#

LOCK TABLES `tblprodutos` WRITE;
/*!40000 ALTER TABLE `tblprodutos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblprodutos` ENABLE KEYS */;
UNLOCK TABLES;

#
# Source for table tblsalas
#

DROP TABLE IF EXISTS `tblsalas`;
CREATE TABLE `tblsalas` (
  `codigo` int(2) NOT NULL AUTO_INCREMENT,
  `ndesalas` int(4) NOT NULL,
  `ndelugares` int(4) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

#
# Dumping data for table tblsalas
#

LOCK TABLES `tblsalas` WRITE;
/*!40000 ALTER TABLE `tblsalas` DISABLE KEYS */;
INSERT INTO `tblsalas` VALUES (1,1,15);
INSERT INTO `tblsalas` VALUES (2,3,30);
/*!40000 ALTER TABLE `tblsalas` ENABLE KEYS */;
UNLOCK TABLES;

#
# Source for table tblusuario
#

DROP TABLE IF EXISTS `tblusuario`;
CREATE TABLE `tblusuario` (
  `usuario` varchar(15) NOT NULL,
  `senha` varchar(15) DEFAULT NULL,
  `AdmKey` int(1) DEFAULT '0',
  PRIMARY KEY (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table tblusuario
#

LOCK TABLES `tblusuario` WRITE;
/*!40000 ALTER TABLE `tblusuario` DISABLE KEYS */;
INSERT INTO `tblusuario` VALUES ('1','62',0);
INSERT INTO `tblusuario` VALUES ('abc','12',1);
INSERT INTO `tblusuario` VALUES ('Bruno','121416',1);
INSERT INTO `tblusuario` VALUES ('bruuno','12',0);
INSERT INTO `tblusuario` VALUES ('Er','36',0);
INSERT INTO `tblusuario` VALUES ('Erasmo','112114116',0);
INSERT INTO `tblusuario` VALUES ('Guilherme','626364656667',1);
INSERT INTO `tblusuario` VALUES ('jack','363771',1);
INSERT INTO `tblusuario` VALUES ('oi','62',1);
INSERT INTO `tblusuario` VALUES ('oi2','63',0);
/*!40000 ALTER TABLE `tblusuario` ENABLE KEYS */;
UNLOCK TABLES;

/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
