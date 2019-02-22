
<?php

echo'hello world';
// echo'</br> hello ','world';
/*echo('</br>hello&nbspworld'); */

//variables:
$x = 12; //integer
$y = 3.5; //float
$z = 3; //integer
$name = "Mona"; //String
$t = false;
$k=1;

echo "</br>", $name;
echo "</br>",$x;


if($x<$y)
echo "</br> yes";
else
echo "</br> No";
//If
$resu = $y == 3.5 ? '</br> yes' : '</br>No';
echo $resu;



switch ($y) {
  case $y == 6:
    echo '</br> it is 6';
    break;

    case $y == 7:
      echo '</br> it is 7';
      break;

  default: 
    echo '</br> none';
    break;
}

//AND: if the two is true will do it , if one of them is false he's gonna ignore it
if ($x==12 and $y==2)
echo '</br> yes'; 

if ($x==12 and $y==3.5)
echo '</br> No'; 


if ($x==12 || $y==2)
echo '</br> yes';

if ($x==6 || $y==5)
echo '</br> No'; 


if ($x==12 xor $y==3.5)
echo '</br> yes';

if ($x==12 xor $y==5)
echo '</br> No'.'</br>'; 



//while loop :
/*while($k<=10){
  echo '</br>'.$k;
  $k++; }
*/

//Do:
/*do{
echo '</br>'.$k;
$k++;
}
while($k<=10);
*/
//for:
for($i =1; $i <=10; $i++){
  echo $i.'</br>';
}


$arr = array('1','2','3');
foreach ($arr as $key =>$value) {
  echo $key.'='.$value.'</br>';
}






if($_POST){
  $name = $_POST['AN'];
  $cname = $_POST['CN'];
  echo 'Anime name is: '.$name.'</br>
       Charecter name is: '.$cname.'</br>';
}


 ?>
 <form action='' method='post'>
   <!--method just have : get *to get information* , post *to send information*-->
<h3>propose a character</h3>
  Anime Name:<input type="text" name="AN">
  <br></br>
  Character Name:<input type="text" name="CN">
  <br></br>

<input type="submit" name="Do it" value="Do it">
<br></br>

</form>