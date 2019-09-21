using UnityEngine;
using UnityEngine.SceneManagement;

public class TapNext : MonoBehaviour {

    public void OnTapNext ()
    {
        MainImage mainImageOpe = GameObject.Find("MainImage").GetComponent<MainImage>();
        mainImageOpe.SetImages();

        SceneManager.LoadScene(1);
    }
}
