
using Xamarin.Forms;
using MvvmHelpers;
using System.Windows.Input;

namespace Counter
{
	public class MainPageViewModel : BaseViewModel
	{

		public MainPageViewModel()
		{
			IncreaseCountCommand = new Command(() => IncreaseCount());
		}

		int count = 0;

		public int Count
		{
			get => count;
			set => SetProperty(ref count, value);
		}

		public ICommand IncreaseCountCommand { get; }

		public void IncreaseCount()
		{
			Count++;
		}
	}
}
