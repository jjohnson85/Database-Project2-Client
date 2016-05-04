<!DOCTYPE html>
<?php
	ob_start( );
?>
<html>
  <head>
      <!-- INTERNAL CSS GOES HERE IN THE HEAD -->
      <style>
          body{
              background-color:white;
              width:auto;
              height:auto;
              margin:0px;
          }
          div.hdiv {
              background-color: cornflowerblue;
              width: auto;
              height: 80px;
              padding: 10px;
              margin-bottom: 5px;
              color:white;
              font-size:64px;
              text-shadow: 5px 5px 5px #888888;
              box-shadow: 2px 2px 2px #888888;
              transition: transform 2s;
          }
          div.hdiv:hover{
            transform:rotate(180deg);
          }
          div.menudiv {
              width: auto;
              height: 25px;
              padding: 0px;
              background-color: royalblue;
              box-shadow: 2px 2px 2px #888888; 
          }
          div.profilewrapper {
              width:auto;
              /*height:1000px;*/
              background-color:aliceblue;
              padding: 5px;
              margin-left: 0px;
              margin-top: 5px;
          }
          div.footbar {
              width:auto;
              height:50px;
              background-color:cornflowerblue;
          }
          input.menubtn {
              width:100px;
              height:25px;
              border-style:hidden;
              background-color:aliceblue;
              
          }
          .inpbox{
                width:500px;
                height:20px;
                border-radius: 5px;
          }
          .sbutton {
                background-color: royalblue;
                color: white;
                font-size: 15px;
                border-radius: 5px;
                border-style:hidden;
                height: 30px;
                width: 100px;
                margin-top: 5px;
            }
      </style>     
  </head>
<body>   
    <div class="hdiv">
        MyBook
    </div>
    <div class="menudiv">
        <form method="POST">
            <input type="submit" value="My Profile" class="menubtn" name="profile">
            <?php
			if(isset($_POST['profile']))
			{
				header( 'Location: profile.php');
			}
		?>
            </input>
            <input type=submit value="Friends" class="menubtn" name="friendspage">
        	<?php
			if(isset($_POST['friendspage']))
			{
				header( 'Location: friendspage.php');
			}
		?>
            </input>
            <input type=submit value="Home" class="menubtn" name="homepage">
		<?php
			if(isset($_POST['homepage']))
			{
				header( 'Location: main.php');
			}
		?>
            </input>
            <input type="submit" value="Logout" class="menubtn" name="logout">
                <!--Logout here with php stuff and redirect to login page-->
		<?php
			if(isset($_POST['logout']) )
			{
				session_destroy( );
				header( 'Location: login.php');
				exit();
			}
		?>
            </input>
        </form>
        
    </div>
    <div class="profilewrapper">
    <form method="POST">
    <?php
    	$link = mysqli_connect( "Services1.mcs.sdsmt.edu",
	  			"s7229736_s16", "Change_Me", "db_7229736_s16" );
	  		$user = $_SESSION["USERID"];
	  		
	  		$profile = mysqli_query($link, "SELECT * FROM Profile WHERE User_idUser = $user" );
	  		if( !$profile )
	  			echo "Why why why<br>";
	  			
	  		if( !isset($_POST["UPDATE"]) && mysqli_num_rows($profile) != 0)
	  		{
	  			$tmprow = mysqli_fetch_row($profile);
	  			$fname=$tmprow[1];
	  			$lname=$tmprow[2];
	  			$fgame=$tmprow[3];
	  			$hscore=$tmprow[4];
	  			$lkgame=$tmprow[5];
	  		}
	  		else
	  		{
	  			$fname = $_POST["FNAME"];
	  			$lname = $_POST["LNAME"];
	  			$fgame = $_POST["FGAME"];
	  			$hscore = $_POST["HSCORE"];
	  			$lkgame = $_POST["OGAMES"];
	  		}
	  		
	  		echo 'First name:<br>';
        echo '<input type=text value="' . $fname . '" class=inpbox name="FNAME"><br>';
      	echo 'Last name:<br>';
      	echo '<input type=text value="' . $lname . '" class=inpbox name="LNAME"><br>';
      	echo 'Favorite Game:<br>';
      	echo '<input type=text value="' . $fgame . '" class=inpbox name="FGAME"><br>';
      	echo 'High Score:<br>';
      	echo '<input type=text value="'. $hscore . '" class=inpbox name="HSCORE"><br>';
      	echo 'Other Games You Enjoy (separate by commas):<br>';
      	echo '<input type=text value="' . $lkgame . '" class=inpbox name="OGAMES"><br>';
      	echo '<input type=submit value="Update" class=sbutton name="UPDATE">';
      
      	
    	if( isset($_POST["UPDATE"]) )
    	{
	  		
	  		if( mysqli_num_rows($profile) == 0 )
	  		{
	  		 	
	  			$getprofileid = mysqli_query($link, "SELECT MAX(idProfile) FROM Profile");
	  			$tmprow = mysqli_fetch_row($getprofileid);
	  			$id = $tmprow[0] + 1;
	  			echo "INSERT INTO Profile(idProfile,fName,lName,fGame
	  				,hScore,lkGame,User_idUser) VALUES ($id,'','','',0,'',$user)";
	  			$flag = mysqli_query( $link,"INSERT INTO Profile(idProfile,fName,lName,fGame
	  				,hScore,lkGame,User_idUser) VALUES ($id,'','','',0,'',$user)");
	  			if(!$flag)
	  				echo "Insert failed";
	 			}
	 			$flag = mysqli_query( $link, "UPDATE Profile SET fName='$fname',
	 				lName='$lname',fGame='$fgame',hScore=$hscore,lkGame='$lkgame' WHERE
	 				User_idUser=$user");
	 			if(!$flag)
	 				echo "Update failed.";
	 			unset ($_SESSION['ENTER']);
				session_unregister($ENTER);
				mysqli_close($link);
				header("Location: profile.php");
	 		}
	 			
    ?>
   
      	</form>
    </div>
    <div class="footbar">
    </div>
</body>
</html>
