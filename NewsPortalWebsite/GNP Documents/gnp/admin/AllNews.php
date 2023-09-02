<table width = "100%" align="justify"><tr>
<tr align="center">
<td><font size="6.2px" >Search Bar</font></td>
<td width="50%"> 
	<form action="DisplayNews.php">
	<label><b>Category:</b></label> 
   
    <select name="category" >
       <option>Choose</option>
        <option>Tank</option>
        <option>Support</option>
        <option>Carry</option>
        <option>Nuker</option>
   	</select>
</td>
        <td align="left"><input  type="text" name="search" placeholder="Field Data"/>
            <input  type="submit" value = "Find"/>&nbsp;&nbsp;&nbsp;</td>
        <td align="right">
            |<a href="DisplayNews.php">Refresh</a>|</td>

	</form>
</tr></table>
			

<?php

include 'includes/config.php'; 
//search 
if(isset($_GET["search"])) {
	
	$s = $_GET["search"];
	$category= $_GET["category"];
		
	$qry = "SELECT * FROM table_news ";
	
	$qry.= " WHERE (Title like '%".$s."%' ) AND (Category like '".$category."') ";  //to show all AND->OR.
}
  
else { 
	$qry = "SELECT * FROM table_news ORDER BY NewsID DESC";
	//$query = "SELECT * FROM table_news ";
	}

$sql = mysql_query($qry);
$affrows = mysql_affected_rows($conn);

$bgcolor='#FFFFFC';

echo '<table>';
echo '<tr>'; 
$j = 1;

		
	if($affrows > 0){
			
		  for($i = 1; $rows= mysql_fetch_assoc($sql); $i++) 
		  {
			  
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
						'?> <textarea  maxlength="50"  rows="6" cols="100" disabled><?php echo $des;?></textarea>
					  	<?php echo '<table border="0"  bgcolor="#33CCCC"><tr><td> 
						<a href="'?><?php echo 'ViewNews.php?&id='.$id;
					  				echo'"><b>Read More</b> </a><br />
						
                      				
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
					  
			echo '</tr>';
			echo '<hr /></table>';
		}else{
			echo"You have no files to display.";
		}
		

		
?>

