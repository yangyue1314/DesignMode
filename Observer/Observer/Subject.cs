using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface Subject
    {
        void RegisterObserver(Observer observer);
        void Remove(Observer observer);
        void NotifyObserver();
    }
}
