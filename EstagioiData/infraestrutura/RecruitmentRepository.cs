using EstagioiData.Model;

namespace EstagioiData.infraestrutura
{
    public class RecruitmentRepository : IRecruitmentRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Recruitment recruitment)
        {
            _context.Recruitments.Add(recruitment);
            _context.SaveChanges();
        }

        public List<Recruitment> Get()
        {
            return _context.Recruitments.ToList();
        }
    }
}