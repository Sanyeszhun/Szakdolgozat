<?php
session_start();
$hostname = "localhost";
$username = "root";
$password = "";
$databaseName = "kamion";
$connect = mysqli_connect($hostname, $username, $password, $databaseName);
$query="SELECT nev,Kikuldes,Felvetelezohely,TermekNev,Lerakohely,Viszaerkezes,Tavolsag,Ido FROM `kuldes` INNER JOIN hely ON kuldes.heid=hely.hid INNER JOIN dolgozok ON kuldes.did=dolgozok.id INNER JOIN termekek ON kuldes.teid=termekek.teid";
$query2="SELECT * FROM `dolgozok` WHERE 1";
$result=mysqli_query($connect,$query);
$result2=mysqli_query($connect,$query2);

?>

<!DOCTYPE html>
<html>
<head>

<title>Truck a Transport Category Flat Bootstarp responsive Website Template| Regisztráció :: w3layouts</title>

<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js"></script>  
           <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />  
           <script src="https://cdn.datatables.net/1.10.12/js/jquery.dataTables.min.js"></script>  
           <script src="https://cdn.datatables.net/1.10.12/js/dataTables.bootstrap.min.js"></script>            
           <link rel="stylesheet" href="https://cdn.datatables.net/1.10.12/css/dataTables.bootstrap.min.css" />  
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Truck Responsive web template, Bootstrap Web Templates, Flat Web Templates, Andriod Compatible web template,Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyErricsson, Motorola web design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>

<!-- bootstarp-css -->
<link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
<!--// bootstarp-css -->
<!-- css -->
<link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
<!--// css -->
<script src="js/jquery-1.11.1.min.js"></script>
<!--fonts-->
<link href='http://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,800,700,600' rel='stylesheet' type='text/css'>
<!--/fonts-->
<link href="css/animate.css" rel="stylesheet" type="text/css" media="all">
<script src="js/wow.min.js"></script>
<script>
	 new WOW().init();
</script>
<!--start-smoth-scrolling-->
		<script type="text/javascript" src="js/move-top.js"></script>
		<script type="text/javascript" src="js/easing.js"></script>
		<script type="text/javascript">
			jQuery(document).ready(function($) {
				$(".scroll").click(function(event){		
					event.preventDefault();
					$('html,body').animate({scrollTop:$(this.hash).offset().top},900);
				});
			});
		</script>
<!--start-smoth-scrolling-->

</head>
<body>
	<!-- banner -->
	<div id="Kezdőlap" class="banner a-banner">
		<!-- container -->
		<div class="container">
			
				<div class="head-logo">
					<a href="index.php
					"><img src="images/logo.svg" id="logokep" alt="" /></a>
				</div>
				<div class="top-nav">
					<span class="menu"><img src="images/menu.png" alt=""></span>
					<ul class="nav1">
						<li class="hvr-sweep-to-bottom"><a href="index2.php">Kezdőlap<i><img src="images/nav-but1.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom"><a href="about.php">Rólunk<i><img src="images/nav-but2.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom"><a href="services.php">Szolgáltatások<i><img src="images/nav-but3.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom active"><a href="adat.php">Adatok<i><img src="images/nav-but4.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom"><a href="mail.php">Kijelentkezés<i><img src="images/nav-but5.png" alt=""/></i></a></li>
						
						<div class="clearfix"> </div>
					</ul>
					<!-- script-for-menu -->
							 <script>
							   $( "span.menu" ).click(function() {
								 $( "ul.nav1" ).slideToggle( 300, function() {
								 // Animation complete.
								  });
								 });
							</script>
						<!-- /script-for-menu -->
				</div>
				<div class="clearfix"> </div>
			</div>
		</div>
		<!-- //container -->
	</div>
	<!-- //banner -->



	
	<!--Adatlekérdezés -->
	<!-- <div class="input-group mb-3">
  <div class="input-group-prepend">
  <form method="POST">
    <input class="btn btn-outline-secondary" type="submit" value="OK">
	
  </div>
  <select name ="adatok" class="custom-select" id="inputGroupSelect03">
    <option selected>Choose...</option>
    <option value="Dolgozok">Dolgozok</option>
    <option value="2">Two</option>
    <option value="3">Three</option>
  </select>
  </form>
</div>	  -->






<br /><br />  

           <div class="container">  
		   <h3 align="center">Dolgozók eddigi útvonalai</h3>  
                <br />  
                <div class="table-responsive">  
                     <table id="dolgozok" class="table table-striped table-bordered">  
                          <thead>  
                               <tr>  
                                    <td>Dolgozó Neve</td>  
                                    <td>Indulás ideje</td>  
                                    <td>Termék felvételének helye</td>  
                                    <td>Termeknév</td>
									<td>Le adás helye</td>
									<td>Vissza érkezés</td>
									<td>Megtett távolság Km-ben</td>
									<td>Idő</td>
                                  
                               </tr>  
                          </thead>  
                          <?php  
                          while($row = mysqli_fetch_array($result))  
                          {  
                               echo '  
                               <tr>  
									<td>'.$row["nev"].'</td>									 
									<td>'.$row["Kikuldes"].'</td>  
									<td>'.$row["Felvetelezohely"].'</td>
									<td>'.$row["TermekNev"].'</td>
                                    <td>'.$row["Lerakohely"].'</td>  
									<td>'.$row["Viszaerkezes"].'</td>
									<td>'.$row["Tavolsag"].'</td>
									<td>'.$row["Ido"].'</td>
                                     
                               </tr>  
                               ';  
                          }  
                          ?>  
                     </table>  
                </div>  

				<h3 align="center">Dolgozók elérhetősége</h3>  
				<div class="table-responsive">  
                     <table id="dolgozok" class="table table-striped table-bordered">  
                          <thead>  
                               <tr>  
                                    <td>id</td>  
                                    <td>Név</td>  
                                    <td>Telefonszam</td>  
                                    <td>Email</td>  
                                  
                               </tr>  
                          </thead>  
                          <?php  
                          while($row = mysqli_fetch_array($result2))  
                          {  
                               echo '  
                               <tr>  
                                    <td>'.$row["id"].'</td>  
                                    <td>'.$row["nev"].'</td>  
                                    <td>'.$row["telefonszam"].'</td>  
                                    <td>'.$row["email"].'</td>  
                                     
                               </tr>  
                               ';  
                          }  
                          ?>  
                     </table>  
                </div>  
           </div>  
 
 
 

	<!-- Adatlekérdezés -->
	<!-- footer -->

	<?php
	
	if(isset($_SESSION['loggeidIn']))
	{

		require_once("footer2.php");

	}
	else
	{

		require_once("footer.php");

	}

	?>
</body>
</html>