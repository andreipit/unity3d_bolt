using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCustomBoltScript1 : MonoBehaviour
{
    public Link Linker;
    // Start is called before the first frame update
    void Start()
    {
    }


    public void DebugNumber(int _x)
    {
        Debug.Log("next event="+_x + " but linker=" + Linker.Value);
    }

}
