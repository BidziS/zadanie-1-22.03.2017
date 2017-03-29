using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    public sealed class Uczelnia
    {
        private string dataRekrutacji;
        private static Uczelnia m_oInstance = null;
        private Uczelnia(string dataRekrutacji)
        {
            this.dataRekrutacji = dataRekrutacji;
        }
        public static Uczelnia Instance
        {
            get
            {
                if (m_oInstance == null)
                {
                    m_oInstance = new Uczelnia("11-06-2017");
                }
                return m_oInstance;
            }
        }
        public void RekrutujStudentow(){
            Console.WriteLine("Data nastepnej rekrutacji:" + dataRekrutacji);
        }
    }
}
