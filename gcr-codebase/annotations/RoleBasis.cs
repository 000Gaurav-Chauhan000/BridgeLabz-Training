using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role { get; }
    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

class AdminService
{
    [RoleAllowed("ADMIN")]
    public void DeleteUser()
    {
        Console.WriteLine("User deleted successfully");
    }

    [RoleAllowed("USER")]
    public void ViewProfile()
    {
        Console.WriteLine("Profile viewed");
    }
}

class Program
{
    static void Main()
    {
        string currentUserRole = "USER"; // simulate logged-in user role
        AdminService service = new AdminService();

        var methods = typeof(AdminService).GetMethods(BindingFlags.Public | BindingFlags.Instance);

        foreach (var method in methods)
        {
            var attr = (RoleAllowedAttribute)Attribute.GetCustomAttribute(method, typeof(RoleAllowedAttribute));
            if (attr != null)
            {
                Console.Write($"{method.Name}: ");
                if (attr.Role == currentUserRole)
                {
                    method.Invoke(service, null);
                }
                else
                {
                    Console.WriteLine("Access Denied!");
                }
            }
        }
    }
}
