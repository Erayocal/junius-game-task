
using UnityEngine;
using UnityEngine.SceneManagement;

public class Res_game : MonoBehaviour
{
   //R tuþuna basýldýðýnda tüm sahneyi ressetler.
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
