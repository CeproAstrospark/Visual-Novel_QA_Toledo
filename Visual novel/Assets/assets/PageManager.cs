using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageManager : MonoBehaviour
{
    public GameObject[] pages;
    public AudioSource[] Music;
    public int redBStartPage;
    public int redBStopPage;
    public int IntrudStartPage;
    public int IntrudStopPage;
    public int BreakingStartPage;
    public int BreakingStopPage;
    public int DapperStartPage;
    public int DapperStopPage;
    public int ItStartPage;
    public int ItStopPage;
    public int rbhStartPage;
    public int rbhStopPage;
    public int ThreeStartPage;
    public int ThreeStopPage;
    public int SDStartPage;
    public int SDStopPage;
    public int PWDStartPage;
    public int PWDStopPage;
    public int redB2StartPage;
    public int redB2StopPage;
    public int rbStartPage;
    public int rbStopPage;


    void Start()
    {
        ShowPage(0);
    }


    public void ShowPage(int pageIndex)
    {

        for (int i = pages.Length - 1; i >= 0; i--)
        {
            pages[i].SetActive(false);
        }

        pages[pageIndex].SetActive(true);

        if (pageIndex >= redBStartPage && pageIndex < redBStopPage)
        {
            if (!Music[0].isPlaying) // Prevents restarting if already playing
            {
                Music[0].Play();
            }
        }
        else if (pageIndex >= redBStopPage)
        {
                Music[0].Stop(); // Stop music when reaching or exceeding the stop page
        }

        if (pageIndex >= IntrudStartPage && pageIndex < IntrudStopPage)
        {
            if (!Music[1].isPlaying) // Prevents restarting if already playing
            {
                Music[1].Play();
            }
        }
        else if (pageIndex >= IntrudStopPage)
        {
            Music[1].Stop(); // Stop music when reaching or exceeding the stop page
        }

        if (pageIndex >= BreakingStartPage && pageIndex < BreakingStopPage)
        {
            if (!Music[2].isPlaying) // Prevents restarting if already playing
            {
                Music[2].Play();
            }
        }
        else if (pageIndex >= BreakingStopPage)
        {
            Music[2].Stop(); // Stop music when reaching or exceeding the stop page
        }

        if (pageIndex >= DapperStartPage && pageIndex < DapperStopPage)
        {
            if (!Music[3].isPlaying) // Prevents restarting if already playing
            {
                Music[3].Play();
            }
        }
        else if (pageIndex >= DapperStopPage)
        {
            Music[3].Stop(); // Stop music when reaching or exceeding the stop page
        }

        if (pageIndex >= ItStartPage && pageIndex < ItStopPage)
        {
            if (!Music[4].isPlaying) // Prevents restarting if already playing
            {
                Music[4].Play();
            }
        }
        else if (pageIndex >= ItStopPage)
        {
            Music[4].Stop(); // Stop music when reaching or exceeding the stop page
        }

        if (pageIndex >= rbhStartPage && pageIndex < rbhStopPage)
        {
            if (!Music[5].isPlaying) // Prevents restarting if already playing
            {
                Music[5].Play();
            }
        }
        else if (pageIndex >= rbhStopPage)
        {
            Music[5].Stop(); // Stop music when reaching or exceeding the stop page
        }

        if (pageIndex >= ThreeStartPage && pageIndex < ThreeStopPage)
        {
            if (!Music[6].isPlaying) // Prevents restarting if already playing
            {
                Music[6].Play();
            }
        }
        else if (pageIndex >= ThreeStopPage)
        {
            Music[6].Stop(); // Stop music when reaching or exceeding the stop page
        }

        if (pageIndex >= SDStartPage && pageIndex < SDStopPage)
        {
            if (!Music[7].isPlaying) // Prevents restarting if already playing
            {
                Music[7].Play();
            }
        }
        else if (pageIndex >= SDStopPage)
        {
            Music[7].Stop(); // Stop music when reaching or exceeding the stop page
        }

        if (pageIndex >= PWDStartPage && pageIndex < PWDStopPage)
        {
            if (!Music[8].isPlaying) // Prevents restarting if already playing
            {
                Music[8].Play();
            }
        }
        else if (pageIndex >= PWDStopPage)
        {
            Music[8].Stop(); // Stop music when reaching or exceeding the stop page
        }

        if (pageIndex >= redB2StartPage && pageIndex < redB2StopPage)
        {
            if (!Music[9].isPlaying) // Prevents restarting if already playing
            {
                Music[9].Play();
            }
        }
        else if (pageIndex >= redB2StopPage)
        {
            Music[9].Stop(); // Stop music when reaching or exceeding the stop page
        }

        if (pageIndex >= rbStartPage && pageIndex < rbStopPage)
        {
            if (!Music[10].isPlaying) // Prevents restarting if already playing
            {
                Music[10].Play();
            }
        }
        else if (pageIndex >= rbStopPage)
        {
            Music[10].Stop(); // Stop music when reaching or exceeding the stop page
        }

    }
}