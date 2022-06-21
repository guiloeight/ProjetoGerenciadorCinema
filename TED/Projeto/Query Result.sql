# Host: localhost  (Version: 5.5.30)
# Date: 2013-06-15 19:51:24
# Generator: MySQL-Front 5.3  (Build 3.15)

/*!40101 SET NAMES utf8 */;

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
  `telefone1` varchar(12) NOT NULL,
  `telefone2` varchar(12) NOT NULL,
  `acesso` varchar(30) NOT NULL DEFAULT '',
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

#
# Data for table "tblfuncionario"
#

INSERT INTO `tblfuncionario` VALUES (1,'legh','gay','niorjf','huhoui','hjhu','jhuihh','kjhkjh',0,'hbhkbh','hohiuhi','-kjhuhuh','bkhjgigi','0000000','000000','Funcionário Bilheteria');
