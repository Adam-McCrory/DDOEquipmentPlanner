using System;

namespace EquipmentDomain
{
    [Flags]
	public enum WeaponCategory
	{
		Simple = 1,
		Martial = 2,
		Exotic = 4,
		Throwing = 8
	}
}
