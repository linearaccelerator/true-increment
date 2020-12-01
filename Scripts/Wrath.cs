using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static BreakInfinity.BigDouble;
public class Wrath : MonoBehaviour
{
    public PersistentMain game;
    public Text wrathText;
    void Start()
    {
        wrathText.text = $"The Titans divide your Matter Production by {Methods.NotationMethodBD(game.data.wrath, y: "F2")}";
    }

    void Update()
    {
        game.data.wrath = Pow(Log10(game.data.Matter + 1), 0.2) + 0.01;
        wrathText.text = $"The Titans divide your Matter Production by {Methods.NotationMethodBD(game.data.wrath, y: "F2")}";
    }
}
