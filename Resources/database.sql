-- --------------------------------------------------------
-- Host:                         5.231.80.204
-- Server version:               5.6.22 - MySQL Community Server (GPL)
-- Server OS:                    Linux
-- HeidiSQL Version:             9.1.0.4882
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping structure for table DbIRyM.Administrador
CREATE TABLE IF NOT EXISTS `Administrador` (
  `Administrador` int(11) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Apellidos` varchar(45) NOT NULL,
  `DNI` varchar(9) NOT NULL,
  `Email` varchar(45) NOT NULL,
  `Telefono` varchar(45) NOT NULL,
  `Direccion` varchar(45) NOT NULL,
  PRIMARY KEY (`Administrador`),
  UNIQUE KEY `DNI_UNIQUE` (`DNI`),
  UNIQUE KEY `Administrador_UNIQUE` (`Administrador`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table DbIRyM.Ambulatorio
CREATE TABLE IF NOT EXISTS `Ambulatorio` (
  `idAmbulatorio` int(11) NOT NULL,
  `Direccion` varchar(45) NOT NULL,
  PRIMARY KEY (`idAmbulatorio`),
  UNIQUE KEY `idAmbulatorio_UNIQUE` (`idAmbulatorio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table DbIRyM.Farmaceutico
CREATE TABLE IF NOT EXISTS `Farmaceutico` (
  `NumeroColegiado` int(11) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Apellidos` varchar(45) NOT NULL,
  `DNI` varchar(9) NOT NULL,
  `UltimoRegistro` datetime DEFAULT NULL,
  `NumeroFarmacia` int(11) NOT NULL,
  PRIMARY KEY (`NumeroColegiado`),
  UNIQUE KEY `DNI_UNIQUE` (`DNI`),
  UNIQUE KEY `NumeroColegiado_UNIQUE` (`NumeroColegiado`),
  KEY `Farmacia_idx` (`NumeroFarmacia`),
  CONSTRAINT `Farmacia` FOREIGN KEY (`NumeroFarmacia`) REFERENCES `Farmacia` (`idFarmacia`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table DbIRyM.Farmacia
CREATE TABLE IF NOT EXISTS `Farmacia` (
  `idFarmacia` int(11) NOT NULL,
  `Direccion` varchar(45) NOT NULL,
  PRIMARY KEY (`idFarmacia`),
  UNIQUE KEY `idFarmacia_UNIQUE` (`idFarmacia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table DbIRyM.Farmacia_Medicamento
CREATE TABLE IF NOT EXISTS `Farmacia_Medicamento` (
  `idFarmacia` int(11) NOT NULL,
  `CNMedicamento` int(11) NOT NULL,
  `Stock` int(11) NOT NULL DEFAULT '0' COMMENT 'Relaciona los medicamentos que hay en una farmacia.',
  PRIMARY KEY (`idFarmacia`,`CNMedicamento`),
  KEY `fk_Farmacia_has_Medicamento_Medicamento1_idx` (`CNMedicamento`),
  KEY `fk_Farmacia_has_Medicamento_Farmacia1_idx` (`idFarmacia`),
  CONSTRAINT `fk_Farmacia_has_Medicamento_Farmacia1` FOREIGN KEY (`idFarmacia`) REFERENCES `Farmacia` (`idFarmacia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Farmacia_has_Medicamento_Medicamento1` FOREIGN KEY (`CNMedicamento`) REFERENCES `Medicamento` (`CNMedicamento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table DbIRyM.GrupoEquivalencias
CREATE TABLE IF NOT EXISTS `GrupoEquivalencias` (
  `GrupoEquivalencias` int(11) NOT NULL,
  `Descripcion` varchar(50) NOT NULL,
  `Composicion` varchar(50) NOT NULL,
  `FormaFarmaceutica` varchar(50) NOT NULL,
  `GrupoTerapeutico` varchar(50) NOT NULL,
  PRIMARY KEY (`GrupoEquivalencias`),
  UNIQUE KEY `GrupoEquivalencias_UNIQUE` (`GrupoEquivalencias`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table DbIRyM.Medicamento
CREATE TABLE IF NOT EXISTS `Medicamento` (
  `CNMedicamento` int(11) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Denominacion` varchar(45) NOT NULL,
  `GrupoEquivalencia` int(11) DEFAULT NULL,
  `Dosis` varchar(245) NOT NULL,
  `Via` varchar(105) NOT NULL,
  `Formato` varchar(45) NOT NULL,
  `NumeroEnvase` int(11) NOT NULL,
  `Posologia` longtext NOT NULL,
  `Precio` float NOT NULL,
  PRIMARY KEY (`CNMedicamento`),
  UNIQUE KEY `CNMedicamento_UNIQUE` (`CNMedicamento`),
  KEY `GrupoEquivalenciaFK` (`GrupoEquivalencia`),
  CONSTRAINT `GrupoEquivalenciaFK` FOREIGN KEY (`GrupoEquivalencia`) REFERENCES `GrupoEquivalencias` (`GrupoEquivalencias`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table DbIRyM.Medico
CREATE TABLE IF NOT EXISTS `Medico` (
  `NumeroFacultativo` int(11) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `Apellidos` varchar(55) NOT NULL,
  `DNI` varchar(9) NOT NULL,
  `FirmaElectronica` varchar(45) NOT NULL,
  `Email` varchar(45) NOT NULL,
  `Telefono` varchar(9) NOT NULL,
  `Direccion` varchar(145) NOT NULL,
  `Cualificacion` enum('Médico','Odontólogo','Podólogo','Enfermero') NOT NULL,
  `LugarTrabajo` int(11) NOT NULL,
  PRIMARY KEY (`NumeroFacultativo`),
  UNIQUE KEY `DNI_UNIQUE` (`DNI`),
  UNIQUE KEY `FirmaElectronica_UNIQUE` (`FirmaElectronica`),
  UNIQUE KEY `NumeroFacultativo_UNIQUE` (`NumeroFacultativo`),
  KEY `LugarTrabajo_idx` (`LugarTrabajo`),
  CONSTRAINT `LugarTrabajo` FOREIGN KEY (`LugarTrabajo`) REFERENCES `Ambulatorio` (`idAmbulatorio`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table DbIRyM.Paciente
CREATE TABLE IF NOT EXISTS `Paciente` (
  `NumeroTarjetaSanitaria` int(11) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Apellidos` varchar(45) NOT NULL,
  `DNI` varchar(9) NOT NULL,
  `FechaNacimiento` date NOT NULL,
  `Cronico` tinyint(1) NOT NULL DEFAULT '0',
  `ExentoAportacion` tinyint(1) NOT NULL DEFAULT '0',
  `BaremoEconomico` enum('<18.000','18.000-100.000','>100.000') NOT NULL,
  `SituacionLaboral` enum('Activo','Pensionista','Parado','Mutualidad') NOT NULL,
  `Entidad` enum('Seguridad Social','Muface','Isfas','Mutualidad General Judicial') DEFAULT NULL,
  `Acumulado` float NOT NULL DEFAULT '0',
  `Historial` longtext,
  PRIMARY KEY (`NumeroTarjetaSanitaria`),
  UNIQUE KEY `DNI_UNIQUE` (`DNI`),
  UNIQUE KEY `NumeroTarjetaSanitaria_UNIQUE` (`NumeroTarjetaSanitaria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table DbIRyM.Receta
CREATE TABLE IF NOT EXISTS `Receta` (
  `idReceta` int(11) NOT NULL AUTO_INCREMENT,
  `Paciente` int(11) NOT NULL,
  `Medicamento` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Dispensada` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idReceta`),
  UNIQUE KEY `idReceta_UNIQUE` (`idReceta`),
  KEY `Medicamento_idx` (`Medicamento`),
  KEY `Paciente_idx` (`Paciente`),
  CONSTRAINT `Medicamento` FOREIGN KEY (`Medicamento`) REFERENCES `Medicamento` (`CNMedicamento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Paciente` FOREIGN KEY (`Paciente`) REFERENCES `Paciente` (`NumeroTarjetaSanitaria`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table DbIRyM.Recetas_Medico
CREATE TABLE IF NOT EXISTS `Recetas_Medico` (
  `idReceta` int(11) NOT NULL AUTO_INCREMENT,
  `NumeroFacultativo` int(11) NOT NULL,
  PRIMARY KEY (`idReceta`,`NumeroFacultativo`),
  UNIQUE KEY `idReceta_UNIQUE` (`idReceta`),
  KEY `fk_Receta_has_Medico_Medico1_idx` (`NumeroFacultativo`),
  KEY `fk_Receta_has_Medico_Receta1_idx` (`idReceta`),
  CONSTRAINT `fk_Receta_has_Medico_Medico1` FOREIGN KEY (`NumeroFacultativo`) REFERENCES `Medico` (`NumeroFacultativo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Receta_has_Medico_Receta1` FOREIGN KEY (`idReceta`) REFERENCES `Receta` (`idReceta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for event DbIRyM.ResetAcumulado
DELIMITER //
CREATE DEFINER=`IRyM`@`%` EVENT `ResetAcumulado` ON SCHEDULE EVERY 1 MONTH STARTS '2014-12-01 00:00:00' ON COMPLETION PRESERVE ENABLE COMMENT 'Resetea el valor de Acumulado al principio de cada mes.' DO BEGIN
	UPDATE `Paciente` SET `Acumulado` = 0;
END//
DELIMITER ;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
