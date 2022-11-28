-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           8.0.31 - MySQL Community Server - GPL
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.2.0.6576
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para bd_cadastro
CREATE DATABASE IF NOT EXISTS `bd_cadastro` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `bd_cadastro`;

-- Copiando estrutura para tabela bd_cadastro.fornecedor
CREATE TABLE IF NOT EXISTS `fornecedor` (
  `idfornecedor` int NOT NULL,
  `Cnpj` varchar(45) DEFAULT NULL,
  `RazaoSocial` varchar(45) DEFAULT NULL,
  `Endereco` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `NomeFantasia` varchar(45) DEFAULT NULL,
  `Telefone` varchar(45) DEFAULT NULL,
  `InscricaoEstadual` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idfornecedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela bd_cadastro.fornecedor: ~0 rows (aproximadamente)

-- Copiando estrutura para tabela bd_cadastro.produto
CREATE TABLE IF NOT EXISTS `produto` (
  `idproduto` int DEFAULT NULL,
  `Codigo` varchar(45) DEFAULT NULL,
  `Descricao` varchar(45) DEFAULT NULL,
  `Validade` varchar(45) DEFAULT NULL,
  `Preco` varchar(45) DEFAULT NULL,
  `QtdEstoque` varchar(45) DEFAULT NULL,
  `Tipo` varchar(45) NOT NULL,
  `Medida` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela bd_cadastro.produto: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
