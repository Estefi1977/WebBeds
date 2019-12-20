using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

/// <summary>
/// Rate object
/// </summary>
public class RateDto
{
    //Propiedades
    [XmlElement(ElementName = "rateType")]
    public string RateType { get; set; }

    [XmlElement(ElementName = "boardType")]
    public string BoradType { get; set; }

    [XmlElement(ElementName = "value")]
    public decimal Price { get; set; }
}
