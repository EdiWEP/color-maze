using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueGameButton : MonoBehaviour {

    public Button button;

	void Start () {
	    if (PlayerPrefs.HasKey("SavedLevel"))
        {
            if(PlayerPrefs.GetInt("SavedLevel") <= 0)
            {
                button.interactable = false;
                
            }
            else
            {
                button.interactable = true;
            }
        }	
        else
        {
            button.interactable = false;
        }
	}
	
}
