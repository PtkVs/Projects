<?php
define('HOST', 'localhost');
define('USER', 'root');
define('PWD', '');
define('DB', 'gnp');

//connect to the server
$conn = mysql_connect(HOST, USER, PWD) or trigger_error("Connection error" . mysql_error()); 

//load the database
@mysql_select_db(DB) or trigger_error("Database not found" . mysql_error());

/*
for checking conncection remove comment and try.
if($conn)
{
 echo"Great work";
 }
 else
 {
 echo "connection error";
 }
 die();
*/
?>
