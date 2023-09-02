<?php
	error_reporting(0);
	session_start();
	$message="";
if(!isset($_SESSION['userid'])){
     header("location:index.php");
}
if(isset($_SESSION['userid'])){
     $ustype=$_SESSION["type"];
	 if ($ustype=="Member"){
		 header("location:index.php");
	 }
}
?>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Display All News</title>
<link rel="stylesheet"  type="text/css" href="userincludes/UserStyle.css" />
</head>

<body>
<div class="container">
<?php include'userincludes/memberheader.php';?>

	<div class="content">
    <?php
  error_reporting(0);
  include 'userincludes/userconfig.php'; 
  ?>
    	
        <?php
		
		$query1= "SELECT * FROM table_users where UserID='".$_SESSION["userid"]."'   ";
	$result1 = mysql_query($query1) or trigger_error("There was some error in the sql statement" . mysql_error());
	$row = mysql_fetch_array($result1);
		
		
		?>
        
        <form method="post" action="SelfDetails.php" enctype="multipart/form-data">
                  <input type="hidden" name="id" value="<?php echo $id; ?>" />
                  <table width='50%' align="center">
                  
                    <tr>
                   <td><label>User ID:</label></td> 
                    <td ><input type="text"  name="NameBox"  value="<?php echo $_SESSION["userid"]; ?>"  disabled="disabled"/></td>
                    </tr>
                    
                   <tr>
                   <td><label>Name:</label></td> 
                    <td ><input type="text"  name="NameBox"  value="<?php echo $_SESSION["name"] ; ?>"  disabled="disabled"/></td>
                    </tr>
                    
                    <tr>
                    <td><label>Usertype:</label></td>
                    <td><input type="text"  name="UsertypeBox" value="<?php echo $_SESSION["type"]; ?>" disabled="disabled"/></td>
                    </tr>
                    
                    <tr>
                    <td><label>Username:</label></td>
                    <td><input type="text" name="UsernameBox" value="<?php echo $_SESSION["username"]; ?>" disabled="disabled"/></td>
                    </tr>
                    
                    <tr>
                    <td><label>Old Password:</label></td>
                    <td><input type="text" name="PasswordBox" value="<?php echo $_SESSION["pswd"]; ?>" disabled="disabled"/></td>
                    </tr>
                    
                     <tr>
                    <td><label>New Password:</label></td>
                    <td><input type="text" name="NewPasswordBox" autofocus="autofocus" required="required"  /></td>
                    </tr>
                    
                    
                       
                   <tr>
                    <td colspan="2"><input type="submit"  name="UpdateBtn"  value="Update" /></td>
                   </tr>
                   
                   </table>
                   </form>
                   
                      <?php
				   if(isset($_POST['UpdateBtn']) && $_POST['UpdateBtn'] == "Update")
				   {
					  
					   $newpassword = $_POST['NewPasswordBox'];
					   
					  // if($password == $newpassword)
				//	   {
					//	   echo'<center><font color="white"><b>New Password cannot be same as New Password. </b></font></center>';
					//   }
					   
					   //else
					//   {
			    $query="UPDATE table_users SET Password='".$newpassword."' WHERE UserID='" .$_SESSION["userid"]."' ";
				
			    $result = mysql_query($query) or trigger_error("There was some error in the sql statement" . mysql_error());
				
                $affrows = mysql_affected_rows($conn);
				
				  if($affrows > 0)
			                {
                                 echo'<center><font color="white"><b>Password updated successfully. </b></font></center>';
				
				
			                }
                
            else
			                 { echo'<center><font color="white"><b>Password update Failed. Please re-try</b></font></center>';	
			                 }
			
						   
					  // }
				   }
				   
				   ?>
        
        
        
        
        
        
        
        
        
        
        
        
      
</div>

</div>
<?php include'userincludes/userfooter.php'; ?>
</body>
</html>