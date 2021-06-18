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
    public class RenovationRepository : Repository<Renovation>
    {
        public override IEnumerable<Entity> SearchStatic(string term = "")
        {
            List<Entity> result = new List<Entity>();

            foreach (Entity entity in ApplicationContext.Instance.Renovations)
            {
                if (((Account)entity).ID.Contains(term))
                {
                    result.Add(entity);
                }
            }
            return result;
        }

        public List<Renovation> SearchRenovation(DateTime startDate, DateTime endDate)
        {
            List<Renovation> result = new List<Renovation>();

            foreach (Entity entity in ApplicationContext.Instance.Renovations)
            {
                Renovation renovation = entity as Renovation;

                DateTime date = DateTime.ParseExact(renovation.DateOfRenovationStart, "dd/MM/yyyy", null);

                if (date >= startDate && date <= endDate) 
                {
                    result.Add(renovation);
                }

            }

            return result;
        }
    }
}
