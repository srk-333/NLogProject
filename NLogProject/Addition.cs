using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogProject
{
    public class Addition        
    {
        private readonly NLog nLog = new NLog();

        public int Sum(int firstnumber, int secondNumber)
        {
            if (firstnumber == 0 || secondNumber == 0)
            {
                nLog.LogDebug(" Debug is unsuccessful : Sum() ");
                nLog.LogError(" Number cann't be zero ");
                nLog.LogWarn(" FirstNumber and Secondnumber should not be zero ");

            }
            int result = firstnumber + secondNumber;
            nLog.LogDebug(" Debug is successful : Sum() ");
            nLog.LogInfo(" Sum Method passed ! Result is : " + result);
            return result;
        }
    }
}
