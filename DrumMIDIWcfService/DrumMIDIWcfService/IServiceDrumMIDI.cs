using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;

namespace DrumMIDIWcfService
{
    [ServiceContract]
    public interface IServiceDrumMIDI
    {
        [OperationContract]
        List<String> UserList();

        [OperationContract]
        Boolean UserLogin(String _UserName, String _Password);

        [OperationContract]
        Boolean UserCreate(String _UserName, String _Password);
    }
}
