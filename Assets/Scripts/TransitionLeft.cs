using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionLeft : MonoBehaviour
{
    private bool clicked = false;
    MainManager mainManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LoadMainMenu();
    }

    void LoadMainMenu()
    {
        if (clicked)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 800 * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);

            if (gameObject.transform.position.x > 1300)
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    public void Clicked()
    {
        //MainManager.SaveName();
        clicked = true;
        //MainManager.SaveName();
    }
}
