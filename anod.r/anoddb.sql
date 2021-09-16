-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Июн 04 2021 г., 12:55
-- Версия сервера: 10.3.22-MariaDB
-- Версия PHP: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `anoddb`
--

-- --------------------------------------------------------

--
-- Структура таблицы `role`
--

CREATE TABLE `role` (
  `id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `role`
--

INSERT INTO `role` (`id`, `name`) VALUES
(1, 'Администратор'),
(2, 'Клиент'),
(3, 'Сотрудник');

-- --------------------------------------------------------

--
-- Структура таблицы `status`
--

CREATE TABLE `status` (
  `id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `status`
--

INSERT INTO `status` (`id`, `name`) VALUES
(1, 'Не подтвержден'),
(2, 'Подтвержден');

-- --------------------------------------------------------

--
-- Структура таблицы `type1`
--

CREATE TABLE `type1` (
  `id` int(11) NOT NULL,
  `count` int(50) NOT NULL,
  `shtutsera` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `skhemaPromyvkiGOST` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `typeYplotn` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `markaNasosa` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `typeNasosa` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `oborotyDvigatelya` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `napravlVrashchen` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `promyvSreda` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `temperPromyv` float NOT NULL,
  `davlPromyv` float NOT NULL,
  `classVzryvoopasZony` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `markirovkaVzryvozashch` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nameSreda` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `sostavSreda` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pH` float NOT NULL,
  `davlInSalCameraMin` float NOT NULL,
  `davlInSalCameraMax` float NOT NULL,
  `davlNaVkhodeMin` float NOT NULL,
  `davlNaVkhodeMax` float NOT NULL,
  `davlNaNaporeMin` float NOT NULL,
  `davlNaNaporeMax` float NOT NULL,
  `temperMin` float NOT NULL,
  `temperMax` float NOT NULL,
  `temperOkrSredaMin` float NOT NULL,
  `temperOkrSredaMax` float NOT NULL,
  `Dv` float NOT NULL,
  `Dvt` float NOT NULL,
  `D1` float NOT NULL,
  `L1` float NOT NULL,
  `L2` float NOT NULL,
  `D2` float NOT NULL,
  `D3` float NOT NULL,
  `Dsh` float NOT NULL,
  `N` float NOT NULL,
  `NalichieResKan` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `zakazFK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `type1`
--

INSERT INTO `type1` (`id`, `count`, `shtutsera`, `skhemaPromyvkiGOST`, `typeYplotn`, `markaNasosa`, `typeNasosa`, `oborotyDvigatelya`, `napravlVrashchen`, `promyvSreda`, `temperPromyv`, `davlPromyv`, `classVzryvoopasZony`, `markirovkaVzryvozashch`, `nameSreda`, `sostavSreda`, `pH`, `davlInSalCameraMin`, `davlInSalCameraMax`, `davlNaVkhodeMin`, `davlNaVkhodeMax`, `davlNaNaporeMin`, `davlNaNaporeMax`, `temperMin`, `temperMax`, `temperOkrSredaMin`, `temperOkrSredaMax`, `Dv`, `Dvt`, `D1`, `L1`, `L2`, `D2`, `D3`, `Dsh`, `N`, `NalichieResKan`, `zakazFK`) VALUES
(5, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(6, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(7, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(8, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(9, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(10, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(11, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(12, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(13, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(14, 1, '1', '1e', '1', '1', '1', '1', '1', '11', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 11, 111, 1, 1, 1, 1, 1, 1, 1, '111', 20),
(15, 1, '1', '1e', '1', '1', '1', '1', '1', '11', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 11, 111, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(16, 1, '11', '11', '1', '1', '1', '11', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 11, 1, 11, 11, 1, 11, 1, 1, 1, 1, 1, '2222', 1),
(17, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(18, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(19, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(20, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(21, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(22, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1),
(23, 1, '1', '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', '1', '1', '1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '111', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `type2`
--

CREATE TABLE `type2` (
  `id` int(11) NOT NULL,
  `count` int(11) NOT NULL,
  `nameAndMarka` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `izgotovitel` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `vid` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `raspolozheniye` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `vidJob` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ispolzuyemyyeTypeYpl` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `materialPoverkhOborud` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `polozheniyeVala` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `napravlVrashchSoStor` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `speedVrashch` float NOT NULL,
  `dValaVMesteYstan` float NOT NULL,
  `dVnutrBobyshki` float NOT NULL,
  `rZakruglBob` float NOT NULL,
  `namePerekachProdukta` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `rabDavlMin` float NOT NULL,
  `rabDavlMax` float NOT NULL,
  `rabTemperMin` float NOT NULL,
  `rabTemperMax` float NOT NULL,
  `sostav` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `plotnost` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `vyazkost` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pH` float NOT NULL,
  `temperKipeniya` float NOT NULL,
  `dopustimYtechka` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nalichiyeAbrazivKompon` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `himSvoystva` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `izmenSvoystvSreda` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nameAndSostavZat` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `D` float NOT NULL,
  `D1` float NOT NULL,
  `D2` float NOT NULL,
  `D3` float NOT NULL,
  `D4` float NOT NULL,
  `Dotv` float NOT NULL,
  `N` float NOT NULL,
  `L1` float NOT NULL,
  `L2` float NOT NULL,
  `a` float NOT NULL,
  `L3` float NOT NULL,
  `L4` float NOT NULL,
  `a1` float NOT NULL,
  `a3` float NOT NULL,
  `osobenGeometriiVala` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `zakazFK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `type3`
--

CREATE TABLE `type3` (
  `id` int(11) NOT NULL,
  `count` int(11) NOT NULL,
  `klimatIspolnAndKateg` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `temperOkrVozdukhaMin` float NOT NULL,
  `temperOkrVozdukhaMax` float NOT NULL,
  `classVzryvoopasPomeshch` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `naznachNasosa` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `raskhodMin` float NOT NULL,
  `raskhodMax` float NOT NULL,
  `raskhodNominal` float NOT NULL,
  `davlSistPeredVkhodom` float NOT NULL,
  `davlSistPosleNasosa` float NOT NULL,
  `naporPotrebPriNominalRaskh` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `kavitatsZapasSeti` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `namePerekachProdukta` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `obyemKontsentrTverVkl` float NOT NULL,
  `tempRab` float NOT NULL,
  `plotnostPriTempRab` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `vyazkostPriTempRab` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `yprugostParovPriTempRab` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `toksichnostPoGOST` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `classOpastPoGOST` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `vzryvoopasPoGOSTR` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pH` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `polymerization` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `material` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `rezina` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `chastotaVrashc` float NOT NULL,
  `podacha` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `napor` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `kavitatsZapas` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `KPD` float NOT NULL,
  `moshchnostPotreb` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `typeElektrodv` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ispolneniyePoVzryvozashch` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `moshchnost` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `napryazheniye` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `chastotaVrashch2` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tiporazmer` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `zatvornayaZhidkost` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `akkumulyatorPruzhGidravl` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `holodilnikYpl` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `avtonomnyyeSist` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `agregatInPolnomObyeme` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nasos` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `massaAgr` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `zakazFK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `type4`
--

CREATE TABLE `type4` (
  `id` int(11) NOT NULL,
  `count` int(11) NOT NULL,
  `markaModNasosa` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `proizvod` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `markaBPY` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `climatIspolnAndKateg` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `classVzryvoopasPomeshch` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tempOkrVozdukhaMin` float NOT NULL,
  `tempOkrVozdukhaMax` float NOT NULL,
  `namePerekachZhid` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tempRabPlotn` float NOT NULL,
  `tempRabVyazkost` float NOT NULL,
  `davlNasyshchParol` float NOT NULL,
  `toksichPoGOST` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `classOpasPoGOST` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `vzryvoopasPoGOST` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pH` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `polymerization` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `naznachNasosa` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `chastotaVrashch` float NOT NULL,
  `napravlVrashch` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `podacha` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `napor` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `davlInSistPeredVkhod` float NOT NULL,
  `davlInSistPosleNasosa` float NOT NULL,
  `sushchProblNasosa` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nameZatvorZhidk` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `davlMPa` float NOT NULL,
  `temperat` float NOT NULL,
  `osobTrebovan` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `typeElektrodvig` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `moshchnost` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `napryazheniye` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `chastotaVrashch2` float NOT NULL,
  `BPYpoln` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `BPYnepoln` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `trebpvanKIPiA` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `zakazFK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `type5`
--

CREATE TABLE `type5` (
  `id` int(11) NOT NULL,
  `count` int(11) NOT NULL,
  `nameAndMarkaApp` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `rabSredaInZoneRazm` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `chastotaVrashchVala` float NOT NULL,
  `massaRotora` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nameRabSreda` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `temperat` float NOT NULL,
  `davlInPolostiPodsh` float NOT NULL,
  `vozmozhPodachiInPol` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `osobenGeomVala` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `dOpor` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `dYpor` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Lopor` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Lypor` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `d1opor` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `d1ypor` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cOpor` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cYpor` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `PocOpor` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `PocYpor` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `zakazFK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `type6`
--

CREATE TABLE `type6` (
  `id` int(11) NOT NULL,
  `count` int(11) NOT NULL,
  `typeArmat` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `naznachenie` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `davlNominal` float NOT NULL,
  `prohodNominal` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prisoyedineniye` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `otvetnyyeFlantsy` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `dTruboprovoda` float NOT NULL,
  `rabDavlMin` float NOT NULL,
  `rabDavlMax` float NOT NULL,
  `rabTemperMin` float NOT NULL,
  `rabTemperMax` float NOT NULL,
  `tempOkrSrMin` float NOT NULL,
  `tempOkrSrMax` float NOT NULL,
  `maxPerepadDavl` float NOT NULL,
  `nameRabSr` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `himSostav` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `agregatSostoyaniye` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nalichiyeTverdChast` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `podKakimPerepadomDavl` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `trebovaniyaPoNermetichnosti` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `materialKor` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `vnutrDetali` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `truboprovod` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `zakazFK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `surname` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `name` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `patronymic` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `phone` varchar(12) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `roleFK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `user`
--

INSERT INTO `user` (`id`, `surname`, `name`, `patronymic`, `phone`, `email`, `password`, `roleFK`) VALUES
(6, 'Козлов', 'Егор', 'Валентинович', '+79206458139', 'kozlov80@mail.ru', '753kozl0', 2),
(7, 'Петров', 'Валентин', 'Дмитриевич', '+79605284170', 'petrov91@mail.ru', '555pt0', 3),
(8, 'Петров', 'Петр', 'Петрович', '+79203441578', 'petrovPetr@mail.ru', '000vb5', 2),
(9, 'Меньшов', 'Иван', 'Борисович', '+79345068473', 'ivanbor85@mail.ru', '02fs785', 3),
(10, 'Каверина ', 'Екатерина', 'Васильевна', '+79206548230', 'kaverina80@mail.ru', '753kozl0', 1),
(11, 'Зайцев', 'Анатолий', 'Борисович', '+79603451790', 'anatoliyzz@gmail.com', '90annz', 3),
(12, 'Кук', 'Петр', 'Иванович', '+79201534788', 'kyk89@mail.ru', '741k089', 3);

-- --------------------------------------------------------

--
-- Структура таблицы `zakaz`
--

CREATE TABLE `zakaz` (
  `id` int(11) NOT NULL,
  `nameOrg` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `addressOrg` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `codeCity` int(11) NOT NULL,
  `phone` varchar(12) COLLATE utf8mb4_unicode_ci NOT NULL,
  `fax` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `FIO` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `position` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `statusFK` int(11) NOT NULL,
  `clientFK` int(11) NOT NULL,
  `sotrudnikFK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `zakaz`
--

INSERT INTO `zakaz` (`id`, `nameOrg`, `addressOrg`, `codeCity`, `phone`, `fax`, `FIO`, `position`, `statusFK`, `clientFK`, `sotrudnikFK`) VALUES
(1, '11', '11', 11, '1', '11', '11', '1', 1, 6, 10),
(3, '11', '11', 11, '1', '11', '11', '1', 1, 6, 7),
(4, '11', '11', 11, '1', '11', '11', '1', 1, 6, 7),
(5, '11', '11', 11, '1', '11', '11', '1', 1, 6, 7),
(6, '11', '11', 11, '1', '11', '11', '1', 1, 6, 7),
(7, '11', '11', 11, '1', '11', '11', '1', 1, 6, 7),
(8, '11', '11', 11, '1', '11', '11', '1', 1, 6, 7),
(9, '11', '11', 11, '1', '11', '11', '1', 1, 6, 7),
(10, '1', '11', 11, '11', '11', '11', '11', 1, 6, 7),
(11, '1', '11', 11, '11', '11', '11', '11', 1, 6, 7),
(12, '11', '11', 11, '11', '11', '11', '11', 1, 6, 7),
(13, '11', '11', 11, '1', '11', '1', '1', 1, 6, 7),
(14, '1', '1', 1, '1', '1', '1', '1', 1, 6, 7),
(15, '1', '1', 1, '1', '1', '1', '1', 1, 6, 7),
(16, '1', '1', 1, '1', '1', '1', '1', 1, 6, 7),
(17, '1', '1', 1, '1', '1', '1', '1', 1, 6, 7),
(18, '1', '1', 1, '1', '1', '1', '1', 1, 6, 7),
(19, '1', '1', 1, '1', '1', '1', '1', 1, 6, 7),
(20, '42', '42', 42, '42', '42', '42', '42', 1, 8, 9),
(21, '75', '75', 75, '75', '75', '75', '75', 1, 8, 9);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `status`
--
ALTER TABLE `status`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `type1`
--
ALTER TABLE `type1`
  ADD PRIMARY KEY (`id`),
  ADD KEY `zakazFK` (`zakazFK`);

--
-- Индексы таблицы `type2`
--
ALTER TABLE `type2`
  ADD PRIMARY KEY (`id`),
  ADD KEY `zakazFK` (`zakazFK`);

--
-- Индексы таблицы `type3`
--
ALTER TABLE `type3`
  ADD PRIMARY KEY (`id`),
  ADD KEY `zakazFK` (`zakazFK`),
  ADD KEY `zakazFK_2` (`zakazFK`);

--
-- Индексы таблицы `type4`
--
ALTER TABLE `type4`
  ADD PRIMARY KEY (`id`),
  ADD KEY `zakazFK` (`zakazFK`);

--
-- Индексы таблицы `type5`
--
ALTER TABLE `type5`
  ADD PRIMARY KEY (`id`),
  ADD KEY `zakazFK` (`zakazFK`);

--
-- Индексы таблицы `type6`
--
ALTER TABLE `type6`
  ADD PRIMARY KEY (`id`),
  ADD KEY `zakazFK` (`zakazFK`);

--
-- Индексы таблицы `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD KEY `roleFK` (`roleFK`);

--
-- Индексы таблицы `zakaz`
--
ALTER TABLE `zakaz`
  ADD PRIMARY KEY (`id`),
  ADD KEY `statusFK` (`statusFK`),
  ADD KEY `clientFK` (`clientFK`),
  ADD KEY `sotrudnikFK` (`sotrudnikFK`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `role`
--
ALTER TABLE `role`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `status`
--
ALTER TABLE `status`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `type1`
--
ALTER TABLE `type1`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT для таблицы `type2`
--
ALTER TABLE `type2`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `type3`
--
ALTER TABLE `type3`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `type4`
--
ALTER TABLE `type4`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `type5`
--
ALTER TABLE `type5`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `type6`
--
ALTER TABLE `type6`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT для таблицы `zakaz`
--
ALTER TABLE `zakaz`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `type1`
--
ALTER TABLE `type1`
  ADD CONSTRAINT `type1_ibfk_1` FOREIGN KEY (`zakazFK`) REFERENCES `zakaz` (`id`);

--
-- Ограничения внешнего ключа таблицы `type2`
--
ALTER TABLE `type2`
  ADD CONSTRAINT `type2_ibfk_1` FOREIGN KEY (`zakazFK`) REFERENCES `zakaz` (`id`);

--
-- Ограничения внешнего ключа таблицы `type3`
--
ALTER TABLE `type3`
  ADD CONSTRAINT `type3_ibfk_1` FOREIGN KEY (`zakazFK`) REFERENCES `zakaz` (`id`);

--
-- Ограничения внешнего ключа таблицы `type4`
--
ALTER TABLE `type4`
  ADD CONSTRAINT `type4_ibfk_1` FOREIGN KEY (`zakazFK`) REFERENCES `zakaz` (`id`);

--
-- Ограничения внешнего ключа таблицы `type5`
--
ALTER TABLE `type5`
  ADD CONSTRAINT `type5_ibfk_1` FOREIGN KEY (`zakazFK`) REFERENCES `zakaz` (`id`);

--
-- Ограничения внешнего ключа таблицы `type6`
--
ALTER TABLE `type6`
  ADD CONSTRAINT `type6_ibfk_1` FOREIGN KEY (`zakazFK`) REFERENCES `zakaz` (`id`);

--
-- Ограничения внешнего ключа таблицы `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_ibfk_1` FOREIGN KEY (`roleFK`) REFERENCES `role` (`id`);

--
-- Ограничения внешнего ключа таблицы `zakaz`
--
ALTER TABLE `zakaz`
  ADD CONSTRAINT `zakaz_ibfk_1` FOREIGN KEY (`statusFK`) REFERENCES `status` (`id`),
  ADD CONSTRAINT `zakaz_ibfk_2` FOREIGN KEY (`clientFK`) REFERENCES `user` (`id`),
  ADD CONSTRAINT `zakaz_ibfk_3` FOREIGN KEY (`sotrudnikFK`) REFERENCES `user` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
