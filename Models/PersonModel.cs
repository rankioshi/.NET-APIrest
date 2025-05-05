namespace Person.Models
{
    public class PersonModel
    {
        public PersonModel(String name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; init; } // Guid gera 32c aleatorios pra usar de ID, init ja inicializa o  construtor com ele
        public String Name { get; private set; }
        
    }
}
