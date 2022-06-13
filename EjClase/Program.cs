namespace EjClase
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Alumno alumno = new Alumno("Ainhoa");
                Alumno alumno2 = new Alumno("Maria");
                Alumno alumno3 = new Alumno("Maria");
                Alumno alumno4 = new Alumno("Jose");


                Aula aula = new Aula("Clase1", 3);

                aula.AddAlumno(alumno);
                aula.AddAlumno(alumno2);
                aula.AddAlumno(alumno3);
                //aula.AddAlumno(alumno4);
                bool a = aula.Contains("Maria");
                Console.WriteLine(a);
                aula.OutAlumno("Maria");
                bool b = aula.Contains("Maria");
                Console.WriteLine(b);
            }
            catch(CustomException e) 
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}