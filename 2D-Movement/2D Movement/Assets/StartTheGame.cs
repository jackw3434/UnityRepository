using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTheGame : MonoBehaviour {

    public void LoadGame()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("Clicked");
    }

}
