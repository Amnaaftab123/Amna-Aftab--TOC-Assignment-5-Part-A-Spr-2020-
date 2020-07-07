using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        Invoke("Startnewscene", 2);
    }

    void Startnewscene()
    {
        SceneManager.LoadScene(1);
    }
}
