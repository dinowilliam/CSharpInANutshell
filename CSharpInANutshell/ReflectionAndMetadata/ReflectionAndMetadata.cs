using System.Reflection;
using System.Reflection.Emit;

namespace CSharpInANutshell.ReflectionAndMetadata {
    public class ReflectionAndMetadata {
        public Type GetDateTimeTypeByReflectionWithGetType() {
            return DateTime.Now.GetType();
        }

        public object GetDateTimeTypeByReflectionWithTypeof() {
            return typeof(DateTime);
        }

        public object GetDateTimeTypeByReflectionWithTypeofFromAnArray() {
            return typeof(DateTime[]);
        }

        public object GetDateTimeTypeByReflectionWithTypeofFromAMatrix() {
            return typeof(DateTime[,]);
        }

        public object GetDictionaryTypeByReflectionWithTypeofFromAClosedGenericType() {
            return typeof(Dictionary<int, int>);
        } 

        public object GetDictionaryTypeByReflectionWithTypeofFromAUnboundGenericType() {
            return typeof(Dictionary<,>);
        }

        public object GetAssemlbyTypeOfTheExecutingAssembly() {
            return Assembly.GetExecutingAssembly().GetType();
        }

        public object GetAssemlbyTypeOfTheInformingAssembly() {
            return Type.GetType("System.Int32, System.Private.CoreLib");
        }
    }
}