
using UnityEngine;
using UnityEngine.SceneManagement;

public class Res_game : MonoBehaviour
{
   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
