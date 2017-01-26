using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Good
{
    class DrawAllShapes
    {
        internal static void Draw()
        {
            var shapeTypes = Assembly.GetAssembly(typeof(Shape)).GetTypes().Where(t => t.IsSubclassOf(typeof(Shape)));
            foreach (var type in shapeTypes)
            {
                var constructor = type.GetConstructor(Type.EmptyTypes);
                var classObject = constructor.Invoke(null);
                var DrawMethod = type.GetMethod("Draw");
                DrawMethod?.Invoke(classObject, null);
            }
        }
    }
}
