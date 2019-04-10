using ReactiveUI;
using ReactiveUI.XamForms;
using Sextant;
using Sample.ViewModels;

namespace Sample.Views
{
	public partial class RedView : ReactiveContentPage<RedViewModel>
    {
        public RedView()
        {
            InitializeComponent();
			this.BindCommand(ViewModel, x => x.PopModal, x => x.PopModal);
            this.BindCommand(ViewModel, x => x.PushPage, x => x.PushPage);
            this.BindCommand(ViewModel, x => x.PopPage, x => x.PopPage);
        }
    }
}
