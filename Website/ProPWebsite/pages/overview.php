<html>
<head>
    <link href="css/bootstrap.min.css" rel="stylesheet">

    <!-- Style CSS -->
    <link rel="stylesheet" href="css/style.css">
    <link href="css/style.css" rel="stylesheet">
    <style>
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
            background-color: #ACADB8;
            color: white;
        }
        .button {
            background-color: #ACADB8;
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
<?php
session_start();
$email =$_SESSION['email'];
$servername ="studmysql01.fhict.local";
$username ="dbi350130";
$password = "Techrex";

try {

    $conn = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi350130', $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    echo'<h2> Now you are in your profile.  </h2>';

    $query = "SELECT * from visitor where email ='$email'";
    $data= $conn->query($query);
    if($query)
    {
        echo' <table>';
        echo '<th>'."Personal Details".'</th>';
        echo '<th>'."".'</th>';
        foreach ($data as $row) {

            echo "<tr>";
            echo "<td>";
            echo "Visitor ID : ". "<br/>";
            echo "First Name : ". "<br/>";
            echo "Last Name : "."<br/>";
            echo "Email : "."<br/>";
            echo "Password : "."<br/>";
            echo "Date of Birth : "."<br/>";

            echo "Balance : "."<br/>";
            echo "Status : "."<br/>";
            echo "Camping Spot: "."<br/>";
            echo "</td>";


            echo "<td>";
            echo  $row["visitor_id"]."<br/>";
            echo  $row["first_name"]."<br/>";
            echo $row["last_name"]."<br/>";
            echo  $row["email"]."<br/>";
            echo  $row["password"]."<br/>";
            echo $row["dob"]."<br/>";

            echo  $row["balance"]."<br/>";
            echo  $row["status"]."<br/>";
            echo $row["camping_spot"]."<br/>";
            echo "</td>";
            echo "</tr>";


        }
    }
    echo '<th>'."".'</th>';
    echo '<th>'."Have a great time at the festival. Thank you !".'</th>';
    echo "</table>";


}
catch(PDOException $error)
{
    $error->getMessage();

}

echo'<h2> Your rented items.  </h2>';
$visitor_id= $row["visitor_id"];


$query = "SELECT p.product_name, r.amount, r.days_rented
FROM product p JOIN rented_products r ON (p.product_id = r.product_id) 
JOIN visitor v ON (v.visitor_id = r.visitor_id)
WHERE v.visitor_id = $visitor_id";
$data= $conn->query($query);
if($query)
{
    echo' <table>';
    echo '<th>'."Personal Items Details".'</th>';
    echo '<th>'."".'</th>';
    foreach ($data as $row) {

        echo "<tr>";
        echo "<td>";
        echo "Product Name : ". "<br/>";
        echo "Amount : ". "<br/>";
        echo "Rented Days : "."<br/>";
        echo "</td>";


        echo "<td>";
        echo  $row["product_name"]."<br/>";
        echo  $row["amount"]."<br/>";
        echo  $row["days_rented"]."<br/>";

        echo "</td>";
        echo "</tr>";


    }
}
echo '<th>'."".'</th>';
echo '<th>'."Please return rented items. Thank you !".'</th>';
echo "</table>";




include '../topup.php'

?>
<br><br>
<a href="/logout.php" class="button"> LOG OUT </a>




