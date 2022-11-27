using UnityEngine;

public class QuitApplication : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quit!");
            Application.Quit();
        }
    }
}
