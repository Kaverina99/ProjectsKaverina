-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Сен 16 2021 г., 15:22
-- Версия сервера: 8.0.24
-- Версия PHP: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `products`
--

-- --------------------------------------------------------

--
-- Структура таблицы `products`
--

CREATE TABLE `products` (
  `ID` int NOT NULL,
  `PRODUCT_ID` int NOT NULL,
  `PRODUCT_NAME` varchar(100) NOT NULL,
  `PRODUCT_PRICE` float NOT NULL,
  `PRODUCT_ARTICLE` varchar(50) NOT NULL,
  `PRODUCT_QUANTITY` int NOT NULL,
  `DATE_CREATE` datetime NOT NULL,
  `PRODUCT_STATUS` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `products`
--

INSERT INTO `products` (`ID`, `PRODUCT_ID`, `PRODUCT_NAME`, `PRODUCT_PRICE`, `PRODUCT_ARTICLE`, `PRODUCT_QUANTITY`, `DATE_CREATE`, `PRODUCT_STATUS`) VALUES
(1, 1, 'Сыворотка для лица ', 320, 'ln5s44fb5', 54, '2021-09-14 11:28:33', 1),
(2, 2, 'Гидрогелевые патчи', 214.2, '45dbf85s', 25, '2021-09-14 12:30:35', 1),
(3, 3, 'Маска для лица', 228.9, 'j4w8hlf4', 97, '2021-09-14 11:32:02', 1),
(4, 4, 'Гель для умывания', 180, 'p2nafnm0', 60, '2021-09-14 11:23:18', 1),
(5, 5, 'Скраб для лица', 205, 'q5gp5s2r', 81, '2021-09-14 11:34:50', 0),
(6, 6, 'Гиалуроновый гель-пенка', 299.3, 'q54g6s9vm', 43, '2021-09-14 11:37:50', 1);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `products`
--
ALTER TABLE `products`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
