using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;
using Ludiq;


public class UIEvents : MonoBehaviour
{
    

    public bool IsBttnClicked()
    {
        //return (bool)Variables.Scene(this).Get("bttnClicked");
        //return (bool)Variables.Object(this).Get("bttnClicked");
        //return (bool)Variables.Object(gameObject).Get("bttnClicked");
        bool oldValue = (bool)Variables.Object(gameObject).Get("bttnClicked22");
        return oldValue;
    }

    public void OnBttnClick()
    {
        //Variables.Scene(this).Set("bttnClicked22", true);
        bool oldValue = (bool)Variables.Object(gameObject).Get("bttnClicked22");
        //Debug.Log(Variables.Object(gameObject).Get("bttnClicked22") + " is now");
        Variables.Object(gameObject).Set("bttnClicked22", !oldValue);
    }
}
