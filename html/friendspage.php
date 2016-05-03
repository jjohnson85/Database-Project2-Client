<!DOCTYPE html>
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
          div.friendswrapper {
              width:auto;
              height:1000px;
              background-color:aliceblue;
              padding: 5px;
              margin-left: 0px;
              margin-top: 5px;
	      font-size: 20px;
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
	  div.request {
	      width:300px;
              height:25px;
	      border-style: groove;
	      margin-top: 5px;
	      background-color:white;
	  }
	  div.head {
	      width:auto;
	      height:auto;
	      font-size: 36px;
              background-color: aliceblue;
	  }
      </style>     
  </head>
<body>   
    <div class="hdiv">
        MyBook
    </div>
    <div class="menudiv">
        <form method="post">
            <input type="submit" value="My Profile" class="menubtn">
            
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
    <div class="friendswrapper">
	<div class="head">All Your Friends</div>
	<?php
	  $link = mysqli_connect( "Services1.mcs.sdsmt.edu",
	  "s7229736_s16", "Change_Me", "db_7229736_s16" );
	  
	  $self = $_SESSION['USERID'];

	  $query = mysqli_query( $link, "SELECT M.uName FROM User AS M JOIN Friends
				 ON M.idUser = User_idUserMain JOIN User AS F
				 ON User_idUserFriend = F.idUser WHERE F.idUser 
				 = $self GROUP BY M.uName" );
	   
	  while( $row = mysqli_fetch_row($query) )
	  {
		echo "<div class = friend>".$row[0]."</div>";
	  }
	?>

	<div class="head">Requests</div>
	<?php
	$request = mysqli_query( $link, "SELECT uName, dReq, User_idUserFrom
					 FROM `Friend Request`
					JOIN User ON User_idUserFrom = idUser
					WHERE User_idUserTo = $self");

	while( $row = mysqli_fetch_row($request) )
	{
		echo "<div class='request'>";
		echo "User: ".$row[0];
		echo " Date:".$row[1];
		echo "</div>";
		echo "<form method='get'>";
		echo "<input type='submit' value='accept' name='accept'>";
		echo "</input>";
		echo "<input type='hidden' value='".$row[2]."' name='accepted'>";
		echo "</input></form>";
		echo "<form method='get'>";
		echo "<input type='submit' value='decline' name='decline'>";
		echo "</input>";
		echo "<input type='hidden' value='".$row[2]."' name='declined'>";
		echo "</input></form>";
	}

	if(isset($_GET['accepted']))
	{
		$other = $_GET['accepted'];
		$acceptqry = mysqli_query( $link, "INSERT INTO Friends( User_idUserMain
		,User_idUserFriend ) VALUES( $self, $other )");
		$acceptqry = mysqli_query( $link, "INSERT INTO Friends( User_idUserMain
		,User_idUserFriend ) VALUES( $other, $self )");
		$removereq = mysqli_query( $link, "DELETE FROM `Friend Request` WHERE
		User_idUserFrom = $other AND User_idUserTo = $self"); 
		header( "Location: friendspage.php" );
		exit( );
	}
	
	if(isset($_GET['declined']))
	{
		$removereq = mysqli_query( $link, "DELETE FROM `Friend Request` WHERE
		User_idUserFrom = $other AND User_idUserTo = $self"); 
		header( "Location: friendspage.php" );
		exit( );
	}
	?>
	<div class="head">Make Friend Request</div>
	To request a friend input their username here
	<form method="post">
		<input type='text' name='reqfriend'>
		</input>
		<input type='submit' value='Request'>
		<?php
			if( isset($_POST['reqfriend']))
			{
				$usertoname = $_POST['reqfriend'];
				$request = mysqli_prepare( $link, "INSERT INTO
				`Friend Request`( dReq, idReq, User_idUserTo,
				User_idUserFrom) VALUES( NOW(), ?, ?, ? )" );
				mysqli_stmt_bind_param( $request, "iii", $id,
				$userto, $userfrom);
				$idget = mysqli_query( $link, "SELECT MAX(idReq) FROM
				`Friend Request`");
				$idrow = mysqli_fetch_row( $idget );
				$id = $idrow[0]+1;
				$usertoget = mysqli_query( $link, "SELECT idUser FROM
				User WHERE uName = '$usertoname'");
				$userrow = mysqli_fetch_row( $usertoget );
				$userto = $userrow[0];
				$userfrom = $self;
				mysqli_stmt_execute($request);
				header('Location: friendspage.php');			
			}
		?>
		</input>
	</form>
    </div>
    <div class="footbar">
    </div>
</body>
</html>
