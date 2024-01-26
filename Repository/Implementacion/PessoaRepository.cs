using PadraoMadiatorAprendendo.Domain.Entities;

namespace PadraoMadiatorAprendendo.Repository.Implementacion
{
    public class PessoaRepository : IRepository<Pessoa>
    {
        public List<Pessoa> pessoas = new List<Pessoa>();

        Pessoa pessoa1 = new Pessoa()
        {
            Id = 1,
            Nome = "marcos",
            Idade = 18
            
        };
        Pessoa pessoa2 = new Pessoa()
        {
            Id = 2,
            Nome = "fabio",
            Idade = 22

        };
        public async Task Add(Pessoa item)
        {
            await Task.Run(() => pessoas.Add(item));
        }

        public async Task Delete(int id)
        {
            
        }

        public async Task Edit(Pessoa? item)
        {
            
        }

        public async Task<Pessoa> Get(int id)
        {
            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);
            return await Task.Run(() => pessoas.Where(x => x.Id == id).FirstOrDefault());
        }

        public async Task<IList<Pessoa>> GetAll()
        {
            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);
            return await Task.Run(() => pessoas.ToList());
        }
    }
}
