
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ObjectSystem]
	public class DlgBagViewComponentAwakeSystem : AwakeSystem<DlgBagViewComponent> 
	{
		protected override void Awake(DlgBagViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgBagViewComponentDestroySystem : DestroySystem<DlgBagViewComponent> 
	{
		protected override void Destroy(DlgBagViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
