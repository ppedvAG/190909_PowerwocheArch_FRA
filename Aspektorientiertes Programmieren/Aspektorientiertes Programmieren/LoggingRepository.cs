using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspektorientiertes_Programmieren
{
    class LoggingRepository<T> : IRepository<T>
    {
        public LoggingRepository(IRepository<T> parentRepo)
        {
            this.parentRepo = parentRepo;
        }
        private IRepository<T> parentRepo;

        private void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{DateTime.Now.ToLongDateString()}]: {message}");
            Console.ResetColor();
        }


        public void Add(T item)
        {
            Log("Logger: Vor dem Add()");
            parentRepo.Add(item);
            Log("Logger: Nach dem Add()");
        }

        public void Delete(T item)
        {
            Log("Logger: Vor dem Delete()");
            parentRepo.Delete(item);
            Log("Logger: Nach dem Delete()");
        }

        public T GetByID(int ID)
        {
            Log("Logger: Vor dem GetByID()");
            var result = parentRepo.GetByID(ID);
            Log("Logger: Nach dem GetByID()");
            return result;
        }

        public void Save()
        {
            Log("Logger: Vor dem Save()");
            parentRepo.Save();
            Log("Logger: Nach dem Save()");
        }

        public void Update(T item)
        {
            Log("Logger: Vor dem Update()");
            parentRepo.Update(item);
            Log("Logger: Nach dem Update()");
        }
    }
}
