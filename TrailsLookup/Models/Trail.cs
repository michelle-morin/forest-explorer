namespace TrailsLookup.Models
{
  public class Trail
  {
    public int TrailId { get; set; }
    public int GeoObjNumber { get; set; }
    public string Name { get; set; }
    public double Miles { get; set; }
    public string Type { get; set; }
    public string Surface { get; set; }
    public int FirstAdjoiningSegment1 { get; set; }
    public int? FirstAdjoiningSegment2 { get; set; }
    public int? FirstAdjoiningSegment3 { get; set; }
    public int? FirstAdjoiningSegment4 { get; set; }
    public int SecondAdjoiningSegment1 { get; set; }
    public int? SecondAdjoiningSegment2 { get; set; }
    public int? SecondAdjoiningSegment3 { get; set; }
    public int? SecondAdjoiningSegment4 { get; set; }
  }
}