using EstagioiData.Model;

namespace EstagioiData.infraestrutura
{
    // Classe que implementa a interface IRecruitmentRepository para manipulação do banco de dados
    public class RecruitmentRepository : IRecruitmentRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext(); // Contexto de conexão com o banco de dados
        public void Add(Recruitment recruitment) // Método para adicionar uma nova informação ao banco de dados
        {
            _context.Recruitments.Add(recruitment); // Adiciona a informação ao contexto
            _context.SaveChanges(); // Salva as alterações no banco de dados
        }

        public List<Recruitment> Get() // Método para obter uma lista de todos os dados do banco de dados
        {
            return _context.Recruitments.ToList(); // Retorna todos os dados do contexto como uma lista
        }
    }
}