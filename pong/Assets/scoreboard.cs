using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreboard : MonoBehaviour
{
    public static scoreboard instance;
    public GameObject Ball;
    public int AIscore;
    public int playerscore;
    public TextMeshProUGUI playerscoretext;
    public TextMeshProUGUI AIscoretext;

    private void Awake()
    {
        instance = this;
    }
    public void Scored(Scorer scorer) {
        switch (scorer)
        {
            case Scorer.Player:
                playerscore++;
                break;
            case Scorer.AI:
                AIscore++;
                break;
        }
    }
    private void OnGUI()
    {
        AIscoretext.text = AIscore.ToString();
        playerscoretext.text = playerscore.ToString();

    }

}
public enum Scorer{
        AI,
        Player
        }

