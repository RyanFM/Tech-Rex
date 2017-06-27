<script type="text/javascript">
    function showAndHidden(){
        var div1=document.getElementById("campingYesNo");
        var div2=document.getElementById("ticket_type");
        if(div1.style.display=='none' && div2.value=="Weekend Ticket" ) div1.style.display='inline';
        else div1.style.display='none';


    }

</script>

<div style="width:550px ; align-self: center; height:auto; margin: 0 auto ">
    <div style="">

        <h1> BUY A TICKET </h1>
        <form  method="POST" style="align-self: center"  class="subscribe-form form-inline" action="profile.php">
            First Name: <input type="text" name="first_name" placeholder="First Name" required class="form-control input-lg"><br>
            Last Name: <input type="text" name="last_name" placeholder="Last Name" required class="form-control input-lg"><br>
            Email: <input type="text" name="email" placeholder="example@example.com" required class="form-control input-lg"><br>
            Date of Birth:<input type="year" name="dob" placeholder="Date of Birth" required class="form-control input-lg"><br>

            Password:<input type="password" name="pass" placeholder="**********" required class="form-control input-lg"><br>
            <!-- <input type="number" name="balance" placeholder="Balance minimum €255" min="250" required class="form-control input-lg"><br>
-->
            Ticket Type:<select  id ="ticket_type" name="ticket_type" required class="form-control input-lg" onchange="showAndHidden()">
                <option selected disabled hidden> --Choose your ticket-- </option>
                <option value="Weekend Ticket">Whole weekend Ticket</option>
                <option value="Friday Ticket">Friday Ticket</option>
                <option value="Saturday Ticket">Saturday Ticket</option>

            </select>
            <select  id ="campingYesNo" name="CampOption" required class="form-control input-lg" style="display: none">
                <option selected disabled hidden> --Do you want camping? -- </option>
                <option value="Yes">Yes</option>
                <option value="No">No</option>
            </select>
            <br>
            <br>
            <button type="submit" name = "signup" class="btn btn-info">SIGN UP </button>
        </form>

    </div>
</div>
<div style="width:500px ; float:right; height:600px;">
    <div style="padding:85px;padding-right:200px;">

        <h1>SIGN IN </h1>
        <form method="POST" action="profile.php">
            <input type="text" name="email" placeholder="example@example.com" required class="form-control input-lg"><br>
            <input type="text" name="pass" placeholder="**********" required class="form-control input-lg"><br>

            <button type="submit" name="login" class="btn btn-info">LOG IN </button>

    </div>
</div>

