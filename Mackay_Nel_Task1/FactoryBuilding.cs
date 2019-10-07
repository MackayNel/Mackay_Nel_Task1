﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mackay_Nel_Task1
{
    //This class is where the Factory building is setup
    [Serializable]
    class FactoryBuilding : Building //All Part of task 2
    {
        public bool IsDestroyed { get; set; }

        public override void Destroyed()
        {
            buildingSymbol = "[X]";
            IsDestroyed = true;
        }


        public int buildingX
        {
            get { return base.buildingX; }
            set { base.buildingX = value; }
        }

        public int buildingY
        {
            get { return base.buildingY; }
            set { base.buildingY = value; }
        }


        public int buildingHealth
        {
            get { return base.buildingHealth; }
            set { base.buildingHealth = value; }
        }

        public int buildingMaxH
        {
            get { return base.buildingMaxH; }
        }

        public int buildingFaction
        {
            get { return base.buildingFaction; }
        }


        public string buildingSymbol
        {
            get { return base.buildingSymbol; }
            set { base.buildingSymbol = value; }
        }


        public override string ToString()
        {
            string temp = " ";
            temp += "Building :";
            temp += ("{" + buildingSymbol + "}");
            temp += "(" + buildingX + "," + buildingY + ")";
            temp += "Building Health" + buildingHealth;
            temp += (IsDestroyed ? "Damaged!" : "Functional!");
            return temp;
        }
        //This is the Factory buildings constructor.
        public FactoryBuilding(int bX, int bY, int bh, int bf, string bs)
        {
            buildingX = bX;
            buildingY = bY;
            buildingHealth = bh;
            base.buildingMaxH = bh;
            base.buildingFaction = bf;
            buildingSymbol = bs;
        }
    }
}

