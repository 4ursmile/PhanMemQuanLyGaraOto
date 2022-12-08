using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyGaraOto
{
    public delegate void AlertNonPara();
    public class UniversalAlert
    {
        private AlertNonPara changeInforAlert;
        private static UniversalAlert ins;

        public static UniversalAlert Ins { 
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
}
