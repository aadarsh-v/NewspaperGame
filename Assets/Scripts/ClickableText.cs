using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/*
public class ClickableText : MonoBehaviour, IPointerClickHandler
{

    TextMeshProUGUI clickableText;
    Color yellow = new Color((float)1, (float)0.92, (float)0.016, (float)1);

    public ClickableText(TextMeshProUGUI clickableText)
    {
        this.clickableText = clickableText;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // var text = GetComponent<TextMeshProUGUI>();
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            int linkIndex = TMP_TextUtilities.FindIntersectingLink(clickableText, Input.mousePosition, null);
            if (linkIndex > -1)
            {
                clickableText.color = yellow;
                NewspaperDriver.researchText.Add(clickableText.text);
            }
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
*/

public class ClickableText : MonoBehaviour
{

    string clickableText;
    static Color yellow = new Color((float)1, (float)0.92, (float)0.016, (float)1);

    public ClickableText(string clickableText)
    {
        this.clickableText = clickableText;
    }

    void OnMouseOver()
    {
        GetComponent<Transform>().localScale = new Vector3(1.2f, 1.2f, 1);
        GetComponent<TextMesh>().color = yellow;
    }

    void OnMouseExit()
    {
        GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        GetComponent<TextMesh>().color = new Color(1, 1, 1, 1);
    }

    void OnMouseDown()
    {
        NewspaperDriver.researchText.Add(clickableText);
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
