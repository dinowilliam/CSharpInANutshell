using Xunit;

namespace CSharpInANutshellTests {
    
    using CSharpInANutshell.ReflectionAndMetadata;
    using FluentAssertions;
    using System.Reflection;

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

        [Fact]
        public void ReflectionAndMetadata_GetDateTimeTypeof_WhenIsAArrayOfDatime() {

            //Arrange
            var reflectionAndMetadata = new ReflectionAndMetadata();

            //Act
            var type = reflectionAndMetadata.GetDateTimeTypeByReflectionWithTypeofFromAnArray();

            //Assert
            type.Should().BeSameAs(typeof(DateTime[]));
        }

        [Fact]
        public void ReflectionAndMetadata_GetDateTimeTypeof_WhenIsAMatrixOfDatime() {

            //Arrange
            var reflectionAndMetadata = new ReflectionAndMetadata();

            //Act
            var type = reflectionAndMetadata.GetDateTimeTypeByReflectionWithTypeofFromAMatrix();

            //Assert
            type.Should().BeSameAs(typeof(DateTime[,]));
        }

        [Fact]
        public void ReflectionAndMetadata_GetDictionaryTypeof_WhenIsAClosedGenericType() {

            //Arrange
            var reflectionAndMetadata = new ReflectionAndMetadata();

            //Act
            var type = reflectionAndMetadata.GetDictionaryTypeByReflectionWithTypeofFromAClosedGenericType();

            //Assert
            type.Should().BeSameAs(typeof(Dictionary<int, int>));
        }

        [Fact]
        public void ReflectionAndMetadata_GetDictionaryTypeof_WhenIsAUnboundGenericType() {

            //Arrange
            var reflectionAndMetadata = new ReflectionAndMetadata();

            //Act
            var type = reflectionAndMetadata.GetDictionaryTypeByReflectionWithTypeofFromAUnboundGenericType();

            //Assert
            type.Should().BeSameAs(typeof(Dictionary<,>));
        }

        [Fact]
        public void ReflectionAndMetadata_GetAssemblyType_WhenIsTheExecutingAssembly() {

            //Arrange
            var reflectionAndMetadata = new ReflectionAndMetadata();

            //Act
            var type = reflectionAndMetadata.GetAssemlbyTypeOfTheExecutingAssembly();

            //Assert
            type.Should().BeSameAs(Assembly.GetExecutingAssembly().GetType());
        }
    }
}