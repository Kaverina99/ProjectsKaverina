<?
include('../connection.php');
$results=mysqli_query($link,"UPDATE `products` SET `PRODUCT_STATUS` = '0' WHERE `products`.`ID` = ".$_GET['id']);
header('Location: ../');


?>