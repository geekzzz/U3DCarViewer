using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWheelColor : MonoBehaviour
{
    public GameObject wheel1_LOD0;
    public GameObject wheel1_LOD1;
    public GameObject wheel1_LOD2;
    public GameObject wheel1_LOD3;

    public GameObject wheel2_LOD0;
    public GameObject wheel2_LOD1;
    public GameObject wheel2_LOD2;
    public GameObject wheel2_LOD3;


    public GameObject wheel3_LOD0;
    public GameObject wheel3_LOD1;
    public GameObject wheel3_LOD2;
    public GameObject wheel3_LOD3;

    public GameObject wheel4_LOD0;
    public GameObject wheel4_LOD1;
    public GameObject wheel4_LOD2;
    public GameObject wheel4_LOD3;




    Material[] matArr;//存储材质
    // Use this for initialization
    void Start()
    {
        //for(int i = 1; i <=8;++i)
        //      {
        //          string path = "Wheel_Mat0" + i.ToString();
        //          Debug.Log(path);
        //          matArr[i] = Resources.Load(path,typeof(Material)) as Material;

        //      }
        matArr = Resources.LoadAll<Material>("Material");
        for(int i= 0;i < 10;++i)
        {
            //Debug.Log(matArr[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetWheelColors(string color)
    {
        //string path = "Wheel_Mat0" + i.ToString();
        //Material m = Resources.Load<Material>(path);
        wheel1_LOD0.GetComponent<Renderer>().materials[0].color = HexToColor(color);
        wheel1_LOD1.GetComponent<Renderer>().materials[0].color = HexToColor(color);
        wheel1_LOD2.GetComponent<Renderer>().materials[0].color = HexToColor(color);
        wheel1_LOD3.GetComponent<Renderer>().materials[0].color = HexToColor(color);

        wheel2_LOD0.GetComponent<Renderer>().materials[0].color = HexToColor(color);
        wheel2_LOD1.GetComponent<Renderer>().materials[0].color = HexToColor(color);
        wheel2_LOD2.GetComponent<Renderer>().materials[0].color = HexToColor(color);
        wheel2_LOD3.GetComponent<Renderer>().materials[0].color = HexToColor(color);


        wheel3_LOD0.GetComponent<Renderer>().materials[0].color = HexToColor(color);
        wheel3_LOD1.GetComponent<Renderer>().materials[0].color = HexToColor(color);
        wheel3_LOD2.GetComponent<Renderer>().materials[0].color = HexToColor(color);
        wheel3_LOD3.GetComponent<Renderer>().materials[0].color = HexToColor(color);

        wheel4_LOD0.GetComponent<Renderer>().materials[0].color = HexToColor(color);
        wheel4_LOD1.GetComponent<Renderer>().materials[0].color = HexToColor(color);
        wheel4_LOD2.GetComponent<Renderer>().materials[0].color = HexToColor(color);
        wheel4_LOD3.GetComponent<Renderer>().materials[0].color = HexToColor(color);
        //Debug.Log(wheel1_LOD3.GetComponent<Renderer>().materials[0].name);
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
