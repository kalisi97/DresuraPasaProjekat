﻿using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    internal class VratiSveKurseve : OpstaSO
    {
        internal override object izvrsi(object odo)
        {
            return Broker.Instanca.vratiSve((OpstiDomenskiObjekat)odo).OfType<Kurs>().ToList<Kurs>();
        }
    }
}
