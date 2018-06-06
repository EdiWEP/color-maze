using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicTransition : MonoBehaviour {


    void Start() {
        int sceneNumber = SceneManager.GetActiveScene().buildIndex;
        if (sceneNumber != 5)
        {
            DontDestroyOnLoad(gameObject);
        }
    }

}
