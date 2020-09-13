using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WSEndpoint
{
    public class HALData
    {
        private Dictionary<string, object> AllData;

        public HALData()
        {
            AllData = new Dictionary<string, object>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path">[type]/[device]/[data]</param>
        /// <returns></returns>
        public T Get<T>(string path)
        {
            string[] split = path.Split('/');
            if (split.Length < 3)
            {
                throw new Exception("Path didn't have enough params (ie. missing type, device, and/or data)");
            }
            AllData.TryGetValue()
        }

        private void AddDIO()
        {

        }

        private void AddAnalogIn()
        {

        }

        private void AddAnalogOut()
        {

        }

        private void AddDriverStation()
        {

        }

        private void AddJoystick()
        {

        }

        private void AddEncoder()
        {

        }

        private void AddPWN()
        {

        }

        private void AddRelay()
        {

        }

        private void AddRoboRIO()
        {

        }
    }

    public static class DictionaryExtensions
    {
        public static Dictionary<string, object> TryDict(this Dictionary<string, object>, dict string key)
        {
            
        }
    }

    /*public struct DIOData
    {
        public bool Value;
        public int PulseLength;
        public bool IsInput;
    }

    public struct AnalogInData
    {
        public int AvgBits;
        public int OversampleBits;
        public double Voltage;
        public double AccumValue;
        public double AccumCount;
        public double AccumCenter;
        public double AccumDeadband;
    }

    public struct AnalogOutData
    {
        public double Voltage;
    }

    public struct DriverStationData
    {
        public bool IsEnabled;
        public bool IsAutonomous;
        public bool IsTest;
        public bool IsEstop;
        public bool FmsConnected;
        public double ElapsedMatchTime;
        public 
    }*/
}
