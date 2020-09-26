/*
Navicat MySQL Data Transfer

Source Server         : aLOCALHOST
Source Server Version : 50505
Source Host           : localhost:3306
Source Database       : hardtraining

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2020-09-26 20:31:59
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for alunos
-- ----------------------------
DROP TABLE IF EXISTS `alunos`;
CREATE TABLE `alunos` (
  `ID` smallint(6) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(100) DEFAULT NULL,
  `EMAIL` varchar(100) DEFAULT NULL,
  `CELULAR` varchar(15) DEFAULT NULL,
  `DATA_NASCIMENTO` varchar(100) DEFAULT '',
  `PLANO` varchar(100) DEFAULT NULL,
  `STATUS` enum('Ativo','Inativo') DEFAULT 'Ativo',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of alunos
-- ----------------------------
INSERT INTO `alunos` VALUES ('1', 'Felipe Rosa Reis', 'feliperosareis@gmail.com', '(47)99148-2738', '1977-12-19', 'Semestral', 'Ativo');
INSERT INTO `alunos` VALUES ('3', 'Maria Vasconcelos de Moraes', 'mvasc@yahoo.com.br', '(47)98989-6556', '1995-12-19', 'Anual', 'Ativo');
INSERT INTO `alunos` VALUES ('8', 'Fulano de Tal', 'fulano@hotmail.com', '(48)98566-6446', '2001-5-21', 'Semestral', 'Ativo');
INSERT INTO `alunos` VALUES ('9', 'Beltrano Aranha', 'belaranha@gmail.com', '(41)98766-5655', '2005-8-6', 'Mensal', 'Ativo');
INSERT INTO `alunos` VALUES ('10', 'Giovana Delavequia', 'giodelavequia@uol.com.br', '(48)99353-5223', '2003-11-15', 'Trimestral', 'Ativo');
INSERT INTO `alunos` VALUES ('11', 'Domingos Ferreira', 'domferreira@gmail.com', '(47)98653-4788', '2000-1-7', 'Anual', 'Ativo');
INSERT INTO `alunos` VALUES ('12', 'Joana Amorim ', 'joamorim@hotmail.com', '(48)98732-1556', '2003-10-29', 'Trimestral', 'Ativo');

-- ----------------------------
-- Table structure for aulas
-- ----------------------------
DROP TABLE IF EXISTS `aulas`;
CREATE TABLE `aulas` (
  `ID` smallint(6) NOT NULL AUTO_INCREMENT,
  `TITULO` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of aulas
-- ----------------------------
INSERT INTO `aulas` VALUES ('1', 'Circuito A - 06:00');
INSERT INTO `aulas` VALUES ('4', 'Circuito F - 14:30');
INSERT INTO `aulas` VALUES ('5', 'Circuito A - 18:30');
INSERT INTO `aulas` VALUES ('6', 'Circuito B - 09:00');
INSERT INTO `aulas` VALUES ('7', 'Circuito B - 11:00');
INSERT INTO `aulas` VALUES ('8', 'Circuito C - 20:00');
INSERT INTO `aulas` VALUES ('9', 'Circuito D - 21:30');
INSERT INTO `aulas` VALUES ('10', 'Circuito H - 18:30');

-- ----------------------------
-- Table structure for checkin
-- ----------------------------
DROP TABLE IF EXISTS `checkin`;
CREATE TABLE `checkin` (
  `ID` smallint(6) NOT NULL AUTO_INCREMENT,
  `FK_AULA_ID` smallint(6) DEFAULT NULL,
  `FK_ALUNO_ID` smallint(6) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_AULA_ID` (`FK_AULA_ID`),
  KEY `FK_ALUNO_ID` (`FK_ALUNO_ID`),
  CONSTRAINT `checkin_ibfk_1` FOREIGN KEY (`FK_AULA_ID`) REFERENCES `aulas` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `checkin_ibfk_2` FOREIGN KEY (`FK_ALUNO_ID`) REFERENCES `alunos` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of checkin
-- ----------------------------
INSERT INTO `checkin` VALUES ('2', '5', '3');
INSERT INTO `checkin` VALUES ('5', '4', '1');
INSERT INTO `checkin` VALUES ('6', '5', '1');
INSERT INTO `checkin` VALUES ('11', '1', '1');
INSERT INTO `checkin` VALUES ('14', '8', '3');
INSERT INTO `checkin` VALUES ('17', '6', '11');
INSERT INTO `checkin` VALUES ('18', '7', '10');
INSERT INTO `checkin` VALUES ('19', '7', '8');
INSERT INTO `checkin` VALUES ('20', '9', '8');
INSERT INTO `checkin` VALUES ('21', '9', '12');
INSERT INTO `checkin` VALUES ('22', '9', '9');
INSERT INTO `checkin` VALUES ('23', '9', '11');
INSERT INTO `checkin` VALUES ('25', '8', '10');
INSERT INTO `checkin` VALUES ('26', '1', '9');
INSERT INTO `checkin` VALUES ('31', '1', '3');
INSERT INTO `checkin` VALUES ('33', '1', '10');
INSERT INTO `checkin` VALUES ('34', '6', '10');
INSERT INTO `checkin` VALUES ('36', '7', '11');
INSERT INTO `checkin` VALUES ('37', '7', '9');
INSERT INTO `checkin` VALUES ('38', '4', '12');

-- ----------------------------
-- Table structure for usuarios
-- ----------------------------
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `ID` smallint(6) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(100) DEFAULT '',
  `EMAIL` varchar(100) DEFAULT NULL,
  `SENHA` varchar(100) DEFAULT '',
  `PERMISSAO` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of usuarios
-- ----------------------------
INSERT INTO `usuarios` VALUES ('1', 'Admin', 'admin@admin.com', '202cb962ac59075b964b07152d234b70', 'Administrador');
INSERT INTO `usuarios` VALUES ('9', 'Suporte', 'suporte@teste.com', '202cb962ac59075b964b07152d234b70', 'Colaborador');
