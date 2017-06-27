using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidgets;
using Phidgets.Events;

namespace Sales
{
    interface iRFID
    {
        void AttachTag(object sender, TagEventArgs e);
    }
}
