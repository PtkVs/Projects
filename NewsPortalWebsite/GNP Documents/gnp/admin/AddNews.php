		<form method="post" action="index.php?page=AddNews" enctype="multipart/form-data">
        		<table  align="center"  border="0" width="50%" cellspacing="0" cellpadding="5" >
                
            <!--table: making a boundary for table, tr: creates a row within a table, td: creates a data field within a row -->
        		<tr>
                <td><label>Title:</label></td> 
          	    <td ><input type="text"  name="TitleBox"  autofocus="autofocus" required/></td>
                </tr>
                
                
				<tr>
                <td><label>Category:</label> </td>
                <td><select name="CategoryBox">
                        <option value="0">[choose]</option>
                        <option>Nuker </option>
                        <option>Support</option>
                        <option>Tank</option>
                        <option>Carry</option>
                                     
              		</select></td>
                </tr>
               
                
                <tr>
                <td><label>Image:</label> </td>
                <td><input type="file" name="imagefile"/></td>
                </tr>
                <!--<tr><td></td><td><p> (*Image size must be less than 1MB)</p></td></tr>-->
                       
				
                
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
	include'includes/config.php';
	error_reporting(0);	
?>

<?php
//posting data into variables below (defining variables)
	$title = $_POST['TitleBox'];
	$category = $_POST['CategoryBox'];
	$createdby = 'admin';
	//for date
	date_default_timezone_set('Asia/Kathmandu');
	$createddate =date('Y-m-d H:i:s');
	
	$modifiedby='null';
	$modifieddate='null';
	
	$description = $_POST ['DescriptionBox'];
	
//checking validation/requests/inserting into database.
	if(isset($_POST['submit']))
	{
		//taking image file and storing 
		$image= addslashes(file_get_contents($_FILES['imagefile']['tmp_name']));
		$name= $_FILES['imagefile']['name'];
		$tmp_name=$_FILES['imagefile']['tmp_name']; 
		
		$size=filesize($tmp_name);	
		
		if (strlen($description)<999999999)//limiting text size for description.
		{
			
				if( $size < 100000000) //almost 1MB(image size limitation)
				{
					if(isset ($name) AND $category!="0")
					{
						if (!empty($name))
						{
							$location="includes/img/";
							if(move_uploaded_file($tmp_name, $location.$name))
							{
								$query="INSERT INTO table_news(Title, Category, Description, CreatedBy,CreatedDate, ModifiedBy, ModifiedDate, ImageName) VALUES('".$title."','".$category."','".$description."', '".$createdby."', '".$createddate."','".$modifiedby."','".$modifieddate."','".$name."')";	
								
								$result = mysql_query($query) or trigger_error("There was some error in the sql statement" . mysql_error());
								$affrows = mysql_affected_rows($conn);
								if($affrows > 0)
								{
									//header('location:index.php');
									echo '<center><font color="Grey"><b>Report entry successful. Thank you.</b></font></center>';								
								}
								else {echo 'Report is NOT added to database';}
							}
							else {echo "Error in moving file to database. Please re-try ";}
						}
						else {echo "You must upload an image.";}
					}
					else 
					{
						echo '<center><font color="maroon"><b>Please re-define your category.. </b></font></center>';
					}
				
				}
				else {echo '<center><font color="maroon"><b>Error in uploading image.. Make sure your image is less than 1MB. </b></font></center>';}
			
		}
		
		else {
			echo '<center><font color="maroon"><b>Please make your description no more than 1000 characters.</b></font></center>';}		
			//echo "Current word count:&nbsp;".str_word_count($description);
			//echo "Current character length:&nbsp;".strlen($description);
		
	}
	
?>



