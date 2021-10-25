using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public GlobalFloat Health;
    // Start is called before the first frame update
    void Start()
    {
        Health.Value = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        Health.Value -= 0.5f * Time.deltaTime;
    }

}
