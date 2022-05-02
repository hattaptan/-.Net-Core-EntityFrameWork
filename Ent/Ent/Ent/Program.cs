
using System.Linq;
using Ent.DataModel;
using Ent.Enum;
namespace Ent
{
    class Prograams
    {
        static void Main(string[] args)
        {
            AddStudent();
             
           getStudent();
           
        }

        static void getStudent()
        {
            using (var context = new Context())
            {
                var student = context.Students
                    .Where(c=>c.Age > 20)
                    .ToList();


                foreach (var st in student)
                {
                    Console.WriteLine($"{st.StudentName}  {st.Age}   {st.StudentClasses}");
                }

            }

            

          

                
               
            

            
        }


        static void AddStudent()
        {
            using (var a = new Context())
            {
                var student = new Student
                {
                    StudentName = "Hattap",
                    Age = 27,
                    StudentClasses = new List<Class>()
        {
            new Class() {
            ClassName  ="D-2",
            ClaMaxClassSize =125,
            ClassLanguage = Ent.Enum.Language.English,
            },
            new Class() {
            ClassName  ="D-1",
            ClaMaxClassSize =110,
            ClassLanguage = Ent.Enum.Language.French,
            }
        }



                };
                a.Add(student);
                a.SaveChanges();
               


            }
        }
    }
}




