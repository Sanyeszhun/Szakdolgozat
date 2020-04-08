
<?php
 
require_once("connect.php");
 
 if(!isset($_POST['username'],$_POST['email'],$_POST['password'])){
     exit("Töltsd ki a mezőket!");

 }
 
 if(empty($_POST['username']) || empty($_POST['email']) || empty($_POST['password']))
       {
          exit("Töltsd ki a mezőket!");
        

      }

 
if($stmt=$conn->prepare("SELECT id,jelszo FROM dolgozok WHERE email=?")){
    $stmt->bind_param('s',$_POST['email']);
    $stmt->execute();
    $stmt->store_result();
 
    if($stmt->num_rows>0){
        echo "Felhasználó már létezik!";
    }
    else{
        if($stmt=$conn->prepare("INSERT INTO dolgozok(nev,telefonszam,email,jelszo) VALUES (?,?,?,?)")){
            $password=$_POST['password'];  
            $phone=$_POST['phone'];          
            $stmt->bind_param('ssss',$_POST['username'],$phone,$_POST['email'],$_POST['password']);
            $stmt->execute();
            echo "Sikeresen regisztráció!";
            header("Location:index.php");
        }
        else{
            echo "Hiba történt!";
        }
        $stmt->close();
        $conn->close();
    }
}else{
    echo "Hiba történt!";
}
 
 
 
?>



