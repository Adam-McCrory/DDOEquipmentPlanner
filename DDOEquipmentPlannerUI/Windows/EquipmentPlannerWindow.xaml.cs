using EquipmentDomain;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DDOEquipmentPlannerUI
{
    /// <summary>
    /// Interaction logic for EquipmentPlannerWindow.xaml
    /// </summary>
    public partial class EquipmentPlannerWindow : Window
    {
        Dictionary<EquipmentSlotType, EquipmentSlotControl> EquipmentSlots = new Dictionary<EquipmentSlotType, EquipmentSlotControl>();

		public EquipmentLoadout CurrentBuild = new EquipmentLoadout();

		List<Equipment> ItemListCopy;
		string LastSortBy;
		int LastSortDir = 1;

		public EquipmentPlannerWindow()
        {
            InitializeComponent();
        }

		public void RegisterEquipmentSlot(EquipmentSlotControl control)
        {
			//EquipmentSlots[control.Slot] = control;
			//control.EquipmentSlotClicked += EquipmentSlotClicked;
			//control.EquipmentSlotCleared += EquipmentSlotCleared;
			//control.EquipmentSlotLockChanged += EquipmentSlotLockChanged;

			//if (control.Slot == EquipmentSlotType.Finger1 || control.Slot == EquipmentSlotType.Finger2) control.SlotType = SlotType.Finger;
			//else control.SlotType = (EquipmentSlotType)Enum.Parse(typeof(EquipmentSlotType), control.Slot.ToString());

			

		}

		private void MLRangeChanged(RangeSlider slider, double oldvalue, double newvalue)
		{
			if (slider == rsML)
			{
				//ItemFilterSettings.MinimumLevel = (int)rsML.LowerValue;
				//ItemFilterSettings.MaximumLevel = (int)rsML.UpperValue;
				//grpML.Header = "ML Range: " + ItemFilterSettings.MinimumLevel + " to " + ItemFilterSettings.MaximumLevel;
				//UpdateItemSearchResults();
			}
		}

		private void BuildMLRangeChanged(RangeSlider slider, double oldvalue, double newvalue)
		{
			CurrentBuild.MinimumLevel = (int)slider.LowerValue;
			CurrentBuild.MaximumLevel = (int)slider.UpperValue;
		}

		private void NewBuild_Click(object sender, RoutedEventArgs e)
		{
			//ResetBuildResultsUI();
			CurrentBuild.Clear();
			//GC.Collect();
		}

		private void LoadBuild_Click(object sender, RoutedEventArgs e)
		{
			//LoadBuild(true, true);
		}

		private void SaveBuild_Click(object sender, RoutedEventArgs e)
		{
			//SaveBuild(true, !CurrentBuild.FiltersResultsMismatch);
		}

		private void LoadBuildFilters_Click(object sender, RoutedEventArgs e)
		{
			//LoadBuild(true, false);
		}

		private void SaveBuildFilters_Click(object sender, RoutedEventArgs e)
		{
			//SaveBuild(true, false);
		}

		private void LoadBuildResults_Click(object sender, RoutedEventArgs e)
		{
			//LoadBuild(false, true);
		}

		private void SaveBuildResults_Click(object sender, RoutedEventArgs e)
		{
			//SaveBuild(false, true);
		}

		private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void BtnFilterAll_Click(object sender, RoutedEventArgs e)
		{
			tbFilterBack.IsChecked = tbFilterBody.IsChecked = tbFilterEye.IsChecked = tbFilterFeet.IsChecked = /*tbFilterFinger.IsChecked =*/ tbFilterHand.IsChecked = tbFilterHead.IsChecked = tbFilterNeck.IsChecked = tbFilterOffhand.IsChecked = tbFilterTrinket.IsChecked = tbFilterWaist.IsChecked = tbFilterWeapon.IsChecked = tbFilterWrist.IsChecked = true;
		}

		private void BtnFilterClear_Click(object sender, RoutedEventArgs e)
		{
			tbFilterBack.IsChecked = tbFilterBody.IsChecked = tbFilterEye.IsChecked = tbFilterFeet.IsChecked = /*tbFilterFinger.IsChecked =*/ tbFilterHand.IsChecked = tbFilterHead.IsChecked = tbFilterNeck.IsChecked = tbFilterOffhand.IsChecked = tbFilterTrinket.IsChecked = tbFilterWaist.IsChecked = tbFilterWeapon.IsChecked = tbFilterWrist.IsChecked = false;
		}

		private void BtnFilterApply_Click(object sender, RoutedEventArgs e)
		{
			txtSearchBox.Text = null;
			//ItemFilterSettings.Slots = SlotType.None;
			//ItemFilterSettings.Slots |= tbFilterBack.IsChecked.Value ? SlotType.Back : 0;
			//ItemFilterSettings.Slots |= tbFilterBody.IsChecked.Value ? SlotType.Body : 0;
			//ItemFilterSettings.BodyCloth = tbFilterBody.IsChecked.Value ? cmiFilterBodyCloth.IsChecked : false;
			//ItemFilterSettings.BodyLight = tbFilterBody.IsChecked.Value ? cmiFilterBodyLight.IsChecked : false;
			//ItemFilterSettings.BodyMedium = tbFilterBody.IsChecked.Value ? cmiFilterBodyMedium.IsChecked : false;
			//ItemFilterSettings.BodyHeavy = tbFilterBody.IsChecked.Value ? cmiFilterBodyHeavy.IsChecked : false;
			//ItemFilterSettings.BodyDocent = tbFilterBody.IsChecked.Value ? cmiFilterBodyDocent.IsChecked : false;
			//ItemFilterSettings.Slots |= tbFilterEye.IsChecked.Value ? SlotType.Eye : 0;
			//ItemFilterSettings.Slots |= tbFilterFeet.IsChecked.Value ? SlotType.Feet : 0;
			//ItemFilterSettings.Slots |= tbFilterFinger.IsChecked.Value ? SlotType.Finger : 0;
			//ItemFilterSettings.Slots |= tbFilterHand.IsChecked.Value ? SlotType.Hand : 0;
			//ItemFilterSettings.Slots |= tbFilterHead.IsChecked.Value ? SlotType.Head : 0;
			//ItemFilterSettings.Slots |= tbFilterNeck.IsChecked.Value ? SlotType.Neck : 0;
			//ItemFilterSettings.Slots |= tbFilterOffhand.IsChecked.Value ? SlotType.Offhand : 0;
			//ItemFilterSettings.OffhandShieldBuckler = tbFilterOffhand.IsChecked.Value ? cmiFilterOffhandBuckler.IsChecked : false;
			//ItemFilterSettings.OffhandShieldSmall = tbFilterOffhand.IsChecked.Value ? cmiFilterOffhandSmall.IsChecked : false;
			//ItemFilterSettings.OffhandShieldLarge = tbFilterOffhand.IsChecked.Value ? cmiFilterOffhandLarge.IsChecked : false;
			//ItemFilterSettings.OffhandShieldTower = tbFilterOffhand.IsChecked.Value ? cmiFilterOffhandTower.IsChecked : false;
			//ItemFilterSettings.OffhandShieldOrb = tbFilterOffhand.IsChecked.Value ? cmiFilterOffhandOrb.IsChecked : false;
			//ItemFilterSettings.OffhandRuneArm = tbFilterOffhand.IsChecked.Value ? cmiFilterOffhandRuneArm.IsChecked : false;
			//ItemFilterSettings.Slots |= tbFilterTrinket.IsChecked.Value ? SlotType.Trinket : 0;
			//ItemFilterSettings.Slots |= tbFilterWaist.IsChecked.Value ? SlotType.Waist : 0;
			//ItemFilterSettings.Slots |= tbFilterWeapon.IsChecked.Value ? SlotType.Weapon : 0;
			//ItemFilterSettings.WeaponSimpleClub = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponSimpleClub.IsChecked : false;
			//ItemFilterSettings.WeaponSimpleQuarterstaff = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponSimpleQuarterstaff.IsChecked : false;
			//ItemFilterSettings.WeaponSimpleDagger = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponSimpleDagger.IsChecked : false;
			//ItemFilterSettings.WeaponSimpleSickle = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponSimpleSickle.IsChecked : false;
			//ItemFilterSettings.WeaponSimpleLightMace = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponSimpleLightMace.IsChecked : false;
			//ItemFilterSettings.WeaponSimpleHeavyMace = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponSimpleHeavyMace.IsChecked : false;
			//ItemFilterSettings.WeaponSimpleMorningstar = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponSimpleMorningstar.IsChecked : false;
			//ItemFilterSettings.WeaponSimpleLightXbow = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponSimpleLightXbow.IsChecked : false;
			//ItemFilterSettings.WeaponSimpleHeavyXbow = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponSimpleHeavyXbow.IsChecked : false;
			//ItemFilterSettings.WeaponMartialHandaxe = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialHandaxe.IsChecked : false;
			//ItemFilterSettings.WeaponMartialBattleAxe = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialBattleAxe.IsChecked : false;
			//ItemFilterSettings.WeaponMartialGreatAxe = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialGreatAxe.IsChecked : false;
			//ItemFilterSettings.WeaponMartialKukri = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialKukri.IsChecked : false;
			//ItemFilterSettings.WeaponMartialShortSword = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialShortSword.IsChecked : false;
			//ItemFilterSettings.WeaponMartialLongSword = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialLongSword.IsChecked : false;
			//ItemFilterSettings.WeaponMartialGreatSword = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialGreatSword.IsChecked : false;
			//ItemFilterSettings.WeaponMartialScimitar = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialScimitar.IsChecked : false;
			//ItemFilterSettings.WeaponMartialFalchion = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialFalchion.IsChecked : false;
			//ItemFilterSettings.WeaponMartialRapier = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialRapier.IsChecked : false;
			//ItemFilterSettings.WeaponMartialLightPick = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialLightPick.IsChecked : false;
			//ItemFilterSettings.WeaponMartialHeavyPick = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialHeavyPick.IsChecked : false;
			//ItemFilterSettings.WeaponMartialLightHammer = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialLightHammer.IsChecked : false;
			//ItemFilterSettings.WeaponMartialWarHammer = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialWarHammer.IsChecked : false;
			//ItemFilterSettings.WeaponMartialMaul = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialMaul.IsChecked : false;
			//ItemFilterSettings.WeaponMartialGreatClub = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialGreatClub.IsChecked : false;
			//ItemFilterSettings.WeaponMartialShortBow = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialShortBow.IsChecked : false;
			//ItemFilterSettings.WeaponMartialLongBow = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponMartialLongBow.IsChecked : false;
			//ItemFilterSettings.WeaponExoticBastardSword = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponExoticBastardSword.IsChecked : false;
			//ItemFilterSettings.WeaponExoticDwarvenWarAxe = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponExoticDwarvenWarAxe.IsChecked : false;
			//ItemFilterSettings.WeaponExoticKama = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponExoticKama.IsChecked : false;
			//ItemFilterSettings.WeaponExoticKhopesh = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponExoticKhopesh.IsChecked : false;
			//ItemFilterSettings.WeaponExoticHandwraps = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponExoticHandwraps.IsChecked : false;
			//ItemFilterSettings.WeaponExoticGreatXbow = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponExoticGreatXbow.IsChecked : false;
			//ItemFilterSettings.WeaponExoticRepeatLightXbow = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponExoticRepeatLightXbow.IsChecked : false;
			//ItemFilterSettings.WeaponExoticRepeatHeavyXbow = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponExoticRepeatHeavyXbow.IsChecked : false;
			//ItemFilterSettings.WeaponThrowingAxe = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponThrowingAxe.IsChecked : false;
			//ItemFilterSettings.WeaponThrowingDagger = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponThrowingDagger.IsChecked : false;
			//ItemFilterSettings.WeaponThrowingHammer = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponThrowingHammer.IsChecked : false;
			//ItemFilterSettings.WeaponThrowingDart = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponThrowingDart.IsChecked : false;
			//ItemFilterSettings.WeaponThrowingShuriken = tbFilterWeapon.IsChecked.Value ? cmiFilterWeaponThrowingShuriken.IsChecked : false;
			//ItemFilterSettings.Slots |= tbFilterWrist.IsChecked.Value ? SlotType.Wrist : 0;

			//if (sender != null) UpdateItemSearchResults();
		}

		private void ItemPropertyFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			//if (cbItemPropertyFilter.SelectedIndex == 0) ItemFilterSettings.SearchProperty = null;
			//else ItemFilterSettings.SearchProperty = (cbItemPropertyFilter.SelectedItem as DDOItemProperty).Property;

			//UpdateItemSearchResults();
		}

		private void TxtSearchBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			//UpdateItemSearchResults();
		}

		private void TbFilterBody_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			cmiFilterBodyCloth.IsChecked = cmiFilterBodyLight.IsChecked = cmiFilterBodyMedium.IsChecked = cmiFilterBodyHeavy.IsChecked = cmiFilterBodyDocent.IsChecked = !tbFilterBody.IsChecked ?? false;
		}

		private void TbFilterOffhand_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			cmiFilterOffhandBuckler.IsChecked = cmiFilterOffhandSmall.IsChecked = cmiFilterOffhandLarge.IsChecked = cmiFilterOffhandTower.IsChecked = cmiFilterOffhandOrb.IsChecked = !tbFilterOffhand.IsChecked ?? false;
		}

		private void LvItemList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			// validate user double-clicked over an item
			if (lvItemList.SelectedItem == null) return;

			Equipment item = lvItemList.SelectedItem as Equipment;
			//if (SlotItem(item, SlotType.None) != SlotType.None)
			//{
			//	CalculateGearSet(true);
			//}
		}

		private void LvItemList_MouseLeave(object sender, MouseEventArgs e)
		{
			//ItemRightClicked = false;
		}

		private void LvItemList_MouseUp(object sender, MouseButtonEventArgs e)
		{
			//if (ItemRightClicked && e.RightButton == MouseButtonState.Released)
			//{
			//	ItemRightClicked = false;
			//	System.Diagnostics.Process.Start(RightClickedItem.WikiURL);
			//	RightClickedItem = null;
			//}
		}

		private void ListViewItem_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
		{
			var item = sender as ListViewItem;
			if (item != null)
			{
				//RightClickedItem = item.Content as Equipment;
				//if (RightClickedItem != null) ItemRightClicked = true;
			}
		}

		private void LvItemList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			//OpenPropertiesTab(lvItemList.SelectedItem as Equipment);
		}

		private void ItemList_HeaderClick(object sender, RoutedEventArgs e)
		{
			string header = (e.OriginalSource as GridViewColumnHeader)?.Content.ToString();
			if (header == null) return;
			if (header != LastSortBy)
			{
				LastSortBy = header;
				LastSortDir = 1;
			}
			else LastSortDir *= -1;
			if (header == "Name") ItemListCopy.Sort((a, b) => string.Compare(a.Name, b.Name) * LastSortDir);
			//else if (header == "Slot") ItemListCopy.Sort((a, b) => string.Compare(a.Slot.ToString(), b.Slot.ToString()) == 0 ? string.Compare(a.Name, b.Name) : string.Compare(a.Slot.ToString(), b.Slot.ToString()));
			//else if (header == "ML") ItemListCopy.Sort((a, b) => a.ML < b.ML ? -1 * LastSortDir : (a.ML > b.ML ? 1 * LastSortDir : string.Compare(a.Name, b.Name)));

			//UpdateItemSearchResults();
		}

		private void BuildFilters_Click(object sender, RoutedEventArgs e)
		{
			//CurrentBuild.SetupLockedSlots(EquipmentSlots);
			//BuildFiltersWindow bfw = new BuildFiltersWindow();
			//bfw.Owner = this;
			//bfw.Initialize(CurrentBuild, EquipmentSlots);
			//bfw.ShowDialog();

			//if (bfw.FiltersChanged)
			//{
			//	if (CurrentBuild.BuildResults.Count != 0)
			//	{
			//		CurrentBuild.FiltersResultsMismatch = true;
			//		MessageBox.Show("By changing the build filters, the current build results will not match the new filter settings. If you save this build, the current build results will not be included in the save.", "Filters and results mismatch", MessageBoxButton.OK, MessageBoxImage.Warning);
			//	}
			//}

			//btnStartBuild.IsEnabled = miSaveBuildFilters.IsEnabled = CurrentBuild.ValidateFilters(false);
			//if (!btnStartBuild.IsEnabled) MessageBox.Show("A build cannot be started without a gear set or slot filter that includes an item property.", "Missing include filter", MessageBoxButton.OK, MessageBoxImage.Warning);
		}

		private void StartBuild_Click(object sender, RoutedEventArgs e)
		{
            //if (CurrentBuild.BuildResults.Count > 0 && MessageBox.Show("This will overwrite the current build results. Are you sure?", "Overwrite Results", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            //{
            //	return;
            //}

            //GC.Collect();

            //CurrentBuild.FiltersResultsMismatch = false;
            //CurrentBuild.SetupBuildProcess(EquipmentSlots);

            //miSaveBuildResults.IsEnabled = false;

            //BuildProcessWindow bpw = new BuildProcessWindow();
            //bpw.Initialize(CurrentBuild, false);
            //bpw.Owner = this;
            //if (bpw.ShowDialog() == true)
            //{
            //	miSaveBuildResults.IsEnabled = true;

            //	CurrentBuild.CurrentBuildResult = 0;
            //	SetBuildResult(0);
            //}

            //GC.Collect();
        }

		private void PreviousGearSet_Click(object sender, RoutedEventArgs e)
		{
			//if (CurrentBuild.CurrentBuildResult < 1) (sender as Button).IsEnabled = false;
			//SetBuildResult(--CurrentBuild.CurrentBuildResult);
		}

		private void NextGearSet_Click(object sender, RoutedEventArgs e)
		{
			//if (CurrentBuild.CurrentBuildResult >= CurrentBuild.BuildResults.Count - 2) (sender as Button).IsEnabled = false;
			//SetBuildResult(++CurrentBuild.CurrentBuildResult);
		}

		private void ImportNamedSet(object sender, RoutedEventArgs e)
		{
			//NamedSetSelectorWindow sw = new NamedSetSelectorWindow();
			//sw.Owner = this;
			//sw.Initialize(EquipmentSlots);
			//if (sw.ShowDialog().Value)
			//{
			//	List<DDOItemData> items = sw.GetItems();
			//	bool w = false;
			//	foreach (var item in items)
			//	{
			//		if (item.Slot == SlotType.Weapon && w) SlotItem(item, SlotType.Offhand);
			//		else
			//		{
			//			SlotItem(item, SlotType.None);
			//			if (item.Slot == SlotType.Weapon) w = true;
			//		}
			//	}

			//	CalculateGearSet(true);
			//}
		}

		private void LockFilledSlots(object sender, RoutedEventArgs e)
		{
			//CurrentBuild.LockedSlots.Clear();
			//foreach (var kv in EquipmentSlots)
			//{
			//	if (kv.Value.Item != null)
			//	{
			//		CurrentBuild.LockedSlots.Add(kv.Key);
			//		kv.Value.SetLockStatus(true);
			//	}
			//	else kv.Value.SetLockStatus(false);
			//}
		}

		private void UnlockClearAll(object sender, RoutedEventArgs e)
		{
			foreach (var kv in EquipmentSlots)
			{
				kv.Value.SetLockStatus(false);
				kv.Value.SetItem(null);
			}

            //CurrentBuild.LockedSlots.Clear();

            //CalculateGearSet(true);
        }

		private void SendGearsetToClipboard(object sender, RoutedEventArgs e)
		{
			Clipboard.Clear();
			//Clipboard.SetData(DataFormats.Text, SerializeGearset());
		}

		private void GetGearsetFromClipboard(object sender, RoutedEventArgs e)
		{
			//UnserializeGearset(Clipboard.GetData(DataFormats.Text).ToString());
		}

		private void ImportGearsetFromFile(object sender, RoutedEventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();// { InitialDirectory = AppDomain.CurrentDomain.BaseDirectory };
			ofd.Filter = "Gear Set file (*.gearset)|*.gearset";
			if (ofd.ShowDialog() == true)
			{
				//UnserializeGearset(File.ReadAllText(ofd.FileName));
			}
		}

		private void ExportGearsetToFile(object sender, RoutedEventArgs e)
		{
			// bring up a save file dialog
			SaveFileDialog sfd = new SaveFileDialog();// { InitialDirectory = AppDomain.CurrentDomain.BaseDirectory };
			sfd.Filter = "Gear Set file (*.gearset)|*.gearset";
			sfd.AddExtension = true;
			if (sfd.ShowDialog() == true)
			{
				//File.WriteAllText(sfd.FileName, SerializeGearset());
			}
		}
	}
}
