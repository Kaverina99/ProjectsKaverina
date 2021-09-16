<?
include('../connection.php');
$ID = $_GET['id'];
$result = mysqli_query($link,"SELECT ID,PRODUCT_QUANTITY FROM products WHERE `ID`=".$ID);
while($row=mysqli_fetch_array($result))
{
	if ($row['PRODUCT_QUANTITY'] == "0")
	{
		echo "<script type=\"text/javascript\">alert('Произошла ошибка! В данный момент товар недоступен для вычитания')</script>";
		echo "<script type=\"text/javascript\">window.location = '../'</script>";
		exit;
	}
	else
	{
		$count = $row['PRODUCT_QUANTITY'] - 1;
		$results=mysqli_query($link,"UPDATE `products` SET `PRODUCT_QUANTITY` = '".$count."' WHERE `products`.`ID` = ".$ID);
	}
	header('Location: ../');
	exit;
}
?>