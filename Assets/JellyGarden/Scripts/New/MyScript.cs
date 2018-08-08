using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour {

    int levelNum = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void OnClickPlay()
    {
        LevelsMap.OnLevelSelected(levelNum);
        this.transform.Find("HomePage").gameObject.SetActive(false);
    }

}
