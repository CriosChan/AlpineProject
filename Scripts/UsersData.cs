using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UsersData
{
    public string user;
	public string pass;
	
	public UsersData(string user, string pass)
	{
		this.user = user;
		this.pass = pass;
	}
}
