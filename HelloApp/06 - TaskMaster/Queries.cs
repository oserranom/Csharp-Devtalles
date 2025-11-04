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

        public List<Task> RemoveTask()
        {
            try
            {
                ResetColor();
                Clear();

                WriteLine("----------Eliminar Tarea----------");
                WriteLine("Introduce la Id de la tarea que deseas eliminar: ");
                var id = ReadLine()!;

                Task task = Tasks.Find(t => t.Id == id)!;
                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"No se ha encontrado la tarea con id: {id}");
                    ResetColor();
                    return Tasks;
                }

                //Eliminar task aquí:
                Tasks.Remove(task);

                ForegroundColor = ConsoleColor.Green;
                WriteLine("La tarea se ha eliminado con éxito");
                ResetColor();
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error al eliminar tarea: {ex.Message}");
                return Tasks;
            }
        }

        public void TasksByState()
        {
            Clear();

            try
            {
                ResetColor();
                WriteLine("-------Tareas por estado------");
                WriteLine("1. Completadas");
                WriteLine("2. In process");
                WriteLine("Escribe la opción de las tareas a mostrar: ");
                string taskState = ReadLine()!;

                if (taskState != "1" && taskState != "2")
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Opción inexistente");
                    ResetColor();
                    return;
                }

                bool completed = taskState == "1";

                List<Task> filteredTasks = Tasks.Where(t => t.Completed == completed).ToList();

                if (filteredTasks.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No se han encontrado tareas con el estado solicitado");
                    ResetColor();
                    return;
                }

                ForegroundColor = completed ? ConsoleColor.Green : ConsoleColor.Red;

                //Mostrar filteredTasks

                Table table = new Table("Id", "Descripción", "Estado");
                foreach (var task in filteredTasks)
                {
                    table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "In process");
                }

                table.Config = TableConfiguration.Unicode();

                Write(table.ToString());
                ReadKey();
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error al filtrar tareas: {ex.Message}");
            }
        }
        
        public void TasksByDescription()
        {
            Clear();

            try
            {
                ResetColor();
                WriteLine("-------Tareas por descripción------");
                WriteLine("Escribe la descripción de la tarea que deseas buscar: ");
                string description = ReadLine()!;

                List<Task> matchingTasks = Tasks.FindAll(t => t.Description?.Contains(description, StringComparison.OrdinalIgnoreCase) ?? false);

                if (matchingTasks.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No se han encontrado tareas con el estado solicitado");
                    ResetColor();
                    return;
                }

                //Mostrar filteredTasks

                Table table = new Table("Id", "Descripción", "Estado");
                foreach (var task in matchingTasks)
                {
                    table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "In process");
                }

                table.Config = TableConfiguration.Unicode();

                Write(table.ToString());
                ReadKey();
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error al filtrar tarea: {ex.Message}");
            }
        }

    }
}
