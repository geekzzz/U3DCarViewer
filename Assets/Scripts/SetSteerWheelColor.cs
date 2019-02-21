using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSteerWheelColor : MonoBehaviour {

    public GameObject steerWheel1_LOD0;
    public GameObject steerWheel1_LOD1;
    public GameObject steerWheel1_LOD2;

    Material[] matArr;//存储材质

    // Use this for initialization
    void Start () {
        matArr = Resources.LoadAll<Material>("Materials/SteerWheelMat");
        for (int i = 0; i < matArr.Length; ++i)
        {
            //Debug.Log(matArr[i]);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SetSteerWheelMat(int n)
    {
        //Debug.Log("1111111111111111");
        //Debug.Log(matArr[3]);
        steerWheel1_LOD0.GetComponent<Renderer>().materials = new Material[1] {matArr[n] };
        steerWheel1_LOD1.GetComponent<Renderer>().materials = new Material[1] { matArr[n] };
        steerWheel1_LOD2.GetComponent<Renderer>().materials = new Material[1] { matArr[n] };
    }

}
