using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XFApp.Model.Service;

namespace XFApp.Behavior
{
    public class MinLengthToEnabledOtherViewBehavior : Behavior<Entry>
    {
        internal Button OtherView { get; set; }
        internal int MinLength { get; set; }

        protected override void OnAttachedTo(Entry c)
        {
            c.TextChanged += TextChanged;
        }

        protected override void OnDetachingFrom(Entry c)
        {
            c.TextChanged -= TextChanged;
        }

        internal void TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OtherView != null) OtherView.IsEnabled = e.NewTextValue?.Length >= MinLength;
        }
    }

    public class AutoTabBehavior : Behavior<Entry>
    {

        public Entry NextEntry { get; set; }
        public int MaxLength { get; set; }

        protected override void OnAttachedTo(Entry c)
        {
            c.TextChanged += TextChanged;
        }

        protected override void OnDetachingFrom(Entry c)
        {
            c.TextChanged -= TextChanged;
        }

        internal void TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NextEntry != null && e.NewTextValue.Length == MaxLength)
            {
                NextEntry.Focus();
            }
            
        }

    }
}
