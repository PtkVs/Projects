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

	
	
    
	<?php
    
    
   
    //retriving data
    if(isset($_GET['id']))
	{
     $id = $_GET['id'];
	}
       
    $query1="SELECT * FROM table_news where NewsID =".$id;
    $result1=mysql_query($query1) or trigger_error("There was some error in the sql statement" . mysql_error());
    $row  = mysql_fetch_array($result1);
    
	//Defining variablies and showing in different steps(mthod2)
    if(is_array($row)) 
	{
        
         $title = $row ['Title'];
		 $category = $row ['Category'];
         $description  = $row['Description'];
         $imagefile  = $row['ImageName'];
         $createdby  = $row['CreatedBy'];	
                        
    }
    
    
    
    ?>
    
    <form method="post" action="EditNews.php" enctype="multipart/form-data">
                  <input type="hidden" name="id" value="<?php echo $id; ?>" />
                  <table width='50%' align="center">
                  
                   <tr>
                   <td><label>Title:</label></td> 
                    <td ><input type="text"  name="Title"  value="<?php echo $title; ?>"  disabled="disabled"/></td>
                    </tr>
                    
                    
                    <tr>
                    <td><label>Category:</label> </td>
                    <td><input type="text"  name="Category"  value="<?php echo $category; ?>"  disabled="disabled"/></td>
                        </tr>
                   
                    
                    <tr>
                    <td><label>Image:</label> </td>
                    <td><?php echo $imagefile; ?></td>
                    </tr>
                    <!--<tr><td></td><td><p> (*Image size must be less than 1MB)</p></td></tr>-->
                           
                    
                    
                    <tr>
                    <td><label>Description:</label></td>
                    <td><textarea type="text" name="Description" cols="35" rows="5"   autofocus required="required"><?php echo $description;?></textarea></td></tr>
                   
                   <tr>
                    <td colspan="2"><input type="submit"  name="UpdateBtn"  value="Update" /></td>
                   </tr>
                    
                </table>                     
    </form>
    
     <?php
    //updating data
    if(isset($_POST['UpdateBtn'])&& $_POST['UpdateBtn'] == "Update")
	{
        $id = $_POST['id'];
        
        date_default_timezone_set('Asia/Kathmandu');
        $md = date ('Y-m-d H:i:s');
        $mby = 'Admin'; 
        $des = $_POST['Description'];
        
  $query = "UPDATE table_news SET  ModifiedDate='".$md."', ModifiedBy='".$mby."', Description='".$des."' WHERE NewsID='".$id."' ";
        
            $result = mysql_query($query) or trigger_error("There was some error in the sql statement" . mysql_error());
			
            $affrows = mysql_affected_rows($conn);
            
            if($affrows > 0)
			{
                echo'<center><font color="Grey"><b>News updated successfully. </b></font></center>';
				
				
			}
                
            else{ echo'<center><font color="Grey"><b>News update Failed. Please re-try</b></font></center>';	}
			
			
    }
	
    ?>
 
    
    
</div>
</div>
    
   
   <?php include'includes/footer.php' ?>

</div>
</body>
</html>