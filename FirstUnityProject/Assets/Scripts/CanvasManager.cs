using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour {

    [SerializeField]
    public Canvas CanvasSwap;

    [SerializeField]
    public Canvas ThisCanvas;

    static Canvas current;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        current = ThisCanvas;
    }

    public void SwapCanvas()
    {
        if(current == null)
        {
            current = ThisCanvas;
        }

        ThisCanvas.gameObject.SetActive(false);
        Debug.Log("Disable curr",current);

        CanvasSwap.gameObject.SetActive(true);
        Debug.Log("Enable Canvas",current);

    }

    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
