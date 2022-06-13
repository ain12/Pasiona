namespace EjClase
{
    public class Alumno
    {
        private string name;
        private double mark;
        public string Name { get { return name; } set
            {
                name = value;
            }
            }
        public double Mark { 
            get 
            { 
                if(Mark == 0) throw new Exception("No hay nota");
                return Mark; 
            } set { 
                mark = value;
            } 
        }
        public Alumno()
        {

        }

        public Alumno(string name)
        {
            Name = name;
            Mark = 0;
        }

        public override string ToString()
        {
            return Mark != 0 ? $"Nombre: {Name} Nota: {Mark}" : $"Nombre: {Name}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Alumno student && student.Name == Name;
        }

        public static bool operator ==(Alumno Left, Alumno Right) => Left.Equals(Right);
        public static bool operator !=(Alumno Left, Alumno Right) => !Left.Equals(Right);





    }
}