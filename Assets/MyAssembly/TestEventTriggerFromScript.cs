using Ludiq;
using Bolt;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEventTriggerFromScript : MonoBehaviour
{
    public GameObject flowMachineGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            CustomEvent.Trigger(flowMachineGameObject, "TestEvent", 350);
        }
    }
}
