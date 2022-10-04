using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform newTarget;
    private SpriteRenderer _spriteRenderer;
    private CameraScroll _cc;
    void Start()
    {
        //get our sprite renderer and turn it off so we don't see our trigger
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        _spriteRenderer.enabled = false;

        _cc = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraScroll>();
        //PlayerController.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //Debug.Log("Hello");
            _cc.ChangeTarget(newTarget);
        }
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Hello 2");
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
