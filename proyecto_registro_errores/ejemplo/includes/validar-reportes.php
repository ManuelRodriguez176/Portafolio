<?php

$conexion=mysqli_connect("localhost","root","","r_user"); 

if (
    isset($_POST["viaje"]) && !empty($_POST["viaje"]) &&
    isset($_POST["fecha_reporte"]) && !empty($_POST["fecha_reporte"]) &&
    isset($_POST["fecha_picking"]) && !empty($_POST["fecha_picking"]) &&
    isset($_POST["hora_picking"]) && !empty($_POST["hora_picking"]) &&
    isset($_POST["medida_unitaria"]) && !empty($_POST["medida_unitaria"])&& 
    isset($_POST["cantidad"]) && !empty($_POST["cantidad"])&&
    isset($_POST["imagen1"]) && !empty($_POST["imagen1"])&&
    isset($_POST["imagen2"]) && !empty($_POST["imagen2"])&&
    isset($_POST["imagen3"]) && !empty($_POST["imagen3"])&&
    isset($_POST["mes"]) && !empty($_POST["mes"])&&
    isset($_POST["usuario"]) && !empty($_POST["usuario"])&&
    isset($_POST["jefatura"]) && !empty($_POST["jefatura"]) 
) {

    $viaje = $_POST["viaje"];
    $fecha_reporte = $_POST["fecha_reporte"];
    $fecha_picking = $_POST["fecha_picking"];
    $hora_picking = $_POST["hora_picking"];
    $medida_unitaria = $_POST["medida_unitaria"];
    $cantidad = $_POST["cantidad"];
    $mes = $_POST["mes"];
    $usuario = $_POST["usuario"];
    $jefatura = $_POST["jefatura"];


    if (isset($_POST["selImg"]) && !empty($_POST["selImg"])) {
		$imagen1 = $_POST["selImg"];
	} else {
		$imagen1 = '';
	}

    
    if (isset($_POST["selImg"]) && !empty($_POST["selImg"])) {
		$imagen2 = $_POST["selImg"];
	} else {
		$imagen2 = '';
	}

    
    if (isset($_POST["selImg"]) && !empty($_POST["selImg"])) {
		$imagen3 = $_POST["selImg"];
	} else {
		$imagen3 = '';
	}

    $sql = "INSERT INTO reportes (viaje, fecha_reporte, fecha_picking, hora_picking,
     medida_unitaria, cantidad, imagen1, imagen2, imagen3, mes, usuario, jefatura)
    VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

    if ($statement = mysqli_prepare($conexion, $sql)) {

        mysqli_stmt_bind_param($statement, "ssssss", $viaje, $fecha_reporte, $fecha_picking, $hora_picking,
        $medida_unitaria,$cantidad, $imagen1, $imagen2, $imagen3,$mes,$usuario,$jefatura);

        if (mysqli_stmt_execute($statement)) {
      header('Location: ../views/registros.php');

        } else {
            echo "No se pudo realizar la accion";
        }
        mysqli_stmt_close($statement);
    }

    mysqli_close($conexion);
} else {
?>
<?php  } ?>
