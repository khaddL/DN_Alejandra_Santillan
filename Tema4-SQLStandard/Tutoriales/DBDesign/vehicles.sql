-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema vehicles
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema vehicles
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `vehicles` DEFAULT CHARACTER SET utf8 ;
USE `vehicles` ;

-- -----------------------------------------------------
-- Table `vehicles`.`model`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `vehicles`.`model` (
  `idmodel` INT NOT NULL,
  `modelname` VARCHAR(500) NOT NULL,
  `firstproductionyear` INT NOT NULL,
  PRIMARY KEY (`idmodel`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `vehicles`.`make`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `vehicles`.`make` (
  `idmake` INT NOT NULL,
  `makename` VARCHAR(100) NOT NULL,
  `country` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`idmake`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `vehicles`.`color`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `vehicles`.`color` (
  `idcolor` INT NOT NULL,
  `name` VARCHAR(100) NOT NULL,
  `code` VARCHAR(5) NOT NULL,
  PRIMARY KEY (`idcolor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `vehicles`.`vehicle`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `vehicles`.`vehicle` (
  `idvehicle` INT NOT NULL,
  `make_idmake` INT NOT NULL,
  `model_idmodel` INT NOT NULL,
  `year` INT NOT NULL,
  PRIMARY KEY (`idvehicle`, `make_idmake`, `model_idmodel`),
  INDEX `fk_vehicle_make_idx` (`make_idmake` ASC) VISIBLE,
  INDEX `fk_vehicle_model1_idx` (`model_idmodel` ASC) VISIBLE,
  CONSTRAINT `fk_vehicle_make`
    FOREIGN KEY (`make_idmake`)
    REFERENCES `vehicles`.`make` (`idmake`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_vehicle_model1`
    FOREIGN KEY (`model_idmodel`)
    REFERENCES `vehicles`.`model` (`idmodel`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `vehicles`.`inventory`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `vehicles`.`inventory` (
  `idinventory` INT NOT NULL,
  `color_idcolor` INT NOT NULL,
  `vehicle_idvehicle` INT NOT NULL,
  `price` DECIMAL(13,2) NOT NULL,
  PRIMARY KEY (`idinventory`),
  INDEX `fk_inventory_color1_idx` (`color_idcolor` ASC) VISIBLE,
  INDEX `fk_inventory_vehicle1_idx` (`vehicle_idvehicle` ASC) VISIBLE,
  CONSTRAINT `fk_inventory_color1`
    FOREIGN KEY (`color_idcolor`)
    REFERENCES `vehicles`.`color` (`idcolor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_inventory_vehicle1`
    FOREIGN KEY (`vehicle_idvehicle`)
    REFERENCES `vehicles`.`vehicle` (`idvehicle`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `vehicles`.`vehiclecentive`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `vehicles`.`vehiclecentive` (
  `vehicle_idvehicle` INT NOT NULL,
  `incentive_idicentive` INT NOT NULL,
  `validtill` DATETIME NOT NULL,
  PRIMARY KEY (`vehicle_idvehicle`, `incentive_idicentive`),
  CONSTRAINT `fk_vehiclecentive_vehicle1`
    FOREIGN KEY (`vehicle_idvehicle`)
    REFERENCES `vehicles`.`vehicle` (`idvehicle`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
