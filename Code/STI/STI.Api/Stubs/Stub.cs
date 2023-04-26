using STI.BAL.Models.DTOs;

namespace STI.Api.Stubs
{
    public class Stub
    {
        public static List<UserDTO> Users = new List<UserDTO>
        {
            new UserDTO() { Username = "vincent_admin", Email = "vincent.admin@gmail.com", Password = "p@ssw0rd",
                            FirstName = "Vincent", LastName ="Pantia", Role = "Admin" },
            new UserDTO() { Username = "jeana_staff", Email = "jeana.staff@gmail.com", Password = "p@ssw0rd",
                            FirstName = "Jeana", LastName ="Manuel", Role = "Staff" },
        };
    }
}
