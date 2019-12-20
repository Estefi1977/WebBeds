using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace HotelList
{
    public class HotelListDto
    {

        // Propiedades 
        [XmlElement(ElementName = "hotel")]
        public Collection<HotelDto> Hotels { get; set; }

        public HotelListDto()
        {
            Hotels = new Collection<HotelDto>();
        }

    }
}
