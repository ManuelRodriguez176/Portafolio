<?php
if(isset($_POST['registrar'])) {
    $usuario = $_POST['usuario'];
    $viaje = $_POST['viaje'];
    $cantidad = $_POST['cantidad'];
    $fecha_reporte = $_POST['fecha_reporte'];
    $sku1 = $_POST['sku1'];
    $fecha_incidente = $_POST['fecha_incidente'];
    $sku2 = $_POST['sku2'];
    $unidad_medida = $_POST['unidad_medida'];
    $jefatura = $_POST['jefatura'];
    $mes = $_POST['mes'];

    // Para procesar las imágenes
    $imagen1 = $_FILES['imagen1']['name'];
    $imagen2 = $_FILES['imagen2']['name'];
    $imagen3 = $_FILES['imagen3']['name'];

    // Subir las imágenes a una carpeta del servidor
    move_uploaded_file($_FILES['imagen1']['tmp_name'], "../imgs/".$imagen1);
    move_uploaded_file($_FILES['imagen2']['tmp_name'], "../imgs/".$imagen2);
    move_uploaded_file($_FILES['imagen3']['tmp_name'], "../imgs/".$imagen3);

    // Insertar datos en la base de datos
    $conexion = mysqli_connect("localhost", "root", "", "r_user");
    $query = "INSERT INTO reporte_errores (usuario, viaje, cantidad, fecha_reporte, sku1, fecha_incidente, sku2, unidad_medida, imagen1, imagen2, imagen3, jefatura, mes)
              VALUES ('$usuario', '$viaje', '$cantidad', '$fecha_reporte', '$sku1', '$fecha_incidente', '$sku2', '$unidad_medida', '$imagen1', '$imagen2', '$imagen3', '$jefatura', '$mes')";
    
    mysqli_query($conexion, $query);

    // Redirigir o mostrar mensaje de éxito
    header("Location: ../views/registros_errores.php");
}
?>
