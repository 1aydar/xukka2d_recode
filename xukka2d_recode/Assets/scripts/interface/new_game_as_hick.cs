using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class new_game_as_hick : MonoBehaviour
{
    void OnMouseDown ()
    {
				SceneManager.LoadScene ("level_01_quarter_hick");
				player_health.healthValue = 1;
				ScoreScript.scoreValue = 0;
				ammo_script.ammo_12x70 = 100;
    }
}