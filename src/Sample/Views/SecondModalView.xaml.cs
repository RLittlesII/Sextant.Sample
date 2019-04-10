using ReactiveUI;
using ReactiveUI.XamForms;
using Sextant;
using Sample.ViewModels;

namespace Sample.Views
{
	public partial class SecondModalView : ReactiveContentPage<SecondModalViewModel>
    {
		public SecondModalView()
        {
            InitializeComponent();
			this.BindCommand(ViewModel, x => x.PushPage, x => x.PushPage);
            this.BindCommand(ViewModel, x => x.PopModal, x => x.PopModal);
        }
    }
}
