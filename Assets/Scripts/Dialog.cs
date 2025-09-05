using UnityEngine;
using UnityEngine.PlayerLoop;

public class Dialog : MonoBehaviour
{

    public string storyline;

    int currentIndex = 0;

    public string[] someText;


    private void Start()
    {
    
        for(int i = 0; i < someText.Length; i++)
        {

            Debug.Log(someText[i]);
        }        
    }

    void Update()
    {
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
