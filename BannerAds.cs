using System.Collections;
using System.Collections.Generic;
using System;
using GoogleMobileAds.Api;
using UnityEngine;

public class BannerAds : MonoBehaviour
{
    private BannerView banner;
    string bannerId;

    void Start()
    {
      
        RequestBanner();
    }

    void RequestBanner()
    {

#if UNITY_ANDROID
        bannerId = "AdmobCode";
#elif UNITY_IPHONE
        bannerId = "AdmobCode";
#else
        bannerId = null;
#endif

        banner = new BannerView(bannerId, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        banner.LoadAd(request); //load & show the banner ad

    }
    public void CloseBanner() 
    {
        banner.Destroy();
    }
}
