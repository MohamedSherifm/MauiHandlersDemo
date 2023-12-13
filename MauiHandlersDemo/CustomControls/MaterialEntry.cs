using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlersDemo.CustomControls
{
    public partial class MaterialEntry : View, IMaterialEntry
    {
        public static readonly BindableProperty PlaceHolderProperty =
           BindableProperty.Create(
               nameof(PlaceHolder),
               typeof(string),
               typeof(MaterialEntry),
               string.Empty);
        public string PlaceHolder
        {
            get => (string)GetValue(PlaceHolderProperty);
            set { SetValue(PlaceHolderProperty, value); }
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(
                nameof(TextColor),
                typeof(Color),
                typeof(MaterialEntry),
                Colors.Black);
        public Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set { SetValue(TextColorProperty, value); }
        }

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
        string IText.Text { get; }
        public Microsoft.Maui.Font Font { get; }
        public double CharacterSpacing { get; }
        public string Placeholder { get; }
        public Color PlaceholderColor { get; set; }
        public TextAlignment HorizontalTextAlignment { get; }
        public TextAlignment VerticalTextAlignment { get; }

        public event EventHandler ClearRequested;
        public event EventHandler SaveRequested;

        public void Clear()
        {
            ClearRequested?.Invoke(this, EventArgs.Empty);
            Handler?.Invoke(nameof(IDraw.Clear));
        }

        public void Save()
        {
            SaveRequested?.Invoke(this, EventArgs.Empty);
            Handler?.Invoke(nameof(IDraw.Save));
        }

        public void Completed()
        {
            throw new NotImplementedException();
        }
    }
}
