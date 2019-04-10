using ReactiveUI;
using ReactiveUI.XamForms;
using Sextant;
using Sample.ViewModels;
using Xamarin.Forms;

namespace Sample.Views
{
	public partial class FirstModalView : ReactiveContentPage<FirstModalViewModel>
    {
		public FirstModalView()
        {
			InitializeComponent();
			this.BindCommand(ViewModel, x => x.OpenModal, x => x.OpenSecondModal);
			this.BindCommand(ViewModel, x => x.PopModal, x => x.PopModal);
        }
    }
}
