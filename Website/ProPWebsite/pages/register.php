
<?php
$email =$_SESSION['email'];

$servername ="studmysql01.fhict.local";
$username ="dbi350130";
$password = "Techrex";

try {

    $conn = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi350130', $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

    if(isset($_POST['paynow']))
    {
        $select = $conn->prepare("SELECT * FROM visitor Where visitor_id = '$email'");
        $select->setFetchMode(PDO::FETCH_ASSOC);
        $select->execute();
        $data = $select->fetch();
    }
}

catch(PDOException $error)
{
    $error->getMessage();
}


?>


<!DOCTYPE html>
<html>
<head>
    <style>
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
<body>

<h2>You are successfully registered. Please make a payment </h2>


<a href="/payment/payment.php" name="paynow" class="button" action="register.php"> PAY NOW </a>

</body>
</html>

<?php
echo'<h2> Your financial overview </h2>';
if(isset($_POST['ticketPrice'])){

    //if (isset($_POST['addNewPerson2']) || isset($_POST['addNewPerson3']) || isset($_POST['addNewPerson4']) || isset($_POST['addNewPerson5']) ||isset($_POST['addNewPerson6']) ) {
    {
        $select = $conn->prepare("SELECT * FROM visitor Where email = '$email'");
        $select->setFetchMode(PDO::FETCH_ASSOC);
        $select->execute();
        $data = $select->fetch();
        $personOneAmount = 55;
        $personTwoAmount = 30;
        $personThreeAmount = 30;
        $personFourAmount = 30;
        $personFiveAmount = 30;
        $personSixAmount = 30;
        $ticketAmount = $personOneAmount+$personTwoAmount+$personThreeAmount+$personFourAmount+$personFiveAmount+$personSixAmount;
        $currentBalance = $data['balance'] - $ticketAmount;

        $insert = $conn->prepare("UPDATE visitor set balance = $currentBalance  WHERE email = '$email'");
        //$insert->bindParam(':amount', $amount);
        $insert->execute();
        header("Refresh:0");
    }
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
            echo "Your current balance : ". "<br/>";
            echo "Total ticket price is : "."<br/>";
            echo "Remaining balance : "."<br/>";
            echo "</td>";


            echo "<td>";
            echo  $row["balance"]."<br/>";
            echo $row[$ticketAmount]."<br/>";
            echo  $row[$currentBalance]."<br/>";
            echo "</td>";
            echo "</tr>";


        }
    }
    if ($currentBalance<$ticketAmount)
    {
        echo'You do not have sufficient fund to complete this purchase';
    }
}
echo '<th>'."".'</th>';
echo '<th>'."Check carefully if everyting is correct  !".'</th>';
echo "</table>";
?> <br> <br><br>

<button type="submit" name="ticketPrice" class="btn btn-info"> Pay Now </button>

</div>
</div>


