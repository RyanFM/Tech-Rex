<?php
session_start();
$servername ="studmysql01.fhict.local";
$username ="dbi350130";
$password = "Techrex";

try {

    $conn = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi350130', $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    if (isset($_POST['signup'])) {
        $first_name = $_POST['first_name'];
        $last_name = $_POST['last_name'];
        $dob = $_POST['dob'];
        $email = $_POST['email'];
        $password = $_POST['pass'];
        $ticket_type = $_POST['ticket_type'];
        $stat = 'Registered';
        if($ticket_type=="Friday Ticket" || $ticket_type=="Saturday Ticket"){
        $balance = $_POST['balance'];}
        else{
            $balance = $_POST['balance'];
        }
        $campingoption = $_POST['CampOption'];

        $insert = $conn->prepare("INSERT INTO visitor (first_name, last_name, email, password, dob, balance, ticket_type, status)
  VALUES(:first_name, :last_name, :email,:password, :dob,:balance,:ticket_type,:status) ");
        $insert->bindParam(':first_name', $first_name);
        $insert->bindParam(':last_name', $last_name);
        $insert->bindParam(':email', $email);
        $insert->bindParam(':password', $password);
        $insert->bindParam(':dob', $dob);
        $insert->bindParam(':balance', $balance);
        $insert->bindParam(':ticket_type', $ticket_type);
        $insert->bindParam(':status', $stat);
        $insert->execute();

        $_SESSION['email'] = $email;

        //header("location:pages/profile.php");
        echo "Registered successfully. Please sign in to buy the ticket.";
        if ($ticket_type == "Weekend Ticket" and $campingoption == "Yes") {
            header("location:../pages/camping.php");
            // header("location:/#section-spot");

            /* if(isset($_POST['cbxwanted']) && $_POST['cbxwanted']=="Spotwanted" )
             {

             }
            */
        } elseif($ticket_type=="Friday Ticket" || $ticket_type=="Saturday Ticket") {

            header("location:pages/pay.php");
            $_SESSION['email'] = $email;


        }

    }
    elseif (isset($_POST['login']))
    {
        $email = $_POST['email'];
        $pass = $_POST['pass'];
        $select = $conn->prepare("SELECT * FROM visitor WHERE email='$email' and password='$pass'");
        $select->setFetchMode(PDO::FETCH_ASSOC);
        $select->execute();
        $data = $select->fetch();
        if ($data['email'] != $email and $data['password'] != $pass)
        {
            echo "invalid email or pass";
        }
        elseif ($data['email'] == $email and $data['password'] == $pass and $data['ticket_type']=="Weekend Ticket") {

            $_SESSION['email'] = $data['email'];
            echo $_SESSION['email'].", You are successfully logged in.";
           header("location:pages/overview.php");

        }
        elseif($data['email'] == $email and $data['password'] == $pass)
            {
                $_SESSION['email'] = $data['email'];
                header("location:pages/overview.php");
            }
    }

    if (isset($_POST['camping']))
    {
    $camping_spot = $_POST['camping_spot'];

    $group_size = $_POST['group_size'];
    // changed parts..............................to restrict the email and

    $_SESSION['email'] = $data['email'];
    $insert = $conn->prepare("UPDATE camping set group_size='$group_size' where email=$email");
    $insert->bindParam(':camping_spot', $camping_spot);
    $insert->bindParam(':group_size', $group_size);
    $insert->execute();
    echo "Thank you for your reservation.";
    }

}
catch(PDOException $e)
{
    echo "error".$e->getMessage();
}
?>

<?php
/*
if(empty($_SESSION['email']))
{
  echo "Your are not logged in, Please login first";
header('location:/#section-pricing');


}*/
echo 'something went wrong';
?>
Click Here to <a href="logout.php">Logout</a>