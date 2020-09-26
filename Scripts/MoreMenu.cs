using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MoreMenu : MonoBehaviour
{
	public GameObject moremenu;
	
	public Animator animator;
	
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	
	public void MoreButtonTrue()
	{
		StartCoroutine(StartAnim());
	}
	
	public void MoreButtonFalse()
	{
		StartCoroutine(End());
	}
	
	public void quitapp()
	{
		Application.Quit();
	}
	
	IEnumerator StartAnim()
	{
		moremenu.SetActive(true);
		animator.SetBool("Start", true);
		yield return new WaitForSeconds(2);
		animator.SetBool("Start", false);
	}
	
	IEnumerator End()
	{
		animator.SetBool("End", true);
		yield return new WaitForSeconds(2.5f);
		animator.SetBool("End", false);
		moremenu.SetActive(false);
	}
	
	public void disconnect()
	{
		string path = Application.persistentDataPath.ToString() + "/users.bin";
		File.Delete(path);
		Application.Quit();
	}
}
