<?php
include "include/dbcon.php";
include "include/lib.php";

$AuthId = addslashes($_COOKIE['AuthId']);
$AuthSession = addslashes($_COOKIE['AuthSession']);

$session_type = ($_REQUEST["type"] == 'band') ? "band_session" : "fb_session";


$sql = "SELECT $session_type, date FROM user WHERE id='$AuthId'";
$result = $connect->query($sql);
$row = $result->fetch_array();

$timenow = date("Y-m-d"); 
$timetarget = $row['date'];
$str_now = strtotime($timenow);
$str_target = strtotime($timetarget);

if ($AuthId && $AuthSession) {
	if ($row[$session_type] != $AuthSession) {
		Logout();
	}
}
if ($str_now > $str_target) {
	Logout();
}

$sql = "SELECT $session_type FROM user WHERE id='$AuthId'";
$result = $connect->query($sql);
$row = $result->fetch_array();
echo $row[$session_type];
$connect->close();
?>