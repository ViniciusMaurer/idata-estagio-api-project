namespace EstagioiData.Model
{
    public interface IRecruitmentRepository
    {
        void Add(Recruitment recruitment);
        List<Recruitment> Get();
    }
}