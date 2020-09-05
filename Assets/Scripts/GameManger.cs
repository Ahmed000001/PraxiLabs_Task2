using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManger : MonoBehaviour
{

     List<string> PlayersIDs;
     List<Player> players;

    [SerializeField] Player Playerrefab;
    [SerializeField] Vector3 startpos;

    private void Start()
    {
        PlayersIDs = PlayersSerializer.instance.PlayersIDs;
        players = new List<Player>();
        PopulatePlayersasCubes();
    }


    public  void PopulatePlayersasCubes()
    {
        for (int i = 0; i < PlayersIDs.Count; i++)
        {
            var player = Instantiate(Playerrefab);
            players.Add(player);
            player.gameObject.name = PlayersIDs[i];
            player.SetPlayerID(PlayersIDs[i]);
            player.transform.position = new Vector3((-i*startpos.x)+startpos.x, startpos.y, startpos.z);
        }
    } 


    public void PlayRound()
    {
        if(players.Count==1)
            return;
        List<Player> SurvivedPlayers=new List<Player>();
        for (int i = 0; i < players.Count; i+=2)
        {
            var match = new Match(players[i], players[i + 1]);
          SurvivedPlayers.Add(match.PlayMatch());
        }
        players.Clear();
        players = SurvivedPlayers;
       
    }




}
