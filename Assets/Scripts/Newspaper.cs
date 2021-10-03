using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newspaper : MonoBehaviour
{
    public GameObject image;
    public string[] text;
    public ClickableText[] interactable;

    public Newspaper(GameObject image, string[] text, ClickableText[] interactable)
    {
        this.image = image;
        this.text = text;
        this.interactable = interactable;
    }

    // prints onto a newspaper sprite as identified
    public void PrintPaper(Sprite newspaperSprite)
    {
        for (int i = 0; i < text.Length; i++)
        {

        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
