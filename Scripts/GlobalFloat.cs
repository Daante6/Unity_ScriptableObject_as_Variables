using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Create global variable/Float", fileName = "FloatGlobalVariable", order = 0)]
public class GlobalFloat : ScriptableObject
{
    [SerializeField]
    private float value;
    public UnityEvent OnValueChange;
    public bool EnableDebugging;
    public float Value
    {
        get => value;
        set
        {
            this.value = value;
            OnValueChange.Invoke();
            if (EnableDebugging)
            {
                Debug.Log("Gold was added: " + value);
            }
        }
    }
    private void OnValidate()
    {
        OnValueChange.Invoke();
        if (EnableDebugging)
        {
            Debug.Log("Gold was added: " + value);
        }
    }

    private void OnEnable()
    {
        value = 0;
    }

    //public void Somethin()
    //{ }
}


//GlobalFloat item = new GlobalFloat();

//try
//{
//    item.Somethin();
//}
//catch (Exception e)
//{

//    Debug.LogError(e.Message);
//}




