using System.Drawing;
using System.Windows.Forms;

public static class PlaceholderConfig
{
    public static void ApplyPlaceholderColor(Control parent, Color color)
    {
        foreach (Control control in parent.Controls)
        {
            if (control is PlaceholderTextBox placeholder)
            {
                placeholder.PlaceholderColor = color;
            }

            if (control.HasChildren)
                ApplyPlaceholderColor(control, color);
        }
    }
}
