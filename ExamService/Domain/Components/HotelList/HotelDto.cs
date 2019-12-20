using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

/// <summary>
/// Hotel object
/// </summary>
public class HotelDto
{
    //Propiedades
    [XmlElement(ElementName = "propertyID")]
    public int PropertyId { get; set; }

    [XmlElement(ElementName = "name")]
    public string HotelName { get; set; }

    [XmlElement(ElementName = "geoId")]
    public int GeoId { get; set; }

    [XmlElement(ElementName = "rating")]
    public int Rating { get; set; }

    [XmlElement(ElementName = "rates")]
    public Collection<RateDto> Rates { get; set; }

    public HotelDto()
    {
        Rates = new Collection<RateDto>();
    }
}
