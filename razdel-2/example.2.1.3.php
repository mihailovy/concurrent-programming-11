<?php

if (isset($_REQUEST['a']) and isset($_REQUEST['b']) ) {
  $a = $_REQUEST['a'];
  $b = $_REQUEST['b'];
  if (isset($_REQUEST['operation'])) {
    $op = $_REQUEST['operation'];
    if ($op = "plus") {
      $out = $a + $b;
    } elseif($op == "minus") {
      $out = $a - $b;
    } else {
      $out = "Error: Unknown operation!";
    }
  }
} else {
  $out = "Error: no parameters a and b given!";
}
echo ($out);
