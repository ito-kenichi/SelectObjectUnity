using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapReturn : MonoBehaviour
{

    public void OnTapReturn()
    {
        GameObject.Find("Canvas").transform.Find("SettingPanel").gameObject.SetActive(false);
    }
}
