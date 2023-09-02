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
    
     <?php
	 
    
    
    if(!isset($_GET['page']))
    {    
         
		 include 'BasicMainPageNews.php';
    }
    else
    {
        if(isset($_GET['page']))
        {
            
            $page = $_GET["page"];
            $filename = include("".$page.'.php');
    
            if($filename == "")
            {
                header("location:index.php"); 
            }
            
            if(file_exists($filename)){
                include $filename;
            }
        
        
        }
    }
    
    ?>
   	
    </div>
    
   
   <?php include'includes/footer.php'; ?>

</div>
</body>
</html>