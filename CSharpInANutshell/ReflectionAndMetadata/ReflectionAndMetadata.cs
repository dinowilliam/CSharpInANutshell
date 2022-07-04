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
    }
}