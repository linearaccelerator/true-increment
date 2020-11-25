﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static BreakInfinity.BigDouble;

public class UpgradeManager : MonoBehaviour
{
    public PersistentMain game;

    //Texts
    public Text MatterText;
    public Text[] matterCostTexts = new Text[6];
    public Text[] matterProductionTexts = new Text[6];
    public Text[] particleTexts = new Text[9];

    void Start()
    {
        MatterText.text = $"{Methods.NotationMethodBD(game.data.Matter, y: "F2")} Matter";

        for (var i = 0; i < matterCostTexts.Length; i++)
        {
            matterCostTexts[i].text = $"Costs: {Methods.NotationMethodBD(game.data.matterUpgradeCost[i], y: "F2")}";
        }

        for (var i = 0; i < matterProductionTexts.Length && i < game.data.matterUpgradeProduction.Length; i++)
        {
            matterProductionTexts[i].text = $"Gain +{Methods.NotationMethodBD(game.data.matterUpgradeProduction[i], y: "F2")} Matter/s";
        }

        for (var i = 0; i < particleTexts.Length; i++)
        {
            particleTexts[i].text = $"Cost {Methods.NotationMethodBD(game.data.particleCosts[i], y: "F2")} Matter";
        }
    }

    private void Update()
    {
        MatterText.text = $"{Methods.NotationMethodBD(game.data.Matter, y: "F2")} Matter";
        game.data.Matter += (game.data.MatterPerSec * game.data.antimatterMulti) * Time.deltaTime;

        for (var i = 0; i < matterCostTexts.Length; i++)
        {
            matterCostTexts[i].text = $"Costs: {Methods.NotationMethodBD(game.data.matterUpgradeCost[i], y: "F2")}";
        }

        for (var i = 0; i < matterProductionTexts.Length && i < game.data.matterUpgradeProduction.Length; i++)
        {
            matterProductionTexts[i].text = $"Gain +{Methods.NotationMethodBD(game.data.matterUpgradeProduction[i], y: "F2")} Matter/s";
        }
    }
    public void BuyMatterThing(string MID)
    {
        switch (MID)
        {
            case "MT1":
                if (game.data.Matter >= game.data.matterUpgradeCost[0])
                {
                    game.data.MatterPerSec += game.data.matterUpgradeProduction[0];
                    if (game.data.particleUnlocked[1])
                    {
                        game.data.MatterPerSec += game.data.matterUpgradeProduction[1] * 0.01;
                    }
                    if (game.data.particleUnlocked[6])
                    {
                        game.data.MatterPerSec += game.data.matterUpgradeProduction[1] * 0.01;
                    }
                    game.data.Matter -= game.data.matterUpgradeCost[0];
                    game.data.matterUpgradeCost[0] *= 1.8;
                    game.data.matterUpgradeProduction[0] *= 1.7;
                    matterProductionTexts[0].text = $"Gain +{Methods.NotationMethodBD(game.data.matterUpgradeProduction[0], y: "F2")} Matter/s";
                    matterCostTexts[0].text = $"Costs: {Methods.NotationMethodBD(game.data.matterUpgradeCost[0], y: "F2")}";
                }
                break;
            case "MT2":
                if (game.data.Matter >= game.data.matterUpgradeCost[1])
                {
                    game.data.MatterPerSec += game.data.matterUpgradeProduction[1];
                    if (game.data.particleUnlocked[2])
                    {
                        game.data.MatterPerSec += game.data.matterUpgradeProduction[5] * 0.01;
                    }
                    if (game.data.particleUnlocked[3])
                    {
                        game.data.MatterPerSec += game.data.matterUpgradeProduction[2] * 0.01;
                    }
                    if (game.data.particleUnlocked[4])
                    {
                        game.data.MatterPerSec += game.data.matterUpgradeProduction[3] * 0.01;
                    }
                    if (game.data.particleUnlocked[5])
                    {
                        game.data.MatterPerSec += game.data.matterUpgradeProduction[4] * 0.01;
                    }
                    if (game.data.antiParticleUnlocked[0])
                    {
                        game.data.MatterPerSec += game.data.matterUpgradeProduction[1] * 0.01;
                    }
                    game.data.Matter -= game.data.matterUpgradeCost[1];
                    game.data.matterUpgradeCost[1] *= 1.8;
                    game.data.matterUpgradeProduction[1] *= 1.7;
                    matterProductionTexts[1].text = $"Gain +{Methods.NotationMethodBD(game.data.matterUpgradeProduction[1], y: "F2")} Matter/s";
                    matterCostTexts[1].text = $"Costs: {Methods.NotationMethodBD(game.data.matterUpgradeCost[1], y: "F2")}";
                }
                break;
            case "MT3":
                if (game.data.Matter >= game.data.matterUpgradeCost[2])
                {
                    if (game.data.particleUnlocked[6])
                    {
                        game.data.MatterPerSec += game.data.matterUpgradeProduction[1] * 0.01;
                    }
                    game.data.MatterPerSec += game.data.matterUpgradeProduction[2];
                    game.data.Matter -= game.data.matterUpgradeCost[2];
                    game.data.matterUpgradeCost[2] *= 1.8;
                    game.data.matterUpgradeProduction[2] *= 1.7;
                    matterProductionTexts[2].text = $"Gain +{Methods.NotationMethodBD(game.data.matterUpgradeProduction[2], y: "F2")} Matter/s";
                    matterCostTexts[2].text = $"Costs: {Methods.NotationMethodBD(game.data.matterUpgradeCost[2], y: "F2")}";
                }
                break;
            case "MT4":
                if (game.data.Matter >= game.data.matterUpgradeCost[3])
                {
                    if (game.data.particleUnlocked[6])
                    {
                        game.data.MatterPerSec += game.data.matterUpgradeProduction[1] * 0.01;
                    }
                    game.data.MatterPerSec += game.data.matterUpgradeProduction[3];
                    game.data.Matter -= game.data.matterUpgradeCost[3];
                    game.data.matterUpgradeCost[3] *= 1.8;
                    game.data.matterUpgradeProduction[3] *= 1.7;
                    matterProductionTexts[3].text = $"Gain +{Methods.NotationMethodBD(game.data.matterUpgradeProduction[3], y: "F2")} Matter/s";
                    matterCostTexts[3].text = $"Costs: {Methods.NotationMethodBD(game.data.matterUpgradeCost[3], y: "F2")}";
                }
                break;
            case "MT5":
                if (game.data.Matter >= game.data.matterUpgradeCost[4])
                {
                    if (game.data.particleUnlocked[6])
                    {
                        game.data.MatterPerSec += game.data.matterUpgradeProduction[1] * 0.01;
                    }
                    game.data.MatterPerSec += game.data.matterUpgradeProduction[4];
                    game.data.Matter -= game.data.matterUpgradeCost[4];
                    game.data.matterUpgradeCost[4] *= 1.8;
                    game.data.matterUpgradeProduction[4] *= 1.7;
                    matterProductionTexts[4].text = $"Gain +{Methods.NotationMethodBD(game.data.matterUpgradeProduction[4], y: "F2")} Matter/s";
                    matterCostTexts[4].text = $"Costs: {Methods.NotationMethodBD(game.data.matterUpgradeCost[4], y: "F2")}";
                }
                break;
            case "MT6":
                if (game.data.Matter >= game.data.matterUpgradeCost[5])
                {
                    if (game.data.particleUnlocked[6])
                    {
                        game.data.MatterPerSec += game.data.matterUpgradeProduction[1] * 0.01;
                    }
                    if (game.data.particleUnlocked[7])
                    {
                        game.data.MatterPerSec += game.data.matterUpgradeProduction[3] * 0.01;
                    }
                    if (game.data.particleUnlocked[7])
                    {
                        game.data.MatterPerSec += game.data.matterUpgradeProduction[4] * 0.01;
                    }
                    if (game.data.particleUnlocked[8])
                    {
                        game.data.MatterPerSec += game.data.matterUpgradeProduction[3] * 0.1;
                    }
                    if (game.data.particleUnlocked[8])
                    {
                        game.data.MatterPerSec += game.data.matterUpgradeProduction[4] * 0.1;
                    }
                    if (game.data.antiParticleUnlocked[1])
                    {
                        game.data.matterUpgradeProduction[5] *= 1.1;
                    }
                    game.data.MatterPerSec += game.data.matterUpgradeProduction[5];
                    game.data.Matter -= game.data.matterUpgradeCost[5];
                    game.data.matterUpgradeCost[5] *= 1.8;
                    game.data.matterUpgradeProduction[5] *= 1.7;
                    matterProductionTexts[5].text = $"Gain +{Methods.NotationMethodBD(game.data.matterUpgradeProduction[5], y: "F2")} Matter/s";
                    matterCostTexts[5].text = $"Costs: {Methods.NotationMethodBD(game.data.matterUpgradeCost[5], y: "F2")}";
                }
                break;
        }
    }

    //credit to SW_CreeperKing
    public void BuyParticle(int PID)
    {
        if (game.data.Matter < game.data.particleCosts[PID - 1]) return;
        if (PID == 1)
        {
            game.data.matterUpgradeProduction[0] *= 2;
        }
        game.data.Matter -= game.data.particleCosts[PID - 1];
        game.data.particleUnlocked[PID - 1] = true;
        particleTexts[PID - 1].text = "UNLOCKED!";
    }
    //end credit
}
