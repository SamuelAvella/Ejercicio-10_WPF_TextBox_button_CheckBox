using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateTextButton_Click(object sender, RoutedEventArgs e)
        {
            // Verificar si el CheckBox está marcado
            if (AlternateTextCheckBox.IsChecked == true)
            {
                // Configurar texto alternativo con subrayado y negrita
                MainTextBlock.Inlines.Clear();
                MainTextBlock.Inlines.Add(new Run("Este texto es alternativo y ") { TextDecorations = TextDecorations.Underline });
                MainTextBlock.Inlines.Add(new Run("tiene negrita.") { FontWeight = FontWeights.Bold });
            }
            else
            {
                // Configurar texto simple sin formato
                MainTextBlock.Inlines.Clear();
                MainTextBlock.Inlines.Add(new Run("Este es un texto simple sin formato."));
            }
        }
    }
}