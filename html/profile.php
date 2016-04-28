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
          div.profilewrapper {
              width:auto;
              height:1000px;
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
      </style>     
  </head>
<body>   
    <div class="hdiv">
        MyBook
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
    <div class="profilewrapper">
        Profile stuff here
    </div>
    <div class="footbar">
        Copyright © 2010 by lulwut inc.
    </div>
</body>
</html>