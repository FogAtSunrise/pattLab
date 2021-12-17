using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.Memento
{
    class Report
    {

        public string nameReport;

        private string dataSurvey;
        private int typeReport;

        private MementoHistory history;

        public Report(string n)
        {
            nameReport = n;
            dataSurvey = "";
            typeReport = 0;
            history = new MementoHistory();
        }

        public void saveState()
        {
            history.pushMemento(new MementoReport(dataSurvey, typeReport));
        }
        public void restoreState() 
        {
            MementoReport oldState = history.popMemento();
            if (oldState == null)
                Console.WriteLine("**Нет версий для отката**");
            else
            {
                dataSurvey = oldState.getData();
                typeReport = oldState.getType();
            }
        }


        public void printRep() { Console.WriteLine("Имя: " + nameReport+"\nТип: "+typeReport+"   Данные: "+dataSurvey); }
        public void setData(string data)    {dataSurvey = data;}
        public void setType(int data) { typeReport = data; }

        public string getData() { return dataSurvey; }
        public int getType() { return typeReport; }

    }
}
