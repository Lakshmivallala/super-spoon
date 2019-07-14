using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{

    public Material brown;
    public Material Red;
    public Material purple;
    public Material pink;
    // Start is called before the first frame update
    void Start()
    {

    }


    // changes colour to brown
    public void changeColortobrown()
    {
        GetComponent<Renderer>().material = brown;
    }
    // changes colour to red
    public void changeColortored()
    {
        GetComponent<Renderer>().material = Red;
    }
    // changes colour to pink
    public void changeColortopink()
    {
        GetComponent<Renderer>().material = pink;
    }
    // changes colour to purple
    public void changeColortopurple()
    {
        GetComponent<Renderer>().material = purple;
    }
}


