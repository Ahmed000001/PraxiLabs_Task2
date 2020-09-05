using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
   
  public   string PlayerID;

    Text Playersign;

    private void Awake()
    {
        Playersign = GetComponentInChildren<Text>();

    }


   public void SetPlayerID(string ID)
    {
        PlayerID = ID;
        Playersign.text = ID;
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
