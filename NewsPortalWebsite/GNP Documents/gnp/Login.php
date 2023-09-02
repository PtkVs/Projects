
    <table align="center">
    	<tr align="center"><td><h2>Login</h2><hr></td></tr>
    <form  method="post" action="index.php?page=Login">
            <tr><td><br>
                        <b><font color="#008000">&nbsp;Username&nbsp;&nbsp;&nbsp;:
                        <input type="text"  name="username"    autofocus required/><br/><br/>
                        
                        &nbsp;Password&nbsp;&nbsp;&nbsp; :</font>
                        <input type="password" name="password"  required/><br /><br />
                        
                        <font color="#A40000">&nbsp;Login Type&nbsp;&nbsp;:
                        <select name="usertype" >	
                               
                            <option value="0">[choose]</option>
                            
                            <option>member</option>
                            <option>user</option></select>										
									
                        
            </td></tr>
            <tr><td bgcolor="#EEEEEE">
                <left><input type="checkbox" name = "remember-me" value="remember-me"  checked/> Keep me signed in </left>
                
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <input type="submit" value="Login" name="submit"></b>
           </td></tr>
     </form>
    
   <tr><td align="center"><hr><a href="index.php?page=SignUp" ><font  size="1px" face="Georgia, Times New Roman, Times, serif" color="#008000">*Not registered yet?  <b><font color="#0000A8" size="1">&nbsp;JOIN US now!&nbsp;</font></font></b></a></p>
        </td></tr> </table>
<?php
	error_reporting(0);
	session_start();
	if (isset($_SESSION['userid'])){
		header('location:index.php');
		if ($_SESSION['type']=='user'){
			header('location:admin/index.php');

		}
		else if ($_SESSION['type']=='member'){
			header('location:index.php');

		}
	}
	
		
	
	include 'admin/includes/config.php';
	//include 'userincludes/userconfig.php';
?>

<?php



if(isset($_POST['submit']))
{
	$username = $_POST['username']; 
	$password = $_POST['password'];
	$usertype = $_POST['usertype'];
	
	
		
	if ($usertype == "user")
	{
		$t="user";
		$sql = "SELECT * FROM table_users WHERE Username='".$username."' AND Password = '".$password."' AND Usertype='".$t."'";
		$res = mysql_query($sql) or trigger_error("There was some error in the sql statement" . mysql_error());
		
		$row  = mysql_fetch_array($res);
		if ($username = $row['Username'] && ($usertype = $row['Usertype'] && $password = $row['Password'] ))
		{
			if(is_array($row)) 
			{
				 $psd=$_SESSION["pswd"]=$row['Password']; //creating session
				 $usid=$_SESSION["userid"] = $row['UserID'];
				 $unam=$_SESSION["username"] = $row['Username'];
				 $uty=$_SESSION["type"] = $row['Usertype']; 
				 
				
													
			}
			
			if (isset($_POST["remember-me"]))
			{
			
				setcookie('uid', $usid, time()+60*60*24*2); 
				setcookie('uname', $unam, time()+60*60*24*2);
				setcookie('psswd', $psd, time()+60*60*24*2);
				setcookie('utype', $uty, time()+60*60*24*2);
			}
			
			else
			{
				
				setcookie('uid', "");
				setcookie('uname', "");
				setcookie('psswd', "");
				setcookie('utype', "");
			}
		
			//directing to admin homepage
			if(isset($_SESSION["userid"]))
			{	
				//include 'includes/logentry.php';
				header("location:admin/index.php");
				
				//for entering log table
				
				date_default_timezone_set('Asia/Kathmandu');
	            $login =date('Y-m-d H:i:s');
				
				$query="Insert into table_log(UserID, LogInTime) values('".$_SESSION["userid"]."' , '".$login."') ";
				
				 $result = mysql_query($query) or trigger_error("There was some error in the sql statement" . mysql_error());
				 $affrows = mysql_affected_rows($conn);
				 
				 $_SESSION["login"]= $login ;
					
				exit;
				
			}
			else{
				echo '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<font color="maroon">Session not set</font>';
			}	
			
		
		}
		echo '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<font color="white" ><center>Please type your login credentials.</center></font>';
	}
	
	
	if($usertype == "member")
	{
		$q="member";
		$sql="SELECT * FROM table_users WHERE Username='".$username."' AND (Password='".$password."' AND Usertype='".$q."')";
		$result=mysql_query($sql) or trigger_error("There was some error in the sql statement" . mysql_error());
		
		$row  = mysql_fetch_array($result);
		if ($username = $row['Username'] && ($usertype = $row['Usertype'] && $password = $row['Password'] )){
			if(is_array($row)) 
			{
				 $psd=$_SESSION["pswd"]=$row['Password'];
				 $usid=$_SESSION["userid"] = $row['UserID'];
				 $unam=$_SESSION["username"] = $row['Username'];
				 $uty=$_SESSION["type"] = $row['Usertype'];
				 $_SESSION["name"]= $row['Name'];		
									
			}
			
			if (isset($_POST["remember-me"])){
			
				setcookie('uid', $usid, time()+60*60*24*2); 
				setcookie('uname', $unam, time()+60*60*24*2);
				setcookie('psswd', $psd, time()+60*60*24*2);
				setcookie('utype', $uty, time()+60*60*24*2);
			}
			else{
				
				setcookie('uid', "");
				setcookie('uname', "");
				setcookie('psswd', "");
				setcookie('utype', "");
			}
		
			//directing to admin homepage
			if(isset($_SESSION["userid"]))
			{	
				//include 'includes/logentry.php';
				header("location:index.php");
				exit;
				
			}
			else{
				echo '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<font color="maroon">Session not set</font>';
			}	
			
		
		}
		echo '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<font color="white" ><center>Please type your login credentials.</center></font>';
	}
}

?>

<?php
if(isset($_GET['action']) && $_GET['action'] == "forget"){
		setcookie('uid', "");
		setcookie('uname', "");
		setcookie('psswd', "");
		setcookie('utype', "");
		header('location:index.php');
	}
?>

<!-- $username = $_POST['username']; 
	$password = $_POST['password'];
	$usertype = $_POST['usertype'];
	$c++;
	if($c==3){
	echo"You have tried for 3 times and failed.";  -->

