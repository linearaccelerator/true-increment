using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BreakInfinity.BigDouble;

public class PersistentMain : MonoBehaviour
{
    public SaveData data;
    public GameObject matterPage;
    public GameObject particlesPage;

    void Start()
    {
        SaveSystem.LoadPlayer(ref data);
        matterPage.SetActive(true);
        particlesPage.SetActive(false);

        if (data.Matter == 0)
        {
            data.Matter += 10;
        }
    }

    void Update()
    {
        SaveSystem.SavePlayer(data);
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
                break;
            case "Particles":
                matterPage.SetActive(false);
                particlesPage.SetActive(true);
                break;
        }
    }
}
