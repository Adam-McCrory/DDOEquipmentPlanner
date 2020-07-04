using System;
using System.Collections.Generic;

namespace EquipmentDomain
{
    public class Equipment
    {
        public string Name;
        public List<EquipmentSlotType> Slots;
        public int Category;
        public List<ItemProperty> ItemProperties;
        public EquipmentSet EquipmentSet;
    }
}
