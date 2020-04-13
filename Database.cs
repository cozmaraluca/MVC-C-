using GrandSmartphoneStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrandSmartphoneStore.Repo
{

    public static class ClientiRepo
    {
        private static List<Clienti> _lista = new List<Clienti>();

        public static void Adaugare(Clienti client)
        {
            _lista.Add(client);
        }
        public static IEnumerable<Clienti> GetClienti()
        {
            return _lista;
        }

    }
}