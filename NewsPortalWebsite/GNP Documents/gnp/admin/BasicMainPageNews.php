

<?php
  //error_reporting(0);
  include 'includes/config.php';
  //$type=$_SESSION['type'];
  echo '<table>';
  echo '<tr>'; 
  $j = 1;
  
$query = "SELECT * FROM table_news ORDER BY NewsID DESC";

$sql = mysql_query($query);
$affrows = mysql_affected_rows($conn);
		if($affrows > 0){
			//echo'Latest entries';
		  for($i = 1; $rows= mysql_fetch_assoc($sql); $i++) {
			  if($i<4){
			  $id = $rows["NewsID"];
			  $title  = $rows["Title"];
			  $img = $rows["ImageName"];
			 		
			  $cat = $rows["Category"];
			  $cd = $rows["CreatedDate"];
			  $des = $rows["Description"];
			  
			  echo '<td width="100px"> 
			  		<td><img src="includes/img/'.$img.'" height="120px" width="200px"></td>';
			  
			  echo '<td width="100px">
			  		<td  width="300px" height="120px">
					  <b>NewsID: </b>'?><?php echo $id; ?><?php echo '<br />
					  <b>Title: </b>'?><?php echo $title; ?><?php echo '<br />
					  <b>Category: </b>'?><?php echo $cat; ?><?php echo '<br />
					  <b>Added In: </b>'?><?php echo $cd; ?><?php echo '<br />
					  
					<td width="300px" align="right">
						'?> <style>
	textarea {overflow:hidden} </style><textarea  maxlength="50"  rows="6" cols="100" disabled><?php echo $des;?></textarea>
					  	<?php echo '<table border="0"  bgcolor="#33CCCC"><tr><td> 
									
									<a href="'?>
					  					<?php echo 'ViewNews.php?&id='.$id; 
                                        echo'"><b>Read More</b></a><br />
                                        
                                    
					 </td>
					 </td></tr>
					 </table>
					 </td>
					 <td width="20">
					 </td>';
		  
			  if ($i == $j){
				  echo'</tr>';
				  echo'<tr>';
				  $j = $j +1;
			  }
			  }
			  else {}
		  }
		  
			echo '</tr>';
			echo '</table>';
		}else{
			echo"You have no files to display.";
		}
?>
<table align="center" width="50%"> 
	
    <tr><hr></tr>
    <tr align="center"> <td> <a href="index.php?page=Login">Join Us! </a>For more news and  full access.</td></tr></table>
</div>
