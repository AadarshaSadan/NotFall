using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanager : MonoBehaviour {
    public bool Panel = false;
    public bool title = false;
    public GameObject Panall;
    public GameObject Title;

    public bool lock_level1;
    public bool lock_level2;
    public bool lock_level3;
    public bool lock_level4;
    public bool lock_level5;
    public bool lock_level6;
    public bool lock_level7;
    public bool lock_level8;
    public bool lock_level9;
    public bool lock_level10;
    public bool deletePlayerpre;
    //game object lock setting to display locked  item
    public GameObject lev1imglocked;
    public GameObject lev2imglocked;
    public GameObject lev3imglocked;
    public GameObject lev4imglocked;
    public GameObject lev5imglocked;
    public GameObject lev6imglocked;
    public GameObject lev7imglocked;
    public GameObject lev8imglocked;
    public GameObject lev9imglocked;
    public GameObject lev10imglocked;

    public String defaultolevel;

     Stack myStack=new Stack();
    //end for gameobject

    public bool oklaunch;

    public int getValue;
    // Use this for initialization
    void Start () {
        defaultolevel = "1";
        //do not display level panel intial load
        Panall.SetActive(false);
        myStack.Push(null);
      if(PlayerPrefs.GetInt("level1cleared")==1)
        {
            lock_level1 = false;
            myStack.Push(1);
           
        }
      if(PlayerPrefs.GetInt("level2cleared")==2)
        {
            myStack.Push(2);
            lock_level2 = false;
        }
        if (PlayerPrefs.GetInt("level3cleared") == 3)
        {
            lock_level3 = false;
            myStack.Push(3);
        }
        if (PlayerPrefs.GetInt("level4cleared") == 4)
        {
            lock_level4 = false;
            myStack.Push(4);
        }
        if (PlayerPrefs.GetInt("level5cleared") == 5)
        {
            lock_level5 = false;
            myStack.Push(5);

        }

        if (PlayerPrefs.GetInt("level6cleared") == 6)
        {
            myStack.Push(6);
            lock_level6 = false;
        }
        if (PlayerPrefs.GetInt("level7cleared") == 7)
        {
            myStack.Push(7);
            lock_level7 = false;
        }
        if (PlayerPrefs.GetInt("level8cleared") == 8)
        {
            myStack.Push(8);
             lock_level8 = false;
        }
        if (PlayerPrefs.GetInt("level9cleared") == 9)
        {
            myStack.Push(9);
            lock_level9 = false;
        }
        if (PlayerPrefs.GetInt("level10cleared") == 10)
        {
            myStack.Push(10);
            lock_level10 = false;
        }
        //get all prefae value;

        //now we check playerprefabe and lock and lock the imag
        //Debug.Log(myStack.Peek());
        defaultolevel = myStack.Peek().ToString();
        //PlayerPrefs.SetString("default", myStack.Peek().ToString());


    }

    // Update is called once per frame
    void Update () {
       
    
        if (Panel)
        {
            Panall.SetActive(true);
            Title.SetActive(false);
            title = true;
        }
        if (!Panel)
        {
            Panall.SetActive(false);
            Title.SetActive(true);
            title = false;
        }
        if (lock_level1)
            lev1imglocked.SetActive(true);
        if (lock_level2)
            lev2imglocked.SetActive(true);
        if (lock_level3)
            lev3imglocked.SetActive(true);
        if (lock_level4)
            lev4imglocked.SetActive(true);
        if (lock_level5)
            lev5imglocked.SetActive(true);
        if (lock_level6)
            lev6imglocked.SetActive(true);
        if (lock_level7)
            lev7imglocked.SetActive(true);
        if (lock_level8)
            lev8imglocked.SetActive(true);
        if (lock_level9)
            lev9imglocked.SetActive(true);
        if (lock_level10)
            lev10imglocked.SetActive(true);



        if (!lock_level1)
            lev1imglocked.SetActive(false);
        if (!lock_level2)
            lev2imglocked.SetActive(false);
        if (!lock_level3)
            lev3imglocked.SetActive(false);
        if (!lock_level4)
            lev4imglocked.SetActive(false);
        if (!lock_level5)
            lev5imglocked.SetActive(false);
        if (!lock_level6)
            lev6imglocked.SetActive(false);
        if (!lock_level7)
            lev7imglocked.SetActive(false);
        if (!lock_level8)
            lev8imglocked.SetActive(false);
        if (!lock_level9)
            lev9imglocked.SetActive(false);
        if (!lock_level10)
            lev10imglocked.SetActive(false);
    }

   public void one ()
    {
        if(!lock_level1)
        {
            Debug.Log("this is levelchange 1");
        }
    }
    public void Two()
    {
        if (!lock_level2)
        {
            Debug.Log("this is levelchange 2");
        }
    }

    public void Three()
    {
        if (!lock_level3)
        {
            Debug.Log("this is levelchange 3");
        }
    }

    public void Four()
    {
        if (!lock_level4)
        {
            Debug.Log("this is levelchange 4");
        }
    }

    public void Five()
    {
        if (!lock_level5)
        {
            Debug.Log("this is levelchange 5");
        }
    }

    public void Six()
    {
        if (!lock_level6)
        {
            Debug.Log("this is levelchange 6");
        }
    }


    public void Seven()
    {
        if (!lock_level7)
        {
            Debug.Log("this is levelchange 7");
        }
    }

    public void Eight()
    {
        if (!lock_level8)
        {
            Debug.Log("this is levelchange 8");
        }
    }
    public void Nine()
    {
        if (!lock_level9)
        {
            Debug.Log("this is levelchange 9");
        }
    }
    public void Ten()
    {
        if (!lock_level10)
        {
            Debug.Log("this is levelchange 10");
        }
    }
   

    public void deletelevel()
    {
        if (deletePlayerpre)
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("deleted player");

            if (!lock_level1)
                lev1imglocked.SetActive(true);
            if (!lock_level2)
                lev2imglocked.SetActive(true);
            if (!lock_level3)
                lev3imglocked.SetActive(true);
            if (!lock_level4)
                lev4imglocked.SetActive(true);
            if (!lock_level5)
                lev5imglocked.SetActive(true);
            if (!lock_level6)
                lev6imglocked.SetActive(true);
            if (!lock_level7)
                lev7imglocked.SetActive(true);
            if (!lock_level8)
                lev8imglocked.SetActive(true);
            if (!lock_level9)
                lev9imglocked.SetActive(true);
            if (!lock_level10)
                lev10imglocked.SetActive(true);
        }
    }

}
