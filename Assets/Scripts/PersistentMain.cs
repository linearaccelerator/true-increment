using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BreakInfinity.BigDouble;

public class PersistentMain : MonoBehaviour
{
    public SaveData data;
    public GameObject matterPage;
    public GameObject particlesPage;
    public GameObject antimatterPage;

    void Start()
    {
        SaveSystem.LoadPlayer(ref data);
        matterPage.SetActive(true);
        particlesPage.SetActive(false);
        antimatterPage.SetActive(false);

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
    }

    public void ChangePage(string PID)
    {
        switch (PID)
        {
            case "Matter":
                matterPage.SetActive(true);
                particlesPage.SetActive(false);
                antimatterPage.SetActive(false);
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
        }
    }

    IEnumerator SaveTimer(){
        yield return new WaitForSecondsRealtime(30);
        SaveSystem.SavePlayer(data);
        yield return new WaitForSecondsRealtime(30);
    }
}
