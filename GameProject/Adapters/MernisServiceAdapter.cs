using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool ChechIsRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(gamer.NationalityId, gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year);
        }
    }
}
