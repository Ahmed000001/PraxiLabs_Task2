using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match 
{
    Player player1;
    Player player2;
   public   Match(Player p1,Player p2)
    {
        player1 = p1;
        player2 = p2;
        var p1pos = player1.transform.position;
        player2.transform.position = new Vector3(p1pos.x, p1pos.y, p1pos.z+1);

    }
    public Player PlayMatch()
    {
        
       var winner=  GameRulesManger.Instance.GetWinner(player1, player2);
        if (player1 == winner)
        {
           GameObject.Destroy(player2.gameObject);
        }
        else
        {
           GameObject.Destroy(player1.gameObject);
        }
        return winner;
    }

    

}
