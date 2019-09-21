using UnityEngine;
using UnityEngine.UI;
using System;

public class ViewResult : MonoBehaviour {

    public GameObject PlayCount;
    public GameObject SuccessCount;

    void Update()
    {
        PlayCount.GetComponent<Text>().text = String.Format("合計タップ : {0}回", MainImage.playCount);
        SuccessCount.GetComponent<Text>().text = String.Format("合計成功 : {0}回", MainImage.successCount);
    }
}
