﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mackay_Nel_Task1
{//This is the building's base class, It only holds the protected variables for the buildings.
    [Serializable]
    public abstract class Building//All Part of task 2
    {
        protected int buildingX;
        protected int buildingY;
        protected int buildingHealth;
        protected int buildingMaxH;
        protected int buildingFaction;
        protected string buildingSymbol;

        public abstract void Destroyed();
        public abstract override string ToString();
    }
   
}
