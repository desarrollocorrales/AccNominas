using System.Collections.Generic;

namespace AccAsistencia
{
    public class CatalogoPermisos
    {
        public List<Permiso> ListaPermisos;

        public CatalogoPermisos()
        {
            ListaPermisos = new List<Permiso>();
            ListaPermisos.Add(new Permiso("Solo Consulta", "ninguno"));
            /* Departamentos */
            ListaPermisos.Add(new Permiso("Departamentos - Alta de departamentos", "alta_depto"));
            ListaPermisos.Add(new Permiso("Departamentos - Baja de departamentos", "baja_depto"));
            ListaPermisos.Add(new Permiso("Departamentos - Modificar departamentos", "cambio_depto"));

            /* Empleados */
            ListaPermisos.Add(new Permiso("Empleados - Alta de empleados", "alta_empleado"));
            ListaPermisos.Add(new Permiso("Empleados - Baja de empleados", "baja_empleado"));
            ListaPermisos.Add(new Permiso("Empleados - Modificar empleados", "cambio_empleado"));

            /* Horarios */
            ListaPermisos.Add(new Permiso("Horarios - Crear nuevos horarios", "alta_horario"));
            ListaPermisos.Add(new Permiso("Horarios - Eliminar horarios", "baja_horario"));
            ListaPermisos.Add(new Permiso("Horarios - Modificar horarios", "cambio_horario"));
            ListaPermisos.Add(new Permiso("Horarios - Asignar horario a empleado", "asignar_horario"));
            ListaPermisos.Add(new Permiso("Horarios - Desasignar horario a empelado", "desasignar_horario"));
            ListaPermisos.Add(new Permiso("Horarios - Desactivar horarios", "desactivar_horario"));
            ListaPermisos.Add(new Permiso("Horarios - Cambiar prioridades de horarios asignados", "prioridad_horario"));

            /* Justificaciones */
            ListaPermisos.Add(new Permiso("Justificaciones - Justificar Checadas", "justificar"));
            ListaPermisos.Add(new Permiso("Justificaciones - Justificar Checadas Masivas", "justificar_masivas"));

            /* Usuarios */
            ListaPermisos.Add(new Permiso("Usuarios - Crear o modificar datos de usuarios del sistema", "usuarios"));

            /* Consultas */
            ListaPermisos.Add(new Permiso("Consultas - Consultar checadas reales", "consultar_checadas_reales"));            
            ListaPermisos.Add(new Permiso("Consultas - Generar reporte de asistencias por empleado", "reporte_asistencias_empleado"));
            ListaPermisos.Add(new Permiso("Consultas - Generar reporte de asistencias por departamento", "reporte_asistencias_depto"));
            ListaPermisos.Add(new Permiso("Consultas - Generar reporte de justificaciones por empleado", "reporte_justificaciones_empleado"));
            ListaPermisos.Add(new Permiso("Consultas - Recalcular Asistencias", "recalcular_asistencias"));
            
        }
    }
}
