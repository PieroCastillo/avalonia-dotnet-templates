using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Media;
using Avalonia.Markup.Xaml;

namespace AvaloniaLibraryTemplate.Controls
{
    public class Control1 : TemplatedControl
    {
         public Control1()
         {
            InitializeComponent();
         }

         private void InitializeComponent()
         {
             AvaloniaXamlLoader.Load(this);
         }
    }
}