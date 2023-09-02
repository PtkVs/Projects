<?php
	session_start();
	//$lin = $_SESSION['lindate'];
	include 'userconfig.php';
	//date_default_timezone_set('Asia/Kathmandu');
	//$lout = date('Y-m-d H:i:s');
	 
	/*$sql = "UPDATE tbl_log SET LoggedOut='".$lout."' WHERE LoggedIn='".$lin."'";
	$result=mysql_query($sql) or trigger_error("There was some error in the sql statement" . mysql_error());*/
	/*if($result==FALSE)
	{ die(mysql_error()); }*/
	$chk =$_COOKIE['uid'];
	
	if ($chk > 0){
		$_COOKIE['uid'] = ""; 
	 	$_COOKIE['uname'] = "";
		$_COOKIE['utype'] = ""; 
		if(isset($_COOKIE['uid'])){
			setcookie('uid',$_SESSION['userid'], time()-(60*60*24*2));
			setcookie("uname",$_SESSION["username"], time()-60*60*24*2); // 86400=1din	60sec 60min 24hr
			setcookie("utype",$_SESSION["type"],time()-60*60*24*2);
			setcookie("psswd",$_SESSION["pswd"],time()-60*60*24*2);

		
		}
		session_destroy();
		$_SESSION['userid'] = "";
		$_SESSION['username'] = "";
		$_SESSION['type'] = "";
		//$_SESSION['lindate'] = "";
		//$_SESSION['logid'] = "";
	 
	
	
		header("Location:../index.php");
	}
?>
