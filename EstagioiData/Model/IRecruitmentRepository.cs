namespace EstagioiData.Model
{
    // Interface que define operações disponíveis para um repositório
    public interface IRecruitmentRepository
    {
        // Método para adicionar um novo dado ao repositório
        void Add(Recruitment recruitment);

        // Método para obter uma lista de todas as informações no repositório
        List<Recruitment> Get();
    }
}