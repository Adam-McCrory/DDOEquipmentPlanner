using System;
using System.Collections.Generic;

namespace EquipmentDomain
{
	[Serializable]
	public class ItemProperty
	{
		public string Property { get; set; }
		public string Type { get; set; }
		public float Value { get; set; }
		public List<ItemProperty> Options;
		//public DDOItemData Owner;
		// this will only ever be used by the interface to create ad hoc item properties in order to track set bonuses in gear sets
		public string SetBonusOwner;

		//public ItemProperty Duplicate()
		//{
		//	ItemProperty ip = new ItemProperty
		//	{
		//		Property = Property,
		//		Type = Type,
		//		Value = Value
		//	};
		//	if (Options != null)
		//	{
		//		ip.Options = new List<ItemProperty>();
		//		foreach (var o in Options)
		//		{
		//			ItemProperty op = o.Duplicate();
		//			ip.Options.Add(op);
		//		}
		//	}

		//	return ip;
		//}

		public override string ToString()
		{
			return "{" + (string.IsNullOrWhiteSpace(Type) ? "untyped" : Type) + " " + Property + " " + Value + "}";
		}
	}
}
