<?php
	session_start();
	
	
	include 'config.php';
	
	date_default_timezone_set('Asia/Kathmandu');
	$logout = date('Y-m-d H:i:s');
	 
	$sql = "UPDATE table_log SET LogOutTime='".$logout."' WHERE LogInTime= '".$_SESSION["login"]."' ";
	$result=mysql_query($sql) or trigger_error("There was some error in the sql statement" . mysql_error());
	
	if($result==FALSE)	{ die(mysql_error()); }
	
	if(isset($_COOKIE['uid'])){
		/*setcookie('uid', "");
		setcookie('uname', "");
		setcookie('psswd', "");
		setcookie('utype', "");*/
		setcookie('uid',$_SESSION['userid'], time() - (3600));
		setcookie("uname",$_SESSION["username"], time() - (3600)); // 86400=1din	60sec 60min 24hr
		setcookie("utype",$_SESSION["type"],time() - (3600));
		setcookie("psswd",$_SESSION["pswd"],time()-(3600));
	}
	session_destroy();
	$_SESSION['userid'] = "";
	$_SESSION['username'] = "";
	$_SESSION['type'] = "";
	$_SESSION['lindate'] = "";
	$_SESSION['logid'] = "";
	
	header("Location: ../../../gnp/index.php");
	
?>
