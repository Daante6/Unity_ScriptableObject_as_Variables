using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldupdateUI : MonoBehaviour
{
    public GlobalFloat gold;
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
        gold.OnValueChange.AddListener(() => text.text = gold.Value.ToString());
    }
}
