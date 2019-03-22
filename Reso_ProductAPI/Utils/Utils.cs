using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reso_ProductAPI.Controllers
{
    public interface IUtils
    {
        bool CheckToken(string token);
    }
    public class Utils : IUtils
    {
        private IConfiguration _iConfig;
        public Utils(IConfiguration iconfig)
        {
            _iConfig = iconfig;
        }

        private static string _enableToken = "";
        public bool CheckToken(string token)
        {
            string _accessToken = _iConfig.GetSection("AppSetting").GetSection("config.order.token").Value;
            if (token != _accessToken)
            {
                //throw new Exception("Invalid token!!1");
                return false;
            }
            return true;
        }
    }
}
