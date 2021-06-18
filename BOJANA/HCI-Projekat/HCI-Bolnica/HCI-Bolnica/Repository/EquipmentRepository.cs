using HCI_Bolnica.Model;
using HCIBolnica.Model;
using HCIBolnica.Repository;
using System.Collections.Generic;

namespace HCI_Bolnica.Repository
{
    class EquipmentRepository : Repository<Equipment>
    {
        List<Entity> staticEquipments = new List<Entity>();
        List<Entity> consumableEquipments = new List<Entity>();
        public override IEnumerable<Entity> SearchStatic(string term = "")
        {
            List<Entity> result = new List<Entity>();
            foreach (Entity entity in ApplicationContext.Instance.EquipmentsStatic)
            {
                if (((Equipment)entity).ID.Contains(term) || ((Equipment)entity).EquipmentName.Contains(term) || ((Equipment)entity).Manufacturer.Contains(term))
                {
                    result.Add(entity);
                }
            }

            return result;
        }
        public IEnumerable<Entity> SearchDinamic(string term = "")
        {
            List<Entity> result = new List<Entity>();
            foreach (Entity entity in ApplicationContext.Instance.EquipmentsConsumable)
            {
                if (((Equipment)entity).ID.Contains(term) || ((Equipment)entity).EquipmentName.Contains(term) || ((Equipment)entity).Manufacturer.Contains(term))
                {
                    result.Add(entity);
                }
            }
            return result;
        }

        public List<Entity> FilterEquipment(EquipmentType equipmentType)
        {
            List<Entity> result = new List<Entity>();

            foreach (Entity entity in ApplicationContext.Instance.EquipmentsConsumable)
            {
                if (((Equipment)entity).EquipmentType == equipmentType)
                {
                    result.Add(entity);
                }
            }

            return result;
        }
        public List<Equipment> FilterByRoom(string roomId)
        {
            List<Equipment> result = new List<Equipment>();

            foreach (Equipment entity in ApplicationContext.Instance.EquipmentsConsumable)
            {
                if (entity.Room == null) 
                {
                    continue;
                }

                if (roomId == entity.Room.ID)
                {
                    result.Add(entity);
                }
            }
            return result;
        }
    }
}
