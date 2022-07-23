namespace WebApiRadarInfraction.Model
{
    public class RadarInfraction
    {


        public RadarInfraction()
        {

        }

        public int idRadar { get; set; }
        public int departement { get; set; }
        public string? dateMiseEnService { get; set; }
        public string? voie { get; set; }
        public string? sensCirculation { get; set; }

        public int nbreInfraction { get; set; }


    }
}
