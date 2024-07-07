using System;
using System.Collections.Generic;
using Interfaces;


namespace Interfaces2
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        Boolean fin();
        Comparable actual();
    }

}