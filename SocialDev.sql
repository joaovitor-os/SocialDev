-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema SocialDev
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema SocialDev
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `SocialDev` DEFAULT CHARACTER SET utf8 ;
USE `SocialDev` ;

-- -----------------------------------------------------
-- Table `SocialDev`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SocialDev`.`usuario` (
  `IdUsuario` INT NOT NULL AUTO_INCREMENT,
  `NomeUsuario` VARCHAR(100) NOT NULL,
  `SenhaUsuario` VARCHAR(150) NOT NULL,
  `Email` VARCHAR(100) NOT NULL,
  `Github` VARCHAR(80) NOT NULL,
  `Linkedin` VARCHAR(100) NOT NULL,
  `Descricao` TEXT(500) NOT NULL,
  PRIMARY KEY (`IdUsuario`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
