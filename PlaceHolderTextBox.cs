public class PlaceholderTextBox : TextBox
{
    private string placeholderText = "Entrer du texte...";
    private Color placeholderColor = Color.FromArgb(205, 33, 42);
    private Color defaultForeColor;
    private bool isPlaceholderActive = false;
    private char defaultPasswordChar;

    public string PlaceholderText
    {
        get => placeholderText;
        set
        {
            placeholderText = value;
            SetPlaceholder();
        }
    }

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
            Text = placeholderText;
            ForeColor = placeholderColor;
            PasswordChar = '\0'; // désactive le masquage pour afficher le placeholder
        }
    }

    private void RemovePlaceholder(object sender = null, EventArgs e = null)
    {
        if (isPlaceholderActive)
        {
            isPlaceholderActive = false;
            Text = "";
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
