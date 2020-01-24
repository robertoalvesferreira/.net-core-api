CREATE TABLE `persons` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `FirstName` VARCHAR(45) NOT NULL,
  `LastName` VARCHAR(45) NOT NULL,
  `Address` VARCHAR(45) NOT NULL,
  `Gender` VARCHAR(45) NOT NULL,
  `Profile_Id` INT NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_persons_profile_idx` (`Profile_Id` ASC))
ENGINE = InnoDB;


