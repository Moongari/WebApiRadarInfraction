using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiRadarInfraction.Interface;
using WebApiRadarInfraction.Model;
using WebApiRadarInfraction.Repository;

namespace WebApiRadarInfraction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RadarController : ControllerBase
    {

        private IRadarInfraction radarInfraction = new RadarInfractionRepository();

     


        [HttpGet]
        public ActionResult<IEnumerable<RadarInfraction>> GetAllRadars()
        {
            return radarInfraction.GetAllRadarInfraction();
        }


        [HttpGet("{id}")]
        public ActionResult<RadarInfraction> GetRadarById(int id)
        {
            var radar =  radarInfraction.GetRadar(id);
            if (radar == null)
            {
                return NotFound();
            }
            return radar;
        }


        [HttpPost]
        public ActionResult CreateRadar(RadarInfraction radar)
        {
            radarInfraction.CreateRadar(radar);
            return CreatedAtAction(nameof(CreateRadar), new { id = radar.idRadar }, radar);

        }

    }
}
