using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET.Client
{
    [FriendOf(typeof(DlgBag))]
    [FriendOf(typeof(BagComponent))]
    public static class DlgBagSystem
    {

        public static void RegisterUIEvent(this DlgBag self)
        {
            self.RegisterCloseEvent<DlgBag>(self.View.EButton_CloseEUIButton);
            self.View.E_TopBtnToggleGroup.AddListener(self.OnTopToggleSelectdHander);
            self.View.E_NextEUIButton.AddListener(self.OnNextPageHandler);
            self.View.E_PreviousEUIButton.AddListener(self.OnPreviousPageHandler);
            self.View.E_BagItemsLoopVerticalScrollRect.AddItemRefreshListener(self.OnLoopItemRefreshHandler);

        }

        public static void ShowWindow(this DlgBag self, ShowWindowDataBase contextData = null)
        {
            self.View.E_MatBtnToggle.IsSelected(true);
        }

        public static void HideWindow(this DlgBag self)
        {
            self.RemoveUIScrollItems(ref self.ScrollItemBagItems);
        }

        public static void Refresh(this DlgBag self)
        {
            self.RefreshItems();
        }
         /// <summary>
         /// 刷新物品
         /// </summary>
         /// <param name="self"></param>
        public static void RefreshItems(this DlgBag self)
        {
            self.ClientScene().GetComponent<BagComponent>().ItemMap.TryGetValue((int)self.CurrentItemType, out List<Item> itemsList);
        }

         public static void RefreshPageIndexInfo(this DlgBag self)
         {
             int itemCount     = self.ClientScene().GetComponent<BagComponent>().GetItemCountByItemType(self.CurrentItemType);
             int maxShowCount  = (self.CurrentPageIndex * 30) + 30;
			
             self.View.E_PreviousEUIButton.interactable = self.CurrentPageIndex != 0;
             self.View.E_NextEUIButton.interactable     = itemCount > maxShowCount;

             int maxPageIndex          = Mathf.CeilToInt(itemCount / 30.0f);
             self.View.E_PageEUIText.text = $"{self.CurrentPageIndex + 1} / {maxPageIndex}";
         }
         
        public static void OnTopToggleSelectdHander(this DlgBag self, int index)
        {
            self.CurrentItemType = (ItemType)index;
            self.CurrentPageIndex = 0;
            self.Refresh();
        }

        public static void OnPreviousPageHandler(this DlgBag self)
        {
            --self.CurrentPageIndex;
            self.Refresh();
        }

        public static void OnNextPageHandler(this DlgBag self)
        {
            ++self.CurrentPageIndex;
            self.Refresh();
        }

        public static void OnLoopItemRefreshHandler(this DlgBag self, Transform transform, int index)
        {
            self.ClientScene().GetComponent<BagComponent>().ItemMap.TryGetValue((int)self.CurrentItemType, out List<Item> itemsList);
            Scroll_Item_bagItem scrollItemBagItem = self.ScrollItemBagItems[index].BindTrans(transform);
            index = (self.CurrentPageIndex * 30) + index;
            scrollItemBagItem.Refresh(itemsList[index].Id);
        }

      

    }
}
