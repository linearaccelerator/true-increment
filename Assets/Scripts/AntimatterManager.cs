using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static BreakInfinity.BigDouble;
public class AntimatterManagaer : MonoBehaviour
{
    public PersistentMain game;
    public Text[] antiParticleTexts = new Text[7];
    void Start()
    {
        for (var i = 0; i < antiParticleTexts.Length; i++)
        {
            antiParticleTexts[i].text = $"Cost {Methods.NotationMethodBD(game.data.antiParticleCosts[i], y: "F2")} AnTiMaTtEr";
        }
    }
    public void BuyAntiParticle(int PID)
    {
        if (game.data.Matter < game.data.particleCosts[PID - 1]) return;
        game.data.Matter -= game.data.antiParticleCosts[PID - 1];
        game.data.particleUnlocked[PID - 1] = true;
        antiParticleTexts[PID - 1].text = "UNLOCKED!";
    }
}