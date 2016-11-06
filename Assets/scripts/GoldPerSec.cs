using UnityEngine;
using System.Collections;

public class GoldPerSec : MonoBehaviour {
    public UnityEngine.UI.Text gpsDisplay;
    public Click click;
    public ItemManager[] items;

    public float GetGoldPerSec()
    {
        float tick = 0;
        foreach(ItemManager item in items)
        {
            tick += item.count * item.tickValue;
        }
        return tick;
    }


    public void AutoGoldPerSec()
    {
        //click.gold += GetGoldPerSec();
        click.gold += (GetGoldPerSec() / 10);
    }

    IEnumerator AutoTick()
    {
        while(true)
        {
            AutoGoldPerSec();
            //yield return new WaitForSeconds(1);
            yield return new WaitForSeconds(0.1f);
        }
    }
    
    void Start()
    {
        StartCoroutine(AutoTick());
    }

    void Update()
    {
        gpsDisplay.text = GetGoldPerSec() + " gold/sec";
    }
}