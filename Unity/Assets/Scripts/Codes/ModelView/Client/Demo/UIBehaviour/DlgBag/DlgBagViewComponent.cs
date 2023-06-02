
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgBagViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.RectTransform EGBackGroundRectTransform
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EGBackGroundRectTransform == null )
     			{
		    		this.m_EGBackGroundRectTransform = UIFindHelper.FindDeepChild<UnityEngine.RectTransform>(this.uiTransform.gameObject,"EGBackGround");
     			}
     			return this.m_EGBackGroundRectTransform;
     		}
     	}

		public UnityEngine.UI.ToggleGroup E_TopBtnToggleGroup
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TopBtnToggleGroup == null )
     			{
		    		this.m_E_TopBtnToggleGroup = UIFindHelper.FindDeepChild<UnityEngine.UI.ToggleGroup>(this.uiTransform.gameObject,"EGBackGround/E_TopBtn");
     			}
     			return this.m_E_TopBtnToggleGroup;
     		}
     	}

		public UnityEngine.UI.Toggle E_MatBtnToggle
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MatBtnToggle == null )
     			{
		    		this.m_E_MatBtnToggle = UIFindHelper.FindDeepChild<UnityEngine.UI.Toggle>(this.uiTransform.gameObject,"EGBackGround/E_TopBtn/E_MatBtn");
     			}
     			return this.m_E_MatBtnToggle;
     		}
     	}

		public ET.EUIText EText_MatEUIText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EText_MatEUIText == null )
     			{
		    		this.m_EText_MatEUIText = UIFindHelper.FindDeepChild<ET.EUIText>(this.uiTransform.gameObject,"EGBackGround/E_TopBtn/E_MatBtn/EText_Mat");
     			}
     			return this.m_EText_MatEUIText;
     		}
     	}

		public UnityEngine.UI.Toggle E_WeaponToggle
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_WeaponToggle == null )
     			{
		    		this.m_E_WeaponToggle = UIFindHelper.FindDeepChild<UnityEngine.UI.Toggle>(this.uiTransform.gameObject,"EGBackGround/E_TopBtn/E_Weapon");
     			}
     			return this.m_E_WeaponToggle;
     		}
     	}

		public ET.EUIText EText_WeaponEUIText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EText_WeaponEUIText == null )
     			{
		    		this.m_EText_WeaponEUIText = UIFindHelper.FindDeepChild<ET.EUIText>(this.uiTransform.gameObject,"EGBackGround/E_TopBtn/E_Weapon/EText_Weapon");
     			}
     			return this.m_EText_WeaponEUIText;
     		}
     	}

		public UnityEngine.UI.Toggle E_PropToggle
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PropToggle == null )
     			{
		    		this.m_E_PropToggle = UIFindHelper.FindDeepChild<UnityEngine.UI.Toggle>(this.uiTransform.gameObject,"EGBackGround/E_TopBtn/E_Prop");
     			}
     			return this.m_E_PropToggle;
     		}
     	}

		public ET.EUIText EText_PropEUIText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EText_PropEUIText == null )
     			{
		    		this.m_EText_PropEUIText = UIFindHelper.FindDeepChild<ET.EUIText>(this.uiTransform.gameObject,"EGBackGround/E_TopBtn/E_Prop/EText_Prop");
     			}
     			return this.m_EText_PropEUIText;
     		}
     	}

		public UnityEngine.UI.LoopVerticalScrollRect E_BagItemsLoopVerticalScrollRect
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_BagItemsLoopVerticalScrollRect == null )
     			{
		    		this.m_E_BagItemsLoopVerticalScrollRect = UIFindHelper.FindDeepChild<UnityEngine.UI.LoopVerticalScrollRect>(this.uiTransform.gameObject,"EGBackGround/ContentBackGround/E_BagItems");
     			}
     			return this.m_E_BagItemsLoopVerticalScrollRect;
     		}
     	}

		public ET.EUIButton EButton_CloseEUIButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_CloseEUIButton == null )
     			{
		    		this.m_EButton_CloseEUIButton = UIFindHelper.FindDeepChild<ET.EUIButton>(this.uiTransform.gameObject,"EGBackGround/EButton_Close");
     			}
     			return this.m_EButton_CloseEUIButton;
     		}
     	}

		public ET.EUIImage EButton_CloseEUIImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_CloseEUIImage == null )
     			{
		    		this.m_EButton_CloseEUIImage = UIFindHelper.FindDeepChild<ET.EUIImage>(this.uiTransform.gameObject,"EGBackGround/EButton_Close");
     			}
     			return this.m_EButton_CloseEUIImage;
     		}
     	}

		public ET.EUIButton E_PreviousEUIButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PreviousEUIButton == null )
     			{
		    		this.m_E_PreviousEUIButton = UIFindHelper.FindDeepChild<ET.EUIButton>(this.uiTransform.gameObject,"EGBackGround/Bottom/E_Previous");
     			}
     			return this.m_E_PreviousEUIButton;
     		}
     	}

		public ET.EUIImage E_PreviousEUIImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PreviousEUIImage == null )
     			{
		    		this.m_E_PreviousEUIImage = UIFindHelper.FindDeepChild<ET.EUIImage>(this.uiTransform.gameObject,"EGBackGround/Bottom/E_Previous");
     			}
     			return this.m_E_PreviousEUIImage;
     		}
     	}

		public ET.EUIText EText_PreviousEUIText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EText_PreviousEUIText == null )
     			{
		    		this.m_EText_PreviousEUIText = UIFindHelper.FindDeepChild<ET.EUIText>(this.uiTransform.gameObject,"EGBackGround/Bottom/E_Previous/EText_Previous");
     			}
     			return this.m_EText_PreviousEUIText;
     		}
     	}

		public ET.EUIButton E_NextEUIButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextEUIButton == null )
     			{
		    		this.m_E_NextEUIButton = UIFindHelper.FindDeepChild<ET.EUIButton>(this.uiTransform.gameObject,"EGBackGround/Bottom/E_Next");
     			}
     			return this.m_E_NextEUIButton;
     		}
     	}

		public ET.EUIImage E_NextEUIImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextEUIImage == null )
     			{
		    		this.m_E_NextEUIImage = UIFindHelper.FindDeepChild<ET.EUIImage>(this.uiTransform.gameObject,"EGBackGround/Bottom/E_Next");
     			}
     			return this.m_E_NextEUIImage;
     		}
     	}

		public ET.EUIText EText_NextEUIText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EText_NextEUIText == null )
     			{
		    		this.m_EText_NextEUIText = UIFindHelper.FindDeepChild<ET.EUIText>(this.uiTransform.gameObject,"EGBackGround/Bottom/E_Next/EText_Next");
     			}
     			return this.m_EText_NextEUIText;
     		}
     	}

		public ET.EUIText E_PageEUIText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PageEUIText == null )
     			{
		    		this.m_E_PageEUIText = UIFindHelper.FindDeepChild<ET.EUIText>(this.uiTransform.gameObject,"EGBackGround/Bottom/E_Page");
     			}
     			return this.m_E_PageEUIText;
     		}
     	}

		public UnityEngine.RectTransform EG_ESItemInfoRootRectTransform
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EG_ESItemInfoRootRectTransform == null )
     			{
		    		this.m_EG_ESItemInfoRootRectTransform = UIFindHelper.FindDeepChild<UnityEngine.RectTransform>(this.uiTransform.gameObject,"EG_ESItemInfoRoot");
     			}
     			return this.m_EG_ESItemInfoRootRectTransform;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_EGBackGroundRectTransform = null;
			this.m_E_TopBtnToggleGroup = null;
			this.m_E_MatBtnToggle = null;
			this.m_EText_MatEUIText = null;
			this.m_E_WeaponToggle = null;
			this.m_EText_WeaponEUIText = null;
			this.m_E_PropToggle = null;
			this.m_EText_PropEUIText = null;
			this.m_E_BagItemsLoopVerticalScrollRect = null;
			this.m_EButton_CloseEUIButton = null;
			this.m_EButton_CloseEUIImage = null;
			this.m_E_PreviousEUIButton = null;
			this.m_E_PreviousEUIImage = null;
			this.m_EText_PreviousEUIText = null;
			this.m_E_NextEUIButton = null;
			this.m_E_NextEUIImage = null;
			this.m_EText_NextEUIText = null;
			this.m_E_PageEUIText = null;
			this.m_EG_ESItemInfoRootRectTransform = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_EGBackGroundRectTransform = null;
		private UnityEngine.UI.ToggleGroup m_E_TopBtnToggleGroup = null;
		private UnityEngine.UI.Toggle m_E_MatBtnToggle = null;
		private ET.EUIText m_EText_MatEUIText = null;
		private UnityEngine.UI.Toggle m_E_WeaponToggle = null;
		private ET.EUIText m_EText_WeaponEUIText = null;
		private UnityEngine.UI.Toggle m_E_PropToggle = null;
		private ET.EUIText m_EText_PropEUIText = null;
		private UnityEngine.UI.LoopVerticalScrollRect m_E_BagItemsLoopVerticalScrollRect = null;
		private ET.EUIButton m_EButton_CloseEUIButton = null;
		private ET.EUIImage m_EButton_CloseEUIImage = null;
		private ET.EUIButton m_E_PreviousEUIButton = null;
		private ET.EUIImage m_E_PreviousEUIImage = null;
		private ET.EUIText m_EText_PreviousEUIText = null;
		private ET.EUIButton m_E_NextEUIButton = null;
		private ET.EUIImage m_E_NextEUIImage = null;
		private ET.EUIText m_EText_NextEUIText = null;
		private ET.EUIText m_E_PageEUIText = null;
		private UnityEngine.RectTransform m_EG_ESItemInfoRootRectTransform = null;
		public Transform uiTransform = null;
	}
}
