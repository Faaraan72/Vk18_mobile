using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameareascript : MonoBehaviour
{
    public GameObject overselectscreen;
    public GameObject loadscreen;
    public GameObject gamearea;

    public int balls;
    public int target;

    public void overselecttogame()
    {
        overselectscreen.SetActive(false);
         loadscreen.SetActive(true);
        Invoke(nameof(gamescreen), 3f);

    }
   
    private void gamescreen()
    {
       
        gamearea.SetActive(true);
        loadscreen.SetActive(false);
    }
    public void sover()
    {
        balls = 6;
        target = Random.Range(7, 16);
    }
    public void threeover()
    {
        balls = 18;
        target = Random.Range(18, 30);
    }
    public void fiveover()
    {
        balls = 30;
        target = Random.Range(29,56);
    }

}
