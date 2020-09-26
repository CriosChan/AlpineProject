using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
	public InputField userField;
	public InputField passwordField;
	public InputField passwordverifField;
	public InputField email;
	public InputField name;
	public InputField firstname;
	
	public Button submitButton;
	
	public GameObject RegisterMenu;
	public GameObject LoginMenu;
	
	public Text error;
	
	public void CallRegister()
	{
		StartCoroutine(RegisterEnum());
	}
	
	IEnumerator RegisterEnum()
	{
		WWWForm form = new WWWForm();
		form.AddField("user", userField.text);
		form.AddField("password", passwordField.text);
		form.AddField("email", email.text);
		form.AddField("name", name.text);
		form.AddField("firstname", firstname.text);
		WWW www = new WWW("https://alpine207.000webhostapp.com/register.php", form);
		yield return www;
		if(www.text == "0")
		{
			Debug.Log("User created successfully.");
			LoginMenu.SetActive(true);
			RegisterMenu.SetActive(false);
		}
		else
		{
			Debug.Log("User creation failed. Error 0" + www.text);
			if(www.text == "1")
			{
				error.text = "ERREUR : Connection a la base de donnee impossible";
			} else if(www.text == "2")
			{
				error.text = "ERREUR : Récupération des données impossibles";
			} else if(www.text == "3")
			{
				error.text = "ERREUR : Nom d'utilisateur ou email deja utilisee";
			} else if(www.text == "4")
			{
				error.text = "ERREUR : QUERY FAILED";
			}
		}
		
		
	}
	
	public void VerifyInputs()
	{
		submitButton.interactable = (userField.text.Length >= 4 && passwordField.text.Length >= 8 && passwordverifField.text == passwordField.text && email.text.Length >= 8 && name.text.Length > 0 && firstname.text.Length > 0);
	}
}
