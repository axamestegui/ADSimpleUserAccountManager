using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ADSimpleAccountManager.Model
{
    public class AppSw1User : INotifyPropertyChanged
    {
        private int keyId;
        private int refProfile;
        private int intBarcode;
        private string txtName = string.Empty;
        private string txtLogin = string.Empty;
        private string txtPassword = string.Empty;
        private byte bolActive;
        private string txtRemarks = string.Empty;
        private byte bolMustChangePassworkd;

        public int KeyId { get { return keyId; } }
        public int Profile
        {
            get { return refProfile; }
            set
            {
                if (value != refProfile)
                {
                    refProfile = value;
                    INotifyPropertyChanged();
                }
            }
        }
        public int Barcode
        {
            get { return intBarcode; }
            set
            {
                if (value != intBarcode)
                {
                    intBarcode = value;
                    INotifyPropertyChanged();
                }
            }
        }
        public string Name
        {
            get { return txtName; }
            set
            {
                if (value != txtName)
                {
                    txtName = value;
                    INotifyPropertyChanged();
                }
            }
        }
        public string Login
        {
            get { return txtLogin; }
            set
            {
                if (value != txtLogin)
                {
                    txtLogin = value;
                    INotifyPropertyChanged();
                }
            }
        }
        public string Password
        {
            get { return txtPassword; }
            set
            {
                if (value != txtPassword)
                {
                    txtPassword = value;
                    INotifyPropertyChanged();
                }
            }
        }
        public byte Active { get { return bolActive; }
            set
            {
                if (value != bolActive)
                {
                    bolActive = value;
                    INotifyPropertyChanged();
                }
            }
        }
        public byte MustChangePassworkd { get { return bolMustChangePassworkd; }
            set
            {
                if (value!= bolMustChangePassworkd)
                {
                    bolMustChangePassworkd = value;
                    INotifyPropertyChanged();
                }
            }
        }
        public string Remarks
        {
            get { return txtRemarks; }
            set
            {
                if (value != txtRemarks)
                {
                    txtRemarks = value;
                    INotifyPropertyChanged();
                }
            }
        }

        public override string ToString()
        {
            return $"{refProfile} {txtName}";
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void INotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
