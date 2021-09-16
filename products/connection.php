<?php
$host = 'localhost'; // адрес сервера 
$database = 'products'; // имя базы данных
$user = 'root'; // имя пользователя
$password = ''; // пароль


$link = mysqli_connect($host, $user, $password, $database);
if (!$link) {
	    die('Ошибка соединения: ' . mysql_error());
	}
?>