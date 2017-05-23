<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Pulse Musisic Festival</title>

    <!-- favicon -->
    <link href="favicon.png" rel=icon>

    <!-- web-fonts -->
    <link href='https://fonts.googleapis.com/css?family=Roboto:100,300,400,700,500' rel='stylesheet' type='text/css'>

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet">

    <!-- Style CSS -->
    <link rel="stylesheet" href="css/style1.css">

    <link href="css/style.css" rel="stylesheet">

</head>
<body id="page-top" data-spy="scroll" data-target=".navbar">
<div id="main-wrapper">
    <!-- Page Preloader -->
    <div id="preloader">
        <div id="status">
            <div class="status-mes"></div>
        </div>
    </div>

    <header class="header">
        <!-- Navigation -->
        <nav class="navbar main-menu" role="navigation">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-main-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand page-scroll" href="#page-top"><img src="img/logop1.png" alt=""></a>
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse navbar-right navbar-main-collapse">
                    <ul class="nav navbar-nav">
                        <!-- Hidden li included to remove active class from about link when scrolled up past about section -->
                        <li class="hidden"><a href="#page-top"></a></li>
                        <li><a class="page-scroll" href="#section-intro">About</a></li>
                        <li><a class="page-scroll" href="#section-spot">Spot</a></li>
                        <li><a class="page-scroll" href="#section-activities">Activities</a></li>
                        <li><a class="page-scroll" href="#section-pricing">Buy Ticket</a></li>
                        <li><a class="page-scroll" href="#section-signup">Log In</a></li>
                        <li><a class="page-scroll" href="#section-venue">Venue</a></li>
                    </ul>
                </div>
                <!-- /.navbar-collapse -->
            </div>
            <!-- /.container -->
        </nav>

        <!-- .nav -->

    </header>

    <div class="jumbotron text-center">
        <div class="content">
            <div class="event-date">DECEMBER 20–25, 2017, EINDHOVEN</div>
            <h1>PULSE MUSIC FESTIVAL</h1>
            <p class="lead">Please Make a reservaton before our spot is full.</p>
            <a href="#section-signup" class="btn btn-default btn-lg"> BOOK YOUR SPOT </a>
        </div>
    </div>
    <!-- .Jumbotron-->

    <section id="section-intro" class="section-wrapper about-event">
        <?php include ('about.php') ?>
    </section>
    <!-- .about-event -->

    <section id="section-spot" class="section-wrapper team gray-bg">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-title">
                        <h1>CHOOSE YOUR SPOT HERE</h1>
                    </div>
                </div>
            </div>


            </div>
            <!-- .row -->
        <!-- here extra page can be added -->
            <!-- .row -->
        </div>
        <!-- /.container -->
    </section>
    <!-- .team -->

    <section id="section-activities" class="section-wrapper section-ajenda">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-title">
                        <h1>ACTIVITIES HIGHLIGHTS</h1>
                    </div>
                </div>
            </div>

              <?php include ('agenda.php') ?>
        </div>

    </section>
    <section id="section-pricing" class="section-wrapper pricing-section gray-bg">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-title">
                        <h1>BUY TICKET</h1>
                        <p> Fill the form below and choose an appropiate day .</p>
                    </div>
                </div>
            </div>
          <?php include ('tickets.php') ?>
            <!-- /.row -->
        </div>
        <!-- /.container -->
    </section>
    <!-- .pricing-section -->
    <section id="section-signup" class="section-wrapper client-logo">
        <?php include ('signup.php') ?>
        <!--end of .container -->
    </section>
    <!-- .client-logo -->
    <section id="section-venue" class="section-wrapper  gray-bg">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-title">
                        <h1>THE VENUE</h1>

                        <p>

                            In the heart of the Netherlands.</p>
                    </div>
                </div>
            </div>
            <!-- /.row-->

            <div class="row">
                <div class="col-md-12">
                    <div id="googleMap"></div>
                </div>
            </div>
            <!-- .row-->

            <div class="row">
                <div class="col-md-12">
                    <div class="section-title">
                        <h2>STAY INFORMED</h2>
                        <p>Don't miss the event!</p>
                    </div>
                  <?php include ('subscriber.php') ?>
                </div>
            </div>

        </div>
    </section>
    <!-- contact-section -->
    <?php include('footer.php') ?>
    <!-- .footer -->
</div>
<!-- jquery -->
<script src="js/jquery-2.1.4.min.js"></script>

<!-- Bootstrap -->
<script src="js/bootstrap.min.js"></script>

<!-- Plugin JavaScript -->
<script src="js/jquery.easing.min.js"></script>

<!-- Google Maps API Key - Use your own API key to enable the map feature. More information on the Google Maps API can be found at https://developers.google.com/maps/ -->
<script src="https://maps.googleapis.com/maps/api/jsAIzaSyAMZMXrZULZnjFFOQc11F3Ds84ICtGLYyg"></script>

<!--<script src="js/one-page-nav.js"></script>-->
<script src="js/scripts.js"></script>
<script src="js/index.js"></script>

</body>
</html>