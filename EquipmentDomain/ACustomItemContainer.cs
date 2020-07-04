using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentDomain
{
	public abstract class ACustomItemContainer
	{
		public string Name;
		//public ItemDataSource Source;

		public virtual List<EquipmentSlotType> GetDisallowedSlots()
		{
			return null;
		}

		public abstract Equipment GetItem();

		////public abstract void ToXml(XmlElement xci, XmlDocument doc);

		////public abstract bool FromXml(XmlElement xci);
	}
}
