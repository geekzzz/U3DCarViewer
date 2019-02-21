using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCarBody : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetSubMenueActive()
    {
        GameObject go = this.transform.Find("menue").gameObject;
        GameObject.Find("Canvas/OutMenue/ChangeDoor/menue").gameObject.SetActive(false);
        GameObject.Find("Canvas/OutMenue/ChangeWheel/menue").gameObject.SetActive(false);
        go.SetActive(!go.activeSelf);
        
    }
}
