namespace testapi.Models
{
    public class User
    {


        public int Id { get; set; }
        public string? UserName { get; set; }  // Login 
        public string? PassWord { get; set; }   
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public List<Client?> clients { get; set; }
        public List<Order?> orders  { get; set; }


    }
}
