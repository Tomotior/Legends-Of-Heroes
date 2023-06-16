namespace ET.Client
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgItemPopUp :Entity,IAwake,IUILogic
	{

		public DlgItemPopUpViewComponent View { get => this.GetParent<UIBaseWindow>().GetComponent<DlgItemPopUpViewComponent>();} 

		 

	}
}
