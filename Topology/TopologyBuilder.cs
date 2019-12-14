﻿using GasStationMs.App.Elements;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder
    { 
        #region поля
        private int colsCount;
        private int rowsCount;

        private int serviceAreaInCells;

        private int fuelTanksCount;
 
        private int cashCountersCount;
        #endregion

        public TopologyBuilder()
        {
            colsCount = Topology.MinColsCount;
            rowsCount = Topology.MinColsCount;

            serviceAreaInCells = RecalculateServiceArea();
        }

        #region свойства
        public int ColsCount
        {
            get
            {
                return colsCount;
            }

            set
            {
                if (value < Topology.MinColsCount)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (value > Topology.MaxColsCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                colsCount = value;
                serviceAreaInCells = RecalculateServiceArea();
            }
        }

        public int RowsCount
        {
            get
            {
                return rowsCount;
            }

            set
            {
                if (value < Topology.MinRowsCount)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (value > Topology.MaxRowsCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                rowsCount = value;
                serviceAreaInCells = RecalculateServiceArea();
            }
        }

    

        public int FuelTanksCount
        {
            get
            {
                return fuelTanksCount;
            }

            set
            {
                if (value < Topology.MinFuelTanksCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > serviceAreaInCells)
                {
                    throw new ArgumentOutOfRangeException();
                }

                fuelTanksCount = value;
            }
        }

        public int CashCountersCount
        {
            get
            {
                return cashCountersCount;
            }

            set
            {
                if (value < Topology.MinCashCountersCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > Topology.MaxCashCountersCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                cashCountersCount = value;
            }
        }
        #endregion

        private int RecalculateServiceArea()
        {
            return (int)(colsCount * rowsCount * Topology.ServiceAreaInShares);
        }

        #region ТБ
        public bool CanAddFuelTank()
        {
            int newNumOfFuelTanks = fuelTanksCount + 1;

            if (newNumOfFuelTanks <= serviceAreaInCells)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddFuelTank()
        {
            FuelTanksCount = FuelTanksCount + 1;
        }

        private void DeleteFuelTank()
        {
            if (fuelTanksCount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            fuelTanksCount--;
        }
        #endregion /ТБ

        #region касса
        public bool CanAddCashCounter()
        {
            int newNumOfCashCounters = cashCountersCount + 1;

            if (newNumOfCashCounters <= Topology.MaxCashCountersCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddCashCounter()
        {
            cashCountersCount++;
        }

        private void DeleteCashCounter()
        {
            if (cashCountersCount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            cashCountersCount--;
        }
        #endregion /касса

        public void DeleteTemplateElement(DataGridViewCell cell)
        {
            bool canDelete = (cell.Tag != null);

            if (canDelete)
            {
                if (cell.Tag is FuelDispenser)
                {
                    DeleteFuelDispenser();
                }
                else if (cell.Tag is FuelTank)
                {
                    DeleteFuelTank();
                }
                else if (cell.Tag is CashCounter)
                {
                    DeleteCashCounter();
                }
                else if (cell.Tag is Entry)
                {
                    DeleteEntry();
                }
                else if (cell.Tag is Exit)
                {
                    DeleteExit();
                }
                else { }

                cell.Tag = null;
                cell.Value = null;
            }
        }

        public IGasStationElement[,] GetGasStationElementsArray(DataGridView dgv)
        {
            IGasStationElement[,] gseArr;
            gseArr = new IGasStationElement[dgv.RowCount, dgv.ColumnCount];

            DataGridViewImageCell cell;
            for (int currRow = 0; currRow < gseArr.GetLength(0); currRow++)
            {
                for (int currCol = 0; currCol < gseArr.GetLength(1); currCol++)
                {
                    cell = (DataGridViewImageCell)dgv.Rows[currRow].Cells[currCol];
                    gseArr[currRow, currCol] = (IGasStationElement)cell.Tag;
                }
            }

            return gseArr;
        }
    }
}
