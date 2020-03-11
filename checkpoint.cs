using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour

{
    public Sprite sign;
    public Sprite reachesign;
    public Sprite reachesign1;
    public Sprite reachesign2;
    public Sprite reachesign3;
    public Sprite reachesign4;
    public Sprite reachedsign;
    private SpriteRenderer checkpointSpriteRenderer;
    public bool checkpointReached;

    void Start()
    {
        checkpointSpriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            checkpointSpriteRenderer.sprite = reachesign;
            checkpointSpriteRenderer.sprite = reachesign1;
            checkpointSpriteRenderer.sprite = reachesign2;
            checkpointSpriteRenderer.sprite = reachesign3;
            checkpointSpriteRenderer.sprite = reachesign4;
            checkpointSpriteRenderer.sprite = reachedsign;
            

    checkpointReached = true;
        }

    }
}