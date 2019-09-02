using MoneyTrack.Data.Models;
using MoneyTrack.Data.Repositories;
using System.Collections.Generic;
using System.Text;

namespace MoneyTrack.Services.TypeService
{
    public class TypeService : ITypeService
    {
        private readonly ITypeRepository typesRepository;
        public TypeService(ITypeRepository typesRepository)
        {
            this.typesRepository = typesRepository;
        }
        public List<Type> Get()
        {
            return typesRepository.Get();
        }
        public Type Get(string id)
        {
            return typesRepository.Get(id);
        }
        public Type Create(Type type)
        {
            return typesRepository.Create(type);
        }

        public bool Update(string id, Type type)
        {
            return typesRepository.Update(id, type);
        }

        public bool Remove(Type type)
        {
            return typesRepository.Remove(type);
        }

        public bool Remove(string id)
        {
            return typesRepository.Remove(id);
        }
    }
}
