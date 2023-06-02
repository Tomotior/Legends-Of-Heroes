
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
}
