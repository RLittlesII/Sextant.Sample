using System;
using ReactiveUI;
using Sextant;

namespace Sample.ViewModels
{
	public class FirstModalNavigationViewModel : ViewModelBase, IPageViewModel
	{
		public FirstModalNavigationViewModel(IViewStackService viewStackService)
            : base(viewStackService)
		{

		}
		public string Id => nameof(FirstModalNavigationViewModel);
	}
}
