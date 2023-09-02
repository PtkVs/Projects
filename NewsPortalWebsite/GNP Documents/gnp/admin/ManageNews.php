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
    <td style="width:115px" align="center"><strong>Title</strong></td>
    <td style="width:115px" align="center"><strong>Category</strong></td>
    <td align="center"><strong>Added By</strong></td>
    <td style="width:115px"align="center"><strong>Added Date</strong></td>
    <td style="width:115px"align="center"><strong>Modified Date</strong></td>
    <td style="width:115px" align="center"><strong>Modified By</strong></td>
    <td colspan="2" style="width:120px" align="center"><strong>Action</strong></td>
    </tr>

<?php 
include 'includes/config.php';

$sql="select * from table_news";
$rel=mysql_query($sql);
$sn=0;
while($row=mysql_fetch_array($rel))
  { 
 // $title=$row ['Title'];
  //$category=$row['Category'];
  //$createdby=$row['CreatedBy'];
  //$createddate=$row['CreatedDate'];
  //$modifieddate=$row['ModifiedDate'];
  //$modifiedby=$row['ModifiedBy'];
   ?> 
  
  <!--Defining variablies and showing in same steps -->
<tr>
  <td><?php echo $sn=$sn+1; ?></td>
  <td style="width:115px"><?php echo $title=$row ['Title']; ?></td>
  <td style="width:115px"><?php echo $category=$row['Category']; ?></td>
  <td style="width:115px"><?php echo $createdby=$row['CreatedBy']; ?></td>
  <td style="width:115px"><?php echo $createddate=$row['CreatedDate']; ?></td>

  <td style="width:115px"><?php echo $modifieddate=$row['ModifiedDate']; ?></td>
  <td style="width:115px"><?php echo $modifiedby=$row['ModifiedBy']; ?></td>

 
  
 
	<td align="center">
  	<a href="<?php echo 'EditNews.php?&id='.$row["NewsID"];?>">Edit</a> ||
    <a href="<?php echo 'ManageNews.php?action=delete&id='.$row["NewsID"];?>" onclick="return confirm('Are you sure?')">X</a>
    
	<?php
// Deleting Item
	if(isset($_GET['action']) && $_GET['action'] == "delete")
	{
        $id = $_GET['id'];

        mysql_query("DELETE FROM table_news WHERE NewsID=".$id);
		
		//linking bak to page(automatic linkin)
        header("Location: ManageNews.php");
	}

  ?>
    
  
 
   </td></tr> 

<?php } ?>

 </table>
</div>
</div>
    
   
   <?php include'includes/footer.php' ?>

</div>
</body>
</html>