using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using XFApp.Model.Service;

namespace XFApp.ViewModel
{
    public class FormPageViewModel : BindableBase
    {
        string name;

        public string Name
        {
            get { return name; }
            set { this.SetProperty(ref this.name, value); }
        }

        Int32 age;
        public Int32 Age
        {
            get { return age; }
            set { this.SetProperty(ref this.age, value); }
        }


        public FormPageViewModel() {
            PropertyChanged += AgeChanged;
            PropertyChanged += NameChanged;
        }

        private void NameChanged(object sender, PropertyChangedEventArgs e)
        {
            // 文字列でプロパティ名を判別
            if (e.PropertyName != PropertyService.GetName(() => Name)) return;

            var f = (FormPageViewModel)sender;

            LogService.OutputLog("名前が変更されました: " + f.Name);
        }

        private void AgeChanged(object sender, PropertyChangedEventArgs e)
        {

            // 文字列でプロパティ名を判別
            if (e.PropertyName != PropertyService.GetName(()=> Age)) return;

            var f = (FormPageViewModel)sender;

            LogService.OutputLog("年齢が変更されました: " + f.Age);
        }
    }
}
