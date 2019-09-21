using UnityEngine;
using UnityEngine.UI;
using System;

public class TapImage : MonoBehaviour
{

	public Image TappedImage;
	public Image MainImageObject;
    public Text decision;
    public Text playCount;
    public Text sucessCount;

    public void onClickAct()
    {
        TappedImage = this.GetComponent<Image>();
        MainImage.playCount++;
        playCount.text = String.Format("タップ : {0}回", MainImage.playCount);

        if (MainImageObject.sprite.name == TappedImage.sprite.name)
        {
            decision.text = "当ったり〜";
            MainImage.successCount++;
            sucessCount.text = String.Format("成功 : {0}回", MainImage.successCount);
        }
        else
        {
            decision.text = "はずれ〜";
        }

        MainImage mainImageOpe = GameObject.Find("MainImage").GetComponent<MainImage>();
        mainImageOpe.SetImages();
    }
}