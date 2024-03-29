-- phpMyAdmin SQL Dump
-- version 4.9.7
-- https://www.phpmyadmin.net/
--
-- Хост: localhost
-- Время создания: Ноя 21 2022 г., 20:29
-- Версия сервера: 5.7.21-20-beget-5.7.21-20-1-log
-- Версия PHP: 5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `kaveri85_test`
--

-- --------------------------------------------------------

--
-- Структура таблицы `comment`
--
-- Создание: Ноя 21 2022 г., 11:27
-- Последнее обновление: Ноя 21 2022 г., 17:00
--

DROP TABLE IF EXISTS `comment`;
CREATE TABLE `comment` (
  `id` int(11) NOT NULL,
  `full_name` varchar(100) NOT NULL,
  `content` varchar(1000) NOT NULL,
  `datetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `post_FK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `comment`
--

INSERT INTO `comment` (`id`, `full_name`, `content`, `datetime`, `post_FK`) VALUES
(8, 'тест 1', 'текст комментария 1 ', '2022-11-21 15:24:38', 3),
(12, 'тест 1', 'Текст описания поста \"Принцесса смиренная: княгиня Шарлен в «покорном» белом пальто, похожим на рясу\"', '2022-11-21 16:28:22', 4),
(13, 'тест 2', 'Текст описания поста \"Принцесса смиренная: княгиня Шарлен в «покорном» белом пальто, похожим на рясу\"', '2022-11-21 16:28:55', 4),
(14, 'тест 1', 'ggg', '2022-11-21 19:57:39', 2),
(15, 'тест 1', 'текст для комментария ', '2022-11-21 19:58:16', 1),
(16, 'ФИО комментатора 2', 'Текст комментария для новости \"Правда ли, что чай помогает худеть?\"', '2022-11-21 19:58:49', 1),
(17, 'ФИО комментатора 2', 'текст описания комментария ', '2022-11-21 19:59:28', 2),
(18, 'ФИО 3', 'текст комментария 3 ', '2022-11-21 20:00:42', 2);

-- --------------------------------------------------------

--
-- Структура таблицы `post`
--
-- Создание: Ноя 21 2022 г., 13:24
-- Последнее обновление: Ноя 21 2022 г., 13:26
--

DROP TABLE IF EXISTS `post`;
CREATE TABLE `post` (
  `id` int(11) NOT NULL,
  `title` varchar(100) NOT NULL,
  `content` varchar(1000) NOT NULL,
  `alias` varchar(100) NOT NULL,
  `image_url` varchar(100) DEFAULT NULL,
  `datetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `published` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `post`
--

INSERT INTO `post` (`id`, `title`, `content`, `alias`, `image_url`, `datetime`, `published`) VALUES
(1, 'Правда ли, что чай помогает худеть?', 'Если вы решили придерживаться диеты, основная установка ясна как день: сократить объем съедаемого. Калории идут на убыль, скудные перекусы уже не выглядят как повод для перерыва, что обидно, особенно в рабочий день. Как же успокоить несытый желудок и заодно отвлечься от трудовой рутины? «Выпить чаю, — советует диетолог и tea-эксперт Лили Соуттер. — Замена перекусов чашкой горячего ароматного напитка не только приобщит вас к манерам британских аристократов, но и поможет терять килограммы». Рекомендация специалиста для нас, конечно, не новость: чай давным-давно знаменит своими дренажными и мочегонными способностями. Но как он помогает снизить вес и что за сорт справляется с этим успешнее прочих?', 'new1', 'http://kaveri85.beget.tech/image/1.jpeg', '2022-11-18 12:23:18', 1),
(2, 'Добавить в корзину: домашний пилинг для лица /skin regimen/', 'В новой рубрике «Добавить в корзину» редакция ELLE делится действенными и проверенными средствами, которые отлично работают. Сегодня рассказываем подробнее про домашний пилинг для лица из линии /skin regimen/ от бренда [ comfort zone ].\r\n\r\nПилинг отлично подойдет для эффективного обновления кожи в осенне-зимний период. Уже после первого использования можно отметить заметно более ровный цвет лица. Гликолиевая кислота в составе глубоко проникает в кожу, а растительная лактобионовая кислота обеспечивает клеточное обновление. У пилинга приятная текстура геля, средство подходит для всех типов кожи.\r\n\r\nПилинг /skin regimen/ от [ comfort zone ]', 'new2', '/image/2.jpeg', '2022-11-19 16:33:07', 1),
(3, 'С французским шиком: Аня Тейлор-Джой в женственном костюме с мини-юбкой', 'Внимательно следим за выходами юной актрисы Ани Тейлор-Джой, которая гастролирует по миру, представляя свой новый фильм «Меню». На днях Аня появилась в Нью-Йорке в нежно-розовом костюме Courrèges с мини-юбкой. Очаровательный ретро-образ получился в стиле кокетливых француженок.\r\nБлагодаря своей необычной и притягательной внешности актриса Аня Тейлор-Джой часто становится «лакомым кусочком» для создателей триллеров и хорроров. В послужном списке звезды уже значатся культовый фильм «Ведьма» студии А24, картина «Прошлой ночью в Сохо», номинированная на премию BAFTA, а также «Сплит» и другие. И вот очередная «страшилка», где Тейлор-Джой сыграла главную роль — в ноябре на большие экраны выходит комедийный хоррор «Меню» от режиссера Марка Майлода. В центре сюжета молодая пара (вместе с Аней в фильме снялся Николас Холт), которая приехала в новый дорогой ресторан на отдаленном острове. Заведением управляет эксцентричный шеф-повар (Рэйф Файнс), он приготовил для гостей нечто совершенно уникаль', 'new3', '/image/3.jpeg', '2022-11-19 19:36:20', 1),
(4, 'Принцесса смиренная: княгиня Шарлен в «покорном» белом пальто, похожим на рясу', '19 ноября — особенная дата в календаре монегасков. В этот день в карликовом государстве отмечают Национальный день Монако, известный так же, как День князя. На торжестве по-традиции присутствуют все члены монаршей семьи Гримальди.  Празднование 2022 года знаменует возвращение в официальную повестку княгини Шарлен. В прошлом году из-за скандалов, интриг и многочисленных проблем со здоровьем это важное торжество монаршая особа пропустила, а в этом — подчеркивает всем своим внешним видом: во Дворце в Монте-Карло все как никогда спокойно. ', 'new4', '/image/4.jpeg', '2022-11-21 16:25:31', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `tag`
--
-- Создание: Ноя 20 2022 г., 15:31
-- Последнее обновление: Ноя 21 2022 г., 13:45
--

DROP TABLE IF EXISTS `tag`;
CREATE TABLE `tag` (
  `id` int(11) NOT NULL,
  `title` varchar(100) NOT NULL,
  `description` varchar(1000) DEFAULT NULL,
  `alias` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `tag`
--

INSERT INTO `tag` (`id`, `title`, `description`, `alias`) VALUES
(1, 'Мода', 'Мода — совокупность привычек, ценностей и вкусов, принятых в определённой среде в определённое время. Установление идеологии или стиля в какой-либо сфере жизни или культуры. Мода может определять тип или форму одежды и аксессуаров, набор идей, принципы поведения людей в обществе друг друга и этикета, и понятий нормы в стилизации и организации пространства. Иногда понятие моды распространяют на представления об образе жизни, искусстве, литературе, архитектуре, кулинарии, индустрии развлечений и отдыха, рассматривают её влияние на тип человеческого тела и т. д. Понятие моды, как правило, подразумевает непрочное и быстро проходящее установление. Стремление неукоснительно следовать условным модным правилам и веяниям часто привлекало внимание карикатуристов.', 'fashion'),
(2, 'Красота', 'Красота — эстетическая (неутилитарная, непрактическая) категория, обозначающая совершенство, гармоничное сочетание аспектов объекта, при котором последний вызывает у наблюдателя эстетическое наслаждение. Красота является одной из важнейших категорий культуры. Противоположностью красоты является безобразие.', 'beauty'),
(3, 'Новости звёзд', NULL, 'stars'),
(4, 'Отношения', NULL, 'relationships'),
(5, 'Стиль жизни', NULL, 'lifestyle'),
(6, 'Гороскопы', NULL, 'horoscopes'),
(7, 'Бьюти-блог', NULL, 'beauty_blog'),
(8, 'Бьюти-тренды', NULL, 'beauty_trends'),
(9, 'Здоровье', NULL, 'health'),
(10, 'Добавить в корзину', NULL, 'add_to_cart');

-- --------------------------------------------------------

--
-- Структура таблицы `tag_post`
--
-- Создание: Ноя 20 2022 г., 13:40
-- Последнее обновление: Ноя 21 2022 г., 14:52
--

DROP TABLE IF EXISTS `tag_post`;
CREATE TABLE `tag_post` (
  `id` int(11) NOT NULL,
  `post_FK` int(11) NOT NULL,
  `tag_FK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `tag_post`
--

INSERT INTO `tag_post` (`id`, `post_FK`, `tag_FK`) VALUES
(1, 1, 7),
(2, 1, 2),
(5, 2, 7),
(6, 2, 2),
(11, 2, 10),
(12, 3, 3),
(13, 4, 1),
(14, 4, 3),
(17, 4, 2);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `comment`
--
ALTER TABLE `comment`
  ADD PRIMARY KEY (`id`),
  ADD KEY `post_FK` (`post_FK`);

--
-- Индексы таблицы `post`
--
ALTER TABLE `post`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `tag`
--
ALTER TABLE `tag`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `tag_post`
--
ALTER TABLE `tag_post`
  ADD PRIMARY KEY (`id`),
  ADD KEY `tag_FK` (`tag_FK`),
  ADD KEY `post_FK` (`post_FK`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `comment`
--
ALTER TABLE `comment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT для таблицы `post`
--
ALTER TABLE `post`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `tag`
--
ALTER TABLE `tag`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT для таблицы `tag_post`
--
ALTER TABLE `tag_post`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `comment`
--
ALTER TABLE `comment`
  ADD CONSTRAINT `comment_ibfk_2` FOREIGN KEY (`post_FK`) REFERENCES `post` (`id`);

--
-- Ограничения внешнего ключа таблицы `tag_post`
--
ALTER TABLE `tag_post`
  ADD CONSTRAINT `tag_post_ibfk_1` FOREIGN KEY (`tag_FK`) REFERENCES `tag` (`id`),
  ADD CONSTRAINT `tag_post_ibfk_2` FOREIGN KEY (`post_FK`) REFERENCES `post` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
