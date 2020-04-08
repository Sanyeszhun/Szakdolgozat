<!--A Design by W3layouts
Author: W3layout
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<?php
session_start();

?>

<!DOCTYPE html>
<html>
<head>
<head>
<title>Truck a Transport Category Flat Bootstarp responsive Website Template| Services :: w3layouts</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/php
; charset=utf-8" />
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
<!-- pop-up -->
<link rel="stylesheet" href="css/touchTouch.css" type="text/css" media="all" />
<script type="text/javascript" src="js/jquery.fancybox.js"></script>
	   <script type="text/javascript">
			$(document).ready(function() {
				/*
				 *  Simple image gallery. Uses default settings
				 */

				$('.fancybox').fancybox();

			});
		</script>
<!-- pop-up -->
<!--start-smoth-scrolling-->
		<script type="text/javascript" src="js/move-top.js"></script>
		<script type="text/javascript" src="js/easing.js"></script>
		<script type="text/javascript">
			jQuery(document).ready(function($) {
				$(".scroll").click(function(event){		
					event.preventDefault();
					$('php'
					,body').animate({scrollTop:$(this.hash).offset().top},900);
				});
			});
		</script>
<!--start-smoth-scrolling-->

</head>
<body>
	
<?php

	if(!isset($_SESSION['loggeidIn'])) 
{ 
	$html='<!-- banner -->
	<div id="home" class="banner a-banner">
		<!-- container -->
		<div class="container">
			<div class="header">
				
				<div class="head-logo">
					<a href="index.php
					"><img src="images/logo.svg" id="logokep" alt="" /></a>
				</div>
				<div class="top-nav">
					<span class="menu"><img src="images/menu.png" alt=""></span>
					<ul class="nav1">
						
						<li class="hvr-sweep-to-bottom"><a href="index.php">Kezdőlap<i><img src="images/nav-but1.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom"><a href="about.php">Rólunk<i><img src="images/nav-but2.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom active"><a href="services.php">Szolgáltatások<i><img src="images/nav-but3.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom"><a href="reg.php">Regisztráció<i><img src="images/nav-but4.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom"><a href="mail.php">Bejelentkezés<i><img src="images/nav-but5.png" alt=""/></i></a></li>
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
	</div>';
	echo $html;
			}
		else					{
									$html2="";
									$html2.='<!-- banner -->
	<div id="home" class="banner a-banner">
		<!-- container -->
		<div class="container">
			<div class="header">
				
				<div class="head-logo">
					<a href="index.php
					"><img src="images/logo.svg" id="logokep" alt="" /></a>
				</div>
				<div class="top-nav">
					<span class="menu"><img src="images/menu.png" alt=""></span>
					<ul class="nav1">
						
						<li class="hvr-sweep-to-bottom"><a href="index2.php">Kezdőlap<i><img src="images/nav-but1.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom"><a href="about.php">Rólunk<i><img src="images/nav-but2.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom active"><a href="services.php">Szolgáltatások<i><img src="images/nav-but3.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom"><a href="adat.php">Adatok<i><img src="images/nav-but4.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom"><a href="logout.php">Kijelentkezés<i><img src="images/nav-but5.png" alt=""/></i></a></li>
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
	</div>';
echo $html2;
								}

	?>
	<!-- //banner -->
	<!-- products-top -->
	<div class="products-top">
		<!-- container -->
		<div class="container">
			<h3 class="wow fadeInRight animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">Főbb szolgáltatások </h3>
			<h5 class="wow fadeInRight animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">Ha szállításról van, szó jöhet bármi mi mindent elvisszük bárhová a világon.<span>Smart Truck Kft </span></h5>
			<div class="products-top-grids wow fadeInLeft animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
				<div class="col-md-4 products-grid">
					<div class="products-number">
						<p>1.</p>
					</div>
					<div class="products-text">
						<h4>Száraz áru szállítás</h4>
						<p>Száraz áru szállítás a viág minden pontjára</p>
					</div>
					<div class="clearfix"> </div>
				</div>
				<div class="col-md-4 products-grid">
					<div class="products-number">
						<p>2.</p>
					</div>
					<div class="products-text">
						<h4>Mirelitt áru szállítás</h4>
						<p>Miden Termék amely fagyasztást igényel</p>
					</div>
					<div class="clearfix"> </div>
				</div>
				<div class="col-md-4 products-grid">
					<div class="products-number">
						<p>3.</p>
					</div>
					<div class="products-text">
						<h4>Élő állat szállítás</h4>
						<p>Élő állat szállítása </p>
					</div>
					<div class="clearfix"> </div>
				</div>
				<div class="clearfix"> </div>
			</div>
			<div class="products-top-grids wow fadeInRight animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
				<div class="col-md-4 products-grid">
					<div class="products-number">
						<p>4.</p>
					</div>
					<div class="products-text">
						<h4>Sport termékek szállítása</h4>
						<p>Minden olyan termék, ami sporthoz kapcsolatos</p>
					</div>
					<div class="clearfix"> </div>
				</div>
				<div class="col-md-4 products-grid">
					<div class="products-number">
						<p>5.</p>
					</div>
					<div class="products-text">
						<h4>Folyadék szállítás</h4>
						<p>Minden olyan foyladék, ami folyékony halmazállapotú</p>
					</div>
					<div class="clearfix"> </div>
				</div>
				<div class="col-md-4 products-grid">
					<div class="products-number">
						<p>6.</p>
					</div>
					<div class="products-text">
						<h4>Jármű szállítás</h4>
						<p>Gépkocsik szállítása</p>
					</div>
					<div class="clearfix"> </div>
				</div>
				<div class="clearfix"> </div>
			</div>
		</div>
		<!-- container -->
 	</div>
	<!-- //products-top -->
	<!-- products-bottom -->
	<div class="products-bottom">
		<!-- container -->
		<div class="container">
			<h3 class="wow fadeInRight animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">Pár kép a gépjrámű parkról</h3>
			<div class="products-bottom-grids">
				<div class="gallery-grids">
					<div class="gallery-grid wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
						 <a class="fancybox" href="images/mirelit.jpg" data-fancybox-group="gallery"><img src="images/mirelit.jpg" class="img-style row6" alt=""><span> </span></a>					
					</div>
					<div class="gallery-grid1 wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
						<a class="fancybox" href="images/sargakamion.jpg" data-fancybox-group="gallery"><img src="images/sargakamion.jpg" class="img-style row6" alt=""><span> </span></a>
					</div>
					<div class="gallery-grid wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
						<a class="fancybox" href="images/animals.jpg" data-fancybox-group="gallery"><img src="images/animals.jpg" class="img-style row6" alt=""><span> </span></a>
					</div>
					<div class="gallery-grid1 wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
						<a class="fancybox" href="images/kamion2.jpg" data-fancybox-group="gallery"><img src="images/kamion2.jpg" class="img-style row6" alt=""><span> </span></a>
					</div>
					<div class="gallery-grid wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
						<a class="fancybox" href="images/scania.jpg" data-fancybox-group="gallery"><img src="images/scania.jpg" class="img-style row6" alt=""><span> </span></a>
					</div>
					<div class="clearfix"> </div>
				</div>
				<div class="gallery-grids">
					<div class="gallery-grid wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
						 <a class="fancybox" href="images/6-.jpg" data-fancybox-group="gallery"><img src="images/6.jpg" class="img-style row6" alt=""><span> </span></a>					
					</div>
					<div class="gallery-grid wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
						<a class="fancybox" href="images/5-.jpg" data-fancybox-group="gallery"><img src="images/5.jpg" class="img-style row6" alt=""><span> </span></a>
					</div>
					<div class="gallery-grid1 wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
						<a class="fancybox" href="images/8-.jpg" data-fancybox-group="gallery"><img src="images/8.jpg" class="img-style row6" alt=""><span> </span></a>
					</div>
					<div class="gallery-grid wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
						<a class="fancybox" href="images/10-.jpg" data-fancybox-group="gallery"><img src="images/10.jpg" class="img-style row6" alt=""><span> </span></a>
					</div>
					<div class="gallery-grid1 wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
						<a class="fancybox" href="images/havaskamion.jpg" data-fancybox-group="gallery"><img src="images/havaskamion.jpg" class="img-style row6" alt=""><span> </span></a>
					</div>
					<div class="clearfix"> </div>
				</div>
			</div>
		</div>
		<!-- //container -->
	</div>
	<!-- products-bottom -->
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
