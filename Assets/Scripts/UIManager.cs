using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class UIManager : MonoBehaviour {

    public bool Player1_Continue;
    public bool Player2_Continue;
    public bool Player3_Continue;
    public bool Player4_Continue;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
       

	}

    public void Continuer(int Player)
    {
        switch (Player)
        {
            case 0:
                break;

            case 1:
                Player1_Continue = true;
                break;

            case 2:
                Player2_Continue = true;
                break;

            case 3:
                Player3_Continue = true;
                break;

            case 4:
                Player4_Continue = true;
                break;
        }          
       
    }

    public void Rentrer(int Player)
    {
        switch (Player)
        {
            case 0:
                break;

            case 1:
                Player1_Continue = false;
                break;

            case 2:
                Player2_Continue = false;
                break;

            case 3:
                Player3_Continue = false;
                break;

            case 4:
                Player4_Continue = false;
                break;
        }
    }


}
