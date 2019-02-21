using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InCarCameraControll : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Input.gyro.enabled = true;
        //Input.compensateSensors = true;
        Input.gyro.updateInterval = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Application.platform == RuntimePlatform.Android)
        {
            this.transform.localRotation = CameraRotation();
        }

    }

    private Quaternion CameraRotation()
    {
        Quaternion input = Input.gyro.attitude;
        input = Quaternion.Euler(90, 0, 0) * (new Quaternion(-input.x, -input.y, input.z, input.w));
        return input;
    }
}
