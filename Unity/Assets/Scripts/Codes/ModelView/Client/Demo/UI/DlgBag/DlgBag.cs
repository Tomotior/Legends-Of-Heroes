using System.Collections.Generic;

namespace ET.Client
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgBag :Entity,IAwake,IUILogic
	{

		public DlgBagViewComponent View { get => this.GetParent<UIBaseWindow>().GetComponent<DlgBagViewComponent>();}

		public Dictionary<int, Scroll_Item_bagItem> ScrollItemBagItems;//背包物品

		public ItemType CurrentItemType;//当前物品类型

		public int CurrentPageIndex = 0;//当前在第几页



	}
}
