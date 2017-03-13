using System;
using AulaSeis.Behaviors;
using Xamarin.Forms;

namespace AulaSeis.Custom
{
    public class EntryCustom : Entry
    {
        public EntryCustom()
        {
            this.Placeholder = "Insira um float";
            NumericValidationBehavior.SetAttachBehavior(this, true);
        }
    }
}
