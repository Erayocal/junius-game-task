
using UnityEngine;
using UnityEngine.SceneManagement;

public class Res_game : MonoBehaviour
{
   //R tu�una bas�ld���nda t�m sahneyi ressetler.
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
