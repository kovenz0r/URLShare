using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Windows.Forms;

namespace WCFWinForm
{
    [ServiceContract]
    public interface IApplicationService
    {
        [OperationContract(IsOneWay = true)]
        void GetURL();
    }

    public class ApplicationService : IApplicationService
    {
        public void GetURL()
        {
            var addCopy = Clipboard.GetText(TextDataFormat.Text);
            WCF.listURL.Items.AddRange(addCopy.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
