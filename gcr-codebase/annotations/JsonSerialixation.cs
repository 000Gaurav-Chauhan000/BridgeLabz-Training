using System;
using System.Reflection;
using System.Text;

[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
    public string Name { get; set; }
}

class User
{
    [JsonField(Name = "user_name")]
    public string Username;

    [JsonField(Name = "user_age")]
    public int Age;

    public string IgnoreMe; // won't be serialized
}

class Program
{
    static string ToJson(object obj)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("{");

        var fields = obj.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);
        bool first = true;

        foreach (var field in fields)
        {
            var attr = (JsonFieldAttribute)Attribute.GetCustomAttribute(field, typeof(JsonFieldAttribute));
            if (attr != null)
            {
                if (!first) sb.Append(", ");
                sb.Append($"\"{attr.Name}\": ");

                var value = field.GetValue(obj);
                if (value is string) sb.Append($"\"{value}\"");
                else sb.Append($"{value}");

                first = false;
            }
        }

        sb.Append("}");
        return sb.ToString();
    }

    static void Main()
    {
        User user = new User { Username = "Alice", Age = 30, IgnoreMe = "Hidden" };
        string json = ToJson(user);
        Console.WriteLine(json);
    }
}
