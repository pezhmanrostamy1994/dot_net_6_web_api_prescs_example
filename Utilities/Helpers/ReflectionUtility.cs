namespace EMR.Utilities.Helpers;

using System.Reflection;
public static class ConstantUtility
{
    public static List<T> GetConstantValues<T>(Type type)
    {
        var fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);

        var constants = fieldInfos.Where(fi => fi.IsLiteral && !fi.IsInitOnly).ToList();

        var values = new List<T>();
        foreach (var fi in constants)
        {
            var value = (T)fi.GetRawConstantValue();
            values.Add(value);
        }

        return values;
    }
}

