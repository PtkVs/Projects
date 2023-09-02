<?php
	//error_reporting(0);
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
<title>Admin Games News Portal</title>
<link rel="stylesheet"  type="text/css" href="userincludes/UserStyle.css" />
</head>

 <body>
 <div class="container">
 
	<?php include'userincludes/memberheader.php'?>
    
    <div class="content">
    
     <div class="viewing">
     
      <table border="0"  align="center"  border="0" width="50%" cellspacing="0" cellpadding="5" >
    
      <tr >
    <td style=" width:100%" align="left"><strong></strong></td>
    </tr>
    
         
    <?php 
        include 'userincludes/userconfig.php';

          $sql="select * from table_aboutus";
          $rel=mysql_query($sql);
          $row=mysql_fetch_array($rel)

    ?>
	
     <tr>
    <td style="width:100%" align="left"><?php echo $aboutus=$row ['AboutUs']; ?></td>
    </tr>
    
    </table>
    </div>
    </div>
    
     <?php include'userincludes/userfooter.php' ?>
     
    </div>
    </body>
    </html>