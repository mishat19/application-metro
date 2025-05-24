using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class PlaceholderTextBox : TextBox
{
    private string placeholderText = "Entrer du texte...";
    private Color placeholderColor = Color.Gray;
    private Color defaultForeColor;
    private bool isPlaceholderActive = false;

    [Category("Placeholder")]
    public string PlaceholderText
    {
        get => placeholderText;
        set
        {
            placeholderText = value;
            SetPlaceholder();
        }
    }

    [Category("Placeholder")]
    public Color PlaceholderColor
    {
        get => placeholderColor;
        set
        {
            placeholderColor = value;
            if (isPlaceholderActive)
                ForeColor = placeholderColor;
        }
    }

    public PlaceholderTextBox()
    {
        defaultForeColor = this.ForeColor;
        GotFocus += RemovePlaceholder;
        LostFocus += SetPlaceholder;
        TextChanged += HandleTextChanged;
    }

    private void SetPlaceholder(object sender = null, EventArgs e = null)
    {
        if (string.IsNullOrWhiteSpace(Text))
        {
            isPlaceholderActive = true;
            Text = placeholderText;
            ForeColor = placeholderColor;
        }
    }

    private void RemovePlaceholder(object sender = null, EventArgs e = null)
    {
        if (isPlaceholderActive)
        {
            isPlaceholderActive = false;
            Text = "";
            ForeColor = defaultForeColor;
        }
    }

    private void HandleTextChanged(object sender, EventArgs e)
    {
        if (!Focused && string.IsNullOrWhiteSpace(Text))
        {
            SetPlaceholder();
        }
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        SetPlaceholder();
    }

    public bool IsPlaceholderActive => isPlaceholderActive;
}
