 <form method="post" action="index.php?page=SignUp" enctype="multipart/form-data">
           
           <!--Design Part-->
            <table align="center" border="0" width="50%" cellspacing="0" cellpadding="5" >
            
            <tr>
            <td><label>Name:</label></td>
            <td><input type="text" name="NameBox" autofocus="autofocus" required/></td>
            </tr>
            
            <tr>
            <td><label>Address:</label></td>
            <td><input type="text" name="AddressBox" required/></td>
            </tr>
            
            <tr>
            <td><label>Username:</label></td>
            <td><input type="text" name="UsernameBox" required/></td>
            </tr>
            
            <tr>
            <td><label>Password:</label></td>
            <td><input type="password" name="PasswordBox" required/></td>
            </tr>
            
            <tr>
            <td><label>E-mail:</label></td>
            <td><input type="text" name="EmailBox" required/></td>
            </tr>
            
            <tr align="center">
            <td colspan="2"><input type="submit"  name="submit"  value="Add this" /></td>
            </tr>
            
            </table>
            </form>
            
       <!--Connection/Defining variables/SQL Part -->
       
       <?php
	    include 'userincludes/userconfig.php';
	    error_reporting(0);
		?>
        
        <?php
		//Definigh Variables 
		if(isset ($_POST['submit']))
		{
			
		$name= $_POST['NameBox'];
		$address= $_POST['AddressBox'];
		$username= $_POST['UsernameBox'];
		$password= $_POST['PasswordBox'];
		$email= $_POST['EmailBox'];
		$utype='member';
		
		$query=" select * from table_users where Username='".$username."' ";
		$result = mysql_query($query) or trigger_error("There was some error in the sql statement" . mysql_error());
		$row  = mysql_fetch_array($result);
		
		
		$affrows = mysql_affected_rows($conn);
		                  if($affrows > 0)
								{
									
									echo '<center><font color="Grey"><b>User Already Exists </b></font></center>';								
								}
						else
						{
									   
	          $query1="insert into table_users(Name, Address, Username, Password, Email,Usertype) values('".$name."', '".$address."', '".$username."'	, '".$password."', '".$email."', '".$utype."') ";
	   
	   
	   
	   
	   $result1 = mysql_query($query1) or trigger_error("There was some error in the sql statement" . mysql_error());
	   
	   
	    	$affrows = mysql_affected_rows($conn);
								if($affrows > 0)
								{
									//header('location:index.php');
									echo '<center><font color="Grey"><b>User entry successful. Thank you.</b></font></center>';								
								}
								else
								 {
									 echo 'Report is NOT added to database';
							     }
		                }
		} 
		
		
		?>
        
        
        
        
        
        
        
        
        
        
        
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
        <!--   malai chaiyeko yehi ho
		$affrows = mysql_affected_rows($conn);
		                  if($affrows > 0) -->
								
		
		
		