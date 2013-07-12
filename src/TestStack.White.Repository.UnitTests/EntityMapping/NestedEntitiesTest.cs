using TestStack.White.Repository.EntityMapping;
using Xunit;

namespace TestStack.White.Repository.UnitTests.EntityMapping
{
    public class NestedEntitiesTest
    {
        [Fact]
        public void Create()
        {
            var testEntity = new TestEntity(new NestedEntity());
            Assert.Equal(2, new NestedEntities(testEntity).Count);
        }
    }
}