using ReactiveUI;
using ReactiveUI.XamForms;
using Sextant;
using Sample.ViewModels;
using System.Reactive.Disposables;

namespace Sample.Views
{
	public partial class HomeView : ReactiveContentPage<HomeViewModel>
    {
		public HomeView()
        {
            InitializeComponent();

			this.WhenActivated(disposables =>
            {
				this.BindCommand(ViewModel, x => x.OpenModal, x => x.FirstModalButton).DisposeWith(disposables);
                this.BindCommand(ViewModel, x => x.PushPage, x => x.PushPage);
            });
        }
    }
}
