<!DOCTYPE html>

<html>
<head>
    <style>
        table {
            border-collapse: collapse;
            width: 50%;
            align-self: center;
        }

        th, td {
            text-align: left;
            padding: 8px;
        }

        tr:nth-child(even){background-color: #f2f2f2}

        th {
            background-color: #200461;
            color: white;
        }
    </style>

</head>
</html>
<?php
$email = $_SESSION['email'];
$servername ="studmysql01.fhict.local";
$username ="dbi350130";
$password = "Techrex";

try {

    $conn = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi350130', $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    echo'Please find your ticket below. ';

    if(isset($_POST['Recharge']))
    {
        $select = $conn->prepare("SELECT balance FROM visitor Where email = '$email'");
        $select->setFetchMode(PDO::FETCH_ASSOC);
        $select->execute();
        $data = $select->fetch();

        $amount = $_POST['amount'];
        $total = $data['balance'] + $amount;

        $insert = $conn->prepare("UPDATE visitor set balance = $total WHERE email = '$email'");
        $insert->bindParam(':amount', $amount);
        $insert->execute();
        echo "Balance updated successfully";
    }
    $query = "SELECT * from visitor where email ='$email'";
    $data= $conn->query($query);

    if($query)
    {
        echo' <table>';
    echo '<th>'."particulars".'</th>';
    echo '<th>'."Details".'</th>';
    foreach ($data as $row) {
        echo "No data found";
        echo "<tr>";
        echo "<td>";
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
    echo "</table>";
}
catch(PDOException $error)
{
    $error->getMessage();

}
?>
Click Here to <a href="/logout.php">Logout</a>



<form action="pages/ticket.php" >
 <fieldset>

         <button type="submit" name="Pay" value="Pay">Pay</button>

 </fieldset>
</form>
