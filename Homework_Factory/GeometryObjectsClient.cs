using Homework_Factory.Factories;

namespace Homework_Factory
{
    public class GeometryObjectsClient
    {
        public void Main()
        {
            var firstObject = CreateObject(new TriangleFactory());
            var secondObject = CreateObject(new CircleFactory());
        }

        private static string CreateObject(Factory factory)
        {
            return factory.CreateGeometryObject();
        }
    }
}