﻿using System;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder // Entry
    {
        private int entriesCount;

        public int EntriesCount
        {
            get
            {
                return entriesCount;
            }

            set
            {
                if (value < Topology.MinEntriesCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > Topology.MaxEntriesCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                entriesCount = value;
            }
        }

        public bool AddEntry()
        {
            if (CanAddEntry())
            {
                entriesCount++;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private bool CanAddEntry()
        {
            int newNumOfEntries = entriesCount + 1;

            if (newNumOfEntries <= Topology.MaxEntriesCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteEntry()
        {
            if (entriesCount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            entriesCount--;
        }
    }
}