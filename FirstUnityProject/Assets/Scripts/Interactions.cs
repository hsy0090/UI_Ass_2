using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interactions : MonoBehaviour {

    [SerializeField]
    GameObject panel;

    [SerializeField]
    GameObject other;
    [SerializeField]
    GameObject other1;

    GameObject current;

    // Use this for initialization
    void Start () {
        if (panel)
        {
            current = panel;
        }

        if (other)
            other.SetActive(false);
        if(other1)
            other1.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void swap()
    {
        if (current == null)
        {
            current = panel;
        }

        if(other)
            other.SetActive(false);

        if(other1)
            other1.SetActive(false);

        current.gameObject.SetActive(true);
    }

    public void show()
    {
        if (other)
            other.SetActive(true);
        if (other1)
            other1.SetActive(true);
    }
}
