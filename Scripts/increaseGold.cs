using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseGold : MonoBehaviour
{
    public GlobalFloat gold;
    // Start is called before the first frame update
    void Start()
    {
        gold.OnValueChange.AddListener(() => Debug.Log("Gold was added"));
        gold.Value += 100;
    }

    // Update is called once per frame
    void Update()
    {

    }
    /*private void OnDestroy()
    {
        gold.OnValueChange.RemoveListener(() => { });
    }*/
}
