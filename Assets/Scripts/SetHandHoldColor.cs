using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHandHoldColor : MonoBehaviour {
    public GameObject handhold;
    Material[] matArr;//存储材质
                      // Use this for initialization
    void Start () {
        matArr = Resources.LoadAll<Material>("Materials/HandHoldMat");
        for (int i = 0; i < matArr.Length; ++i)
        {
            Debug.Log(matArr[i]);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SetHandHoldMat(int n)
    {
        handhold.GetComponent<Renderer>().materials = new Material[1] { matArr[n] };
    }
}
