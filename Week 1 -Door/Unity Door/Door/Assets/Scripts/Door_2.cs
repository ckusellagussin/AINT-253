using UnityEngine;
using System.Collections;

public class Door_2 : MonoBehaviour {


    private Animator _animation;
    public GameObject OpenPanel = null;



	// Use this for initialization
	void Start () {

        _animation = GetComponent<Animator>();

	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OpenPanel.SetActive(true);

        }

    }

    void OnTriggerExit(Collider other)
        {
        if (other.tag == "Player")
        {
            _animation.SetBool("open", false);
            OpenPanel.SetActive(false);

        }


        }

    private bool IsOpenPanePanelActive
    {
        get
        {
            return OpenPanel.activeInHierarchy;

        }

    }


    
	// Update is called once per frame
	void Update () {
	
	}
}
