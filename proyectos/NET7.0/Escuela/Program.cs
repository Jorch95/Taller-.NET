using Microsoft.EntityFrameworkCore;
using Escuela;

using (var context = new EscuelaContext()){ //El using es para asegurar que el objeto DbContext
    context.Database.EnsureCreated();       //sea usado en una única unidad de trabajo
    EscuelaInit.Inicializar(context);    
}

/* using (var db = new EscuelaContext()){
  //Agregamos un nuevo alumno
  var alumno = new Alumno() { Nombre = "Pablo" }; // el Id será establecido por SQLite
  db.Add(alumno); // se agregará realmente con el db.SaveChanges()
  db.SaveChanges(); //actualiza la base de datos. SQlite establece el valor de alumno.Id
  // Agregamos un examen para el nuevo alumno
  var examen = new Examen(){
      AlumnoId = alumno.Id,
      Materia = "Historia",
      Nota = 9.5
  };
  db.Add(examen);
  db.SaveChanges();
} */

/* using (var db = new EscuelaContext()){
  //borramos de la tabla Alumnos el registro con Id=3
  var alumnoBorrar = db.Alumnos.Where(a => a.Id == 3).SingleOrDefault();
  if (alumnoBorrar != null)
  {
      db.Remove(alumnoBorrar); //se borra realmente con el db.SaveChanges()
  }

  //La nota en Inglés del alumno id=1 es un 5. La cambiamos a 7.5
  var examenModificar = db.Examenes.Where(
                           e => e.AlumnoId == 1 && e.Materia == "Inglés").SingleOrDefault();
  if (examenModificar != null)
  {
      examenModificar.Nota = 7.5; //se modifica el registro en memoria
  }

  db.SaveChanges(); //actualiza la base de datos.
} */

/* using (var context = new EscuelaContext()){
    var query = context.Alumnos.Join(context.Examenes,
                 a => a.Id,
                 e => e.AlumnoId,
                 (a, e) => new
                 {
                     Alumno = a.Nombre,
                     Materia = e.Materia,
                     Nota = e.Nota
                 });
    foreach (var obj in query)
    {
        Console.WriteLine(obj);
    }
 } */
using (var db = new EscuelaContext())
{
   Alumno nuevo = new Alumno()
   {
       Nombre = "Andrés",
       Examenes = new List<Examen>() {
           new Examen(){Materia="Lengua",Nota=7,Fecha = DateTime.Parse("5/5/2022") },
           new Examen(){Materia="Matemática",Nota=6,Fecha = DateTime.Parse("6/5/2022") }
       }
   };
   db.Add(nuevo);
   db.SaveChanges();
}
using (var db = new EscuelaContext()){
   foreach (Alumno a in db.Alumnos.Include(a => a.Examenes)){
       Console.WriteLine(a.Nombre);
       a.Examenes?.ToList()
           .ForEach(ex => Console.WriteLine($" - {ex.Materia} {ex.Nota}"));
   }
}
