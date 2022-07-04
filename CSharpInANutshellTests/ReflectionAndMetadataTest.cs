using Xunit;

namespace CSharpInANutshellTests {
    
    using CSharpInANutshell.ReflectionAndMetadata;
    using FluentAssertions;

    public class ReflectionAndMetadataTest {
        
        [Fact]
        public void ReflectionAndMetadata_GetATypeWhenIsADatime_IsValid() {

            //Arrange
            var reflectionAndMetadata = new ReflectionAndMetadata();

            //Act
            var type = reflectionAndMetadata.GetDateTimeTypeByReflectionWithGetType();

            //Assert
            type.Should().BeSameAs(DateTime.Now.GetType());

        }

        [Fact]
        public void ReflectionAndMetadata_GetDateTimeTypeofWhenIsADatime_IsValid() {

            //Arrange
            var reflectionAndMetadata = new ReflectionAndMetadata();

            //Act
            var type = reflectionAndMetadata.GetDateTimeTypeByReflectionWithTypeof();

            //Assert
            type.Should().BeSameAs(typeof(DateTime));

        }
    }
}