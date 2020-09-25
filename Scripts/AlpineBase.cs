using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlpineBase : MonoBehaviour
{
	
	public Text usersdata;
	
	public GameObject listobject;
	
	public GameObject MoreMenu;
	
	public GameObject objectToPool;
 
	public void ADD(){
		Instantiate(objectToPool.transform, listobject.transform);
	}
	
	public void moremenu()
	{
		MoreMenu.SetActive(true);
	}
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DBManager.LoggedIn){
			usersdata.text = "Prenom :\n" + DBManager.firstname + "\n" + "Nom :\n" + DBManager.name;
		}
    }
}
