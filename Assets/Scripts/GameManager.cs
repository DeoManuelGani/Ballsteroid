using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PlayerScoreL = 0;
    public int PlayerScoreR = 0;

    public TMP_Text txtPLayerScoreL;
    public TMP_Text txtPLayerScoreR;

    public static GameManager instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        txtPLayerScoreL.text = PlayerScoreL.ToString();
        txtPLayerScoreR.text = PlayerScoreR.ToString();
    }

    // Update is called once per frame
    public void Score(string wallID)
    {
        if (wallID == "Line_L")
        {
            PlayerScoreR = PlayerScoreR + 10;
            txtPLayerScoreR.text = PlayerScoreR.ToString();
            ScoreCheck();
        }
        else
        {
            PlayerScoreL = PlayerScoreL + 10;
            txtPLayerScoreL.text = PlayerScoreL.ToString();
            ScoreCheck();
        }
    }

    public void ScoreCheck()
    {
        if (PlayerScoreL > 20)
        {
            Debug.Log("You Win");
            this.gameObject.SendMessage("ChangeScene", "MainMenu");
        }
        if (PlayerScoreR > 20)
        {
            Debug.Log("You Lose");
            this.gameObject.SendMessage("ChangeScene", "MainMenu");
        }
    }
}
