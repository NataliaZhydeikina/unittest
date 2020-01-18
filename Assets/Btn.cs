using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn : MonoBehaviour {
    public Button btn;
    public Text text;
    public int counter;
    // Use this for initialization
    void Start() {
        btn.onClick.AddListener(()=>
        {
            clicker();
        });
    }
    private void Awake()
    {
        btn = (Button)GetComponent<Button>();
       // text = (Text)GetComponent<Text>();

    }
    void clicker()
    {
        counter++;

        text.text = "Counter: " + counter;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
