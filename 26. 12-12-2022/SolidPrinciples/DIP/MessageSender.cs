using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class MessageSender
    {
        //Email _email;
        //SMS _sms;
        //Facebook _facebook;

        List<IMessageSender> _senderList;

        public MessageSender(List<IMessageSender> senderList)
        {
            this._senderList = senderList;
        }

        //public MessageSender(Email email, SMS sms, Facebook facebook)
        //{
        //    _email = email;
        //    _sms = sms;
        //    _facebook = facebook;
        //}

        public void Send()
        {
            foreach (var item in _senderList)
            {
                item.Send();
            }
        }
    }
}
