<!--Php here for include('session.php')-->
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
              margin-right: 5px;
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
              height:1000px;
              background-color:aliceblue;
              padding: 5px;
              margin-left: 0px;
              margin-top: 5px;
          }
          div.post {
              
              
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
        <form>
            <input type="submit" value="My Profile" class="menubtn">
            
            </input>
            <input type=submit value="Friends" class="menubtn">
        
            </input>
            <input type=submit value="Home" class="menubtn">
        
            </input>
            <input type="submit" value="Logout" class="menubtn">
                <!--Logout here with php stuff and redirect to login page-->
            </input>
        </form>
    </div>
    <div class="friendbox">
       ONLINE FRIENDS GO HERE<br>
        <!-- PHP Query and gen html for friends here-->
        <!-- use data from login session include('session.php')-->
        <!-- PHP wil echo the friend divs filled with that friends info-->
	<?php
	  $link = mysql_connect( "Services1.mcs.sdsmt.edu", "s7229736_s16", "Change_Me");

	  mysql_select_db("db_7229736_s16");

	  $friend = $_SESSION['USERID'];

	  $query = mysql_query("SELECT M.uName FROM User AS M JOIN Friends
				 ON M.idUser = User_idUserMain JOIN User AS F
				 ON User_idUserFriend = F.idUser WHERE F.idUser 
				= $friend GROUP BY M.uName");
	  
	  if($query)
	    while( $row = mysql_fetch_row($query))
	    {
	  	  for( $i=0; $i< mysql_num_fields($query); $i++ )
		  {
			  echo '<div class = "friend">';
		     	  echo $row[$i];
			  echo '</div>';
		  }
	    }
	
	?>
        <div class="friend">
        FRIEND
        </div>
        <div class="friend">
        FRIEND 2
        </div>
        <form action="friendspage.php">
            <input type="submit" name="Friends" class="menubtn" value="More...">
            
            </input>
        </form>
    </div>
    <div class="postbox">
        POSTS GO HERE
    </div>
    <div class="footbar">
        Copyright © 2010 by lulwut inc.
    </div>
</body>
</html>
