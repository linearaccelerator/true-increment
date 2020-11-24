using BreakInfinity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BreakInfinity.BigDouble;

[Serializable]
public class SaveData
{
    #region Matter;
    public BigDouble[] matterUpgradeCost = new BigDouble[6];
    public BigDouble[] matterUpgradeProduction = new BigDouble[6];
    public double[] particleCosts = new double[9];
    public bool[] particleUnlocked = new bool[9];
    public BigDouble Matter;
    public BigDouble MatterPerSec;
    #endregion
    public BigDouble antimatter;
    public BigDouble[] antiParticleCosts = new BigDouble[7];

    public SaveData()
    {
        #region Matter
        matterUpgradeCost[0] = 10;
        matterUpgradeCost[1] = 100;
        matterUpgradeCost[2] = 1e4;
        matterUpgradeCost[3] = 1e6;
        matterUpgradeCost[4] = 1e8;
        matterUpgradeCost[5] = 1e10;
        matterUpgradeProduction[0] = 1;
        matterUpgradeProduction[1] = 10;
        matterUpgradeProduction[2] = 500;
        matterUpgradeProduction[3] = 5e3;
        matterUpgradeProduction[4] = 5.5e5;
        matterUpgradeProduction[5] = 1e8;
        particleCosts[0] = 100;
        particleCosts[1] = 101;
        particleCosts[2] = 1000;
        particleCosts[3] = 1e6;
        particleCosts[4] = 1e8;
        particleCosts[5] = 1e10;
        particleCosts[6] = 1e10;
        particleCosts[7] = 1e20;
        particleCosts[8] = 1e30;

        for (var i = 0; i < particleUnlocked.Length; i++)
        {
            particleUnlocked[i] = false;
        }

        Matter = 10;
        MatterPerSec = 0;
        #endregion
        //All APs Cost Antimatter
        antiParticleCosts[0] = 10;
        antiParticleCosts[1] = 100;
        antiParticleCosts[2] = 500;
        antiParticleCosts[3] = 2000;
        antiParticleCosts[4] = 1e6;
        antiParticleCosts[5] = 1e10;
        antiParticleCosts[6] = 1e25;
    }
}