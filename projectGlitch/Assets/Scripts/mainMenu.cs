using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class mainMenu : MonoBehaviour
{
    public Button startGame;
    public Button options;
    public Button endGame;
    public TMP_Text startGameText;
    public TMP_Text optionsText;
    public TMP_Text endGameText;

    // Start is called before the first frame update
    void Start()
    {
        startGameText.text = "Start Game";
        optionsText.text = "Credits";
        endGameText.text = "Quit Game";
    }
}
