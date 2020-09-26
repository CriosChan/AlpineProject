using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.IO;

public class CheckUpdate : MonoBehaviour
{
	public GameObject UpdateAvailable;

	public void CheckUpdateButton ()
	{
		StartCoroutine(check());
	}

	void Start()
	{
		Debug.Log("Actual application version : " + Application.version);
		StartCoroutine(check());
		StartCoroutine(autocheck());
	}

    // Update is called once per frame
    void Update()
    {
        
    }
	
	IEnumerator autocheck()
	{
		yield return new WaitForSeconds(3600);
		StartCoroutine(check());
		StartCoroutine(autocheck());
	}
	
	IEnumerator check()
	{
	
			Debug.Log("Start Android");
			WWW www = new WWW("https://alpine207.000webhostapp.com/getversion.php");
			yield return www;
			Debug.Log("Server version : " + www.text + "\n Actual version : " + Application.version);
			if(www.text.ToString() == Application.version.ToString())
			{
				Debug.Log("Up To Date");
			} else	{
				Debug.Log("Application isn't up to date");
				UpdateAvailable.SetActive(true);
			}
	}
	
	public void Download(){
		Application.OpenURL("https://github.com/CriosChan/AlpineProject/releases/download/latest/alpine.apk");
	}
}
