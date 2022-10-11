using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{
    public string[] story = new string[50]; //number can be anything. As long as you want to write.
    private int _storyindex;

    public TMP_Text mainText;
    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    // Start is called before the first frame update
    void Start()
    {
        _storyindex = 0;
        btn3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextLineofStory()
    {
        /*if(_storyindex++ > 0)
        {
            _storyindex++;
        }*/
        //_storyindex++;
        if (_storyindex < story.Length)
        {
            mainText.SetText(story[_storyindex]);
            _storyindex++;
        }
        else
        {
            mainText.SetText("To Be Continued...");
            btn1.SetActive(false);
            btn2.SetActive(false);
        }
    }

    /*public void SkipLineofStory()
    {
        _storyindex = _storyindex + 5; 

        if (_storyindex < story.Length)
        {
            mainText.SetText(story[_storyindex]);
        }
        else
        {
            mainText.SetText("The End");
            btn1.SetActive(false);
            btn2.SetActive(false);
        }
    }*/

    public void SkipStory(int skipAmount) //if you want to have it go more than the set amount, make several buttons to skip different amounts
    {
        _storyindex = _storyindex + skipAmount;

        if (_storyindex < story.Length)
        {
            mainText.SetText(story[_storyindex]);
        }
        else
        {
            mainText.SetText("It's over. Now actually read it this time.");
            //_storyindex = 0;
            btn1.SetActive(false);
            btn2.SetActive(false);
            btn3.SetActive(true);
        }
    }

    public void RestartStory()
    {
        _storyindex = 0;
        btn1.SetActive(true);
        btn2.SetActive(true);
        btn3.SetActive(false);
    }
}
