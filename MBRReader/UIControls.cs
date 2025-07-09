using System.Windows.Forms;
using System.Drawing;

internal static class UIControls {
    public static Button CreateButton(string text, int height, DockStyle dock, EventHandler onClick) {
        var btn = new Button {
            Text = text,
            Height = height,
            Dock = dock
        };
        btn.Click += onClick;
        return btn;
    }

    public static TextBox CreateTextBox(Font font, ScrollBars scrollBars, bool wordWrap, DockStyle dock) {
        return new TextBox {
            Multiline = true,
            Font = font,
            ScrollBars = scrollBars,
            WordWrap = wordWrap,
            Dock = dock
        };
    }
}
