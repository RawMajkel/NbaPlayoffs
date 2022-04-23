using PlayoffsApi.Domain.SeedWork;

namespace PlayoffsApi.Domain.Weathers;

public class WeatherId : TypedIdValueBase
{
    public WeatherId(Guid value) : base(value)
    {
    }
}

//public readonly struct WeatherId
//{
//    // Not shown: the OrderId implementation and other converters

//    public class StronglyTypedIdEfValueConverter : ValueConverter<WeatherId, Guid>
//    {
//        public StronglyTypedIdEfValueConverter(ConverterMappingHints mappingHints = null)
//            : base(id => id.Value, value => new WeatherId(value), mappingHints)
//        {
//        }
//    }
//}