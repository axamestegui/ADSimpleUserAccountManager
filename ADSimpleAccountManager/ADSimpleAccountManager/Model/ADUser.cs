using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ADSimpleAccountManager.Model
{
    internal class ADUser : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string GivenName { get; set; }
        public string UserPrincipalName { get; set; }
        public string DistinguishedName { get; set; }   
        public string EMail { get; set; }
        public string SN { get; set; }
        public string Adspath { get; set; }
        public string Surname { get; set; }
        public string EmployeeId { get; set; }
        public string Guid { get; set; }    
        public string Sid { get; set; }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
