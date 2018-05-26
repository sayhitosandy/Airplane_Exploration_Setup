using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneMovement : MonoBehaviour {
    Camera cockpit;
    float speed = 2f;
    public float maxSpeed = 12f;
    bool flag = false;
    // Use this for initialization
	void Start () {
        cockpit = GetComponentInChildren<Camera>();	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            flag = true;
        }
        if (flag == true) 
        {
            transform.position += cockpit.transform.forward * speed * Time.deltaTime;
            if (speed < maxSpeed)
            {
                speed += 0.5f;
            }

            if (cockpit.transform.eulerAngles.z >= 45f && cockpit.transform.eulerAngles.z <= 315f)
            {
                SceneManager.LoadScene("Menu", LoadSceneMode.Single);
            }

        }
	}
}
