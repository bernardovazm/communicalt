<?php 
 require_once "config.php";
 require_once "feed.php";

    $feed = new Feed();
   
    $feed->add();   
	

?>

 $feed->set($_POST['feedback']);