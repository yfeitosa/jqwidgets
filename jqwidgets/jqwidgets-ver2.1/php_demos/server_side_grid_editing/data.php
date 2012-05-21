<?php
#Include the connect.php file
include('connect.php');
#Connect to the database
//connection String
$connect = mysql_connect($hostname, $username, $password)
or die('Could not connect: ' . mysql_error());
//Select The database
$bool = mysql_select_db($database, $connect);
if ($bool === False){
   print "can't find $database";
}
// get data and store in a json array
$query = "SELECT * FROM employees";

if (isset($_GET['update']))
{
	// UPDATE COMMAND 
	$update_query = "UPDATE `employees` SET `FirstName`='".$_GET['FirstName']."',
	`LastName`='".$_GET['LastName']."',
	`Title`='".$_GET['Title']."',
	`Address`='".$_GET['Address']."',
	`City`='".$_GET['City']."',
	`Country`='".$_GET['Country']."',
	`Notes`='".$_GET['Notes']."' WHERE `EmployeeID`='".$_GET['EmployeeID']."'";
	 $result = mysql_query($update_query) or die("SQL Error 1: " . mysql_error());
     echo $result;
}
else
{
    // SELECT COMMAND
	$result = mysql_query($query) or die("SQL Error 1: " . mysql_error());
	while ($row = mysql_fetch_array($result, MYSQL_ASSOC)) {
		$employees[] = array(
			'EmployeeID' => $row['EmployeeID'],
			'FirstName' => $row['FirstName'],
			'LastName' => $row['LastName'],
			'Title' => $row['Title'],
			'Address' => $row['Address'],
			'City' => $row['City'],
			'Country' => $row['Country'],
			'Notes' => $row['Notes']
		  );
	}
	 
	echo json_encode($employees);
}
?>