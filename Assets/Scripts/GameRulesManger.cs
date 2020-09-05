using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRulesManger : MonoBehaviour
{
  public  static GameRulesManger Instance=null;
    [SerializeField] List<GameRule> gameRules;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
  public Player GetWinner(Player Player1,Player Player2)
    {
        var A1 = Player1.PlayerID[1];
        var A2 = Player2.PlayerID[1];
        var Num1 = int.Parse(Player1.PlayerID[0].ToString());
        var Num2 = int.Parse(Player2.PlayerID[0].ToString());

       if(A1==A2)
        {
            return Num1 < Num2 ? Player1 : Player2;
        }
        else
        {
            var res = gameRules.Find((Gr) => (A1+A2)==(Gr.FirstAnimal+Gr.SecondAnimal));
            return res.SurvivalAnimal == A1 ? Player1 : Player2;
        }

    
    }
}
