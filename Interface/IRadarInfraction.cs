using System.Collections.Generic;
using WebApiRadarInfraction.Model;

namespace WebApiRadarInfraction.Interface
{
    public interface IRadarInfraction
    {

        public List<RadarInfraction> GetAllRadarInfraction();

        public RadarInfraction GetRadar(int id);
        


    }
}
