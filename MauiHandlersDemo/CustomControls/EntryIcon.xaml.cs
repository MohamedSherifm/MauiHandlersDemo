
using System.Diagnostics;

namespace MauiHandlersDemo.CustomControls;

public partial class EntryIcon : Border, IEntry
{
	public EntryIcon()
	{
		InitializeComponent();
	}

    public string StartIconGlyph
    {
        get { return (string)GetValue(StartIconGlyphProperty); }
        set { SetValue(StartIconGlyphProperty, value); }
    }

    public static readonly BindableProperty StartIconGlyphProperty =
        BindableProperty.Create(nameof(StartIconGlyph), typeof(string), typeof(EntryIcon), string.Empty);



    public bool IsPassword { get; }
    public ReturnType ReturnType { get; }
    public ClearButtonVisibility ClearButtonVisibility { get; }
    public string Text { get; set; }
    public bool IsTextPredictionEnabled { get; }
    public bool IsSpellCheckEnabled { get; }
    public bool IsReadOnly { get; }
    public Keyboard Keyboard { get; }
    public int MaxLength { get; }
    public int CursorPosition { get; set; }
    public int SelectionLength { get; set; }
    public Color TextColor { get; }
    public Microsoft.Maui.Font Font { get; }
    public double CharacterSpacing { get; }
    public string Placeholder { get; }
    public Color PlaceholderColor { get; set; }
    public TextAlignment HorizontalTextAlignment { get; }
    public TextAlignment VerticalTextAlignment { get; }
    string IText.Text { get; }

    public void Completed()
    {
        throw new NotImplementedException();
    }
}