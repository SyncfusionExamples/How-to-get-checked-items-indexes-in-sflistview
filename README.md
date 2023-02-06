# How-to-get-checked-items-indexes-in-sflistview
In SfListView, you can get the index of the item in CheckedItems collection by using the IndexOf method in DisplayItems property.

# C#

        sfListView1.ShowCheckBoxes = true;
        ObservableCollection<int> selectedIndex = new ObservableCollection<int>();

        foreach (var allItems in sfListView1.View.Items)
        {
            foreach (var checkedItem in sfListView1.CheckedItems)
            {
                if (allItems == checkedItem)
                {
                     selectedIndex.Add(sfListView1.View.DisplayItems.IndexOf(allItems));
                }
            }
        }

![Checked Item Index](https://user-images.githubusercontent.com/93652178/204502856-e286e616-345e-4fd9-97b5-7b6039172e65.png)



