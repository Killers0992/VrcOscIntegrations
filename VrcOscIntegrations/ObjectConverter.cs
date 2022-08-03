using YamlDotNet.Core;
using YamlDotNet.Core.Events;

namespace VrcOscIntegrations
{
    public class ObjectConverter : IYamlTypeConverter
    {
        public bool Accepts(Type type)
        {
            return type == typeof(object);
        }

        public object ReadYaml(IParser parser, Type type)
        {
            var sc = parser.Expect<Scalar>();

            return sc.Value.ConvertStringToObject();
        }

        public void WriteYaml(IEmitter emitter, object value, Type type)
        {
        }
    }
}
