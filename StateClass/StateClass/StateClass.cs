using StateClass.StateInfoDataSetTableAdapters;
using System.Data.OleDb;

namespace StateClass
{
    public class StateClass
    {

        StateInfoTableAdapter stateInfoTableAdapter;
        StateInfoDataSet stateInfoDataSet;

        public StateClass()
        {
            stateInfoTableAdapter = new StateInfoTableAdapter();
            stateInfoDataSet = new StateInfoDataSet();
        }

        public void StateText(int column, string text)
        {
            switch (column)
            {
                case 0:
                    stateInfoTableAdapter.SearchState(stateInfoDataSet.StateInfo, text);
                    break;
                case 1:
                    stateInfoTableAdapter.SearchFlag(stateInfoDataSet.StateInfo, text);
                    break;
                case 2:
                    stateInfoTableAdapter.SearchFlower(stateInfoDataSet.StateInfo, text);
                    break;
                case 3:
                    stateInfoTableAdapter.SearchBird(stateInfoDataSet.StateInfo, text);
                    break;
                case 4:
                    stateInfoTableAdapter.SearchColors(stateInfoDataSet.StateInfo, text);
                    break;
                case 5:
                    stateInfoTableAdapter.SearchCities(stateInfoDataSet.StateInfo, text);
                    break;
                case 6:
                    stateInfoTableAdapter.SearchCapitol(stateInfoDataSet.StateInfo, text);
                    break;
            }
        }
    }
}
