using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET.Client
{
	[FriendOf(typeof(DlgBag))]
	public static  class DlgBagSystem
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
			
		}
       
		public static void HideWindow(this DlgBag self)
		{
			self.RemoveUIScrollItems(ref self.ScrollItemBagItems);
		}

		public static void Refresh(this DlgBag self)
		{
			
		}
		
		
		public static void OnTopToggleSelectdHander(this DlgBag self,int index)
		{
			
		}
		
		public static void OnPreviousPageHandler(this DlgBag self)
		{
			
		}
		
		public static void OnNextPageHandler(this DlgBag self)
		{
			
		}
		
		public static void OnLoopItemRefreshHandler(this DlgBag self,Transform transform,int index)
		{
			
		}
		
		
		
	}
}
