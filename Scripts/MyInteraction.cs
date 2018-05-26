using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyInteraction : MonoBehaviour {

    public string SceneName;
    public Color enterColor;
    public Color exitColor;

	// Use this for initialization
	void Start () {
        GetComponent<TextMesh>().color = exitColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PointerEnter() 
    {
        GetComponent<TextMesh>().color = enterColor;
        SceneManager.LoadScene(SceneName);
    }

    public void PointerExit()
    {
        GetComponent<TextMesh>().color = exitColor;
    }
}
