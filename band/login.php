<?php
include "include/dbcon.php";
include "include/lib.php";

if ($_REQUEST["action"] == 'login') {
	$Id = StrToLower($_POST['id']);
	$Pass = StrToLower($_POST['pass']);
	$sql = "SELECT pass,date FROM user WHERE id='$Id'";
	$result = $connect->query($sql);
	if ($result->num_rows < '1') {
		AlertBox ('실패','','./login.php');
		Exit;
	} else {
		$row = $result->fetch_array();

		$timenow = date("Y-m-d"); 
		$timetarget = $row['date'];
		$str_now = strtotime($timenow);
		$str_target = strtotime($timetarget);

		if ($Pass == $row['pass']) {
			if ($str_now > $str_target) {
				AlertBox ('기간만료','','./login.php');
				Exit;
			}
			$session = md5(rand());
			SetCookie('AuthId',$Id,-1,'/');
			SetCookie('AuthSession',$session,-1,'/');
			$sql = "UPDATE user SET band_session='$session' WHERE id='$Id'";
			$connect->query($sql);
			AlertBox ('성공','','./session.php?type=band');
		} else {
			AlertBox ('실패','','./login.php');
			Exit;
		}
	}
} elseif ($_REQUEST["action"] == 'logout') {
	Logout();
	PageRedirect('./login.php', 0);
} else {
?>
<!DOCTYPE html>
<meta charset="utf-8" />
<form method='post' action="login.php?action=login">
<table>
<tr>
	<td>아이디</td>
	<td><input type='text' name='id' tabindex='1'/></td>
	<td rowspan='2'><input type='submit' tabindex='3' value='로그인' style='height:50px'/></td>
</tr>
<tr>
	<td>비밀번호</td>
	<td><input type='password' name='pass' tabindex='2'/></td>
</tr>
</table>
</form>
<?php
}
$connect->close();
?>