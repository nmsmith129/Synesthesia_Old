using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour
{

    GameObject C = GameObject.FindGameObjectWithTag("C");
    GameObject E = GameObject.FindGameObjectWithTag("E");
    GameObject G = GameObject.FindGameObjectWithTag("G");
    public Color CColor = Color.green;
    public Color EColor = Color.yellow;
    public Color GColor = Color.blue;

    // Use this for initialization
    void Start()
    {
        C.GetComponent<Renderer>().material.color = CColor;
        E.GetComponent<Renderer>().material.color = EColor;
        G.GetComponent<Renderer>().material.color = GColor;
    }

    // When user hits button
    void OnClick()
    {
        C.GetComponent<Renderer>().material.color = Color.white;
        E.GetComponent<Renderer>().material.color = Color.white;
        G.GetComponent<Renderer>().material.color = Color.white;
    }
}


