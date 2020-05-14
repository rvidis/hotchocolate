using NetTopologySuite.Geometries;

namespace HotChocolate.Types.Spatial.CRS
{
    public class GeoJSONLineStringTypeExtension : ObjectTypeExtension<LineString>
    {
        protected override void Configure(IObjectTypeDescriptor<LineString> descriptor)
        {
            descriptor.BindFieldsExplicitly();
            descriptor.Field<GeoJSONResolvers>(x => x.GetCrs(default!));
        }
    }
}