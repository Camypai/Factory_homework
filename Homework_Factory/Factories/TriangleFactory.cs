using Homework_Factory.GeometryObjects;
using Homework_Factory.Interfaces;

namespace Homework_Factory.Factories
{
    public class TriangleFactory : Factory
    {
        protected override IGeometryObject FactoryMethod()
        {
            return new Triangle();
        }
    }
}