using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartUIInisializer : MonoBehaviour
{
	public GameObject login;
	public GameObject register;
	public GameObject interfacebase;
	public GameObject MoreMenu;

    // Start is called before the first frame update
	
    void Start()
    {
		login.SetActive(true);
		register.SetActive(false);
		interfacebase.SetActive(false);
        MoreMenu.SetActive(false);
    }
}
