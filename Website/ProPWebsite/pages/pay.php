<html>

<head>
    <link href="css/bootstrap.min.css" rel="stylesheet">

    <!-- Style CSS -->
    <link rel="stylesheet" href="css/style.css">
    <link href="css/style.css" rel="stylesheet">
    <style>
        /*
Template Name: finadvisor
Description: HTML5 / CSS3 One Page
Version: 1.0
Author: uiCookies.com
*/

        /*------------------------------------------------------------------
        [Table of contents]

        1. Body
            2. Global Typography
            3. Section Background / .gray-bg / .white-bg
            4. Header /
                4.1. .top-bar
                4.2. Navigation / .navbar
            5. Hero Slider / .hero-slide
            6. Services / .services
            7. About Us / .about-us
            8. Testimonial / .testimonialOne
            9. Team / .team
            10. Pricing Table / .pricing-section
            11. Client Logo / .client-logo
            12. Contact Section
                12.1. #googleMap
                12.2. Contact Form
            13. Footer / .footer
            14. Preloader / #preloader


        # [Color codes]

        # Body  (text): #888
        # Heading Color #0E1555
        # Theme Color (link color) #FD367E
        # Mid grey (sub header) #666666
        # -------------------------------------------------------------------*/

        body {
            font-family : 'Roboto', sans-serif;
            font-size   : 17px;
            line-height : 1.7em;
            color       : #353e55;
            font-weight : 100;
            background  : #ffffff;
            border      : 10px solid #fff;
        }

        /* --------------------------------------
         * Global Typography
         *------------------------------------------*/

        h1, h2, h3, h4, h5, h6 {
            margin : 0 0 15px;
            color  : #0e1555;
        }

        h1 {
            font-size   : 36px;
            line-height : 1.2em;
            font-weight : 700;
        }

        h2 {
            font-size   : 30px;
            line-height : 1.5em;
            font-weight : 400;
        }

        h3 {
            font-size   : 24px;
            line-height : 1.5em;
            font-weight : 300;
        }

        h4 {
            font-size   : 18px;
            line-height : 1.5em;
            font-weight : 300;
        }

        h5 {
            font-size   : 16px;
            line-height : 1.5em;
            font-weight : 500;
        }

        h6 {
            font-size   : 15px;
            line-height : 24px;
        }

        /* --------------------------------------
         * LINK STYLE
         *------------------------------------------*/
        a {
            color              : #fd367e;
            text-decoration    : none;
            -webkit-transition : all 0.3s ease 0s;
            -moz-transition    : all 0.3s ease 0s;
            -o-transition      : all 0.3s ease 0s;
            transition         : all 0.3s ease 0s;
        }

        a,
        a:active,
        a:focus,
        a:active {
            text-decoration : none;
            outline         : none
        }

        a:hover,
        a:focus {
            text-decoration : none;
            color           : #999999;
        }

        p {
            margin-bottom : 20px;
        }

        p.lead {
            font-size   : 19px;
            line-height : 1.7em;
        }

        ul {
            margin     : 0;
            padding    : 0;
            list-style : none;
        }

        /*Button Style*/
        .btn {
            padding        : 10px 30px;
            margin-bottom  : 0;
            font-size      : 16px;
            border-radius  : 0;
            font-weight    : 500;
            border-width   : 2px;
            text-transform : uppercase;
        }

        .btn-lg {
            font-size : 18px;
            padding   : 15px 30px
        }

        /*btn-primary*/
        .btn-primary {
            background-color : #fd367e;
            border-color     : #fd367e;
        }

        .btn-primary:hover,
        .btn-primary:focus,
        .btn-primary:active:focus {
            background   : transparent;
            color        : #fd367e;
            border-color : #fd367e;
        }

        /*btn-default*/
        .btn-default {
            color            : #ffffff;
            background-color : transparent;
            border-color     : #ffffff;
        }

        .btn-default:hover,
        .btn-default:focus,
        .btn-default:active:focus {
            background-color : transparent;
            color            : #fd367e;
            border-color     : #fd367e;
        }

        button:focus,
        .btn:focus,
        .btn:active:focus {
            outline : none;
        }

        /* --------------------
         * Section Background
         * -------------------*/

        .gray-bg {
            background-color : #f0f1f3;
            border-top       : 1px solid #eeeeee;
            border-bottom    : 1px solid #eeeeee;
        }

        .white-bg {
            background-color : #ffffff;
        }

        /* --------------------
         *  main Wrapper
         * -------------------*/
        #main-wrapper {
            background : #ffffff;
            overflow   : hidden;
        }

        /*-----------------------------
         * NAVIGATION & HEADER STYLE
         *-------------------------------*/

        .header {
            position : absolute;
            left     : 15px;
            right    : 15px;
            top      : 40px;
            z-index  : 9;
        }

        /*Logo*/
        .navbar-brand {
            padding : 0;
            height  : auto;
            margin  : 5px 0 !important;
        }

        @media (max-width : 768px) {
            .navbar-brand {
                width : 200px;
            }

            .navbar-brand img {
                max-width : 100%;
                height    : auto;
            }
        }

        /*navbar*/

        .navbar {
            border-radius  : 0;
            padding        : 30px 0;
            background     : transparent;
            margin         : 0;
            font-size      : 15px;
            text-transform : uppercase;
        }

        @media (max-width : 768px) {
            .navbar {
                padding : 10px;
            }
        }

        /*navbar toggle*/
        .navbar-toggle {
            margin        : 5px 0;
            padding       : 11px 10px;
            background    : transparent;
        }

        .navbar-toggle:hover {
            color: #fff;
        }

        .navbar-toggle .icon-bar {
            background: #fff;
        }

        /*Navigation Style*/

        .main-menu .navbar-right {
            margin-right : -15px;
        }

        .main-menu .nav li a {
            color       : #ffffff;
            font-weight : 500;
            padding     : 15px 0 15px 30px;
        }

        .main-menu .nav li a:hover,
        .main-menu .nav li.active a {
            color      : #fd367e;
            background : transparent;
        }

        .main-menu .nav li a:focus {
            background : transparent;
        }

        @media (max-width : 991px) {
            .main-menu .nav li a {
                padding-left : 15px;
            }
        }

        @media (max-width : 768px) {
            .main-menu .nav li {
                text-align : center;
            }

            .main-menu .nav li a {
                padding : 5px 0;
                color: #0e1555;
            }

            .navbar-collapse {
                margin-top : 10px;
                background: #fff;
            }
        }


        /* Sticky Menu */
        .sticky-nav {
            position           : fixed;
            right              : 0;
            left               : 0;
            top                : 0;
            z-index            : 999;
            background         : #ffffff !important;
            padding            : 5px 0;
            box-shadow         : 0 2px 5px rgba(0, 0, 0, .1);
            -webkit-transition : all .5s ease-in-out;
            -moz-transition    : all .5s ease-in-out;
            transition         : all .5s ease-in-out;
        }

        .sticky-nav .nav li a {
            color : #0e1555;
        }

        .sticky-nav .navbar-toggle .icon-bar{
            background: #333;
        }

        @media (max-width: 768px) {
            .sticky-nav{
                padding-left: 10px;
                padding-right: 10px;
            }
        }

        /*-------------------
         * Jumbotron
         *-------------------*/

        .jumbotron {
            background            : url("../img/img-jumbotron-bg.jpg");
            background-size       : cover;
            padding               : 0;
            margin                : 0;
            height                : 100vh;
            min-height            : 700px;
            vertical-align        : middle;
            position              : relative;
            background-attachment : fixed;
            background-repeat     : no-repeat;
            background-position   : center center;
            overflow              : hidden;
        }

        .jumbotron .content {
            color             : #ffffff;
            position          : absolute;
            top               : 50%;
            left              : 0;
            right             : 0;
            height            : 30%;
            width             : 100%;
            margin            : 0 auto;
            padding           : 0 10%;
            transform         : translateY(-50%);
            -webkit-transform : translateY(-50%);
            -moz-transform    : translateY(-50%);
        }

        .jumbotron .content h1 {
            color       : #ffffff;
            font-weight : bold;
        }

        .jumbotron .content p.lead {
            font-size   : 24px;
            line-height : 1.5em;
            color       : rgba(255, 255, 255, .7);
        }

        .jumbotron .content .event-date {
            font-size     : 24px;
            margin-bottom : 40px;
        }

        .jumbotron .btn {
            margin-top : 40px;
        }

        @media (max-width : 600px) {
            .jumbotron .content {
                min-height : auto;
            }

            .jumbotron .content h1 {
                font-size : 26px;
            }

            .jumbotron .content p.lead {
                font-size : 15px;
            }
        }

        /*---------------------------
         * Section Wrapper
         *---------------------------*/
        .section-wrapper {
            padding : 100px 0;
        }

        /*---------------------------
         * Section Title
         *---------------------------*/
        .section-title {
            margin-bottom : 60px;
            text-align    : center;
        }

        .section-title h1 {
            margin-bottom : 5px;
        }

        .section-title p {
            font-size : 18px;
            color     : #888888;
        }

        /* ----------------------------------------------
         * About Event
         *-----------------------------------------------*/
        .about-event .lead {
            font-size   : 19px;
            line-height : 1.7em;
        }

        .about-event address {
            font-size   : 15px;
            color       : #888888;
            line-height : 1.8em;
        }

        .about-event address strong {
            color : #353e55;
        }

        /* ----------------------------------------------
         * Team Section
         *-----------------------------------------------*/

        .team .thumbnail {
            padding          : 0;
            line-height      : 22px;
            background-color : transparent;
            border           : 0;
            margin-bottom: 30px;
        }

        @media (max-width : 767px) {
            .team .thumbnail {
                margin-bottom : 30px;
            }
        }

        .team .thumbnail img {
            width : 100%;
        }

        .team .thumbnail .caption {
            padding          : 10px;
        }

        .team .thumbnail h3 {
            font-size        : 16px;
            font-weight: bold;

            margin           : 0 40px;
            text-transform   : uppercase;
            padding          : 10px 0;
        }



        .team .thumbnail h3 small {
            font-size: 14px;
            color     : #888;
            display: block;
            font-weight: normal;
        }


        .team .social-links li {
            display      : inline-block;
            margin-right : 3px;
        }

        .team .social-links li:last-child {
            margin-right : 0;
        }

        .team .social-links li a {
            display   : block;
            font-size : 14px;
            color     : #ccc;
            padding   : 0 5px;
        }

        .team .social-links li a:hover {
            color : #333;
        }

        /* --------------------------
         * Agenda
         *---------------------------*/
        .section-ajenda .session {
            padding       : 15px 0;
            border-left   : 1px solid #eeeeee;
            margin-bottom : 40px;
        }

        .section-ajenda .session time {
            padding       : 5px 25px 15px;
            border-bottom : 1px solid #eeeeee;
            display       : inline-block;
        }

        .section-ajenda .session h2 {
            margin : 20px 0 0 20px;
        }

        .section-ajenda .session h3 {
            margin         : 20px 0 20px 20px;
            font-size      : 20px;
            text-transform : uppercase;
        }

        .section-ajenda .session h3 span {
            font-size   : 14px;
            display     : block;
            line-height : 1;
        }

        /* --------------------------
         * Pricing Table
         *---------------------------*/

        .pricing-section .pricing-table-default {
            border         : 1px solid #f1f1f1;
            background     : #ffffff;
            padding-bottom : 40px;
        }

        @media (max-width : 766px) {
            .pricing-section .pricing-table-default {
                margin-bottom : 30px;
            }
        }

        .pricing-section .pricing-head h3 {
            font-size        : 15px;
            font-weight      : bold;
            text-transform   : uppercase;
            color            : #ffffff;
            padding          : 14px 40px;
            margin           : 0;
            background-color : #0e1555;
        }

        .pricing-section .pricing-head .price {
            display     : block;
            font-size   : 60px;
            line-height : 60px;
            font-weight : bold;
            padding     : 43px 0 0;
        }

        .pricing-section .pricing-head .price sup {
            font-size      : 24px;
            font-weight    : bold;
            vertical-align : super;
            top            : 0;
        }

        .pricing-section .pricing-detail {
            margin : 0 50px 25px 50px;
        }

        .pricing-section .pricing-detail p {
            margin : 0;
        }

        /*pricing list*/

        .pricing-section .pricing-list li {
            display : block;
            padding : 8px 0;
        }

        .pricing-section .pricing-list li i {
            margin-right : 17px;
        }

        .pricing-section .pricing-list li:first-child {
            padding-top : 25px;
        }

        .pricing-section .pricing-list li:last-child {
            padding : 12px 0 0;
        }

        .pricing-section .pricing-detail .pink-i li {
            position : relative;
        }

        /* --------------------------
         * Client Logo
         *---------------------------*/

        .client-logo a img {
            width              : 100%;
            opacity            : 1;
            -webkit-transition : all 0.8s ease 0s;
            -moz-transition    : all 0.8s ease 0s;
            -o-transition      : all 0.8s ease 0s;
            transition         : all 0.8s ease 0s;
        }

        .client-logo a:hover img {
            opacity : .5;
        }

        @media (max-width : 992px) {
            .client-logo .section-margin {
                margin-bottom : 30px;
            }
        }

        /* ------------------
         * Google Map
         * ------------------*/

        #googleMap {
            height        : 320px;
            border        : 5px solid #ffffff;
            margin-bottom : 100px;
        }

        /* ---------------------------
         * Subscribe Form
         * --------------------------- */

        .subscribe-form {
            text-align : center;
        }



        /*-------------------
         * Form Style
         *-------------------*/

        .form-control {
            height        : 46px;
            padding       : 0 20px;
            font-size     : 14px;
            line-height   : 46px;
            color         : #969595;
            border        : 1px solid #f1f1f1;
            border-radius : 0;
            box-shadow    : none;
        }

        .form-control.input-lg {
            height        : 60px;
            padding       : 0 20px;
            font-size     : 18px;
            line-height   : 60px;
            color         : #969595;
            border        : 1px solid #f1f1f1;
            border-radius : 0;
            box-shadow    : none;
            min-width     : 400px;
        }

        .form-control:focus,
        .form-control:active {
            box-shadow   : none;
            border-color : #fd367e;
        }


        @media (max-width : 600px) {
            .form-control.input-lg{
                min-width: auto;
                display: block;
            }
        }

        /* --------------------------------------------
         *   Footer
         *---------------------------------------------- */

        /* Copyright */

        .footer .copyright-section {
            font-size : 13px;
            color     : #888888;
            padding   : 30px 0;
        }

        .footer .copyright-section .copytext {
            font-weight : 400;
            display     : block;
        }

        /* ---------------------------------------------- /*
         * Preloader
        /* ---------------------------------------------- */
        #preloader {
            background : #ffffff;
            bottom     : 0;
            left       : 0;
            position   : fixed;
            right      : 0;
            top        : 0;
            z-index    : 9999;
        }

        #status,
        .status-mes {
            background-image    : url(../img/preloader.gif);
            background-position : center;
            background-repeat   : no-repeat;
            height              : 200px;
            left                : 50%;
            margin              : -100px 0 0 -100px;
            position            : absolute;
            top                 : 50%;
            width               : 200px;
        }

        .status-mes {
            background : none;
            left       : 0;
            margin     : 0;
            text-align : center;
            top        : 65%;
        }
        .section-pricing {
            text-align : center;
            navbutton_background_color: red;
            font-color: rgb(0, 0, 153);
        }


        subscribe-form {
            text-align : center;
        }



        /*-------------------
         * Form Style
         *-------------------*/

        .form-control {
            height        : 46px;
            padding       : 0 20px;
            font-size     : 14px;
            line-height   : 46px;
            color         : #969595;
            border        : 1px solid #f1f1f1;
            border-radius : 0;
            box-shadow    : none;
        }

        .form-control.input-lg {
            height        : 60px;
            padding       : 0 20px;
            font-size     : 18px;
            line-height   : 60px;
            color         : #969595;
            border        : 1px solid #f1f1f1;
            border-radius : 0;
            box-shadow    : none;
            min-width     : 400px;
        }

        .form-control:focus,
        .form-control:active {
            box-shadow   : none;
            border-color : #fd367e;
        }


        @media (max-width : 600px) {
            .form-control.input-lg{
                min-width: auto;
                display: block;
            }
        }
        .btn {
            padding        : 10px 30px;
            margin-bottom  : 0;
            font-size      : 16px;
            border-radius  : 0;
            font-weight    : 500;
            border-width   : 2px;
            text-transform : uppercase;
        }

        .btn-lg {
            font-size : 18px;
            padding   : 15px 30px
        }

        /*btn-primary*/
        .btn-primary {
            background-color : #fd367e;
            border-color     : #fd367e;
        }

        .btn-primary:hover,
        .btn-primary:focus,
        .btn-primary:active:focus {
            background   : transparent;
            color        : #fd367e;
            border-color : #fd367e;
        }

        /*btn-default*/
        .btn-default {
            color            : #ffffff;
            background-color : transparent;
            border-color     : #ffffff;
        }

        .btn-default:hover,
        .btn-default:focus,
        .btn-default:active:focus {
            background-color : transparent;
            color            : #fd367e;
            border-color     : #fd367e;
        }

        button:focus,
        .btn:focus,
        .btn:active:focus {
            outline : none;
        }
        h1, h2, h3, h4, h5, h6 {
            margin : 0 0 15px;
            color  : #0e1555;
        }

        h1 {
            font-size   : 36px;
            line-height : 1.2em;
            font-weight : 700;
        }

        h2 {
            font-size   : 30px;
            line-height : 1.5em;
            font-weight : 400;
        }

        h3 {
            font-size   : 24px;
            line-height : 1.5em;
            font-weight : 300;
        }

        h4 {
            font-size   : 18px;
            line-height : 1.5em;
            font-weight : 300;
        }

        h5 {
            font-size   : 16px;
            line-height : 1.5em;
            font-weight : 500;
        }

        h6 {
            font-size   : 15px;
            line-height : 24px;
        }
        table {
            border-collapse: collapse;
            width: 50%;
        }

        th, td {
            text-align: left;
            padding: 8px;
        }

        tr:nth-child(even){background-color: #f2f2f2}

        th {
            background-color: #9C93AF;
            color: white;
        }
        .button {
            background-color: #041860;
            border: none;
            color: white;
            padding: 15px 32px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
        }
    </style>

</head>
</html>
<script type="text/javascript">
    function showAndHidden()
    {
        var div1=document.getElementById("group_size");
        var div2=document.getElementById("newPerson");
        var div3=document.getElementById("newPerson3");
        var div4=document.getElementById("newPerson4");
        var div5=document.getElementById("newPerson5");
        var div6=document.getElementById("newPerson6");


        if(div1.value =='2')
        {
            div2.style.display='inline'
            div3.style.display = 'none';
            div4.style.display = 'none';
            div5.style.display = 'none';
            div6.style.display = 'none';
        }
        else if (div1.value =='3')
        {

            div2.style.display='inline';
            div3.style.display='inline';
            div4.style.display = 'none';
            div5.style.display = 'none';
            div6.style.display = 'none';
        }
        else if(div1.value =='4')
        {

            div2.style.display='inline';
            div3.style.display='inline';
            div4.style.display='inline';
            div5.style.display = 'none';
            div6.style.display = 'none';
        }
        else if(div1.value =='5')
        {

            div2.style.display='inline';
            div3.style.display='inline';
            div4.style.display='inline';
            div5.style.display='inline';
            div6.style.display = 'none';
        }
        else if(div1.value =='6')
        {

            div2.style.display='inline';
            div3.style.display='inline';
            div4.style.display='inline';
            div5.style.display='inline';
            div6.style.display='inline';
        }

        else {
            div2.style.display = 'none';
            div3.style.display = 'none';
            div4.style.display = 'none';
            div5.style.display = 'none';
            div6.style.display = 'none';
            //location.reload();

        }
    }

    function PassValue()
    {
        var camp=document.getElementById("camping_spot");

    }

</script>
<?php
session_start();
$email = $_SESSION['email'];
$username ="dbi350130";
$password = "Techrex";
try {

    $conn = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi350130', $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $personOneAmount = 0;

    $query = "SELECT * from visitor where email ='$email'";
    $data= $conn->query($query);
    if($query)
    {
        echo' <table>';
        echo '<th>'."Payments Details".'</th>';
        echo '<th>'."".'</th>';
        foreach ($data as $row) {

            echo "<tr>";
            echo "<td>";
            echo "Dear, : ".$first_name. "<br/>";
            echo "Total ticket price is : "."<br/>";
            //echo "Remaining balance : "."<br/>";
            echo "</td>";


            echo "<td>";
            //$balance = $row["balance"]+30;
            echo  $first_name."<br/>";
            //$currentBalance= $row["balance"];
            echo $personOneAmount."<br/>";
           // echo $row["balance"]."<br/>";

            echo "</td>";
            echo "</tr>";


        }
            }
            if ($currentBalance<$ticketAmount)
            {
                echo'You do not have sufficient fund to complete this purchase';
            }
        }


catch(PDOException $e)
{
    echo "error".$e->getMessage();
}
?>

<div>
    <div>
        <form method="POST" action="ticket.php">
            <?php
            echo' <financial> <strong> Your financial overview</strong></financial>';
            //if(isset($_POST['ticketPrice'])){

           /* if (isset($_SESSION['email']))
            {
                    $select = $conn->prepare("SELECT * FROM visitor Where email = '$email'");
                    $select->setFetchMode(PDO::FETCH_ASSOC);
                    $select->execute();
                    $data = $select->fetch();

                    $personOneAmount = 30;

                    $ticketAmount = $personOneAmount;
                    //$remainingBalance = $data['balance'] - $ticketAmount;


                    $insert = $conn->prepare("UPDATE visitor set balance = $remainingBalance  WHERE email ='$email'");
                    //$insert->bindParam(':amount', $amount);
                    $insert->execute();
                    header("Refresh:0");
                }

 */

            echo '<th>'."".'</th>';
            echo '<th>'."Check carefully if everyting is correct  !".'</th>';
            echo "</table>";
            ?> <br> <br><br>
            <form method="POST" action="ticket.php">
                <button  onclick="location.href='logout.php'" type="submit" name="ticketPrice" class="btn btn-info" > PAY NOW </button>

            </form>

    </div>
</div>
