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
<title>News Description</title>
<link rel="stylesheet"  type="text/css" href="includes/AdminStyle.css" />
</head>

<body>
<div class="container">

<?php include'includes/header.php';?>
	
<div class="content">
    <?php
		error_reporting(0);
		include 'includes/config.php';
			//retriving data
			if(isset($_GET['id'])){
				$id = $_GET['id'];
			}
			
			
			$sql="SELECT * FROM table_news WHERE NewsID =".$id;
			$result1=mysql_query($sql) or trigger_error("There was some error in the sql statement" . mysql_error());
			
			$row  = mysql_fetch_array($result1);
			if(is_array($row)) {
			
				$newsid = $row["NewsID"];
				$title  = $row["Title"];
				$img = $row["ImageName"];
					
				$cat = $row["Category"];
				$cd = $row["CreatedDate"];
				$des = $row["Description"];
				$uname = $row["CreatedBy"];
				$modify = $row["ModifiedDate"];
			}
	?>
            
			<table width="100%">
			<tr>
			<td align="left" width="400px"><?php echo '<img src="includes/img/'.$img.'" height="280px" width="350px">';?></td>
			<td   align ="left" height="280px" width="550px"><font color="#424242">	
			<b>News ID: </b> <?php echo '<font color="#AE4F09">'.$id.'</font>'; ?><br />
			<b>Title Name: </b> <?php echo '<font color="#AE4F09"><b>'.$title.'</b></font>'; ?><br />
			<b>Image Name:</b><?php echo '<font color="#AE4F09">'.$img.'</font>'; ?><br />
			<b>Category:</b><?php echo '<font color="#AE4F09"><b>'.$cat.'</b></font>'; ?><br /><hr />
			
			<b>Added In:</b><?php echo '<font color="#AE4F09">'.$cd.'</font>'; ?><br />
			<b>Added By:</b><?php echo '<font color="#AE4F09">'.$uname.'</font>'; ?><br />
			<b>Updated In:</b><?php echo '<font color="#AE4F09">'.$modify.'</font>'; ?><br /><hr />
			

			</td></tr>
                
            </table>
            <hr  color="#FFFFFF"/>
            <table width="75%" align="center"> <tr align=""><td width ="" height="200" align="center">
                    <b>Description<br /></b><?php echo '<font color="#AE4F09">'.$des.'</font>'; ?><br /></font>
            </td></tr></table>
    	
       
      
</div>

</div>
<?php include'includes/footer.php'; ?>

</body>
</html>