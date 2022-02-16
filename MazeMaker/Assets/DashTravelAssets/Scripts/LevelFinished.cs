using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinished : MonoBehaviour
{
    // BUG: we dont reach this part after its called by the animation, being set active by the levelcomplete ui
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Next Scene");
    }
}
//This script recreates the same script on the assets folder everytime it is updated