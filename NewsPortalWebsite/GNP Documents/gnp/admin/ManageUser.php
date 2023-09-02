<?php
	error_reporting(0);
	session_start();
	$message="";
	if (isset ($_SESSION["type"])){
		 $ustype=$_SESSION["type"];
		 if ($ustype=="member"){
			  header("location:../../../gnp/index.php");
		 }
	}
	if(!isset($_SESSION['userid'])){
     header("location:../../../gnp/index.php");
	}

?>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Admin Games News Portal</title>
<link rel="stylesheet"  type="text/css" href="includes/AdminStyle.css" />
</head>

<body>
<div class="container">
	<?php include'includes/header.php'?>
    <div class="content">
    

<div class="viewing">
    <table border="1" >
    <tr >
    <td align="center"><strong>Sn</strong></td>
    <td style="width:115px" align="center"><strong>Name</strong></td>
    <td style="width:115px" align="center"><strong>Address</strong></td>
    <td align="center"><strong>Username</strong></td>
    <td style="width:115px"align="center"><strong>Password</strong></td>
    <td style="width:115px"align="center"><strong>Email</strong></td>
    <td colspan="2" style="width:120px" align="center"><strong>Action</strong></td>
    </tr>
    
    
    <!--Connection with database-->
    
    <?php
	include 'includes/config.php';
	
	$sql="select * from table_users";
	$rel=mysql_query($sql);
	$sn=0;
	while($row=mysql_fetch_array($rel)) 
	
	{
	?>
    
     <!--Defining variablies and showing in same steps -->
     
    <tr>
    <td><?php echo $sn=$sn+1 ?></td>
    <td style="width:115px"><?php echo $name=$row['Name']; ?> </td>
    <td style="width:115px"><?php echo $address=$row['Address']; ?> </td>
    <td style="width:115px"><?php echo $username=$row['Username']; ?> </td>
    <td style="width:115px"><?php echo $password=$row['Password']; ?> </td>
    <td style="width:115px"><?php echo $email=$row['Email']; ?> </td>
    
    <td align="center">
  	<a href="<?php echo 'EditUser.php?&id='.$row["UserID"];?>">Edit</a> ||
    <a href="<?php echo 'ManageUser.php?action=delete&id='.$row["UserID"];?>" onclick="return confirm('Are you sure?')">X</a>
    
    <?php
	//deleting
	if(isset($_GET['action']) && $_GET['action'] == "delete")
	{
		$id= $_GET['id'];
		
		mysql_query("DELETE FROM table_users WHERE UserID=".$id);
		
		//linking bak to page
		header("Location: ManageUser.php");
	}
	?> 
      
    </td>
    </tr>
    
    
    
    
    <?php } ?>
    </table>
    </div>
    </div>
    <?php include'includes/footer.php' ?>
	</div>
    </body>
    </html>
    
    
    
    
		
	