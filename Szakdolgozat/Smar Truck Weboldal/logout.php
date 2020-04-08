<?php 
session_start();

unset($_SESSION['loggeidIn']);

header("Location: index.php");

?>