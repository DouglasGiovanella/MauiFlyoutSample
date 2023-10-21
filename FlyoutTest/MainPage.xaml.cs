namespace FlyoutTest;

public partial class MainPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		flyoutPage.collectionView.SelectionChanged += OnSelectionChanged;
	}

	void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection.FirstOrDefault() is FlyoutPageItem item)
		{
				IsPresented = false;
		}
	}
}


