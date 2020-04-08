<?php
session_start();
require_once("connect.php");


if(!isset($_SESSION['loggeidIn'])) 
{
	header("Location: index.php");

}else
{

	header("Location: index2.php");


}




$message = "";

if( empty($_POST['email']) || empty($_POST['password'])){
       
    $message .=("Töltsd ki a mezőket!");
     }

if($_SERVER['REQUEST_METHOD'] == "POST" && !empty($_POST["email"]) && !empty($_POST["password"]) ){
    $email = $_POST['email'];
    $pw = $_POST['password'];
    $sql = "SELECT * FROM dolgozok WHERE email = '$email' AND jelszo = '$pw'; ";
    $res = $conn -> query($sql);
    if(!$res){
        die("Hibás sql lekérdezés");
    }
    echo $email;
    echo $pw;
    if($res -> num_rows == 1){
        
        $row = $res -> fetch_assoc();
        $id=$row["id"];
        $_SESSION["loggeidIn"]=$id;
           echo  $_SESSION["loggeidIn"];
        $message .= "Sikeres Belépés!";
       header("Location: adat.php");
    }else{
        $message .= "Helytelen belépési adatok!";
    }

}
echo $message;




?>   