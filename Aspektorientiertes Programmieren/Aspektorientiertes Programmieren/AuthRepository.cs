using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspektorientiertes_Programmieren
{
    enum User
    {
        ReadOnlyUser,
        RegularUser,
        Admin
    }

    class AuthRepository<T> : IRepository<T>
    {
        public AuthRepository(IRepository<T> parentRepo, User currentUser)
        {
            this.parentRepo = parentRepo;
            this.currentUser = currentUser;
        }
        private IRepository<T> parentRepo;
        private User currentUser;

        private void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"[{DateTime.Now.ToLongDateString()}]: {message}");
            Console.ResetColor();
        }

        public void Add(T item)
        {
            if(currentUser == User.ReadOnlyUser)
            {
                Log("Add-Operation ist für den aktuellen User nicht erlaubt");
                return;
            }
            else
            {
                parentRepo.Add(item);
            }
        }

        public void Delete(T item)
        {
            if (currentUser == User.ReadOnlyUser || currentUser == User.RegularUser)
            {
                Log("Delete-Operation ist für den aktuellen User nicht erlaubt");
                return;
            }
            else
                parentRepo.Delete(item);
        }

        public T GetByID(int ID)
        {
            return parentRepo.GetByID(ID);
        }

        public void Save()
        {
            if (currentUser == User.ReadOnlyUser)
            {
                Log("Save-Operation ist für den aktuellen User nicht erlaubt");
                return;
            }
            else
                parentRepo.Save();
        }

        public void Update(T item)
        {
            if (currentUser == User.ReadOnlyUser)
            {
                Log("Update-Operation ist für den aktuellen User nicht erlaubt");
                return;
            }
            else
                parentRepo.Update(item);
        }
    }
}
