using UnityEngine;
using UnityEngine.SceneManagement;

public class TapStart : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}