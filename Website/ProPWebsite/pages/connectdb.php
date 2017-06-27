<?php
$servername ="studmysql01.fhict.local";
$username ="dbi350130";
$password = "Techrex";
$database = "dbi350130";
$message="";

try {
    $connect = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi350130', $username, $password);
    $connect->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
}
catch(PDOException $e)
{
    echo "error".$e->getMessage();
}
?>
