using UnityEngine;
using UnityEngine.PlayerLoop;

public class Dialog : MonoBehaviour
{

    public string storyline;

    int currentIndex = 0;

    //this is just for demo, has nothing to do with dialog
    public string[] someText;


    private void Start()
    {
        //this is just for demo, has nothing to do with dialog
        for (int i = 0; i < someText.Length; i++)
        {

            Debug.Log(someText[i]);
        }        
    }

    void Update()
    {
        //this is just for demo, has nothing to do with dialog
        return;

        if(someText.Length == 0)
        {
            return;
        }

        Debug.Log(someText[currentIndex]);
        currentIndex++;

        if(currentIndex >= someText.Length)
        {
            currentIndex = 0;
        }
    }
}
