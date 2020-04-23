using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameArangement : MonoBehaviour {

    public Text playTxt, gameName;

    private bool clicked;

    void OnMouseDown() {
        if (!clicked) {
            clicked = true;
            playTxt.gameObject.SetActive (false);
            gameName.text = "0";
        }

        
    }
}
