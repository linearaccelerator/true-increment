using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static BreakInfinity.BigDouble;

public class DGs : MonoBehaviour
{
    public PersistentMain game;
    public Text challengeText;
    void Start()
    {

    }

    void Update()
    {

    }

    public void challengeTextSet(string id)
    {
        var data = game.data;
        switch (id)
        {
            case "DG1":
                challengeText.text = $"DG1: Particle Decay: All Particles and Anti-Particles are Disabled\nCompletions: {data.dgCompletions[1]}/20\nFirst Time Reward: Unlock Matter Thing Autobuyers\nEvery Completion makes Particles 1% Cheaper";
                break;
            case "DG2":
                challengeText.text = $"DG2: Dark Matter: Antimatter is useless and Anti-Particles are Disabled\nCompletions: {data.dgCompletions[1]}/10\nFirst Time Reward: Unlock Particle and Anti-Particle Autobuyers\nEvery Completion makes the Antimatter Gain formula better";
                break;
            case "DG3":
                challengeText.text = $"DG3: Matter Crash: Matter Thing Cost Scaling is Increased and Particle 6 is Disabled\nCompletions: {data.dgCompletions[1]}/3\nEvery Completion makes Particle 6 Better";
                break;
            case "DG4":
                challengeText.text = $"DG4: Titans Curse: Wrath is worse (you're really gonna hate this one)\nCompletions: {data.dgCompletions[1]}/5\nEvery Completion makes Wrath better! (that sounds dumb but you'll love it)";
                break;
            case "DG5":
                challengeText.text = $"DG5: OMEGA: ALL PREVIOUS DARK GALAXIES AT ONCE\nCompletions: {data.dgCompletions[1]}/1\nCompleting this Dark Galaxy will open a portal to The Great Tree";
                break;
        }
    }

    public void enterDG(int id)
    {
        var data = game.data;
        if (data.dgCompletions[id] >= data.dgMaxCompletions[id]) return;
        data.isInDG[id] = true;
    }

    public void exitDG()
    {
        var data = game.data;
        for (var i = 0; i < data.isInDG.Length; i++)
        {
            data.isInDG[i] = false;
        }
    }
}
