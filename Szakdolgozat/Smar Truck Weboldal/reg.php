
<!DOCTYPE html>
<html>
<head>
<title>Truck a Transport Category Flat Bootstarp responsive Website Template| Regisztráció :: w3layouts</title>
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
<script  type="text/javascript" scr=js/valid.js></script>
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
						<li class="hvr-sweep-to-bottom"><a href="index.php">Kezdőlap<i><img src="images/nav-but1.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom"><a href="about.php">Rólunk<i><img src="images/nav-but2.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom"><a href="services.php">Szolgáltatások<i><img src="images/nav-but3.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom active"><a href="reg.php">Regisztráció<i><img src="images/nav-but4.png" alt=""/></i></a></li>
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
	</div>
	<!-- //banner -->
	<!--Regisztráció -->

	
<div class="Regisztráció">
<form id="Myform" action="register.php" method="post" id="register-form">
	<div class="container">
		


	<p>Név
           
            
    <input class="form-control" type="text" placeholder="Teljes név Pl: Lakatos Pál" name="username" id="username" pattern="([A-Z]([a-záéúőóüö.]{1,}\s?)){2,}" required>
         </p>
		

		 <p>Telefonszám
        <input class="form-control"  type="tel" placeholder="+36204447641" name="phone" id="phone"   pattern="((?:\+?3|0)6)(?:-|\()?(\d{1,2})(?:-|\))?(\d{3})-?(\d{3,4})" required>
        </p>
		 <p>Email
            
          <input class="form-control" type="email" placeholder="valami@email.com" name="email" id="email" required>
		 
          </p>
		 
		 
         
            <p>Jelszó
			

           <input class="form-control" type="password" placeholder="jelszó (Legfejebb 8 karakter, amelynek kis és nagy betűt kell tartalmaznia és egy speciális karaktert)" name="password" id="password" pattern="(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@#!%*?&])[A-Za-z\d$@$!%*?&]{8,32}" title="" required>
                    </p>
            <br>
								 
            <input class="form-control btn btn-primary" type="submit" value="Regisztráció" name="submit" value="submit">
			<br>
			</div>
			<br>
		</form>
			</div>
		
		
	 
	<!-- //Regisztráció -->
	<!-- footer -->
	<div class="footer">
		<!-- container -->
		<div class="container">
	
			<div class="col-md-6 footer-left  wow fadeInLeft animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
				<ul>
					<li><a href="index.php">Kezdőlap</a></li>
					<li><a href="about.php">Rólunk</a></li>
					<li><a href="services.php">Szolgáltatások</a></li>
					<li><a href="reg.php">Regisztráció</a></li>
					<li><a href="mail.php">Bejelentkezés</a></li>
				</ul>
				
			</div>
			<div class="col-md-3 footer-middle wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
				<h3>CégHelye</h3>
				<div class="address">
					<p>Csongrád megye 6775 Kiszombor
						<span>Kör Utca 124-128</span>
					</p>
				</div>
				<div class="phone">
					<p>+36205887203</p>
				</div>
			</div>
			<div class="col-md-3 footer-right  wow fadeInRight animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
				<a href="#"><img src="images/logo.svg" alt="" /></a>
				<p>A Világ legmegbizhatobb szállító cége Az egész Földön</p>
			</div>
			<div class="clearfix"> </div>	
		</div>
		<!-- //container -->
	</div>
	<!-- //footer -->
	<div class="copyright">
		<!-- container -->
		<div class="container">
			<div class="copyright-left wow fadeInLeft animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
				<p>© 2015 Truck. Design by <a href="http://w3layouts.com/">W3layouts</a></p>
			</div>
			<div class="copyright-right wow fadeInRight animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
				<ul>
					<li><a href="#" class="twitter"> </a></li>
					<li><a href="#" class="twitter facebook"> </a></li>
					<li><a href="#" class="twitter chrome"> </a></li>
					<li><a href="#" class="twitter pinterest"> </a></li>
					<li><a href="#" class="twitter linkedin"> </a></li>
					<li><a href="#" class="twitter dribbble"> </a></li>
				</ul>
			</div>
			<div class="clearfix"> </div>
			<script type="text/javascript">
									$(document).ready(function() {
										/*
										var defaults = {
								  			containerID: 'toTop', // fading element id
											containerHoverID: 'toTopHover', // fading element hover id
											scrollSpeed: 1200,
											easingType: 'linear' 
								 		};
										*/
										
										$().UItoTop({ easingType: 'easeOutQuart' });
										
									});
								</script>
		<a href="#Kezdőlap" id="toTop" class="scroll" style="display: block;"> <span id="toTopHover" style="opacity: 1;"> </span></a>

		</div>
		<!-- //container -->
	</div>
</body>
</html>