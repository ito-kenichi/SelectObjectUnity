using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class MainImage : MonoBehaviour {

    public Image mainImage;
    public Image subImage001;
    public Image subImage002;
    public Image subImage003;
    public Image subImage004;
    public Image subImage005;
    public Image subImage006;
    public Image subImage007;
    public Image subImage008;

    private const int MAX_IMAGE_COUNT = 8;
    HashSet<int> hashSet = new HashSet<int>();

    public static int playCount = 0;
    public static int successCount = 0;

    // Use this for initialization
    void Start () {
        SetImages();
    }

    public void SetImages()
    {
        changeImage(mainImage);
        changeImage(subImage001);
        changeImage(subImage002);
        changeImage(subImage003);
        changeImage(subImage004);
        changeImage(subImage005);
        changeImage(subImage006);
        changeImage(subImage007);
        changeImage(subImage008);

        hashSet.Clear();
        GameObject.Find("Canvas").transform.Find("SettingPanel").gameObject.SetActive(false);
    }

    private void changeImage(Image img)
    {
        if(img != null)
        {
            //画像の乱数の生成
            int imageInt = Random.Range(1, MAX_IMAGE_COUNT + 1);
            while (hashSet.Contains(imageInt))
            {
                imageInt = Random.Range(1, MAX_IMAGE_COUNT + 1);
            }

            //画像変更
            string imageName = "image" + imageInt.ToString("D3");
            Texture2D texture = Resources.Load("img/" + imageName) as Texture2D;
            img.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
            img.sprite.name = imageName;
            if (img != mainImage)
            {
                hashSet.Add(imageInt);
            }
        }
    }
}
