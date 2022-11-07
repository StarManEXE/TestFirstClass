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
    public Transform newTransform; //enter a new location in unity
    public TMP_Text mainText;
    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject btn4;
    public GameObject btn5;
    public GameObject btn6;
    public GameObject btn7;
    public GameObject btn8;
    public GameObject btn9;
    public GameObject btn10;
    public GameObject btn11;
    // Start is called before the first frame update
    void Start()
    {
        _storyindex = 0;
        btn2.SetActive(false);
        btn3.SetActive(false);
        btn4.SetActive(false);
        btn5.SetActive(false);
        btn6.SetActive(false);
        btn7.SetActive(false);
        btn8.SetActive(false);
        btn9.SetActive(false);
        btn10.SetActive(false);
        btn11.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void moveObject()
    {
        gameObject.transform.position = newTransform.position;
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
            mainText.SetText("Let's just start over, okay?");
            _storyindex = 0;
            btn1.SetActive(true);
            btn2.SetActive(false);
        }
        if (_storyindex == 3)
        {
            //gameObject.transform.position = newTransform.position;
            btn1.SetActive(false);
            btn2.SetActive(true);
        }
        if (_storyindex == 4)
        {
            btn2.SetActive(false);
            btn3.SetActive(true);
        }
        if (_storyindex == 5)
        {
            btn3.SetActive(false);
            btn4.SetActive(true);
        }
        if (_storyindex == 6)
        {
            btn4.SetActive(false);
            btn1.SetActive(true);
        }
        if (_storyindex == 9)
        {
            btn1.SetActive(false);
            btn5.SetActive(true);
            btn6.SetActive(true);
            btn7.SetActive(true);
            btn8.SetActive(true);
            btn9.SetActive(true);
            btn10.SetActive(true);
            btn11.SetActive(true);
        }
        if (_storyindex == 10)
        {
            btn1.SetActive(true);
            btn5.SetActive(false);
            btn6.SetActive(false);
            btn7.SetActive(false);
            btn8.SetActive(false);
            btn9.SetActive(false);
            btn10.SetActive(false);
            btn11.SetActive(false);
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
