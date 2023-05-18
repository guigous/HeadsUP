using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{


    public int playerSelected = 0;
    public GameObject playerList;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchPlayer()
    {
        int i = 0;
        foreach (Transform item in playerList.transform)
        {
            if (i == playerSelected)
            {
                item.gameObject.SetActive(true);

                
            }
            else
            {
                item.gameObject.SetActive(false);
            }
            i++;
        }
    }
}
