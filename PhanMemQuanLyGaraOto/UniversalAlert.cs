using System;
using System.Runtime.Serialization;

namespace PhanMemQuanLyGaraOto
{
    public delegate void AlertNonPara();
    public class UniversalAlert
    {
        private AlertNonPara changeInforAlert;
        private static UniversalAlert ins;

        public static UniversalAlert Ins
        {
            get
            {
                if (ins == null)
                    ins = new UniversalAlert();
                return ins;
            }
            private set => ins = value;
        }
        public void AddListener(AlertNonPara listener)
        {
            changeInforAlert += listener;
        }
        public void RemoveListenr(AlertNonPara listner)
        {
            changeInforAlert -= listner;
        }
        public void Alert()
        {
            changeInforAlert?.Invoke();
        }
    }
    public class ReloadDataEvent
    {
        private AlertNonPara[] AlertHoler = new AlertNonPara[Enum.GetNames(typeof(DataType)).Length];
        private static ReloadDataEvent ins;
        public static ReloadDataEvent Ins { 
            get
            {
                if (ins == null)
                    ins=new ReloadDataEvent();
                return ins;
            } 
            private set => ins = value; 
        }
        private ReloadDataEvent()
        {
        }
        public void Addlistener(AlertNonPara listener, params DataType[] types)
        {
            foreach(var typeOfData in types)
                AlertHoler[(int)typeOfData] += listener;
        }
        public void RemoveListerner(AlertNonPara listener,params DataType[] types)
        {
            foreach (var typeOfData in types)
                AlertHoler[(int)typeOfData] -= listener;
        }
        public void Alert(params DataType[] types)
        {
            foreach(DataType type in types)
            {
                AlertHoler[(int)type]?.Invoke();
            }
        }
        public void AlertAll()
        {
            foreach(var k in AlertHoler)
            {
                k?.Invoke();
            }
        }
    }
    public enum DataType
    {
        Car, Customer, Tool, Brand, Money, FixForm, FixDetail, ImportForm, TimesFix, ImportDetail
    }
}
