
<!DOCTYPE html>
<html>
    <head>
        <!--CSS GOES HERE-->
        <style>
            body {
                background-color: white;
            }
            div.loginbox{
                background-color:cornflowerblue;
                width:500px;
                height:300px;
                margin:auto;
                text-align: center;
                color:aliceblue;
                padding-top:5px;
                margin-top: 100px;
                align-self: center;
                box-shadow: 2px 2px 10px #888888;
                border-radius: 10px;
            }
            .sbutton {
                background-color: aliceblue;
                border-radius: 10px;
                border-style:hidden;
                height: 50px;
                width: 200px;
                margin-top: 5px;
            }
            div.loginheader {
                width:490px;
                height:50px;
                margin-left:5px;
                border-radius: 5px;
                margin-bottom:40px;
                text-align: left;
                font-size: 40px;
                text-shadow:  5px 5px 10px black;
                background-color: royalblue;
            }
            .inpbox{
                width:200px;
                height:20px;
                border-radius: 5px;
            }
            .inpform {
                font-size:20px;
                text-shadow:  2px 2px 10px black;
            }
        </style>
    </head>
    <body>
        <div class="loginbox" >
            <div class="loginheader">
                MyBook
            </div>


            <form class="inpform" method="post">

                Username:<br>
                <input type="text" class="inpbox" placeholder="Hello World" name="USERNAME"><br>
                Password:<br>
                <input type="password" class="inpbox" placeholder="********" name="PASSWORD"><br>
                <input type="submit" value="Login" class="sbutton" name="SUBMIT">
            </form>
		<!--PHP BEGINS HERE-->
		<?php
		  session_start( );
		  $link = mysqli_connect("Services1.mcs.sdsmt.edu", "s7229736_s16",
					 "Change_Me", "db_7229736_s16");
		  $user = $_POST['USERNAME'];
		  $pass = $_POST['PASSWORD'];

	          $login = mysqli_query($link, "SELECT uName, idUser FROM
						 User WHERE uName='$user' AND pWord='$pass'");
		
		  if(mysqli_num_rows($login)==0)
		  {
		    echo "invalid username or password";
		  }
		  else
		  {
		    $row = mysqli_fetch_row($login);
		    $_SESSION["USER"] = $row[0];
		    $_SESSION["USERID"] = $row[1];
		    header('Location: main.php');
		  }

		  mysqli_close($link);
		?>
        </div>
    </body>


</html>
