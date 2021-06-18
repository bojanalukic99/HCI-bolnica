using HCI_Bolnica.Model;
using HCIBolnica.Model;
using HCIBolnica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Repository
{
    class MedicineRepository : Repository<Medicine>
    {
        public override IEnumerable<Entity> SearchStatic(string term = "")
        {
            List<Entity> result = new List<Entity>();

            foreach (Entity entity in ApplicationContext.Instance.Medicines)
            {
                if (((Medicine)entity).ID.Contains(term) || ((Medicine)entity).Name.Contains(term) || ((Medicine)entity).Replacment.Contains(term) || ((Medicine)entity).Comment.Contains(term) || ((Medicine)entity).Composition.Contains(term))
                {
                    result.Add(entity);
                }
            }
            return result;
        }
    }
}
