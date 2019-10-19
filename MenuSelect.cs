using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuSelect : MonoBehaviour
{
    [SerializeField]
    int currentChoice = -1;//-1 Refers to it being next to the Title
    RectTransform rect;

    Vector2 title_to_start = new Vector2(-271f,-204f);
    Vector2 start_to_load = new Vector2(-329f,-119f);
    Vector2 load_to_exit = new Vector2(-78f,-119f);
    Vector2 title_to_exit = new Vector2(-678f,-446f);
    public float ratio = 1;
    // Start is called before the first frame update
    void Start()
    {
        rect = this.gameObject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
        {
            Activate();
        }

        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            Shift(true);
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Shift(false);
        }
    }

    void Activate()
    {
        switch(currentChoice)
        {
            case -1:
                return;
            case 0:
                SceneManager.LoadSceneAsync("SampleScene", LoadSceneMode.Single);
                break;
            case 1:
                return;
            case 2:
                Application.Quit();
                return;
        }
    }


    void Shift(bool moveDown)
    {
        if(currentChoice == -1)//STARTING AT TITLE
        {
            if(moveDown)
            {
                transform.Translate(title_to_start * ratio);
                currentChoice = 0;
            }
            else if (!moveDown)
            {
                transform.Translate(title_to_exit * ratio);
                currentChoice = 2;
            }
        }
        else if (currentChoice == 0)//STARTING AT "Start"
        {
            if(moveDown)
            {
                transform.Translate(start_to_load * ratio);
                currentChoice = 1;
            }
            else
            {
                transform.Translate(start_to_load * ratio);
                transform.Translate(load_to_exit * ratio);
                currentChoice = 2;
            }
        }
        else if(currentChoice == 1)//STARTING AT Load
        {
            if(moveDown)
            {
                transform.Translate(load_to_exit * ratio);
                currentChoice = 2;
            }
            else
            {
                transform.Translate(-start_to_load * ratio);
                currentChoice = 0;
            }
        }
        else if(currentChoice == 2)
        {
            if(moveDown)
            {
                transform.Translate(-load_to_exit * ratio);
                transform.Translate(-start_to_load * ratio);
                currentChoice = 0;
            }
            else
            {
                transform.Translate(-load_to_exit * ratio);
                currentChoice = 1;
            }
        }
    }
}
