using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBodyColor : MonoBehaviour {

    public GameObject body1_LOD0;
    public GameObject body1_LOD1;
    public GameObject body1_LOD2;
    public GameObject body1_LOD3;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SetBodyColors(string color)//hex 红色:6F0000FF
    {
        body1_LOD0.GetComponent<MeshRenderer>().materials[0].color = HexToColor(color);
        body1_LOD1.GetComponent<MeshRenderer>().materials[0].color = HexToColor(color);
        body1_LOD2.GetComponent<MeshRenderer>().materials[0].color = HexToColor(color);
        body1_LOD3.GetComponent<MeshRenderer>().materials[0].color = HexToColor(color);
    }


    private Color32 HexToColor(string hex)
    {
        hex = hex.Replace("0x", "");//in case the string is formatted 0xFFFFFF
        hex = hex.Replace("#", "");//in case the string is formatted #FFFFFF
        byte a = 255;//assume fully visible unless specified in hex
        byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
        byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
        byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
        if (hex.Length == 8)
        {
            a = byte.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
        }
        return new Color32(r, g, b, a);
    }
}
