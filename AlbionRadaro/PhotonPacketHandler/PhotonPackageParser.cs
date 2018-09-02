using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionRadaro
{
    public interface IPhotonPackageHandler
    {
        void OnEvent(byte code, Dictionary<byte, object> parameters);

        void OnResponse(byte operationCode, short returnCode, Dictionary<byte, object> parameters);

        void OnRequest(byte operationCode, Dictionary<byte, object> parameters);
    }
}