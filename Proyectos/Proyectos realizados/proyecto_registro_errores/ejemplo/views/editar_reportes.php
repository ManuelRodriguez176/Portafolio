<?php

session_start();
error_reporting(0);

$validar = $_SESSION['nombre'];

if ($validar == null || $validar == '') {
    header("Location: ../includes/login.php");
    die();
}

$id = $_GET['id'];
$conexion = mysqli_connect("localhost", "root", "", "r_user");
$consulta = "SELECT * FROM reporte_errores WHERE id = $id";
$resultado = mysqli_query($conexion, $consulta);
$reporte = mysqli_fetch_assoc($resultado);

?>

<!DOCTYPE html>
<html lang="es-MX">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Editar Reporte de Errores</title>

    <link rel="stylesheet" href="../css/fontawesome-all.min.css">
    <link rel="stylesheet" href="../css/styles.css">
    <link rel="stylesheet" href="../css/es.css">
</head>

<body id="page-top">

<form action="../includes/_functions.php" method="POST" enctype="multipart/form-data">
    <div id="login">
        <div class="container">
            <div id="login-row" class="row justify-content-center align-items-center">
                <div id="login-column" class="col-md-6">
                    <div id="login-box" class="col-md-12">
                        <h3 class="text-center">Editar Reporte de Errores</h3>

                        <!-- Código Físico -->
                        <div class="form-group">
                            <label for="codigo_fisico" class="form-label">Código Físico *</label>
                            <input type="text" id="codigo_fisico" name="codigo_fisico" class="form-control" value="<?php echo $reporte['codigo_fisico']; ?>" required>
                        </div>

                        <!-- Código de Etiqueta -->
                        <div class="form-group">
                            <label for="codigo_etiqueta" class="form-label">Código de Etiqueta *</label>
                            <input type="text" id="codigo_etiqueta" name="codigo_etiqueta" class="form-control" value="<?php echo $reporte['codigo_etiqueta']; ?>" required>
                        </div>

                        <!-- Cantidad -->
                        <div class="form-group">
                            <label for="cantidad" class="form-label">Cantidad *</label>
                            <input type="number" id="cantidad" name="cantidad" class="form-control" value="<?php echo $reporte['cantidad']; ?>" required>
                        </div>

                        <!-- Caja o Unidad -->
                        <div class="form-group">
                            <label for="caja_unidad" class="form-label">Caja o Unidad *</label>
                            <input type="text" id="caja_unidad" name="caja_unidad" class="form-control" value="<?php echo $reporte['caja_unidad']; ?>" required>
                        </div>

                        <!-- Usuario -->
                        <div class="form-group">
                            <label for="usuario" class="form-label">Usuario *</label>
                            <input type="text" id="usuario" name="usuario" class="form-control" value="<?php echo $reporte['usuario']; ?>" required>
                        </div>

                        <!-- Fecha de Picking -->
                        <div class="form-group">
                            <label for="fecha_picking" class="form-label">Fecha de Picking *</label>
                            <input type="date" id="fecha_picking" name="fecha_picking" class="form-control" value="<?php echo $reporte['fecha_picking']; ?>" required>
                        </div>

                        <!-- Hora de Picking -->
                        <div class="form-group">
                            <label for="hora_picking" class="form-label">Hora de Picking *</label>
                            <input type="time" id="hora_picking" name="hora_picking" class="form-control" value="<?php echo $reporte['hora_picking']; ?>" required>
                        </div>

                        <!-- Día de Picking -->
                        <div class="form-group">
                            <label for="dia_picking" class="form-label">Día de Picking *</label>
                            <input type="text" id="dia_picking" name="dia_picking" class="form-control" value="<?php echo $reporte['dia_picking']; ?>" required>
                        </div>

                        <!-- Viaje -->
                        <div class="form-group">
                            <label for="viaje" class="form-label">Viaje *</label>
                            <input type="text" id="viaje" name="viaje" class="form-control" value="<?php echo $reporte['viaje']; ?>" required>
                        </div>

                        <!-- Fecha de Reporte -->
                        <div class="form-group">
                            <label for="fecha_reporte" class="form-label">Fecha de Reporte *</label>
                            <input type="date" id="fecha_reporte" name="fecha_reporte" class="form-control" value="<?php echo $reporte['fecha_reporte']; ?>" required>
                        </div>

                        <!-- Jefatura -->
                        <div class="form-group">
                            <label for="jefatura" class="form-label">Jefatura *</label>
                            <input type="text" id="jefatura" name="jefatura" class="form-control" value="<?php echo $reporte['jefatura']; ?>" required>
                        </div>

                        <!-- Imagen 1 -->
                        <div class="form-group">
                            <label for="imagen" class="form-label">Imagen 1 *</label>
                            <input type="file" id="imagen1" name="imagen1" class="form-control">
                            <?php if ($reporte['imagen1']): ?>
                                <img src="../uploads/<?php echo $reporte['imagen1']; ?>" alt="Imagen del reporte 1" width="100">
                            <?php endif; ?>
                        </div>

                        <!-- Imagen 2 -->
                        <div class="form-group">
                            <label for="imagen" class="form-label">Imagen 2 *</label>
                            <input type="file" id="imagen2" name="imagen2" class="form-control">
                            <?php if ($reporte['imagen2']): ?>
                                <img src="../uploads/<?php echo $reporte['imagen2']; ?>" alt="Imagen del reporte 2" width="100">
                            <?php endif; ?>
                        </div>

                        <!-- Imagen 3 -->
                        <div class="form-group">
                            <label for="imagen" class="form-label">Imagen 3 *</label>
                            <input type="file" id="imagen3" name="imagen3" class="form-control">
                            <?php if ($reporte['imagen3']): ?>
                                <img src="../uploads/<?php echo $reporte['imagen3']; ?>" alt="Imagen del reporte 3" width="100">
                            <?php endif; ?>
                        </div>

                        <!-- Botones de Guardar y Cancelar -->
                        <div class="form-group">
                            <input type="hidden" name="accion" value="editar_reporte_error">
                            <input type="hidden" name="id" value="<?php echo $id; ?>">
                            <button type="submit" class="btn btn-success">Guardar Cambios</button>
                            <a href="reporte_errores.php" class="btn btn-danger">Cancelar</a>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</form>

</body>
</html>
