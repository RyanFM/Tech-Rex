
<?php
if(!isset($_SESSION)){
ob_start();
session_start();}
else{
//    session_destroy();
}

$servername ="studmysql01.fhict.local";
$username ="dbi350130";
$password = "Techrex";

try {

    $conn = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi350130', $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    echo "Connected successfully";
    if (isset($_POST['signup'])) {
        $first_name = $_POST['first_name'];
        $last_name = $_POST['last_name'];
        $dob = $_POST['dob'];
        $email = $_POST['email'];
        $password = $_POST['pass'];
        $ticket_type = $_POST['ticket_type'];

        $stat='Registered';
        $bal='5.00';
        $insert = $conn->prepare("INSERT INTO visitor (first_name, last_name, email, password, dob, balance, ticket_type, status)

  VALUES(:first_name, :last_name, :email,:password, :dob,:balance,:ticket_type,:status) ");
        $insert->bindParam(':first_name', $first_name);
        $insert->bindParam(':last_name', $last_name);

        $insert->bindParam(':email', $email);
        $insert->bindParam(':password',$password);
        $insert->bindParam(':dob', $dob);
        $insert->bindParam(':balance', $bal);
        $insert->bindParam(':ticket_type', $ticket_type);
        $insert->bindParam(':status', $stat);
        $insert->execute();
        //header("location:pages/profile.php");


    } elseif (isset($_POST['login'])) {
        console.log("Hello");
        $email = $_POST['email'];
        $pass = $_POST['pass'];
        $select = $conn->prepare("SELECT * FROM users WHERE email='$email' and pass='$pass'");
        $select->setFetchMode(PDO::FETCH_ASSOC);
        $select->execute();
        $data = $select->fetch();
        if ($data['email'] != $email and $data['password'] != $pass) {
            echo "invalid email or pass";
        } elseif ($data['email'] == $email and $data['password'] == $pass) {
            $_SESSION['email'] = $data['email'];
            WELCOME :echo $_SESSION['email'];

            //$_SESSION['name'] = $data['name'];
           // header("location:profile.php");

        }
    }
}
catch(PDOException $e)
{
    echo "error".$e->getMessage();
}

?>
<?php

if(empty($_SESSION['email']))
{

header('location:pages/signup.php');

}

?>



<a href="logout.php">Logout</a>