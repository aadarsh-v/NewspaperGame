using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewspaperDriver : MonoBehaviour
{

    public GameObject newspaperOriginal;
    public GameObject newspaperButton;
    

    public Newspaper[] newspapers;
    public IDictionary<GameObject, Newspaper> spriteNewspapers = new Dictionary<GameObject, Newspaper>();
    public GameObject[] newspaperClones;
    public GameObject[] newspaperButtonClones;

    public static List<string> researchText = new List<string>();

    /// <summary>
    /// Creates newspapers and formats them on the camera based on the amount of newspapers to be made as given.
    /// </summary>
    /// <param name="num">The number of newspapers to be made.</param>
    void CreateNewspapers(int num)
    {
        newspapers = new Newspaper[num];
        newspaperButtonClones = new GameObject[num];
        newspaperClones = new GameObject[num];
        Camera cam = Camera.main;

        for (int i = 0; i < num; ++i)
        {
            // GameObject image = parseImage("images/newspaper1");
            FileParser fp = new FileParser();
            string[] text = fp.ParseText("Assets/Newspapers/newspaper1.txt");
            ClickableText[] interactable = fp.ParseInteractable();

            // newspapers[i] = new Newspaper(image, text, interactable);
            GameObject newspaperClone = Instantiate(newspaperOriginal, new Vector2((float)(-1 * (cam.orthographicSize * 2) + 4 + 6 * i), (float)-0.4 * cam.orthographicSize), newspaperOriginal.transform.rotation);
            GameObject newspaperButtonClone = Instantiate(newspaperOriginal, new Vector2((float)(-1 * (cam.orthographicSize * 2) + 4 + 6 * i), (float)-0.4 * cam.orthographicSize), newspaperOriginal.transform.rotation);
            newspaperClones[i] = newspaperClone;
            newspaperButtonClones[i] = newspaperButtonClone;
            spriteNewspapers.Add(newspaperClones[i], newspapers[i]);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // GameObject newspaperClone = Instantiate(newspaperOriginal);
        CreateNewspapers(3);
        // GameObject newspaperButtonClone = Instantiate(newspaperButton, new Vector2(0, 0), newspaperButton.transform.rotation);
        foreach (var sn in spriteNewspapers)
            Debug.Log("Key: " + sn.Key + "Value: " + sn.Value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
