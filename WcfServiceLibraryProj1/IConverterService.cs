using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;


namespace WcfServiceLibraryProj1
{
    [ServiceContract]
    public interface IConverterService
    {
        [OperationContract]
        String Calc_bmi(double weight, double height);

        [OperationContract]
        String ConvertTemperature(int from, int to, double temp);

        [OperationContract]
        String ConvertLength(int from, int to, double length);

        [OperationContract]
        String ConvertMass(int from, int to, double mass);

        [OperationContract]
        String ConvertEnergy(int from, int to, double amount);

        [OperationContract]
        String Calc_Interest(double prinAmt, double rate, double year, int type);

    }
}
