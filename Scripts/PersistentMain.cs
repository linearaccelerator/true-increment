﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BreakInfinity.BigDouble;

public class PersistentMain : MonoBehaviour
{
    public SaveData data;
    public AntimatterManager anti;
    public UpgradeManager ups;
    public GameObject matterPage;
    public GameObject particlesPage;
    public GameObject antimatterPage;
    public GameObject tgtPage;
    public GameObject dgPage;

    void Start()
    {
        if (data.isNewSave)
        {
            FullReset();
            data.isNewSave = false;
        }
        SaveSystem.LoadPlayer(ref data);
        matterPage.SetActive(true);
        particlesPage.SetActive(false);
        antimatterPage.SetActive(false);
        tgtPage.SetActive(false);
        dgPage.SetActive(false);

        if (data.Matter == 0)
        {
            data.Matter += 10;
        }
    }

    void Update()
    {
        StartCoroutine(SaveTimer());
    }

    public void FullReset()
    {
        data = new SaveData();
        for (var i = 0; i < anti.antiParticleTexts.Length; i++)
        {
            anti.antiParticleTexts[i].text = $"Cost {Methods.NotationMethodBD(data.antiParticleCosts[i], y: "F2")} AnTiMaTtEr";
        }

        anti.antimatterText.text = $"{Methods.NotationMethodBD(data.antimatter, y: "F2")} GAMEING ANTIMATTER";
        anti.antimatterMultiText.text = $"Your AnTiMaTtEr is multipling your Matter by {Methods.NotationMethodBD(data.antimatterMulti, y: "F2")}x! Swag!";
        anti.antimatterGainText.text = $"GAIN +{Methods.NotationMethodBD((data.Matter / 1e8), y: "F2")} GAMEING ANTIMATTER";
        anti.apocalypseButton.SetActive(false);
        ups.MatterText.text = $"{Methods.NotationMethodBD(data.Matter, y: "F2")} Matter";

        for (var i = 0; i < ups.matterCostTexts.Length; i++)
        {
            ups.matterCostTexts[i].text = $"Costs: {Methods.NotationMethodBD(data.matterUpgradeCost[i], y: "F2")}";
        }

        for (var i = 0; i < ups.matterProductionTexts.Length && i < data.matterUpgradeProduction.Length; i++)
        {
            ups.matterProductionTexts[i].text = $"Gain +{Methods.NotationMethodBD(data.matterUpgradeProduction[i], y: "F2")} Matter/s";
        }

        for (var i = 0; i < ups.particleTexts.Length; i++)
        {
            ups.particleTexts[i].text = $"Cost {Methods.NotationMethodBD(data.particleCosts[i], y: "F2")} Matter";
        }
    }

    public void ChangePage(string PID)
    {
        switch (PID)
        {
            case "Matter":
                matterPage.SetActive(true);
                particlesPage.SetActive(false);
                antimatterPage.SetActive(false);
                tgtPage.SetActive(false);
                dgPage.SetActive(false);
                break;
            case "Particles":
                matterPage.SetActive(false);
                particlesPage.SetActive(true);
                antimatterPage.SetActive(false);
                break;
            case "Antimatter":
                matterPage.SetActive(false);
                particlesPage.SetActive(false);
                antimatterPage.SetActive(true);
                break;
            case "TGT":
                matterPage.SetActive(false);
                particlesPage.SetActive(false);
                antimatterPage.SetActive(false);
                tgtPage.SetActive(true);
                dgPage.SetActive(false);
                break;
            case "DG":
                matterPage.SetActive(false);
                particlesPage.SetActive(false);
                antimatterPage.SetActive(false);
                tgtPage.SetActive(false);
                dgPage.SetActive(true);
                break;
        }
    }

    IEnumerator SaveTimer()
    {
        yield return new WaitForSecondsRealtime(30);
        SaveSystem.SavePlayer(data);
        yield return new WaitForSecondsRealtime(30);
    }
}
