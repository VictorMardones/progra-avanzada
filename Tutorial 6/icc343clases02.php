<html>
<head>
</head>
<body>
<?php
include_once "class.Ambiente.php";

$amb = new Ambiente(1000, 800);
$amb->generaEntesAlAzar(50, "#33AA44");
$amb->generaEntesAlAzar(1, "#AA3344");

for ($k = 0; $k < 100; $k++) {
    echo "\n";
    echo '<div id="amb_'.$k.'" style="display:none">';
    echo $amb->vistaSVG();
    echo "\n</div>'";
    $amb->mueve();
}
?>
<script>
    var actual = 0;
    function muestraSiguiente() {
        var nuevo = (actual == 99) ? 0 : (actual + 1); // operador  condicional terciario
        console.log(nuevo);
        document.getElementById("amb_" + actual).style.display = "none";
        document.getElementById("amb_" + nuevo).style.display = "";
        actual = nuevo;
        setTimeout(muestraSiguiente, 300);
    }
    muestraSiguiente();
</script>
</body>
</html>