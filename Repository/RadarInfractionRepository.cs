using System.Collections.Generic;
using System.Linq;
using WebApiRadarInfraction.Interface;
using WebApiRadarInfraction.Model;

namespace WebApiRadarInfraction.Repository
{
    public class RadarInfractionRepository : IRadarInfraction
    {
        List<RadarInfraction> _radarInfractions { get; set; }
        private int idRadar = 5;

        public RadarInfractionRepository()
        {
                _radarInfractions = new List<RadarInfraction>()
            {
                new RadarInfraction(){idRadar=1,departement=3,dateMiseEnService="23/07/2012",sensCirculation="Dole vers Besancon",voie="RN39",nbreInfraction=345},
                new RadarInfraction(){idRadar=2,departement=3,dateMiseEnService="02/10/2000",sensCirculation="MONTBEUGNY vers THIEL SUR ACOLIN",voie="RN79",nbreInfraction=2936},
                new RadarInfraction(){idRadar=3,departement=5,dateMiseEnService="25/03/2013",sensCirculation="Grenoble vers Sisteron",voie="RD 1075",nbreInfraction=1904},
                new RadarInfraction(){idRadar=4,departement=21,dateMiseEnService="07/11/2014",sensCirculation="BRIANCON vers GAP",voie="RD111",nbreInfraction=3279},
                new RadarInfraction(){idRadar=5,departement=34,dateMiseEnService="01/04/2014",sensCirculation="EZE vers CAP D AIL",voie="RM6007",nbreInfraction=26}

            };
        }

     

    




        public List<RadarInfraction> GetAllRadarInfraction() => _radarInfractions;
      

        public RadarInfraction GetRadar(int id)
        {
            return _radarInfractions.Where(r => r.idRadar == id).FirstOrDefault();
        }


        public void CreateRadar(RadarInfraction radar)
        {
            radar.idRadar = idRadar++;
            if (radar != null)
            {
                
                _radarInfractions.Add(radar);
            }
        }
    }
}
