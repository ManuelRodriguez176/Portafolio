<?php

session_start();
error_reporting(0);

$validar = $_SESSION['nombre'];

if( $validar == null || $validar = ''){

  header("Location: ../includes/login.php");
  die();
  
}


?>
<!DOCTYPE html>
<html lang="en">
    
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.1/css/all.css" 
    integrity="sha384-50oBUHEmvpQ+1lW4y57PTFmhCaXp0ML5d60M1M7uH2+nqUivzIebhndOJK28anvf"
    crossorigin="anonymous">
    <link rel="stylesheet" href="../DataTables/css/dataTables.bootstrap4.min.css">
 
    <link rel="stylesheet" href="../css/es.css">


    <script src="../js/jquery.min.js"></script>

    <script src="../js/resp/bootstrap.min.js"></script>
    

    <title>Registros</title>
</head>
<header>
  <nav>
    <a href="user.php">Usuarios</a>
  </nav>
</header>
<br>
<div class="container is-fluid">


<div class="col-xs-12">
  		<h1>Bienvenido Administrador <?php echo $_SESSION['nombre']; ?></h1>

		<h1>Lista de registros</h1>
    <br>
  <!-- <p> Mostrar cantidad de <select name="sel" id="value"> 
        <option value="1">1 Registro</option>
        <option value="2">2 Registros</option>
        <option value="3">3 Registros</option>
    </select>
    <br>-->

		<div>
    <button type="button" class="btn btn-success" data-toggle="modal" data-target="#create">
				<span class="glyphicon glyphicon-plus"></span> Nuevo registros   <i class="fa fa-plus"></i> </a></button>

      <a class="btn btn-warning" href="../includes/_sesion/cerrarSesion.php">Log Out
      <i class="fa fa-power-off" aria-hidden="true"></i>
       </a>

       <a class="btn btn-primary" href="../includes/excel.php">Excel
       <i class="fa fa-table" aria-hidden="true"></i>
       </a>
       <a href="../includes/reporte.php" class="btn btn-primary"><b>PDF</b> </a>
		</div>



<!-- Aquí puedes escribir tu comentario 
    <div class="container-fluid"> 
  <form class="d-flex">
			<form action="" method="GET">
			<input class="form-control me-2" type="search" placeholder="Buscar con PHP" 
			name="busqueda"> <br>
			<button class="btn btn-outline-info" type="submit" name="enviar"> <b>Buscar </b> </button> 
			</form>
  </div>-->
  <?php
$conexion=mysqli_connect("localhost","root","","r_user"); 
$where="";

if(isset($_GET['enviar'])){
  $busqueda = $_GET['busqueda'];


	if (isset($_GET['busqueda']))
	{
		$where="WHERE user.correo LIKE'%".$busqueda."%' OR nombre  LIKE'%".$busqueda."%'
    OR telefono  LIKE'%".$busqueda."%'";
	}
  
}


?>
   


			</form>
     <!-- <div class="container-fluid">
  <form class="d-flex">
      <input class="form-control me-2 light-table-filter" data-table="table_id" type="text" 
      placeholder="Buscar con JS">
      <hr>
      </form>
  </div>  -->

  <br>


      <table class="table table-striped table-dark table_id " id="table_id">

                   
                         <thead>    
                         <tr>
                        <th>Usuario</th>
                        <th>Viaje</th>
                        <th>Cantidad</th>
                        <th>Fecha de reporte</th>
                        <th>sku1</th>
                        <th>Fecha de incidente</th>
                        <th>sku2</th>
                        <th>Unidad medida</th>
                        <th>Imagen 1</th>
                        <th>Imagen 2</th>
                        <th>Imagen 3</th>
                        <th>Jefatura</th>
                        <th>Mes</th>
                        <th>Acciones</th>

         
                        </tr>
                        </thead>
                        <tbody>

				<?php

$conexion=mysqli_connect("localhost","root","","r_user");               
$SQL=mysqli_query($conexion,"SELECT reporte_errores.id, reporte_errores.usuario, reporte_errores.viaje,
reporte_errores.cantidad, reporte_errores.fecha_reporte,reporte_errores.sku1,reporte_errores.fecha_incidente,
reporte_errores.sku2,reporte_errores.unidad_medida,reporte_errores.imagen1,reporte_errores.imagen2,
reporte_errores.imagen3,reporte_errores.jefatura,reporte_errores.mes FROM reporte_errores" );

    while($fila=mysqli_fetch_assoc($SQL)):
    
?>
<tr>
<td><?php echo $fila['usuario']; ?></td>
<td><?php echo $fila['viaje']; ?></td>
<td><?php echo $fila['cantidad']; ?></td>
<td><?php echo $fila['fecha_reporte']; ?></td>
<td><?php echo $fila['sku1']; ?></td>
<td><?php echo $fila['fecha_incidente']; ?></td>
<td><?php echo $fila['sku2']; ?></td>
<td><?php echo $fila['unidad_medida']; ?></td>
<td><img src="../imgs/<?php echo $fila['imagen1']; ?>" onerror=this.src="../imgs/noimage.png" width="50" 
heigth="70"></td>
<td><img src="../imgs/<?php echo $fila['imagen2']; ?>" onerror=this.src="../imgs/noimage.png" width="50" 
heigth="70"></td>
<td><img src="../imgs/<?php echo $fila['imagen3']; ?>" onerror=this.src="../imgs/noimage.png" width="50" 
heigth="70"></td>
<td><?php echo $fila['jefatura']; ?></td>
<td><?php echo $fila['mes']; ?></td>


<td>


<a class="btn btn-warning" href="editar_reportes.php?id=<?php echo $fila['id']?> ">
<i class="fa fa-edit"></i> </a>


<a class="btn btn-danger btn-del" href="eliminar_user.php?id=<?php echo $fila['id']?> ">
<i class="fa fa-trash"></i></a>
</td>
</tr>


<?php endwhile;?>

	</body>
  </table>

  <script>
$('.btn-del').on('click', function(e){
  e.preventDefault();
  const href = $(this).attr('href')

  Swal.fire({
  title: 'Estas seguro de eliminar este usuario?',
  text: "¡No podrás revertir esto!!",
  icon: 'warning',
  showCancelButton: true,
  confirmButtonColor: '#3085d6',
  cancelButtonColor: '#d33',
  confirmButtonText: 'Si, eliminar!', 
  cancelButtonText: 'Cancelar!', 
}).then((result)=>{
    if(result.value){
        if (result.isConfirmed) {
    Swal.fire(
      'Eliminado!',
      'El usuario fue eliminado.',
      'success'
    )
  }

        document.location.href= href;
    }   

})
})

  </script>
  <!-- <div id="paginador" class=""></div>-->
<script src="../package/dist/sweetalert2.all.js"></script>
<script src="../package/dist/sweetalert2.all.min.js"></script>
<script src="../package/jquery-3.6.0.min.js"></script>

<script type="text/javascript" src="../DataTables/js/datatables.min.js"></script>
  <script type="text/javascript" src="../DataTables/js/jquery.dataTables.min.js"></script>
  <script src="../DataTables/js/dataTables.bootstrap4.min.js"></script>

<script src="../js/page.js"></script>
<script src="../js/buscador.js"></script>
<script src="../js/user.js"></script>




		<?php include('formulario_reportes.php'); ?>
</html>