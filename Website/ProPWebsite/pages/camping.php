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
            background-color: #9C93AF;
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
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js">


</script>
<script type="text/javascript">
    function showAndHidden()
    {
        var div1=document.getElementById("group_size");
        var div2=document.getElementById("newPerson");
        var div3=document.getElementById("newPerson3");
        var div4=document.getElementById("newPerson4");
        var div5=document.getElementById("newPerson5");
        var div6=document.getElementById("newPerson6");


        if(div1.value =='1')
        {
            div2.style.display = 'none'
            div3.style.display = 'none';
            div4.style.display = 'none';
            div5.style.display = 'none';
            div6.style.display = 'none';
        }

        else if(div1.value =='2')
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
    document.getElementById("campChoose").addEventListener("click", myFunction);

    function myFunction()
    {
        document.getElementById("formfinance").style.display = 'none';
        document.getElementById("formfinance").style.display = 'inline';
        $("formfinance").show();
    }
</script>
<?php
ob_start();
session_start();
$email = $_SESSION['email'];
$username ="dbi350130";
$password = "Techrex";
try {

    $conn = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi350130', $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    if (isset($_POST['addNewPerson2']) || isset($_POST['addNewPerson3']) || isset($_POST['addNewPerson4']) || isset($_POST['addNewPerson5']) || isset($_POST['addNewPerson6'])) {
        $first_name = $_POST['first_name'];
        $last_name = $_POST['last_name'];
        $dob = $_POST['dob'];
        $semail = $_POST['email'];
        $password = $_POST['pass'];
        $ticket_type = $_POST['ticket_type'];
        $stat = 'Registered';
        $balance = $_POST['balance'];
        $camping_spot = $_POST['camping_spot'];
        //$camping_spot = camping_spot;
        $select = $conn->prepare("SELECT * FROM camping Where camping_spot ='$camping_spot'");
        $select->setFetchMode(PDO::FETCH_ASSOC);
        $select->execute();
        $data = $select->fetch();
        if (($data['group_size'] + $group_size) <= 6) {


            $insert = $conn->prepare("INSERT INTO visitor (first_name, last_name, email, password, dob, balance, ticket_type, status, camping_spot)
VALUES(:first_name, :last_name, :email,:password, :dob,:balance,:ticket_type,:status,:camping_spot) ");
            $insert->bindParam(':first_name', $first_name);
            $insert->bindParam(':last_name', $last_name);
            $insert->bindParam(':email', $semail);
            $insert->bindParam(':password', $password);
            $insert->bindParam(':dob', $dob);
            $insert->bindParam(':balance', $balance);
            $insert->bindParam(':ticket_type', $ticket_type);
            $insert->bindParam(':status', $stat);
            $insert->bindParam(':camping_spot', $camping_spot);
            $insert->execute();
            $updatevisitor = $conn->prepare("UPDATE visitor set camping_spot ='$camping_spot' WHERE     email='$email'");
            $insert->bindParam(':camping_spot', $camping_spot);
            //header("location:pages/profile.php");
            echo "New person added  successfully";
            //header('location:/#section-pricing');

        } else {
            echo "Choose another spot";
        }

    } elseif (isset($_POST['chooseCamp'])) {

        $camping_spot = $_POST['camping_spot'];
        $group_size = $_POST['group_size'];
        $select = $conn->prepare("SELECT * FROM camping Where camping_spot ='$camping_spot'");
        $select->setFetchMode(PDO::FETCH_ASSOC);
        $select->execute();
        $data = $select->fetch();
        if (($data['group_size'] + $group_size) <= 6) {
            $insert = $conn->prepare("UPDATE camping set group_size='$group_size' where camping_spot='$camping_spot'");
            $updatevisitor = $conn->prepare("UPDATE visitor set camping_spot ='$camping_spot' WHERE email='$email'");
            $insert->bindParam(':camping_spot', $camping_spot);
            $insert->bindParam(':group_size', $group_size);
            $insert->execute();
            $updatevisitor->execute();

        } //header("location:../overview.php");}
        else {
            echo "There is not enough space on this camp, try another spot";
            header("location:../pages/camping.php");
        }
    }
}

catch(PDOException $e)
{
    echo "error".$e->getMessage();
}
?>

<div style="width:500px ; height:600px; float:left;">
    <div style="padding:85px;">

        <section id="section-spot" class="section-wrapper team gray-bg">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="section-title">
                            <h1> BUY A TICKET </h1>
                            <form method="POST" class="subscribe-form form-inline">
                                <select id="camping_spot" name="camping_spot" class="form-control input-lg" onchange="PassValue()">
                                    <option value="find"> Find available Camping</option>
                                    <option value="1">1</option>
                                    <option value="2">2</option>
                                    <option value="3">3</option>
                                    <option value="4">4</option>
                                    <option value="5">5</option>
                                    <option value="6">6</option>
                                    <option value="7">7</option>
                                    <option value="8">8</option>
                                    <option value="9">9</option>
                                    <option value="10">10</option>
                                    <option value="11">11</option>
                                    <option value="12">12</option>
                                    <option value="13">13</option>
                                    <option value="14">14</option>
                                    <option value="15">15</option>
                                    <option value="16">16</option>
                                    <option value="17">17</option>
                                    <option value="18">18</option>
                                    <option value="19">19</option>
                                    <option value="20">20</option>
                                    <option value="21">21</option>
                                    <option value="22">22</option>
                                    <option value="23">23</option>
                                    <option value="24">24</option>
                                    <option value="25">25</option>
                                </select>
                                <br><br>
                                <select id="group_size" name="group_size" class="form-control input-lg" onchange="showAndHidden()">
                                    <option value="find"> Choose your group size</option>
                                    <option value=1>1</option>
                                    <option value=2>2</option>
                                    <option value=3>3</option>
                                    <option value=4>4</option>
                                    <option value=5>5</option>
                                    <option value=6>6</option>
                                    <option value=7>7</option>
                                </select> <br><br>
                                <option selected disabled hidden> --Choose your ticket-- </option>
                                <button type="submit" id="chooseCamp" name = "chooseCamp" value="chooseCamp" onclick="myFunction()"  class="btn btn-info">Choose Camping </button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </section>



        <!-- /.container -->
        <div id="newPerson" style="display:none">
            <h3> ADD A NEW PERSON 2 </h3>
            <form  method="POST" class="subscribe-form form-inline">
                <input type="text" name="first_name" placeholder="First Name" required class="form-control input-lg"><br>
                <input type="text" name="last_name" placeholder="Last Name" required class="form-control input-lg"><br>
                <input type="text" name="email" placeholder="example@example.com" required class="form-control input-lg"><br>
                <input type="year" name="dob" placeholder="Date of Birth" required class="form-control input-lg"><br>
                <input type="password" name="pass" placeholder="**********" required class="form-control input-lg"><br>
                <br>
                <select  id ="ticket_type" name="ticket_type" required class="form-control input-lg">
                    <option selected disabled hidden> --Choose your ticket-- </option>
                    <option selected value="Weekend Ticket">Whole weekend Ticket</option>
                    <option value="fridayTicket">Friday Ticket</option>
                    <option value="saturdayTicket">Saturday Ticket</option>
                </select><br>
                <button type="submit" name = "addNewPerson2" class="btn btn-info">Add </button>
            </form>

        </div>

        <div id="newPerson2" style="display: none">
            <h3> ADD A NEW PERSON 2 </h3>
            <form  method="POST" class="subscribe-form form-inline">
                <input type="text" name="first_name" placeholder="First Name" required class="form-control input-lg"><br>
                <input type="text" name="last_name" placeholder="Last Name" required class="form-control input-lg"><br>
                <input type="text" name="email" placeholder="example@example.com" required class="form-control input-lg"><br>
                <input type="year" name="dob" placeholder="Date of Birth" required class="form-control input-lg"><br>
                <input type="password" name="pass" placeholder="**********" required class="form-control input-lg"><br>
                <br>
                <select  id ="ticket_type" name="ticket_type" required class="form-control input-lg">
                    <option selected disabled hidden> --Choose your ticket-- </option>
                    <option selected value="Weekend Ticket">Whole weekend Ticket</option>
                    <option value="fridayTicket">Friday Ticket</option>
                    <option value="saturdayTicket">Saturday Ticket</option>
                </select><br>
                <button type="submit" name = "addNewPerson2" class="btn btn-info">Add </button>
            </form>
        </div>
        <div id="newPerson3" style="display: none">
            <h3> ADD A NEW PERSON 3 </h3>
            <form  method="POST" class="subscribe-form form-inline">
                <input type="text" name="first_name" placeholder="First Name" required class="form-control input-lg"><br>
                <input type="text" name="last_name" placeholder="Last Name" required class="form-control input-lg"><br>
                <input type="text" name="email" placeholder="example@example.com" required class="form-control input-lg"><br>
                <input type="year" name="dob" placeholder="Date of Birth" required class="form-control input-lg"><br>
                <input type="password" name="pass" placeholder="**********" required class="form-control input-lg"><br>
                <br>
                <select  id ="ticket_type" name="ticket_type" required class="form-control input-lg">
                    <option selected disabled hidden> --Choose your ticket-- </option>
                    <option selected value="Weekend Ticket">Whole weekend Ticket</option>
                    <option value="fridayTicket">Friday Ticket</option>
                    <option value="saturdayTicket">Saturday Ticket</option>
                </select><br>
                <button type="submit" name = "addNewPerson3" class="btn btn-info">Add </button>
            </form>
        </div>
        <div id="newPerson4" style="display: none">
            <h3> ADD A NEW PERSON 4 </h3>
            <form  method="POST" class="subscribe-form form-inline">
                <input type="text" name="first_name" placeholder="First Name" required class="form-control input-lg"><br>
                <input type="text" name="last_name" placeholder="Last Name" required class="form-control input-lg"><br>
                <input type="text" name="email" placeholder="example@example.com" required class="form-control input-lg"><br>
                <input type="year" name="dob" placeholder="Date of Birth" required class="form-control input-lg"><br>
                <input type="password" name="pass" placeholder="**********" required class="form-control input-lg"><br>
                <br>
                <select  id ="ticket_type" name="ticket_type" required class="form-control input-lg">
                    <option selected disabled hidden> --Choose your ticket-- </option>
                    <option selected value="Weekend Ticket">Whole weekend Ticket</option>
                    <option value="fridayTicket">Friday Ticket</option>
                    <option value="saturdayTicket">Saturday Ticket</option>
                </select><br>
                <button type="submit" name = "addNewPerson4" class="btn btn-info">Add </button>
            </form>
        </div>
        <div id="newPerson5" style="display: none">
            <h3> ADD A NEW PERSON 5 </h3>
            <form  method="POST" class="subscribe-form form-inline">
                <input type="text" name="first_name" placeholder="First Name" required class="form-control input-lg"><br>
                <input type="text" name="last_name" placeholder="Last Name" required class="form-control input-lg"><br>
                <input type="text" name="email" placeholder="example@example.com" required class="form-control input-lg"><br>
                <input type="year" name="dob" placeholder="Date of Birth" required class="form-control input-lg"><br>
                <input type="password" name="pass" placeholder="**********" required class="form-control input-lg"><br>
                <br>
                <select  id ="ticket_type" name="ticket_type" required class="form-control input-lg">
                    <option selected disabled hidden> --Choose your ticket-- </option>
                    <option selected value="Weekend Ticket">Whole weekend Ticket</option>
                    <option value="fridayTicket">Friday Ticket</option>
                    <option value="saturdayTicket">Saturday Ticket</option>
                </select><br>
                <button type="submit" name = "addNewPerson5" class="btn btn-info">Add </button>
            </form>
        </div>
        <div id="newPerson6" style="display: none">
            <h3> ADD A NEW PERSON 6 </h3>
            <form  method="POST" class="subscribe-form form-inline">
                <input type="text" name="first_name" placeholder="First Name" required class="form-control input-lg"><br>
                <input type="text" name="last_name" placeholder="Last Name" required class="form-control input-lg"><br>
                <input type="text" name="email" placeholder="example@example.com" required class="form-control input-lg"><br>
                <input type="year" name="dob" placeholder="Date of Birth" required class="form-control input-lg"><br>
                <input type="password" name="pass" placeholder="**********" required class="form-control input-lg"><br>
                <br>
                <select  id ="ticket_type" name="ticket_type" required class="form-control input-lg">
                    <option selected disabled hidden> --Choose your ticket-- </option>
                    <option selected value="Weekend Ticket">Whole weekend Ticket</option>
                    <option value="fridayTicket">Friday Ticket</option>
                    <option value="saturdayTicket">Saturday Ticket</option>
                </select><br>
                <button type="submit" name = "addNewPerson2" class="btn btn-info">Add </button>
            </form>
        </div>
    </div>
</div>


<div>
    <div>
        <form method="POST" action="ticket.php">
            <?php
            echo'<h2> Your financial overview </h2>';
            //if(isset($_POST['ticketPrice'])){

            if (isset($_POST['addNewPerson2']) || isset($_POST['addNewPerson3']) || isset($_POST['addNewPerson4']) || isset($_POST['addNewPerson5']) ||isset($_POST['addNewPerson6'])|| isset($_POST['chooseCamp']) ) {
                {
                    $select = $conn->prepare("SELECT * FROM visitor Where email = '$email'");
                    $select->setFetchMode(PDO::FETCH_ASSOC);
                    $select->execute();
                    $data = $select->fetch();

                    $personOneAmount = 195;

                    if(isset($_POST['addNewPerson2']))
                    {
                        $personTwoAmount = 185;

                    }
                    else if(isset($_POST['addNewPerson3']))
                    {
                        $personThreeAmount = 185;

                    }
                    else if(isset($_POST['addNewPerson4']))
                    {
                        $personFourAmount = 185;

                    }
                    else if(isset($_POST['addNewPerson5']))
                    {
                        $personFiveAmount = 185;

                    }
                    else if(isset($_POST['addNewPerson6']))
                    {
                        $personSixAmount = 185;

                    }
                    $ticketAmount = $personOneAmount+$personTwoAmount+$personThreeAmount+$personFourAmount+$personFiveAmount+$personSixAmount;
                    $currentBalance = $data['balance'];
                    $remainingBalance = $data['balance'] - $ticketAmount;


                    $insert = $conn->prepare("UPDATE visitor set balance = 0  WHERE email ='$email'");
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
                        echo "Total ticket price is : "."<br/>";
                        echo "</td>";
                        echo "<td>";
                        echo  $ticketAmount."<br/>";
                        echo "</td>";
                        echo "</tr>";
                    }
                }
                if ($currentBalance<$ticketAmount)
                {
                }
            }
            echo '<th>'."".'</th>';
            echo '<th>'."Check carefully if everyting is correct  !".'</th>';
            echo "</table>";
            ?> <br> <br><br>
            <form method="POST" action="ticket.php">
                <button  type="submit" name="ticketPrice" class="btn btn-info" > Pay Now </button>
            </form>
    </div>
</div>
