# PickerUpdateSample
Sample Xamarin.Forms project illustrating an issue with Picker binding

### Description
When using a `Picker` control with its `ItemsSource` bound to an `ObservableCollection`, the `Picker` only responds to additions and deletions in the collection, not to updates in the collection's members.

### Steps to Reproduce
1.   Create a `Picker` control bound to an `ObservableCollection`
2.   Mutate the displayed property (that is, the property denoted by the Picker's `ItemDisplayBinding` of one member of the collection

### Expected Behavior
The new value should appear in the `Picker`.

### Actual Behavior
No changes is shown in the `Picker`.

### Basic Information

- Version with issue: 3.1.0.697729
- Last known good version: none
- IDE: Visual Studio 2017
- Platform Target Frameworks: <!-- All that apply -->
  - Android: 8.1 - API 27
- Nuget Packages: Refactored.MvvmHelpers (although the problem presents without this package as well)
