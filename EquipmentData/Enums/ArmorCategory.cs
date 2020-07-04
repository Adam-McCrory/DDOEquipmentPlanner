using System;

namespace EquipmentDomain
{
    [Flags]
	public enum ArmorCategory
	{
		Cloth = 1,
		Light = 2,
		Medium = 4,
		Heavy = 8,
		Docent = 16
	}
}
