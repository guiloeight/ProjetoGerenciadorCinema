# Host: localhost  (Version: 5.5.30)
# Date: 2013-06-19 01:17:00
# Generator: MySQL-Front 5.3  (Build 3.15)

/*!40101 SET NAMES utf8 */;

DROP DATABASE IF EXISTS `bdcadastro`;
CREATE DATABASE `bdcadastro` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bdcadastro`;

#
# Source for table "cadastrosalas"
#

DROP TABLE IF EXISTS `cadastrosalas`;
CREATE TABLE `cadastrosalas` (
  `codigo` int(2) NOT NULL,
  `ndesalas` int(4) NOT NULL,
  `ndelugares` int(4) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "cadastrosalas"
#


#
# Source for table "tblcadastrofornecedor"
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
# Data for table "tblcadastrofornecedor"
#


#
# Source for table "tblcadastrosessoes"
#

DROP TABLE IF EXISTS `tblcadastrosessoes`;
CREATE TABLE `tblcadastrosessoes` (
  `filme` varchar(40) NOT NULL,
  `horario` varchar(6) NOT NULL,
  `d3` varchar(3) NOT NULL,
  `sala` int(3) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `try` varchar(8) NOT NULL,
  `faixa` varchar(20) NOT NULL DEFAULT '',
  `precoSessao` decimal(10,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`try`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "tblcadastrosessoes"
#

INSERT INTO `tblcadastrosessoes` VALUES ('','','',0,'','','',0.00),('filmea','01:01','Não',3,'filmea (12) às 01:01 na Sala 3 - 3D(Não)','01:01-3','',0.00),('filmea','09:00','Não',1,'- às 09:00 Sala1 - Não','09:00-1','',0.00),('Batman','11:11','Não',1,'Batman (ola) às 11:11 na Sala 1 - 3D(Não)','11:11-1','12 anos ',0.00),('Ola','11:12','Não',1,'Ola (acao) às 11:12 na Sala 1 - 3D(Não)','11:12-1','14 anos ',0.00),('filmeb','12:00','Sim',3,'-filmeb às 12:00 Sala3 - Sim\t','12:00-3','',0.00),('Batman','12:22','Não',1,'Batman (ola) às 12:22 na Sala 1 - 3D(Não)','12:22-1','16 anos',0.00),('filmea','13:00','Sim',3,'-filmea às 13:00 Sala3 - Sim\t','13:00-3','',0.00),('Ola','13:44','Não',1,'Ola (acao) às 13:44 na Sala 1 - 3D(Não)','13:44-1','16 anos',0.00),('filmec','14:14','Sim',1,'filmec (comedia) às 14:14 na Sala 1 - 3D(Sim\t)','14:14-1','',0.00),('filmeb','14:00','Não',1,'-filmeb às 15:00 Sala1 - Não','15:00-1','',0.00),('filmeb','15:00','Sim',3,'-filmeb às 15:00 Sala3 - Sim\t','15:00-3','',0.00),('filmea','16:00','Sim',1,'filmea (12) às 16:00 na Sala 1 - 3D(Sim\t)','16:00-1','',0.00),('filmeb','17:00','Não',3,'-filmeb às 15:00 Sala1 - Não','17:00-3','',0.00),('filmeb','18:00','Sim',1,'-filmeb às 18:00 Sala1 - Sim\t','18:00-1','',0.00),('filmeb','18:00','Sim',3,'filmeb (comedia) às 18:00 na Sala 3 - 3D(Sim\t)','18:00-3','',0.00),('filmea','24:00','Sim',3,'filmea(12) às 24:00 na Sala 3 - 3D(Sim)','24:00-3','',0.00),('filmea','35:46','Sim',1,'filmea (12) às 35:46 na Sala 1 - 3D(Sim\t)','35:46-1','',0.00);

#
# Source for table "tblcliente"
#

DROP TABLE IF EXISTS `tblcliente`;
CREATE TABLE `tblcliente` (
  `cod_cli` int(11) NOT NULL AUTO_INCREMENT,
  `nome_cli` varchar(100) DEFAULT NULL,
  `tel_cli` varchar(13) DEFAULT NULL,
  `end_cli` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`cod_cli`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;

#
# Data for table "tblcliente"
#

INSERT INTO `tblcliente` VALUES (4,'Bruno ','vdfs','fdsfsdf'),(11,'','',''),(12,'','',''),(13,'Bruno1','TELEFONE','eu moro aki'),(15,'eu','',''),(16,'brun','1','12321'),(17,'23','',''),(18,'','(  )    -','');

#
# Source for table "tblcontas"
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "tblcontas"
#


#
# Source for table "tblfilme"
#

DROP TABLE IF EXISTS `tblfilme`;
CREATE TABLE `tblfilme` (
  `filme` varchar(40) NOT NULL,
  `genero` varchar(20) NOT NULL,
  `preco` decimal(12,2) NOT NULL,
  PRIMARY KEY (`filme`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "tblfilme"
#

INSERT INTO `tblfilme` VALUES ('Batman','ola',23.00),('Ola','acao',20.00);

#
# Source for table "tblfuncionario"
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
  `telefone1` varchar(19) NOT NULL DEFAULT '',
  `telefone2` varchar(19) NOT NULL DEFAULT '',
  `acesso` varchar(30) NOT NULL DEFAULT '',
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

#
# Data for table "tblfuncionario"
#

INSERT INTO `tblfuncionario` VALUES (1,'legh','gay','niorjf','huhoui','hjhu','jhuihh','kjhkjh',0,'hbhkbh','hohiuhi','-kjhuhuh','bkhjgigi','0000000','000000','Administrador'),(2,'guilherme','Feminino ','111,111,111-11','111111','Divorciado(a)','rua dos bovbos','Brasilia',111,'apartament 23','jd interklagos','Bahia  - BA','ffhuogfiuergui','(12)1111-1111','(13)2444-4444','Funcionário Bilheteria');

#
# Source for table "tblingresso"
#

DROP TABLE IF EXISTS `tblingresso`;
CREATE TABLE `tblingresso` (
  `codigo` int(6) NOT NULL AUTO_INCREMENT,
  `filme` varchar(40) NOT NULL,
  `horario` varchar(10) NOT NULL DEFAULT '',
  `preco` varchar(9) NOT NULL DEFAULT '0',
  `ndemeias` int(4) DEFAULT '0',
  `ndeinteiras` int(4) DEFAULT '0',
  `total` decimal(12,2) DEFAULT NULL,
  `valorpago` decimal(12,2) DEFAULT NULL,
  `troco` decimal(12,2) DEFAULT NULL,
  `lugaresocupados` int(4) DEFAULT '0',
  `lugaresvagos` int(4) DEFAULT '0',
  `sessao` varchar(70) NOT NULL DEFAULT '',
  `etaria` varchar(25) NOT NULL DEFAULT '',
  `sala` varchar(5) DEFAULT '0',
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "tblingresso"
#

INSERT INTO `tblingresso` VALUES (1,'Batman','11:11','23,00',1,1,NULL,NULL,NULL,0,0,'Batman (ola) às 11:11 na Sala 1 - 3D(Não)','12 anos ','1'),(2,'Batman','11:11','23,00',1,1,NULL,NULL,NULL,0,0,'Batman (ola) às 11:11 na Sala 1 - 3D(Não)','12 anos ','1');

#
# Source for table "tblprodutos"
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
# Data for table "tblprodutos"
#


#
# Source for table "tblsalas"
#

DROP TABLE IF EXISTS `tblsalas`;
CREATE TABLE `tblsalas` (
  `codigo` int(2) NOT NULL AUTO_INCREMENT,
  `ndesalas` int(4) NOT NULL,
  `ndelugares` int(4) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

#
# Data for table "tblsalas"
#

INSERT INTO `tblsalas` VALUES (1,1,30);

#
# Source for table "tblusuario"
#

DROP TABLE IF EXISTS `tblusuario`;
CREATE TABLE `tblusuario` (
  `usuario` varchar(15) NOT NULL,
  `senha` varchar(15) DEFAULT NULL,
  `AdmKey` int(1) DEFAULT '0',
  `codfunc` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "tblusuario"
#

INSERT INTO `tblusuario` VALUES ('1','62',0,0),('abc','12',1,0),('Bruno','121416',1,0),('bruuno','12',0,0),('Er','36',0,0),('Erasmo','112114116',0,0),('FOIO0','656667',0,0),('foioo','62636465',0,0),('gfhrgyrfg','37404142434059',0,0),('gui','626364',1,1),('guihh','626364656667',1,2),('Guilherme','626364656667',1,0),('Guilherme1','626364656667',1,1),('hfiohf','70696970',0,0),('hughyugygyu','626364656667',0,0),('iiiiiii','434343434343',0,0),('jack','363771',1,0),('oi','62',1,0),('oi2','63',0,0),('ola','626364',0,1),('ola1','64656667',0,1),('tt','5454',0,0),('tudo','626364656667',0,0),('tufo','62636465',0,0);
