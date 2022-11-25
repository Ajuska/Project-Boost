using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisionHandler : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("this is frienly");
                break;
            case "Finish":
                Debug.Log("this is finish");
                break;
            case "Fuel":
                Debug.Log("You picked fuel");
                break;
            default:
                Debug.Log("sorry you blew up");
                ReloadLevel();
                break;
        }
   }
    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}


