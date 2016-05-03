
<!DOCTYPE html>
<?php
	ob_start( );
?>
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
                /*height:300px;*/
                margin:auto;
                text-align: center;
                color:aliceblue;
                padding-top:5px;
                padding-bottom:5px;
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
            err {
            	color: red;
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
                Email:<br>
                <input type="text" class="inpbox" placeholder="youremail@email.com" name = "EMAIL"><br>
                Password:<br>
                <input type="password" class="inpbox" placeholder="********" name="PASSWORD"><br>
                Confirm Password:<br>
                <input type="password" class="inpbox" placeholder="********" name="CPASWORD"><br>
                <input type="submit" value="Sign Up" class="sbutton" name="SUBMIT">
                
            </form>
            
		<!--PHP BEGINS HERE-->
		<?php
		  session_start( );
		  $link = mysqli_connect("Services1.mcs.sdsmt.edu", "s7229736_s16",
					 "Change_Me", "db_7229736_s16");
			if(isset($_POST['USERNAME']))
			{
		  	$user = $_POST['USERNAME'];
		  	$pass = $_POST['PASSWORD'];
      	$cpas = $_POST['CPASWORD'];
      	$email = $_POST['EMAIL'];
      
		    $checkname = mysqli_query($link, "SELECT * FROM User WHERE uName = '$user'");
		   	
		   	
		   	if(mysqli_num_rows($checkname)==0 && $user != "")
		   	{
				  $getid = mysqli_query($link,"SELECT MAX(idUser) FROM User");
				  
				  if(mysqli_num_rows($getid)!=0)
				  {
				  	$idr = mysqli_fetch_row($getid);
				  	$id = $idr[0] + 1;
				  
						if( $pass == $cpas )
					 	{  
							 $login = mysqli_query($link, "INSERT INTO User (idUser,uName,pWord,email)
							 VALUES ($id,'$user','$pass','$email')");
							 mysqli_close($link);
							 header("Location: login.php");
						}
						else
						{
							mysqli_close($link);
							echo "<p class = \"err\">Provided passwords not equal</p>";
						}
					}
					else
					{
						mysqli_close($link);
				  	echo "error";
				  }
				}
				if( $user == "" )
					echo "Enter a valid username";
				else
					echo "'$user' already exists.";
		    mysqli_close($link);	
			}
		?>
        </div>
    </body>


</html>
