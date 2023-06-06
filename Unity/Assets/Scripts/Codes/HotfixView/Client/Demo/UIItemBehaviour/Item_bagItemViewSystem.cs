
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ObjectSystem]
	public class Scroll_Item_bagItemDestroySystem : DestroySystem<Scroll_Item_bagItem> 
	{
		protected override void Destroy( Scroll_Item_bagItem self )
		{
			self.DestroyWidget();
		}
	}

	public static class Scroll_Item_bagItemSystem
	{
		public static void Refresh(this Scroll_Item_bagItem self,long id)
		{
			Item item = self.ClientScene().GetComponent<BagComponent>().GetItemById(id);
            
			self.E_IconImage.overrideSprite = IconHelper.LoadIconSprite("Icons", item.ItemConfig.Icon);
			self.E_QualityImage.color       = item.ItemQualityColor();
			self.E_SelectButton.AddListenerWithId(self.OnShowItemEntryPopUpHandler,id);
		}
        
		public static void OnShowItemEntryPopUpHandler(this Scroll_Item_bagItem self, long Id)
		{
			self.ClientScene().GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_ItemPopUp);
			Item item = self.ClientScene().GetComponent<BagComponent>().GetItemById(Id);
			self.ClientScene().GetComponent<UIComponent>().GetDlgLogic<DlgItemPopUp>().RefreshInfo(item,ItemContainerType.Bag);
		}
	}
}
