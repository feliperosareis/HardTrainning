/*
Navicat MySQL Data Transfer

Source Server         : aLOCALHOST
Source Server Version : 50505
Source Host           : localhost:3306
Source Database       : hardtraining

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2020-09-05 11:20:23
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
  `STATUS` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of alunos
-- ----------------------------
INSERT INTO `alunos` VALUES ('1', 'Felipe Rosa Reis', 'feliperosareis@gmail.com', '(47)99148-2768', '0000-00-00', 'mensal', '1');
INSERT INTO `alunos` VALUES ('2', 'José de Alencar', 'jalencar@htmail.com', '(48)94458-9964', '1980-8-31', 'Trimestral', '1');
INSERT INTO `alunos` VALUES ('3', 'Benito de Paula', 'benito@uol.com.br', '(41)96584-5879', '1995-2-11', 'Anual', '1');
INSERT INTO `alunos` VALUES ('4', 'Marina Morena', 'mmorena@yahoo.com', '(51)93224-8117', '1982-5-29', 'Mensal', '1');

-- ----------------------------
-- Table structure for usuarios
-- ----------------------------
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `ID` smallint(6) NOT NULL AUTO_INCREMENT,
  `USUARIO` varchar(100) DEFAULT NULL,
  `SENHA` varchar(255) DEFAULT NULL,
  `TIPO` enum('Aluno','Atendente','Professor') DEFAULT NULL,
  `STATUS` tinyint(1) DEFAULT 1,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of usuarios
-- ----------------------------
