<!DOCTYPE html>

<html>
<head>
    <style>
        table {
            border-collapse: collapse;
            width: 100%;
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
session_start();
$email =$_SESSION['email'];
$servername ="studmysql01.fhict.local";
$username ="dbi350130";
$password = "Techrex";

try {

    $conn = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi350130', $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    echo'Please find your ticket below';
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
    echo'<table width = "70%" border="1" cellpadding="5" cellspacing="5" >
<tr>
<th>Visitor ID </th>
<th>First Name</th>
<th>Last Name</th>
<th>Email</th>
<th>Password</th>
<th>Date of Birth</th>
<th>Balance</th>
<th>Ticket Type</th>
<th>Status</th>
<th>Camping Spot</th>

</tr>';
    foreach ($data as $row) {
        echo '<tr>
                <td>' . $row["visitor_id"] . '</td>
                <td>' . $row["first_name"] . '</td>
                <td>' . $row["last_name"] . '</td>                
                <td>' . $row["email"] . '</td>
                <td>' . $row["password"] . '</td>
                <td>' . $row["dob"] . '</td>
                <td>' . $row["balance"] . '</td>
                <td>' . $row["ticket_type"] . '</td>
                <td>' . $row["status"] . '</td>                
                <td>' . $row["camping_spot"] . '</td>

        </tr>';
    }
    echo '</table>';


}
catch(PDOException $error)
{
    $error->getMessage();

}
include("../topup.php");
?>

Click Here to <a href="/logout.php">Logout</a>



