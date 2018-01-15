<!DOCTYPE HTML>
<!--
	Prologue by HTML5 UP
	html5up.net | @ajlkn
	Free for personal and commercial use under the CCA 3.0 license (html5up.net/license)
-->
<html lang="en-US">
	<head>
	    <link rel='shortcut icon' type='image/x-icon' href='favicon.ico' />
		<title>Old School Web</title>
		<!-- SEO -->

		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
		<!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->
		<link rel="stylesheet" href="assets/css/main.css" />
		<!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->
		<!--[if lte IE 9]><link rel="stylesheet" href="assets/css/ie9.css" /><![endif]-->
		
	</head>
	<body>
		<?php include 'site/create.php'; ?>

		<!-- Header -->
			<div id="header">

				<div class="top">

					<!-- Logo -->
						<div id="logo">
							<span class="image avatar48"><img src="images/avatar.jpg" alt="" /></span>
							<h1 id="title">Old School Web</h1>
							<p>Dublin - 7777 Parnell Street</p>
						</div>

					<!-- Nav -->
						<nav id="nav">
							<!--

								Prologue's nav expects links in one of two formats:

								1. Hash link (scrolls to a different section within the page)

								   <li><a href="#foobar" id="foobar-link" class="icon fa-whatever-icon-you-want skel-layers-ignoreHref"><span class="label">Foobar</span></a></li>

								2. Standard link (sends the user to another page/site)

								   <li><a href="http://foobar.tld" id="foobar-link" class="icon fa-whatever-icon-you-want"><span class="label">Foobar</span></a></li>

							-->
							<ul>
								<li><a href="#top" id="top-link" class="skel-layers-ignoreHref"><span class="icon fa-home">Intro</span></a></li>
								<li><a href="#portfolio" id="portfolio-link" class="skel-layers-ignoreHref"><span class="icon fa-th">Portfolio</span></a></li>
								<li><a href="#about" id="about-link" class="skel-layers-ignoreHref"><span class="icon fa-user">About Us</span></a></li>
								<li><a href="#team" id="team-link" class="skel-layers-ignoreHref"><span class="icon fa-users">Team</span></a></li>
								<li><a href="#contact" id="contact-link" class="skel-layers-ignoreHref"><span class="icon fa-envelope">Contact</span></a></li>
							</ul>
						</nav>

				</div>

				<div class="bottom">

					<!-- Social Icons -->
						<ul class="icons">
							<li><a href="#" class="icon fa-tumblr" target="_blank"><span class="label">Tumblr</span></a></li>
							<li><a href="#" class="icon fa-facebook" target="_blank"><span class="label">Facebook</span></a></li>
						</ul>

				</div>

			</div>

		<!-- Main -->
			<div id="main">

				<!-- Intro -->
					<section id="top" class="one dark cover">
						<div class="container">

							<header>
								<h2 class="alt">Lorem ipsum <strong>Old School Web</strong>, mollis feugiat<br />
								dolor sit amet, consectetur adipiscing elit.</h2>
								<p>Quisque vehicula neque vitae leo dictum consequat. Nullam lorem ipsum, 
								luctus a dictum nec, aliquam a sapien. Donec elementum ligula luctus, 
								placerat nisl id, mollis massa.</p>
							</header>

							<footer>
								<a href="#portfolio" class="button scrolly">Know more</a>
							</footer>

						</div>
					</section>

				<!-- Portfolio -->
					<section id="portfolio" class="two">
						<div class="container">

							<header>
								<h2>Portfolio</h2>
							</header>

							<p>Aliquam at metus sed justo pretium fermentum a vitae est. 
							Quisque a finibus massa. Suspendisse potenti. </p>

							<div class="row">
								<?php GetContent("portfolio"); ?>
							</div>
							
						</div>
					</section>

				<!-- About Us -->
					<section id="about" class="three">
						<div class="container">

							<header>
								<h2>About Us</h2>
							</header>

							<a href="#about" class="image featured"><img src="images/aboutus.jpg" alt="" /></a>

							<p>Orci varius natoque penatibus et magnis dis parturient montes, nascetur 
							ridiculus mus. Proin id tortor ac eros fringilla suscipit sit amet sit amet lorem. 
							Pellentesque habitant morbi tristique senectus et netus et malesuada fames 
							ac turpis egestas. Sed imperdiet arcu metus, nec porta dui gravida sit amet.</p>

						</div>
					</section>
				
				<!-- Team -->
					<section id="team" class="four">
						<div class="container">

							<header>
								<h2>Team</h2>
							</header>

							<div class="row">
								<?php GetContent("team"); ?>
							</div>

						</div>
					</section>

				<!-- Contact -->
					<section id="contact" class="five">
						<div class="container">

							<header>
								<h2>Contact</h2>
							</header>

							<p>Dublin - 
								7777 Parnell Street
								 - Tel: (99) 555 5555</p>

							<form id="mail-form">
								<div class="row">
									<div class="6u 12u$(mobile)">
										<input type="text" name="name" placeholder="Name" />
										<div id="namevalidate" class="validatetext"></div>
									</div>
									<div class="6u$ 12u$(mobile)">
										<input type="text" name="email" placeholder="Email" />
										<div id="emailvalidate" class="validatetext"></div>
									</div>
									<div class="12u$">
										<textarea name="message" placeholder="Message"></textarea>
										<div id="messagevalidate" class="validatetext"></div>
									</div>
									<div class="12u$">
										<input type="submit" value="Send Message" />
									</div>
								</div>
							</form>
							<br />
							<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d8401.234210212884!2d-6.270164301954448!3d53.352772351649364!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x48670e8218b111ad%3A0x8460869c573ae386!2sCineworld+Cinema+-+Dublin!5e0!3m2!1sen!2sie!4v1509134572884" width="100%" height="450" frameborder="0" style="border:0" allowfullscreen></iframe>
						</div>
					</section>

			</div>

		<!-- Footer -->
			<div id="footer">

				<!-- Copyright -->
					<ul class="copyright">
						<li>&copy; Old School Web Ltd. All rights reserved.</li>
						<li>Design: <a href="http://html5up.net" target="_blank">HTML5 UP</a></li>
						<li>Powered by <a href="https://br.linkedin.com/in/rodrigo-vedovato-14648357" target="_blank">Rodrigo Vedovato</a></li>
					</ul>

			</div>	

		<!-- Content -->
			<div id="content" class="root">

				<div class="closepage">
					<span id="close">X</span>
				</div>

				<div id="loader" class="loader"></div>
				
				<div id="pagecontent" class="singlepagecontent"></div>
				
			</div>

		<!-- Scripts -->
			<script src="assets/js/jquery.min.js"></script>
			<script src="assets/js/jquery.scrolly.min.js"></script>
			<script src="assets/js/jquery.scrollzer.min.js"></script>
			<script src="assets/js/skel.min.js"></script>
			<script src="assets/js/util.js"></script>
			<!--[if lte IE 8]><script src="assets/js/ie/respond.min.js"></script><![endif]-->
			<script src="assets/js/main.js"></script>
			<script src="assets/js/singlepagecontent.js"></script>

	</body>
</html>