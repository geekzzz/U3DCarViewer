using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDoorColor : MonoBehaviour {

    public GameObject door1_LOD0;
    public GameObject door1_LOD1;
    public GameObject door1_LOD2;
    public GameObject door1_LOD3;

    public GameObject door2_LOD0;
    public GameObject door2_LOD1;
    public GameObject door2_LOD2;
    public GameObject door2_LOD3;


    public GameObject door3_LOD0;
    public GameObject door3_LOD1;
    public GameObject door3_LOD2;
    public GameObject door3_LOD3;

    public GameObject door4_LOD0;
    public GameObject door4_LOD1;
    public GameObject door4_LOD2;
    public GameObject door4_LOD3;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SetDoorColors(string color)//hex 红色:6F0000FF
    {
        door1_LOD0.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);
        door1_LOD1.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);
        door1_LOD2.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);
        door1_LOD3.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);

        door2_LOD0.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);
        door2_LOD1.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);
        door2_LOD2.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);
        door2_LOD3.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);

        door3_LOD0.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);
        door3_LOD1.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);
        door3_LOD2.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);
        door3_LOD3.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);

        door4_LOD0.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);
        door4_LOD1.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);
        door4_LOD2.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);
        door4_LOD3.GetComponent<MeshRenderer>().materials[3].color = HexToColor(color);
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
