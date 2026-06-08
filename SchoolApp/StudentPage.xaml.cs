namespace SchoolApp;

public partial class StudentsPage : ContentPage
{
    public StudentsPage()
    {
        InitializeComponent();

        // Mock data. We replace this with the database in L16.
        StudentsList.ItemsSource = new[]
        {
            "Otezhan Black",
            "Yasha Lava",
            "Daia Iskakova",
            "Nurbol Nurpeisov",
            "Nikolay Katkalov"
        };
    }

    private async void OnStudentSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not string name) return;

        await Shell.Current.GoToAsync(
            $"{nameof(StudentDetailPage)}?name={Uri.EscapeDataString(name)}");

        // Clear selection so the same item can be tapped again after returning
        StudentsList.SelectedItem = null;
    }
}