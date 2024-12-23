<?php

require_once ("_db.php");

if (isset($_POST['accion'])) { 
    switch ($_POST['accion']) {
        // Casos de registros
        case 'editar_registro':
            editar_registro();
            break;

        case 'eliminar_registro':
            eliminar_registro();
            break;

        case 'acceso_user':
            acceso_user();
            break;

        case 'editar_reporte_error':  // Caso para editar el reporte de errores
            editar_reporte_error();
            break;

        case 'eliminar_reporte_error':  // Caso para eliminar el reporte de errores
            eliminar_reporte_error();
            break;
    }
}

function editar_registro() {
    $conexion = mysqli_connect("localhost", "root", "", "r_user");
    extract($_POST);
    $consulta = "UPDATE user SET nombre = '$nombre', correo = '$correo', telefono = '$telefono',
                password = '$password', rol = '$rol' WHERE id = '$id' ";

    mysqli_query($conexion, $consulta);
    header('Location: ../views/user.php');
}

function eliminar_registro() {
    $conexion = mysqli_connect("localhost", "root", "", "r_user");
    extract($_POST);
    $id = $_POST['id'];
    $consulta = "DELETE FROM user WHERE id = $id";

    mysqli_query($conexion, $consulta);
    header('Location: ../views/user.php');
}

function acceso_user() {
    $nombre = $_POST['nombre'];
    $password = $_POST['password'];
    session_start();
    $_SESSION['nombre'] = $nombre;

    $conexion = mysqli_connect("localhost", "root", "", "r_user");
    $consulta = "SELECT * FROM user WHERE nombre='$nombre' AND password='$password'";
    $resultado = mysqli_query($conexion, $consulta);
    $filas = mysqli_fetch_array($resultado);

    if ($filas['rol'] == 1) {  // Admin
        header('Location: ../views/user.php');
    } else if ($filas['rol'] == 2) {  // Lector
        header('Location: ../views/lector.php');
    } else {
        header('Location: login.php');
        session_destroy();
    }
}

function editar_reporte_error() {
    $conexion = mysqli_connect("localhost", "root", "", "r_user");
    extract($_POST);

    // Manejo de las imágenes
    $imagen1 = $_FILES['imagen1']['name'];
    $imagen1_temp = $_FILES['imagen1']['tmp_name'];
    $imagen2 = $_FILES['imagen2']['name'];
    $imagen2_temp = $_FILES['imagen2']['tmp_name'];
    $imagen3 = $_FILES['imagen3']['name'];
    $imagen3_temp = $_FILES['imagen3']['tmp_name'];

    // Verifica si cada imagen ha sido cargada, si no, mantiene la imagen anterior
    if (!empty($imagen1)) {
        $imagen1_destino = "../uploads/" . $imagen1;
        move_uploaded_file($imagen1_temp, $imagen1_destino);
    } else {
        $imagen1 = $_POST['imagen1_actual'];
    }

    if (!empty($imagen2)) {
        $imagen2_destino = "../uploads/" . $imagen2;
        move_uploaded_file($imagen2_temp, $imagen2_destino);
    } else {
        $imagen2 = $_POST['imagen2_actual'];
    }

    if (!empty($imagen3)) {
        $imagen3_destino = "../uploads/" . $imagen3;
        move_uploaded_file($imagen3_temp, $imagen3_destino);
    } else {
        $imagen3 = $_POST['imagen3_actual'];
    }

    // Actualiza el reporte de errores
    $consulta = "UPDATE reporte_errores SET 
                    codigo_fisico='$codigo_fisico', 
                    codigo_etiqueta='$codigo_etiqueta', 
                    cantidad='$cantidad', 
                    caja_unidad='$caja_unidad', 
                    usuario='$usuario', 
                    fecha_picking='$fecha_picking', 
                    hora_picking='$hora_picking', 
                    dia_picking='$dia_picking', 
                    viaje='$viaje', 
                    fecha_reporte='$fecha_reporte', 
                    jefatura='$jefatura', 
                    imagen1='$imagen1', 
                    imagen2='$imagen2', 
                    imagen3='$imagen3' 
                WHERE id=$id";

    mysqli_query($conexion, $consulta);
    header('Location: ../views/reporte_errores.php');
}

function eliminar_reporte_error() {
    $conexion = mysqli_connect("localhost", "root", "", "r_user");
    $id = $_POST['id'];
    $consulta = "DELETE FROM reporte_errores WHERE id = $id";
    mysqli_query($conexion, $consulta);
    header('Location: ../views/reporte_errores.php');
}

?>







