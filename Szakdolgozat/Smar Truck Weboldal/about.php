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
<title>Truck a Transport Category Flat Bootstarp responsive Website Template| About :: w3layouts</title>
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

<?php
if(!isset($_SESSION['loggeidIn'])) 
{
	$html='
	<div id="home" class="banner a-banner">
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
						<li class="hvr-sweep-to-bottom active"><a href="about.php">Rólunk<i><img src="images/nav-but2.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom"><a href="services.php">Szolgáltatások<i><img src="images/nav-but3.png" alt=""/></i></a></li>
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

}else
{

	$html2="";
	$html2.='<!-- banner -->
	<div id="home" class="banner a-banner">
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
						<li class="hvr-sweep-to-bottom active"><a href="about.php">Rólunk<i><img src="images/nav-but2.png" alt=""/></i></a></li>
						<li class="hvr-sweep-to-bottom"><a href="services.php">Szolgáltatások<i><img src="images/nav-but3.png" alt=""/></i></a></li>
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
	<!-- about -->
	<div class="about-top">
		<!-- container -->
		<div class="container">
			<div class="about-info wow fadeInLeft animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
				<h3>Magunkról</h3>
				<h5>A cégunk 1996 óta folyamatosan üzemel és bővül az európai piacon <span>A legjobb Szállító cég</span></h5>
			</div>
			<div class="banner-bottom-grids a-banner-bottom-grids">
				<div class="col-md-5 banner-bottom-right wow fadeInRight animated animated" data-wow-delay="0.5s" style="visibility: visible; -webkit-animation-delay: 0.5s;">
					<img src="images/img1.jpg" alt="">
				</div>
				<div class="col-md-7 a-banner-bottom-text">
					<div class="jumbotron banner-bottom-left wow fadeInLeft animated animated" data-wow-delay="0.5s" style="visibility: visible; -webkit-animation-delay: 0.5s;">
					  <h3>Fontosabb Információk a Cégünkről</h3>
						<h5>Szárazföldi szállítmányozással foglalkozó cég vagyunk <span>Jelen vagyunk mindenhol a világon.</span></h5>
						<p>
							Cégünk az alapítás óta folyamatosan nagy tendenciával növekszik. Kezdetben belföldi fuvarozással foglalkoztunk jelenleg már cégünk egyaránt foglakozik belföldi és külföldi fuvarokkal. A gépjármű parkot tekintve Európában a mi cégünknek van a legmodernebb gépjármű parkja.
						</p>
					</div>
				</div>
				<div class="clearfix"> </div>
			</div>
		</div>
		<!-- //container -->
	</div>
	<!-- //about -->
	<!-- about-bottom -->
	<div class="about-bottom">
		<!-- container -->
		<div class="container">
			<h3 class="wow fadeInRight animated" style="visibility: visible;">A legújabb generációs kamionokkal dolgozunk világszerte.</h3>
			<div class="about-bottom-grids">
				<div class="col-md-6 about-bottom-left wow fadeInLeft animated animated" data-wow-delay="0.5s" style="visibility: visible; -webkit-animation-delay: 0.5s;">
					<h4>A legújabb generációs Scania</h4>
					<p>Cégünk 2014-óta Folyamatos kapcsoaltban áll a Scaniaval amely biztositja nekünk a legújabb generációs járműveket.
						<span>A  gépjárműveket  tekintve cégünk a legmodernebb  Scania G típusú kamionokat használja, amelyeket egy évre béreltünk ki. </span>
						A gépjárműveket a Scaniatól bérbe kapjuk, amelyeket 1 éves szerződés aláírásával béreljük. Esetlegesen hosszabbíthatjuk azokat vagy új szerződés alapján gépjárművet cserélünk.
				</div>
				<div class="col-md-6 about-bottom-left about-bottom-right wow fadeInRight animated animated" data-wow-delay="0.5s" style="visibility: visible; -webkit-animation-delay: 0.5s;">
					<h4>Cégünk kapcsolatai más cégekkel </h4>
					<p> Cégünk a világ minden pontján kapcsolatban áll nagy multi vállalatokkal, akiknek a szerződésben megfelelően szállítjuk  ki a termékeiket.
						<span> Mivel cégünk sok nagyvállalattal áll kapcsolatban ezért, csak említenek párat akik velünk dolgoznak.
						A vállalatok, akikkel együtt dolgozunk: Hervis,Tesco,Mizo,Coca Cola. </span>
						A cégünk évente több mint 100 új szerződéssel bővül ezáltal biztosítva a vezető pozíciót a piacon. </p>
				</div>

				<div class="clearfix"> </div>
			</div>
		</div>
		<!-- //container -->
	</div>
	<!-- //about-bottom -->
	<!-- team -->
	<div class="team">
		<!-- container -->
		<div class="container">
			<div class="team-info">
				<h3 class="wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">Cégek akikkel kapcsolatban állunk</h3>
				<div class="team-grids">
					<div class="col-md-3 team-grid wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
						<img src="images/tesco.png" alt="">
						<h6>Tesco</h6>
						<p> Száraz áru szállítás és mirelit</p>
					</div>
					<div class="col-md-3 team-grid wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
						<img src="images/auchan.png" alt="">
						<h6>Auchan</h6>
						<p> Száraz áru szállítás</p>
					</div>
					<div class="col-md-3 team-grid wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
						<img src="images/hervis.png" alt="">
						<h6>Hervis</h6>
						<p> Sport áru</p>
					</div>
						<div class="col-md-3 team-grid wow bounceIn animated" data-wow-delay="0.4s" style="visibility: visible; -webkit-animation-delay: 0.4s;">
						<img src="images/coca cola.png" alt="">
						<h6>Coca cola</h6>
						<p> Folyadék szállítás </p>
					</div>
					
					
				
					<div class="clearfix"> </div>
				</div>
			</div>
		</div>
		<!-- //container -->
	</div>
	<!-- //team -->
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