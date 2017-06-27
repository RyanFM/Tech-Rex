        <!DOCTYPE html>
    <html>
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <title>Pulse Music Festival</title>

        <!-- favicon -->
        <link href="favicon.png" rel=icon>

        <!-- web-fonts -->
        <link href='https://fonts.googleapis.com/css?family=Roboto:100,300,400,700,500' rel='stylesheet' type='text/css'>

        <!-- Bootstrap -->
        <link href="css/bootstrap.min.css" rel="stylesheet">

        <!-- Style CSS -->
        <link rel="stylesheet" href="css/style1.css">
        <link href="css/style.css" rel="stylesheet">
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
                    <div class="collapse navbar-collapse navbar-right navbar-main-collapse">
                        <ul class="nav navbar-nav">
                            <li class="hidden"><a href="#page-top"></a></li>
                            <li><a class="page-scroll" href="#section-intro">About</a></li>
                           <!-- <li><a class="page-scroll" href="#section-spot">Spot</a></li> -->
                            <li><a class="page-scroll" href="#section-activities">Activities</a></li>
                            <li><a class="page-scroll" href="#section-pricing">Buy Ticket</a></li>
                            <li><a class="page-scroll" href="#section-signin">Log In</a></li>

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
                <a href="#section-pricing" class="btn btn-default btn-lg"> BUY A TICKET </a>
            </div>
        </div>
        <!-- .Jumbotron-->

        <section id="section-intro" class="section-wrapper about-event">
            <?php include ('pages/about.php') ?>
        </section>
        <!-- .about-event -->

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

            <?php include ('pages/agenda.php') ?>
        </div>

    </section>
    <section id="section-pricing" class="section-wrapper pricing-section gray-bg">
        <div class="container">
            <?php include ('pages/signup.php');?>
            <!-- /.row -->
        </div>
        <!-- /.container -->
    </section>

    <!--end of .container -->
        <section id="section-signin" class="section-wrapper  gray-bg">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="section-title">
                            <h1>LOG IN HERE</h1>

                            <p> Make Sure that you already have an account.</p>
                        <?php include ('pages/login.php') ?>
                        </div>
                    </div>
                </div>

            </div>

            <!-- /.row-->


            <!-- .row-->
        </section>


        <!-- .client-logo -->
    <section id="section-venue" class="section-wrapper  gray-bg">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-title">
                        <h1>THE VENUE</h1>

                        <p> In the heart of the Netherlands.</p>
                    </div>
                </div>
            </div>
            <!-- /.row-->

            <div class="row">
                <div class="col-md-12">
                    <div id="googleMap">

                        Google map here
                    </div>
                </div>
            </div>
            <!-- .row-->
    </section>

    <!-- contact-section -->
    <?php include('pages/footer.php') ?>
    <!-- .footer -->
    </div>

    <!-- jquery -->
    <script src="js/jquery-2.1.4.min.js"></script>

    <!-- Bootstrap -->
    <script src="js/bootstrap.min.js"></script>

    <!-- Plugin JavaScript -->
    <script src="js/jquery.easing.min.js"></script>

    <!-- Google Maps API Key - Use your own API key to enable the map feature. More information on the Google Maps API can be found at https://developers.google.com/maps/ -->
    <script src="https://maps.googleapis.com/maps/api/js"></script>

    <!--<script src="js/one-page-nav.js"></script>-->
    <script src="js/scripts.js"></script>
    </body>

    </head>

    </html>