using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSeatColor : MonoBehaviour {
    public GameObject seat;
    Material[] matArr;//存储材质
    // Use this for initialization
    void Start () {
        matArr = Resources.LoadAll<Material>("Materials/SeatMat");
        for (int i = 0; i < matArr.Length; ++i)
        {
            Debug.Log(matArr[i]);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SetSeatMat(int n)
    {
        seat.GetComponent<Renderer>().materials = new Material[1] { matArr[n] };
    }
}
