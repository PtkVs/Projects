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


<?php
	error_reporting(0);
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
    <?php include 'includes/config.php'?>


<form method="post" action="AddAboutUs.php" enctype="multipart/form-data">
        		<table  align="center"  border="0" width="50%" cellspacing="0" cellpadding="5" >
                
            <!--table: making a boundary for table, tr: creates a row within a table, td: creates a data field within a row -->
        		
                
             
				<tr>
                <td><label>Description:</label></td>
                <td><textarea type="text" name="DescriptionBox" cols="100" rows="15" required="required"></textarea></td>
                </tr>
               
                <tr align="left">
                <td colspan="2"><input type="submit"  name="submit"  value="Add this" /></td>
                </tr>
                
			</table>                            
		</form>
        
          <?php
		//Definigh Variables 
		if(isset ($_POST['submit']))
		{
			
		$description= $_POST['DescriptionBox'];
		
	
	   //SQL Query
	   
	   $query="insert into table_aboutus (AboutUs) values('".$description."') ";
	   
	   
	   
	   
	   $result = mysql_query($query) or trigger_error("There was some error in the sql statement" . mysql_error());
	   
	   
	    	$affrows = mysql_affected_rows($conn);
								if($affrows > 0)
								{
									//header('location:index.php');
									echo '<center><font color="Grey"><b>Description entry successful. Thank you.</b></font></center>';								
								}
								else {echo 'Report is NOT added to database';}
		}
		?>
		
        
        </div>
        </div>
        
         <?php include'includes/footer.php' ?>
		 
         </body>
         </html>
         