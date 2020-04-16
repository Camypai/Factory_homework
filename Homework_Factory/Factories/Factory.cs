using Homework_Factory.Interfaces;

namespace Homework_Factory.Factories
{
    public abstract class Factory
    {
        public abstract IGeometryObject FactoryMethod();

        public string CreateGeometryObject()
        {
            var geometryObject = FactoryMethod();
            return geometryObject.WhoAmI();
        }
    }
}