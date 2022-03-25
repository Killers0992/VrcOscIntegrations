
namespace VrcOscIntegrations
{
    public class YDS
	{
		public static ISerializer Serializer { get; } = new SerializerBuilder()
			.WithNamingConvention(UnderscoredNamingConvention.Instance)
			.IgnoreFields()
			.Build();

		public static IDeserializer Deserializer { get; } = new DeserializerBuilder()
			.WithNamingConvention(UnderscoredNamingConvention.Instance)
			.IgnoreFields()
			.IgnoreUnmatchedProperties()
			.Build();
	}
}
