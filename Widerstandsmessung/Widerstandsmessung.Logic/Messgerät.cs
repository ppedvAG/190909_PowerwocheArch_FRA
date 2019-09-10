using System;
using Widerstandsmessung.Domain;

namespace Widerstandsmessung.Logic
{
    public class Messgerät
    {
        public Messgerät(IMesstechnik software,IRepository repository)
        {
            Software = software;
            this.repository = repository;
        }

        private IRepository repository;
        public IMesstechnik Software { get; set; }
        public SOLLWiderstand Widerstand { get; set; }

        public void WiderstandMessen()
        {
            ISTWiderstand ist = Software.Berechne(Widerstand);
            repository.Add(ist);
            repository.Save();
        }

    }
}
