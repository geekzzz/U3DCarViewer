using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ChangeView : MonoBehaviour {
    // Use this for initialization
    private bool nowCamera = false;//false表示当前为外面摄影机，true表示当前为车内部摄影机

	void Start () {
        Camera camIn = GameObject.Find("Main Camera").GetComponent<Camera>();
        Camera camOut = GameObject.Find("In Camera").GetComponent<Camera>();
        camIn.enabled = true;
        camOut.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeCameraView()
    {
        if(nowCamera)
        {
            nowCamera = false;
            ChangeToCarOutterView();
        }
        else
        {
            nowCamera = true;
            ChangeToCarInnerView();
        }
    }

    public void ChangeToCarInnerView()
    {
        //this.GetComponent<DigitalRubyShared.FingersPanOrbitComponentScript>().enabled = false;
        //this.GetComponent<DigitalRubyShared.DemoScript3DOrbit>().enabled = false;
        Camera camOut = GameObject.Find("Main Camera").GetComponent<Camera>();
        Camera camIn = GameObject.Find("In Camera").GetComponent<Camera>();


        GameObject camInGo = GameObject.Find("In Camera");
        camInGo.GetComponent<InCarCameraControll>().enabled = true;

        GameObject.Find("Canvas/ChangeToCarInner/Text").GetComponent<Text>().text = "外观";


        GameObject.Find("Canvas/OutMenue/ChangeDoor").gameObject.SetActive(false);
        GameObject.Find("Canvas/OutMenue/ChangeBody").gameObject.SetActive(false);
        GameObject.Find("Canvas/OutMenue/ChangeWheel").gameObject.SetActive(false);

        GameObject.Find("Canvas/InMenue/ChangeSteerWheel").gameObject.SetActive(true);
        GameObject.Find("Canvas/InMenue/ChangeSeat").gameObject.SetActive(true);
        GameObject.Find("Canvas/InMenue/ChangeHandHold").gameObject.SetActive(true);
        camOut.enabled = false;
        camIn.enabled = true;
    }

    public void ChangeToCarOutterView()
    {
        Camera camOut= GameObject.Find("Main Camera").GetComponent<Camera>();
        Camera camIn = GameObject.Find("In Camera").GetComponent<Camera>();
        GameObject.Find("In Camera").GetComponent<InCarCameraControll>().enabled = false;

        GameObject.Find("Canvas/ChangeToCarInner/Text").GetComponent<Text>().text = "内饰";

        GameObject.Find("Canvas/OutMenue/ChangeDoor").gameObject.SetActive(true);
        GameObject.Find("Canvas/OutMenue/ChangeBody").gameObject.SetActive(true);
        GameObject.Find("Canvas/OutMenue/ChangeWheel").gameObject.SetActive(true);

        GameObject.Find("Canvas/InMenue/ChangeSteerWheel").gameObject.SetActive(false);
        GameObject.Find("Canvas/InMenue/ChangeSeat").gameObject.SetActive(false);
        GameObject.Find("Canvas/InMenue/ChangeHandHold").gameObject.SetActive(false);

        camIn.enabled = false;
        camOut.enabled = true;
    }
}
