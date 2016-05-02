<!--Php here for include('session.php')-->
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
          div.menubox {
              width:100px;
              height:25px;
              float:left;
              border-right-style:groove;
              border-right-width: 2px;
              background-color: aliceblue;
          }
          div.friendbox {
              width:250px;
              height:15px;
              max-height:500px;
              padding:5px;
              background-color: cornflowerblue;
              border-right-style:groove;
              border-right-width: 2px;
              margin-top: 5px;
              float:left;
              transition: height 2s;
              overflow: hidden;
          }
          div.friendbox:hover{
              height: 500px;
          }
          .friend {
              width:240px;
              height:auto;
              margin-top:5px;
              margin-bottom:5px;
	      border-radius:1px;
	      font-size:24px;
              background-color: aliceblue;
          }
          div.postbox {
              width:auto;
              height:auto;
              background-color:aliceblue;
              padding: 5px;
              margin-left: 0px;
              margin-top: 5px;
          }
	  div.sub_postbox{
              width:auto;
	      height:auto;
	      position:static;
	      background-color:aliceblue;
	      margin-left:260px;
	  }
          div.post {
              width:auto;
	      height:auto;
	      background-color:white;
              margin-bottom: 20px;
	      margin-left: 2px;
	      padding: 5px;
	      word-wrap: break-word;
	      border-style: groove;
          }
	  .make_post {
	      width: 500px;
	      height: 100px;
              background-color:white;
	      margin-top: 10px;
	      margin-left: 2px;

	  }
          div.reply{
              
              
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
      </style>     
  </head>
<body>   
    <div class="hdiv">
        MyBook
	<?php
		echo $_SESSION['USER'];
	?>
    </div>
    <div class="menudiv">
        <form method="post">
            <input type="submit" value="My Profile" class="menubtn">
            
            </input>
            <input type=submit value="Friends" class="menubtn">
        
            </input>
            <input type=submit value="Home" class="menubtn">
        
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
    <div class="friendbox">
       Your Friends<br>
        <!-- PHP Query and gen html for friends here-->
        <!-- use data from login session include('session.php')-->
        <!-- PHP wil echo the friend divs filled with that friends info-->
	<?php
	  $link = mysqli_connect( "Services1.mcs.sdsmt.edu",
	  "s7229736_s16", "Change_Me", "db_7229736_s16" );
	  
	  $friend = $_SESSION['USERID'];

	  $query = mysqli_query( $link, "SELECT M.uName FROM User AS M JOIN Friends
				 ON M.idUser = User_idUserMain JOIN User AS F
				 ON User_idUserFriend = F.idUser WHERE F.idUser 
				 = $friend GROUP BY M.uName" );
	   
	  while( $row = mysqli_fetch_row($query) )
	  {
		echo "<div class = friend>".$row[0]."</div>";
	  }
	?>


    </div>
    <div class="postbox">
      <div class="sub_postbox">
	  Friends Posts
	  <!-- List posts here, post's must be made by friends -->
	  <?php
	 
	  //Query gets all your friends Posts 
	  $postquery = mysqli_query($link, "SELECT tstamp, likes, txt, uName, idPost FROM
	  Post JOIN User ON idUser = User_idUser JOIN (SELECT User_idUserFriend FROM Friends
	  WHERE User_idUserMain = $friend) AS F ON User_idUser = F.User_idUserFriend
	  ORDER BY tstamp DESC LIMIT 10"); 


	  if($postquery)
	    while( $row = mysqli_fetch_row($postquery))
	    {

		echo '<div class = "post">';
		echo 'Post Made On: ' . $row[0] . ' By: ' . $row[3];
		echo '<br>';  
		echo $row[2];
		echo '<br>';
		echo $row[1] . ' Likes';
		echo '<br><form method="get"><input type="submit" value="Like"
		     name="like"></input><input type=
		     "hidden" name="liked" value="'. $row[4] . '"</input></form>';
		echo '</div>';
	
		
	   }

	   if($_GET['liked'])
	   {
	      $postid = $_GET['liked'];
              $likeqry = mysqli_query($link, "UPDATE Post SET likes =
		 likes+1 WHERE idPost='$postid'");
	      header( 'Location: main.php');
	      exit( );
	   }
	  ?>

	</div>
	<div class="sub_postbox">
	My Posts
	<?php
	$postquery = mysqli_query($link, "SELECT tstamp, likes, txt, uName, idPost FROM
	Post JOIN User ON idUser = User_idUser WHERE idUser = $friend ORDER BY tstamp DESC
	LIMIT 10");
	
	if($postquery)
	    while( $row = mysqli_fetch_row($postquery))
	    {

		echo '<div class = "post">';
		echo 'Post Made On: ' . $row[0] . ' By: ' . $row[3];
		echo '<br>';  
		echo $row[2];
		echo '<br>';
		echo $row[1] . ' Likes';
		echo '<br><form method="get"><input type="submit" value="Like"
		     name="like"></input><input type=
		     "hidden" name="liked" value="'. $row[4] . '"</input></form>';
		echo '</div>';
	
		
	   }

	?>
                <form id="post_form" method="get" >


		<!--End post listing-->

		<form id="post_form" method="get" >
			<textarea class = "make_post" name ="textpost" cols='100' rows='10' >

			</textarea>

			<input type="submit" value="Post" name="inppost" >

			</input>
		</form>

	   <?php
		if(isset($_GET['textpost']))
		{
		$pstmt = mysqli_prepare( $link, "INSERT INTO Post( idPost, tStamp, likes,
						 txt, User_idUser ) VALUES( ?, NOW(), ?, ?, ?)");
		mysqli_stmt_bind_param( $pstmt, "iisi", $id, $likes, $text, $user );
		$idget = mysqli_query( $link, "SELECT MAX(idPost) FROM Post");
		$idrow = mysqli_fetch_row( $idget );
		$id = $idrow[0]+1;	
		$likes = 0;
		$text = $_GET['textpost'];
		$user = $_SESSION['USERID'];	
		mysqli_stmt_execute($pstmt);
		header('Location: main.php');
		exit();
		}
	   ?>
	</div>
    </div>
    <div class="footbar">
        Copyright © 2010 by lulwut inc.
    </div>
</body>
</html>
