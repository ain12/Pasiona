namespace EjClase
{
    public class Aula
    {
        private String name;
        private int size;
        private Alumno[] StudentsList;
        public Aula(string name, int size)
        {
            Name = name;
            Size = size;
            StudentsList = new Alumno[size];
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public void AddAlumno(Alumno student)
        {
            string name = student.Name;
            bool checkIfTrue = Contains(name);

            if(!checkIfTrue)
            {
                for (int i = 0; i < StudentsList.Length; i++)
                {
                    if (StudentsList[i] is null)
                    {
                        StudentsList[i] = student;
                        return;
                    }

                }
                throw new Exception("Error");
            }
        }

        public void AddAlumno(string student)
        {
            AddAlumno(new Alumno(Name));

        }

        public void OutAlumno(string name)
        {

            //Array.Fill(StudentsList, null);
            int index = -1;

            for (int i = 0; i < StudentsList.Length; i++)
            {
                if (StudentsList[i] is not null)
                {
                    if(StudentsList[i].Name == name) 
                    index = i;
                }
            }
            if(index > -1)
            {
                StudentsList = StudentsList.Where((source, i) => index != i).ToArray();
            }
        }
        public void Destroy()
        {
            StudentsList = new Alumno[Size];
        }

        public bool Contains(string student)
        {
            bool IsTrue = false;
            foreach(Alumno alumno in StudentsList)
            {
                if(alumno is not null)
                {
                    if(alumno.Name == student)
                    IsTrue = true;
                }
            }
            return IsTrue;
        }

        public double Media()
        {
            double sum = 0;
            int count = 0;
            foreach(Alumno alumno in StudentsList)
            {
                if(alumno is not null)
                {
                    try
                    {
                        sum += alumno.Mark;
                        count++;
                    }
                    catch(Exception e)
                    {
                       
                    }
         
                }
            }
            return sum/ count;
        }

        public void Puntua(string name, double mark)
        {
            foreach(Alumno alumno in StudentsList)
            {
                if (alumno is not null)
                {
                    if (alumno.Name == name)
                    {
                        alumno.Mark = mark;
                    }
                }
            }
        }

    }
}