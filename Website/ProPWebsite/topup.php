<?php
$email =$_SESSION['email'];
$servername ="studmysql01.fhict.local";
$username ="dbi350130";
$password = "Techrex";

try {

$conn = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi350130', $username, $password);
$conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        if(isset($_POST['Recharge']))
        {
            $select = $conn->prepare("SELECT * FROM visitor Where email = '$email'");
            $select->setFetchMode(PDO::FETCH_ASSOC);
            $select->execute();
            $data = $select->fetch();
            $amount = $_POST['amount'];
            $total = $data['balance'] + $amount;
            $insert = $conn->prepare("UPDATE visitor set balance = $total  WHERE email = '$email'");
            //$insert->bindParam(':amount', $amount);
            $insert->execute();
            header("Refresh:0");
        }
}
catch(PDOException $error)
{
    $error->getMessage();
}
?>

<h4>Please choose your amount to Top-up your account:</h4>

<section id="section-spot" class="section-wrapper team gray-bg">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="section-title">

                        <form method="POST">
                            <legend>
                                <fieldset>Enter a amount you wish to top up
                                <label>€ :</label>
                                <input type="number" name="amount" placeholder="Your Amount" min="5">

                                <button type="submit" name="Recharge" class="btn-btn-info" > TOP UP </button>
                                </fieldset>
                            </legend>
                        </form>

                </div>
            </div>
        </div>

    </div>
</section>


