# How-to-get-checked-items-indexes-in-sflistview
This example demonstrates how to retrieve the indexes of checked items in the SfListView control using Syncfusion’s Windows Forms UI components. The SfListView supports checkboxes, allowing users to select multiple items. In many real-world applications, it’s useful to know not just which items are selected, but also their positions (indexes) within the list.
To achieve this, the example uses the CheckedItems collection in combination with the DisplayItems.IndexOf() method. By iterating through the items in the view and comparing them with the checked items, you can determine the index of each selected item and store it in a separate collection.
Key Implementation Steps:
    • Enable checkboxes in SfListView using ShowCheckBoxes = true.
    • Loop through the View.Items and compare each with the CheckedItems.
    • Use DisplayItems.IndexOf() to get the index of each checked item.
    • Store the indexes in an ObservableCollection<int> for further use.
    • This approach is efficient and integrates well with MVVM patterns in WinForms.
