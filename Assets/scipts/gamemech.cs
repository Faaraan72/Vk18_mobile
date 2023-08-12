using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemech : MonoBehaviour
{
   private int balls;
    private int target;
    private int runs = 0;
   private int userchoice;
   private int aichoice;
   private  bool Out = false;
   private  bool Win = false;
   private  bool loose = false;

    //----------------------------->
    public Text ballstxt;
    public Text runstxt;
    public Text targettxt;
    public Text resultperballtxt;
    public Text aichoicetxt;
    public GameObject winscreen;
    public GameObject loosescreen;
    public GameObject winpannel;
    public GameObject loosepannel;

    public GameObject aichoice1;
    public GameObject aichoice2;
    public GameObject aichoice3;
    public GameObject aichoice4;
    public GameObject aichoice6;

    public GameObject waitpanelscreen;

    public gameareascript gs;
    //------------------------->
   
    private void Start()
    {

        target = gs.target;
        balls = gs.balls;
        ballstxt.text = "" + balls;
        targettxt.text = "" + target;
        aichoice1.SetActive(false);
        aichoice2.SetActive(false);
        aichoice3.SetActive(false);
        aichoice4.SetActive(false);
        aichoice6.SetActive(false);
        waitpanelscreen.SetActive(false);

    }
    
    void checkwin()
    {
        if( runs > target && Win == false)
        {
            Win = true;
            winpannel.SetActive(true);
            Invoke(nameof(winning), 3f);
        }
    }
    void winning()
    {
        winpannel.SetActive(false);
        winscreen.SetActive(true);
    }
    void checkloose()
    {
        if((Out == true) && loose == false)
        {
            loose = true;
            loosepannel.SetActive(true);
            Invoke(nameof(loosing), 3f);
        }
    }
    void loosing()
    {
        loosepannel.SetActive(false);
        loosescreen.SetActive(true);
    }
    public void soverui()
    {
       
        Debug.Log("super over" + balls);
        ballstxt.text = "" + balls;
        targettxt.text = "" + target;

    }
    public void fiveoverui()
    {
        
       
        Debug.Log("5 over" + balls);
        ballstxt.text = "" + balls;
        targettxt.text = "" + target;
    }
    public void threeoverui()
    {
       
        Debug.Log("3 over" + balls);
        ballstxt.text = "" + balls;
        targettxt.text = "" + target;
    }

    public void one()
    {
        userchoice = 1;
        aichoice = Random.Range(1, 5);
       
       // aichoicetxt.text = "" + aichoice;
        if (aichoice == 1)
        {
            aichoice1.SetActive(true);

            aichoice2.SetActive(false);
            aichoice3.SetActive(false);
            aichoice4.SetActive(false);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 2)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(true);
            aichoice3.SetActive(false);
            aichoice4.SetActive(false);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 3)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(false);
            aichoice3.SetActive(true);
            aichoice4.SetActive(false);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 4)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(false);
            aichoice3.SetActive(false);
            aichoice4.SetActive(true);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 6)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(false);
            aichoice3.SetActive(false);
            aichoice4.SetActive(false);
            aichoice6.SetActive(true);
        }
        wait();

        if (aichoice == userchoice)
        {
            Out = true;
            Debug.Log("out!");
            balls= balls -1; ballstxt.text = "" + balls;
            checkloose();
        }
        else
        {
            runs += userchoice;
            Debug.Log("runs:" + runs);
            runstxt.text = "" + runs;
            balls = balls - 1; ballstxt.text = "" + balls;
            resultperballtxt.text = "Single"; checkwin();
            
        }

    }
    public void two()
    {
        userchoice = 2;
        aichoice = Random.Range(1, 5);
       // aichoicetxt.text = "" + aichoice;
        if (aichoice == 1)
        {
            aichoice1.SetActive(true);

            aichoice2.SetActive(false);
            aichoice3.SetActive(false);
            aichoice4.SetActive(false);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 2)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(true);
            aichoice3.SetActive(false);
            aichoice4.SetActive(false);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 3)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(false);
            aichoice3.SetActive(true);
            aichoice4.SetActive(false);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 4)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(false);
            aichoice3.SetActive(false);
            aichoice4.SetActive(true);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 6)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(false);
            aichoice3.SetActive(false);
            aichoice4.SetActive(false);
            aichoice6.SetActive(true);
        }
        wait();
        if (aichoice == userchoice)
        {
            Out = true; Debug.Log("out!");
            balls = balls - 1; ballstxt.text = "" + balls; checkloose();
        }
        else
        {
            runs = runs + userchoice;
            Debug.Log("runs:" + runs); runstxt.text = "" + runs; balls = balls - 1; ballstxt.text = "" + balls;
            resultperballtxt.text = "Double";
            checkwin();
        }
    }
    public void three()
    {
        userchoice = 3;
        aichoice = Random.Range(1, 5);
       // aichoicetxt.text = "" + aichoice;
        if (aichoice == 1)
        {
            aichoice1.SetActive(true);

            aichoice2.SetActive(false);
            aichoice3.SetActive(false);
            aichoice4.SetActive(false);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 2)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(true);
            aichoice3.SetActive(false);
            aichoice4.SetActive(false);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 3)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(false);
            aichoice3.SetActive(true);
            aichoice4.SetActive(false);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 4)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(false);
            aichoice3.SetActive(false);
            aichoice4.SetActive(true);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 6)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(false);
            aichoice3.SetActive(false);
            aichoice4.SetActive(false);
            aichoice6.SetActive(true);
        }
        wait();
        if (aichoice == userchoice)
        {
            Out = true; Debug.Log("out!"); balls = balls - 1; ballstxt.text = "" + balls; checkloose();
        }
        else
        {
            runs = runs + userchoice; Debug.Log("runs:" + runs); runstxt.text = "" + runs;
            balls = balls - 1; ballstxt.text = "" + balls;
            resultperballtxt.text = "Quick 3"; checkwin();
        }
    }
    public void four()
    {
        userchoice = 4;
        aichoice = Random.Range(1, 5);
       // aichoicetxt.text = "" + aichoice;
        if (aichoice == 1)
        {
            aichoice1.SetActive(true);

            aichoice2.SetActive(false);
            aichoice3.SetActive(false);
            aichoice4.SetActive(false);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 2)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(true);
            aichoice3.SetActive(false);
            aichoice4.SetActive(false);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 3)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(false);
            aichoice3.SetActive(true);
            aichoice4.SetActive(false);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 4)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(false);
            aichoice3.SetActive(false);
            aichoice4.SetActive(true);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 6)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(false);
            aichoice3.SetActive(false);
            aichoice4.SetActive(false);
            aichoice6.SetActive(true);
        }
        wait();
        if (aichoice == userchoice)
        {
            Out = true; Debug.Log("out!"); balls = balls - 1; ballstxt.text = "" + balls; checkloose();
        }
        else
        {
            runs = runs + userchoice; Debug.Log("runs:" + runs); runstxt.text = "" + runs; balls = balls - 1; 
            ballstxt.text = "" + balls; resultperballtxt.text = "its a " + userchoice;
            checkwin();
        }
    }
    public void six()
    {
        userchoice = 6;
        aichoice = Random.Range(1, 7);
       // aichoicetxt.text = "" + aichoice;
        if (aichoice == 1)
        {
            aichoice1.SetActive(true);

            aichoice2.SetActive(false);
            aichoice3.SetActive(false);
            aichoice4.SetActive(false);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 2)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(true);
            aichoice3.SetActive(false);
            aichoice4.SetActive(false);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 3)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(false);
            aichoice3.SetActive(true);
            aichoice4.SetActive(false);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 4)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(false);
            aichoice3.SetActive(false);
            aichoice4.SetActive(true);
            aichoice6.SetActive(false);
        }
        else if (aichoice == 6)
        {
            aichoice1.SetActive(false);
            aichoice2.SetActive(false);
            aichoice3.SetActive(false);
            aichoice4.SetActive(false);
            aichoice6.SetActive(true);
        }
        wait();
        if (aichoice == 5) { aichoice = Random.Range(5,7); }
        if (aichoice == userchoice)
        {
            Out = true; Debug.Log("out!"); balls = balls - 1; ballstxt.text = "" + balls; checkloose();
        }
        else
        {
            runs = runs + userchoice; Debug.Log("runs:" + runs); runstxt.text = "" + runs; balls = balls - 1;
            ballstxt.text = "" + balls; resultperballtxt.text = "its a " + userchoice+" !!!";
            checkwin();
        }
    }
    
    
    public void wait()
    {
        
        waitpanelscreen.SetActive(true);
        Invoke(nameof(aichoicereset), 1f);
        Invoke(nameof(waitpanel), 2f);
        
    }
    public void aichoicereset()
    {
        aichoice1.SetActive(false);
        aichoice2.SetActive(false);
        aichoice3.SetActive(false);
        aichoice4.SetActive(false);
        aichoice6.SetActive(false);
    }
    public void waitpanel()
    {
        waitpanelscreen.SetActive(false);
    }

}
