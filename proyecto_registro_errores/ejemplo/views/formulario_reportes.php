<!DOCTYPE html>
<html lang="es-MX">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registro de Errores</title>

	<link rel="stylesheet" href="./css/es.css">
    <link rel="stylesheet" href="./css/styles.css">
    <link rel="stylesheet" href="./package/dist/sweetalert2.css">
</head>

<body id="page-top">
<div class="modal fade" id="create" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header bg-primary text-white">
                <h3 class="modal-title" id="exampleModalLabel">Registro de Errores</h3>
                <button type="button" class="btn btn-primary" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
            <div class="modal-body">
                <form action="../includes/guardar_error.php" method="POST" enctype="multipart/form-data">

                    <div class="form-group">
                        <label for="usuario" class="form-label">Usuario *</label>
                        <input type="text" id="usuario" name="usuario" class="form-control" required>
                    </div>

                    <div class="form-group">
                        <label for="viaje">Viaje *</label>
                        <input type="text" name="viaje" id="viaje" class="form-control" required>
                    </div>

                    <div class="form-group">
                        <label for="cantidad">Cantidad *</label>
                        <input type="number" name="cantidad" id="cantidad" class="form-control" required>
                    </div>

                    <div class="form-group">
                        <label for="fecha_reporte">Fecha de reporte *</label>
                        <input type="date" name="fecha_reporte" id="fecha_reporte" class="form-control" required>
                    </div>

                    <div class="form-group">
                        <label for="sku1">SKU 1 *</label>
                        <input type="text" name="sku1" id="sku1" class="form-control" required>
                    </div>

                    <div class="form-group">
                        <label for="fecha_incidente">Fecha del incidente *</label>
                        <input type="date" name="fecha_incidente" id="fecha_incidente" class="form-control" required>
                    </div>

                    <div class="form-group">
                        <label for="sku2">SKU 2 *</label>
                        <input type="text" name="sku2" id="sku2" class="form-control" required>
                    </div>

                    <div class="form-group">
                        <label for="unidad_medida">Unidad de medida *</label>
                        <input type="text" name="unidad_medida" id="unidad_medida" class="form-control" required>
                    </div>

                    <div class="form-group">
                        <label for="imagen1">Imagen 1 *</label>
                        <input type="file" id="imagen1" name="imagen1" class="form-control">
                    </div>

                    <div class="form-group">
                        <label for="imagen2">Imagen 2 *</label>
                        <input type="file" id="imagen2" name="imagen2" class="form-control">
                    </div>

                    <div class="form-group">
                        <label for="imagen3">Imagen 3 *</label>
                        <input type="file" id="imagen3" name="imagen3" class="form-control">
                    </div>

                    <div class="form-group">
                        <label for="jefatura">Jefatura *</label>
                        <input type="text" name="jefatura" id="jefatura" class="form-control" required>
                    </div>

                    <div class="form-group">
                        <label for="mes">Mes *</label>
                        <input type="text" name="mes" id="mes" class="form-control" required>
                    </div>

                    <div class="mb-3">
                        <input type="submit" value="Guardar" class="btn btn-success" name="registrar">
                        <a href="registros_eroores.php" class="btn btn-danger">Cancelar</a>
                    </div>

                </form>
            </div>
        </div>
    </div>
</div>

<script src="../package/dist/sweetalert2.all.js"></script>
<script src="../package/dist/sweetalert2.all.min.js"></script>
<script src="../package/jquery-3.6.0.min.js"></script>

</body>
</html>
