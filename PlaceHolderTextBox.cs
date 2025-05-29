public class PlaceholderTextBox : TextBox
{
    private Color placeholderColor = Color.FromArgb(205, 33, 42);
    private Color defaultForeColor;
    private bool isPlaceholderActive = false;
    private char defaultPasswordChar;


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

    public override Color ForeColor
    {
        get => base.ForeColor;
        set
        {
            base.ForeColor = value;
            defaultForeColor = value;
        }
    }

    public PlaceholderTextBox()
    {
        defaultForeColor = this.ForeColor;
        defaultPasswordChar = this.PasswordChar;
        GotFocus += RemovePlaceholder;
        LostFocus += SetPlaceholder;
        TextChanged += HandleTextChanged;
    }

    private void SetPlaceholder(object sender = null, EventArgs e = null)
    {
        if (string.IsNullOrWhiteSpace(Text))
        {
            isPlaceholderActive = true;
            ForeColor = placeholderColor;
            PasswordChar = '\0'; // désactive le masquage pour afficher le placeholder
        }
    }

    private void RemovePlaceholder(object sender = null, EventArgs e = null)
    {
        if (isPlaceholderActive)
        {
            isPlaceholderActive = false;
            ForeColor = defaultForeColor;
            PasswordChar = defaultPasswordChar; // réactive le masquage
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
