<!DOCTYPE HTML>
<html>

<head>
    <script src="/js/hidden.js"></script>
    <meta charset="utf-8">
    <title>Тестовое задание</title>
</head>

<body>

 <div>
    <h1 align='center'>Каталог товаров</h1>
    <?php

        class CProducts{

            function writeProducts($limit) {

                require_once 'connection.php'; // подключаем скрипт
                $link = mysqli_connect($host, $user, $password, $database)
                    or die("Ошибка " . mysqli_error($link));

                $query ="SELECT * FROM products WHERE PRODUCT_STATUS=1 ORDER BY DATE_CREATE DESC";

                $result = mysqli_query($link, $query) or die("Ошибка " . mysqli_error($link));
                if($result)
                {
                    $rows = mysqli_num_rows($result); // количество полученных строк

                    echo "<table width='100%'; border='1'; cellpadding='5';><tr><th>ID</th><th>Название</th><th>Цена, руб.</th><th>Артикул</th><th>Количество </th><th>Дата добавления</th></tr>";

                    if ($rows >= $limit) $count=$limit;
                    else $count=$rows;

                    for ($i = 0 ; $i < $count ; ++$i)
                    {
                        $row = mysqli_fetch_row($result);
                        echo "<tr>";
                            for ($j = 1 ; $j < 7 ; ++$j)
                                if ($j==5)
                                echo "<td align='center'><button onclick='minus($row[0])'>-</button> $row[$j] <button onclick='plus($row[0])'>+</button></td>";
                                else echo "<td align='center'>$row[$j]</td>";
                        echo "<td align='center'><button onclick='hide($row[0])'>Скрыть</button></td>";
                        echo "</tr>";
                    }
                    echo "</table>";

                    // очищаем результат
                    mysqli_free_result($result);
                }
                mysqli_close($link);
            }
        }


        $cp = new CProducts();
        $func = "writeProducts";
        $cp->$func(10);
    ?>



</div>

</body>
</html>