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
        <form method= "POST">
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
    <?php
    
	  $link = mysqli_connect( "Services1.mcs.sdsmt.edu",
	  "s7229736_s16", "Change_Me", "db_7229736_s16" );
	  if(isset($_POST["EDIT"]))
    {
    	mysqli_close($link);
    	header("Location: editprofile.php");
    }
	  $user = $_SESSION["USERID"];
	  $uname = $_SESSION["USER"];
	  if( isset($_SESSION["FRIEND"]) )
	  {
	  	$pick = $_SESSION["FRIEND"];
	  }
	  else
	  {
	  	$pick = $user;
	  }
	  
	  $profile = mysqli_query( $link , "SELECT * FROM Profile WHERE User_idUser = $pick");
	  if( $profile )
	  {
	  	$row = mysqli_fetch_row($profile);
	  	$fname = $row[1];
	  	$lname = $row[2];
	  	$fgame = $row[3];
	  	$hscore = $row[4];
	  	$lkgame = $row[5];
	  	echo 'Name: ' . $fname . ' ' . $lname . '<br>';
	  	echo 'Favorite Game: ' . $fgame . '<br>';
	  	echo 'High Score: ' . $hscore . '<br>';
	  	echo 'Other Games ' . $fname . ' Enjoys: ' . $lkgame . '<br>';
	  }
	  else
	  {
	  	if( $user == $pick )
	  	header("Location: editprofile.php");
	  }
	  if( $user == $pick )
	  {
	  	echo '<form method=POST ><input type="submit" value="Edit Profile" ' .
	  		' class=sbutton name="EDIT"></input></form>';
	  }
	  
    ?>
    </div>
    <div class="footbar">
    </div>
</body>
</html>
