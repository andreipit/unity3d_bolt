using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptWithoutAssembly : MonoBehaviour
{
    public LinkOfScriptWithoutAssembly link;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ArbitaryFunction(int _value)
    {
        link.ArbitaryFunction2(_value);
        //Debug.Log("ArbitaryFunction value = " + _value);
    }

}
