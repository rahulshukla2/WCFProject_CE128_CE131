using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryProj1
{
    public class ConverterService : IConverterService
    {


//-------------------------------------------------Calculate BMI------------------------------------------------------------------
        public String Calc_bmi(double weight, double height)
        {
            double answer = weight / (height * height);

            if (answer <= 18.4)
            {
                return String.Format("Your Bmi is {0:0.00}, You are Underweight",answer);
            }
            else if(answer <=24.9 && answer >=18.5)
            {
                return String.Format("Your Bmi is {0:0.00}, You are healthy", answer);
            }
            else
            {
                return String.Format("Your Bmi is {0:0.00}, You are Overweight", answer);
            }
        }

//--------------------------------------------------Temperature Converter-------------------------------------------------------------
        public String ConvertTemperature(int from, int to, double temp)
        {
            //0-->celsius
            //1-->fahrenheit
            //2-->kelvin
            double answer = 0.0;

            if (from == 0 && to == 0)//celsius to celsius
            {
                return String.Format("The temperature is {0:0.00 degree celsius}", temp);
            }
            else if(from == 0 && to == 1)//celsius to fahrenheit
            {
                answer = (temp * ((double)9 / 5)) + 32;
                return String.Format("The temperature is {0:0.00} degree fahrenheit ", answer);

            }
            else if (from == 0 && to == 2)//celsius to kelvin
            {
                answer = temp + 273.15;
                return String.Format("The temperature is {0:0.00} degree kelvin", answer);

            }
            else if (from == 1 && to == 1)//fahrenheit to fahrenheit
            {
                return String.Format("The temperature is {0:0.00 degree fahrenhei}", temp);

            }
            else if (from == 1 && to == 0)//fahrenheit to celsius
            {
                answer = ((temp - 32) * 5) / 9;
                return String.Format("The temperature is {0:0.00} degree celsius", answer);

            }
            else if (from == 1 && to == 2)//fahrenheit to kelvin
            {
                answer = ((temp - 32) * 5) / 9;
                answer += 273.15;
                return String.Format("The temperature is {0:0.00} degree kelvin", answer);

            }
            else if (from == 2 && to == 2)//kelvin to kelvin
            {
                return String.Format("The temperature is {0:0.00 degree kelvin}", temp);

            }
            else if (from == 2 && to == 0)//kelvin to celsius
            {
                
                answer = temp - 273.15;
                return String.Format("The temperature is {0:0.00} degree celsius", answer);

            }
            else if (from == 2 && to == 1)//kelvin to fahrenheit
            {

                answer = temp - 273.15;
                answer = (answer * ((double)9 / 5)) + 32;

                return String.Format("The temperature is {0:0.00} degree celsius", answer);

            }
        return "Default";

        }


//------------------------------------------------------length converter --------------------------------------------------------------------------------------------------------
       
        public double ConvertToMilli(int from, double length)
        {
            double ans = 0.0;

            if (from == 0)//from kiliometer
            {
                ans = length * 1000000;
                return ans;
            }
            else if(from == 1)//from meter
            {
                ans = length * 1000;
                return ans;
            }
            else if (from == 2)//from centimeter
            {
                ans = length * 10;
                return ans;
            }
            else if (from == 3)//from millimeter
            {
                ans = length;
                return ans;
            }
            else if (from == 4)//from micrometer
            {
                ans = length / 1000;
                return ans;
            }
            else if (from == 5)//from nanometer
            {
                ans = length / 1000000;
                return ans;
            }
            else if (from == 6)//from mile
            {
                ans = length * 1609344;
                return ans;
            }
            else if (from == 7)//from yard
            {
                ans = length * 914.4;
                return ans;
            }
            else if (from == 8)//from foot
            {
                ans = length * 304.8;
                return ans;
            }
            else if (from == 9)//from inch
            {
                ans = length * 25.4;
                return ans;
            }

            return 0.0;


        }


        public String ConversionFromMilli(int to, double length)
        {
            double ans = 0.0;

            if (to == 0)//to kiliometer
            {
                ans = length / 1000000;
                return String.Format("{0:0.00000000} Kilometer", ans);
            }
            else if (to == 1)//to meter
            {
                ans = length / 1000;
                return String.Format("{0:0.00000000} meter", ans);
            }
            else if (to == 2)//to centimeter
            {
                ans = length / 10;
                return String.Format("{0:0.0000000000} centimeter", ans);
            }
            else if (to == 3)//to millimeter
            {
                ans = length;
                return String.Format("{0:0.00000000} millimeter", ans);
            }
            else if (to == 4)//from micrometer
            {
                ans = length * 1000;
                return String.Format("{0:0.00000000} micrometer", ans);
            }
            else if (to == 5)//from nanometer
            {
                ans = length * 1000000;
                return String.Format("{0:0.00000000} nanometer", ans);
            }
            else if (to == 6)//from mile
            {
                ans = length / 1609344;
                return String.Format("{0:0.00000000} mile", ans);
            }
            else if (to == 7)//from yard
            {
                ans = length / 914.4;
                return String.Format("{0:0.00000000} yard", ans);
            }
            else if (to == 8)//from foot
            {
                ans = length / 304.8;
                return String.Format("{0:0.00000000} foot", ans);
            }
            else if (to == 9)//from inch
            {
                ans = length / 25.4;
                return String.Format("{0:0.00} inch", ans);
            }

            return "";


        }
        public String ConvertLength(int from, int to, double length)
        {
            double ans = 0.0;
            String stmt;
            ans = ConvertToMilli(from, length);
            stmt = ConversionFromMilli(to, ans);

            return stmt;
        }

        //-------------------------------------------------------Convert Weight-------------------------------------------------------------------

        public double ConvertToGram(int from, double mass)
        {
            double ans = 0.0;

            if (from == 0)//from tonne
            {
                ans = mass * 1000000;
                return ans;
            }
            else if (from == 1)//from kilpgram
            {
                ans = mass * 1000;
                return ans;
            }
            else if (from == 2)//from gram
            {
                ans = mass;
                return ans;
            }
            else if (from == 3)//from milligram
            {
                ans = mass / 1000;
                return ans;
            }
            else if (from == 4)//from microgram
            {
                ans = mass / 1000000;
                return ans;
            }
            else if (from == 5)//from pound
            {
                ans = mass * 453.592;
                return ans;
            }
            else if (from == 6)//from ounce
            {
                ans = mass * 28.3495;
                return ans;
            }
            return 0.0;


        }

        public String ConversionFromGram(int to, double mass)
        {
            double ans = 0.0;

            if (to == 0)//to tonne
            {
                ans = mass / 1000000;
                return String.Format("{0:0.00000000} tonne", ans);
            }
            else if (to == 1)//to kilogram
            {
                ans = mass / 1000;
                return String.Format("{0:0.00000000} kilogram", ans);
            }
            else if (to == 2)//to centimeter
            {
                ans = mass;
                return String.Format("{0:0.00000000} gram", ans);
            }
            else if (to == 3)//to milligram
            {
                ans = mass * 1000;
                return String.Format("{0:0.00000000} milligram", ans);
            }
            else if (to == 4)//to microgram
            {
                ans = mass * 1000000;
                return String.Format("{0:0.00000000} microgram", ans);
            }
            else if (to == 5)//to pound
            {
                ans = mass / 453.592;
                return String.Format("{0:0.00000000} pound", ans);
            }
            else if (to == 6)//from mile
            {
                ans = mass / 28.3495;
                return String.Format("{0:0.00000000} ounce", ans);
            }

            return "Default";

        }


        public String ConvertMass(int from, int to, double mass)
        {
            double ans = 0.0;

            String stmt;
            ans = ConvertToGram(from, mass);
            stmt = ConversionFromGram(to, ans);

            return stmt;
        }


        //-----------------------------------------------------------Convert Energy-------------------------------------------------------



        public double ConvertToJoule(int from, double amount)
        {
            double ans = 0.0;

            if (from == 0)//from kilojoule
            {
                ans = amount * 1000;
                return ans;
            }
            else if (from == 1)//from joule
            {
                ans = amount;
                return ans;
            }
            else if (from == 2)//from calorie
            {
                ans = amount * 4.184;
                return ans;
            }
            else if (from == 3)//from kilocalorie
            {
                ans = amount * 4184 ;
                return ans;
            }
            else if (from == 4)//from Watt hour
            {
                ans = amount * 3600 ;
                return ans;
            }
            else if (from == 5)//from kilowatt hour
            {
                ans = amount * 3600000;
                return ans;
            }
           
            return 0.0;


        }

        public String ConversionFromJoule(int to, double amount)
        {
            double ans = 0.0;

            if (to == 0)//to kilojoule
            {
                ans = amount / 1000;
                return String.Format("{0:0.00000000} kilojoule", ans);
            }
            else if (to == 1)//to joule
            {
                ans = amount;
                return String.Format("{0:0.00000000} joule", ans);
            }
            else if (to == 2)//to calorie
            {
                ans = amount / 4.184;
                return String.Format("{0:0.00000000} calorie", ans);
            }
            else if (to == 3)//to kilocalorie
            {
                ans = amount / 4184;
                return String.Format("{0:0.00000000} kilocalorie", ans);
            }
            else if (to == 4)//to watthour
            {
                ans = amount / 3600;
                return String.Format("{0:0.00000000} watt hour", ans);
            }
            else if (to == 5)//to kilowatt hour
            {
                ans = amount / 3600000;
                return String.Format("{0:0.00000000} kilowatt hour", ans);
            }

            return "Default";

        }

        public String ConvertEnergy(int from, int to, double amount)
        {
            double ans = 0.0;

            String stmt;
            ans = ConvertToJoule(from, amount);
            stmt = ConversionFromJoule(to, ans);

            return stmt;

        }

        //---------------------------------------------------Calculate Interest----------------------------------------------------------------

        public String Calc_Interest(double prinAmt, double rate, double year, int type)
        {
            double ans = 0.0;
            double interest = 0.0;
            double temp = 0.0;

            if(type == 0)//simple intereset
            {
                interest = (prinAmt * rate * year) / 100;
                ans = prinAmt + interest;

                return String.Format("Interest is {0:0.00} and Total amount is  {1:0.00} ",interest, ans);
            }
            else if(type == 1)
            {
                int i;
                double p = 0.0;
                p = prinAmt;
                for(i=0; i<year; i++)
                {
                    temp = 0.0;
                    temp = (p * rate) / 100;
                    interest = interest + temp;
                    p += temp;
                }

                ans = prinAmt + interest;
                return String.Format("Interest is {0:0.00} and Total amount is  {1:0.00} ", interest, ans);
            }

            return "Default";
        }
    }
}
