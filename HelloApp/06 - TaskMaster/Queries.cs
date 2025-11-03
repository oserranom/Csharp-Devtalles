using System.Reflection.Metadata;
using BetterConsoleTables; 
namespace TaskMaster
{
  public class Queries(List<Task> _tasks)
  {
        private List<Task> Tasks = _tasks;

        // Desarrollar métodos para gestionar las tareas 

        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("\n----------Lista de tareas----------");

            Table table = new Table("Id", "Descripción", "Estado");
            foreach (var task in Tasks)
            {
                table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "In process");
            }

            table.Config = TableConfiguration.Unicode();

            Write(table.ToString());
            ReadKey();
        }

        public List<Task> AddTask()
        {
            try
            {
                ResetColor();
                Clear();

                WriteLine("----------Añadir tarea----------");
                WriteLine("Introduce la descripción de la tarea: ");
                var description = ReadLine()!;

                Task newTask = new Task(Utils.GenerateId(), description);

                Tasks.Add(newTask);

                ForegroundColor = ConsoleColor.Green;
                WriteLine("La tarea ha sido añadida");
                ResetColor();

                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error al añadir tarea: {ex.Message}");
                return Tasks;
            }
        }

        public List<Task> MarkAsCompleted()
        {
            try
            {
                ResetColor();
                Clear();

                WriteLine("----------Marcar tarea como completada----------");
                WriteLine("Introduce la Id de la tarea que deseas completar: ");
                var id = ReadLine()!;

                Task task = Tasks.Find(t => t.Id == id)!;
                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"No se ha encontrado la tarea con id: {id}");
                    ResetColor();
                    return Tasks;
                }

                task.Completed = true;
                task.ModifiedAt = DateTime.Now;
                ForegroundColor = ConsoleColor.Green;
                WriteLine("La tarea se ha completado con éxito");
                ResetColor();
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error al completar tarea: {ex.Message}");
                return Tasks;
            }
        }
        

        public List<Task> EditTask()
        {
            try
            {
                ResetColor();
                Clear();

                WriteLine("----------Editar Tarea----------");
                WriteLine("Introduce la Id de la tarea que deseas editar: ");
                var id = ReadLine()!;

                Task task = Tasks.Find(t => t.Id == id)!;
                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"No se ha encontrado la tarea con id: {id}");
                    ResetColor();
                    return Tasks;
                }

                WriteLine("Escribe la nueva descripción de la tarea: ");
                var description = ReadLine()!;
                task.Description = description;
                task.ModifiedAt = DateTime.Now;
                
                ForegroundColor = ConsoleColor.Green;
                WriteLine("La tarea se ha modificado con éxito");
                ResetColor();
                return Tasks; 
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error al modificar tarea: {ex.Message}");
                return Tasks;
            }
        }

    }
}
