﻿using HCI_Bolnica.Model;
using HCIBolnica.Model;
using HCIBolnica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Repository
{
    class ManagerRepository : Repository<Manager>
    {
        public override IEnumerable<Entity> SearchStatic(string term = "")
        {
            List<Entity> result = new List<Entity>();

            foreach (Entity entity in ApplicationContext.Instance.Managers)
            {
                if (((Manager)entity).ID.Contains(term))
                {
                    result.Add(entity);
                }
            }
            return result;
        }
    }
}
