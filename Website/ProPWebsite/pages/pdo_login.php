<?php
ob_start();
session_start();
$servername ="studmysql01.fhict.local";
$username ="dbi350130";
$password = "Techrex";
$database = "dbi350130";
$message="";

try {
    $connect = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi350130', $username, $password);
    $connect->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    if(isset($_POST["login"]))
    {
        if(empty($_POST["email"]) || empty($_POST["password"]))
        {
            $message = '<lable> All Fields are required </lable>';
        }
        else
        {
            $query= "SELECT* FROM visitor WHERE email = :email AND pass = :pass";
            $statement = $connect->prepare($query);
            $statement->execute(

                array(
                    'email' => $_POST["email"],
                    'pass'=>$_POST["pass"]
                )
            );
            $count = $statement->rowCount();
            if ($count>0)
            {
               // $_SESSION["email"] = $_POST["email"];
                header("location:tickets.php");
            }
            else
            {
                $message='<lable> Enter the right in </lable>';
            }
        }
    }
}
catch(PDOException $error)
{
    $message =$error->getMessage();
}
?>


<div class="container" style="width:500px;>

            <h1>SIGN IN </h1>
            <form method="POST">?
<label>Email </label>
<input type="email" name="email" class="form-control" />
<label>Password</label>
<input type="password" name="pass"  class="form-control">
<button type="submit" name = "signup"class="btn btn-primary btn-lg">SIGN IN </button>

</form>
</div>