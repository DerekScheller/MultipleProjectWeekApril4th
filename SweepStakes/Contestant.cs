using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {
        private string _name;
        private uint _phoneNumber;
        private string _mailingAddress;
        public Contestant(string name, uint phoneNumber, string mailingAddress)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            MailingAddress = mailingAddress;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public uint PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public string MailingAddress
        {
            get { return _mailingAddress; }
            set { _mailingAddress = value; }
        }
        public override string ToString()
        {
            string ContestantInfo = string.Format("{0}, lives at {1}, and can be reached by phone at {2}.", Name, MailingAddress, PhoneNumber);
            return ContestantInfo;
        }
    }
}
