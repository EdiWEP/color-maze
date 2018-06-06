using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusicOnMenu : MonoBehaviour {

    
	void Start () {
        Destroy(GameObject.FindGameObjectWithTag("Music"));    		
	}

}
